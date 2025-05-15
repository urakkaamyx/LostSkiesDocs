using System;
using System.Linq;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Exceptions;
using static JWT.Internal.EncodingHelper;
#if NET35
using static JWT.Compatibility.String;
#endif

namespace JWT
{
    /// <summary>
    /// Decodes JWT.
    /// </summary>
    public sealed class JwtDecoder : IJwtDecoder
    {
        private readonly IJsonSerializer _jsonSerializer;
        private readonly IJwtValidator _jwtValidator;
        private readonly IBase64UrlEncoder _urlEncoder;
        private readonly IAlgorithmFactory _algFactory;

        /// <summary>
        /// Creates an instance of <see cref="JwtDecoder" />
        /// </summary>
        /// <remarks>
        /// This overload supplies no <see cref="IJwtValidator" /> and no <see cref="IAlgorithmFactory" /> so the resulting decoder cannot be used for signature validation.
        /// </remarks>
        /// <param name="jsonSerializer">The JSON serializer</param>
        /// <param name="urlEncoder">The base64 URL encoder</param>
        /// <exception cref="ArgumentNullException" />
        public JwtDecoder(IJsonSerializer jsonSerializer, IBase64UrlEncoder urlEncoder)
        {
            _jsonSerializer = jsonSerializer ?? throw new ArgumentNullException(nameof(jsonSerializer));
            _urlEncoder = urlEncoder ?? throw new ArgumentNullException(nameof(urlEncoder));
        }

        /// <summary>
        /// Creates an instance of <see cref="JwtDecoder" />
        /// </summary>
        /// <param name="jsonSerializer">The JSON serializer</param>
        /// <param name="jwtValidator">The JWT validator</param>
        /// <param name="urlEncoder">The base64 URL encoder</param>
        /// <param name="algFactory">The JWT algorithm Factory</param>
        /// <exception cref="ArgumentNullException" />
        public JwtDecoder(IJsonSerializer jsonSerializer, IJwtValidator jwtValidator, IBase64UrlEncoder urlEncoder, IAlgorithmFactory algFactory)
            : this(jsonSerializer, urlEncoder)
        {
            _jwtValidator = jwtValidator ?? throw new ArgumentNullException(nameof(jwtValidator));
            _algFactory = algFactory ?? throw new ArgumentNullException(nameof(algFactory));
        }

        /// <summary>
        /// Creates an instance of <see cref="JwtDecoder" />
        /// </summary>
        /// <param name="jsonSerializer">The JSON serializer</param>
        /// <param name="jwtValidator">The JWT validator</param>
        /// <param name="urlEncoder">The base64 URL encoder</param>
        /// <param name="algorithm">The JWT algorithm</param>
        /// <exception cref="ArgumentNullException" />
        public JwtDecoder(IJsonSerializer jsonSerializer, IJwtValidator jwtValidator, IBase64UrlEncoder urlEncoder, IJwtAlgorithm algorithm)
            : this(jsonSerializer, jwtValidator, urlEncoder, new DelegateAlgorithmFactory(algorithm))
        {
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="InvalidTokenPartsException" />
        /// <exception cref="FormatException" />
        public string DecodeHeader(string token)
        {
            if (String.IsNullOrEmpty(token))
                throw new ArgumentException(nameof(token));

            var header = new JwtParts(token).Header;
            var decoded = _urlEncoder.Decode(header);
            return GetString(decoded);
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="FormatException" />
        public T DecodeHeader<T>(JwtParts jwt)
        {
            if (jwt is null)
                throw new ArgumentNullException(nameof(jwt));

            var decodedHeader = _urlEncoder.Decode(jwt.Header);
            var stringHeader = GetString(decodedHeader);
            return _jsonSerializer.Deserialize<T>(stringHeader);
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="InvalidTokenPartsException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public string Decode(JwtParts jwt, bool verify) =>
            Decode(jwt, (byte[])null, verify);

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="InvalidTokenPartsException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public string Decode(JwtParts jwt, byte[] key, bool verify) =>
            Decode(jwt, new[] { key }, verify);

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public string Decode(JwtParts jwt, byte[][] keys, bool verify)
        {
            if (jwt is null)
                throw new ArgumentNullException(nameof(jwt));

            if (verify)
            {
                if (_jwtValidator is null)
                    throw new InvalidOperationException("This instance was constructed without validator so cannot be used for signature validation");
                if (_algFactory is null)
                    throw new InvalidOperationException("This instance was constructed without algorithm factory so cannot be used for signature validation");

                Validate(jwt, keys);
            }
            else
            {
                ValidateNoneAlgorithm(jwt);
            }
            return Decode(jwt);
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public object DecodeToObject(Type type, JwtParts jwt, bool verify)
        {
            var payload = Decode(jwt, verify);
            return _jsonSerializer.Deserialize(type, payload);
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public object DecodeToObject(Type type, JwtParts jwt, byte[] key, bool verify)
        {
            var payload = Decode(jwt, key, verify);
            return _jsonSerializer.Deserialize(type, payload);
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public object DecodeToObject(Type type, JwtParts jwt, byte[][] keys, bool verify)
        {
            var payload = Decode(jwt, keys, verify);
            return _jsonSerializer.Deserialize(type, payload);
        }

        /// <summary>
        /// Prepares data before calling <see cref="IJwtValidator" />
        /// </summary>
        /// <param name="parts">The array representation of a JWT</param>
        /// <param name="key">The key that was used to sign the JWT</param>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public void Validate(string[] parts, byte[] key) =>
            Validate(new JwtParts(parts), key);

        /// <summary>
        /// Prepares data before calling <see cref="IJwtValidator" />
        /// </summary>
        /// <param name="parts">The array representation of a JWT</param>
        /// <param name="keys">The keys provided which one of them was used to sign the JWT</param>
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public void Validate(string[] parts, params byte[][] keys) =>
            Validate(new JwtParts(parts), keys);

        /// <summary>
        /// Prepares data before calling <see cref="IJwtValidator" />
        /// </summary>
        /// <param name="jwt">The JWT parts</param>
        /// <param name="keys">The keys provided which one of them was used to sign the JWT</param>
        /// <exception cref="ArgumentException" />
        /// <exception cref="ArgumentNullException" />
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="FormatException" />
        /// <exception cref="SignatureVerificationException" />
        /// <exception cref="TokenNotYetValidException" />
        /// <exception cref="TokenExpiredException" />
        public void Validate(JwtParts jwt, params byte[][] keys)
        {
            if (jwt is null)
                throw new ArgumentNullException(nameof(jwt));
            if (jwt.Payload is null)
                throw new ArgumentNullException(nameof(JwtParts.Payload));
            if (jwt.Signature is null)
                throw new ArgumentNullException(nameof(JwtParts.Signature));

            var decodedPayload = GetString(_urlEncoder.Decode(jwt.Payload));
            var decodedSignature = _urlEncoder.Decode(jwt.Signature);

            var header = DecodeHeader<JwtHeader>(jwt);
            var algorithm = _algFactory.Create(JwtDecoderContext.Create(header, decodedPayload, jwt));
            if (algorithm is null)
                throw new ArgumentNullException(nameof(algorithm));

            var bytesToSign = GetBytes(jwt.Header, '.', jwt.Payload);

            if (algorithm is IAsymmetricAlgorithm asymmAlg)
            {
                _jwtValidator.Validate(decodedPayload, asymmAlg, bytesToSign, decodedSignature);
            }
            else
            {
                ValidSymmetricAlgorithm(keys, decodedPayload, algorithm, bytesToSign, decodedSignature);
            }
        }

        private string Decode(JwtParts jwt)
        {
            if (jwt is null)
                throw new ArgumentNullException(nameof(jwt));

            var decoded = _urlEncoder.Decode(jwt.Payload);
            return GetString(decoded);
        }

        private void ValidSymmetricAlgorithm(byte[][] keys, string decodedPayload, IJwtAlgorithm algorithm, byte[] bytesToSign, byte[] decodedSignature)
        {
            if (keys is null)
                throw new ArgumentNullException(nameof(keys));
            if (!AllKeysHaveValues(keys))
                throw new ArgumentOutOfRangeException(nameof(keys));

            // the signature on the token, with the leading =
            var rawSignature = Convert.ToBase64String(decodedSignature);

            // the signatures re-created by the algorithm, with the leading =
            var recreatedSignatures = keys.Select(key => Convert.ToBase64String(algorithm.Sign(key, bytesToSign))).ToArray();

            _jwtValidator.Validate(decodedPayload, rawSignature, recreatedSignatures);
        }

        private static bool AllKeysHaveValues(byte[][] keys)
        {
            if (keys is null)
                return false;

            if (keys.Length == 0)
                return false;

            return Array.TrueForAll(keys, key => key.Length > 0);
        }

        private void ValidateNoneAlgorithm(JwtParts jwt)
        {
            var header = DecodeHeader<JwtHeader>(jwt);

            if (String.IsNullOrEmpty(header.Type) &&
                String.IsNullOrEmpty(header.Algorithm))
            {
                throw new InvalidOperationException("Error deserializing JWT header, all mandatory properties are null or empty");
            }

            if (String.Equals(header.Algorithm, nameof(JwtAlgorithmName.None), StringComparison.OrdinalIgnoreCase) &&
                !String.IsNullOrEmpty(jwt.Signature))
            {
                throw new InvalidOperationException("Signature is not acceptable for algorithm None");
            }
        }
    }
}