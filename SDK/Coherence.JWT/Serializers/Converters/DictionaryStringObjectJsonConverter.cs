#if MODERN_DOTNET
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JWT.Serializers.Converters
{
    /// <remarks>
    /// Copied from https://github.com/joseftw/JOS.SystemTextJsonDictionaryStringObjectJsonConverter/blob/develop/src/JOS.SystemTextJsonDictionaryObjectModelBinder/DictionaryStringObjectJsonConverterCustomWrite.cs
    /// </remarks>
    public sealed class DictionaryStringObjectJsonConverterCustomWrite : JsonConverter<Dictionary<string, object>>
    {
        public override Dictionary<string, object> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException($"JsonTokenType was of type {reader.TokenType}, only objects are supported");

            var dic = new Dictionary<string, object>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                    return dic;

                if (reader.TokenType != JsonTokenType.PropertyName)
                    throw new JsonException("JsonTokenType was not PropertyName");

                var propertyName = reader.GetString();
                if (String.IsNullOrWhiteSpace(propertyName))
                    throw new JsonException("Failed to get property name");

                reader.Read();
                dic.Add(propertyName, ExtractValue(ref reader, options));
            }
            return dic;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<string, object> value, JsonSerializerOptions options)
        {
            throw new NotSupportedException("Use the built in logic for serializing to json.");
        }

        private object ExtractValue(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                {
                    return reader.TryGetDateTime(out var date) ? date : reader.GetString();
                }
                case JsonTokenType.False:
                {
                    return false;
                }
                case JsonTokenType.True:
                {
                    return true;
                }
                case JsonTokenType.Null:
                {
                    return null;
                }
                case JsonTokenType.Number:
                {
                    return reader.TryGetInt64(out var result) ? result : reader.GetDecimal();
                }
                case JsonTokenType.StartObject:
                {
                    return Read(ref reader, null, options);
                }
                case JsonTokenType.StartArray:
                {
                    var list = new List<object>();
                    while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                    {
                        list.Add(ExtractValue(ref reader, options));
                    }
                    return list;
                }
                default:
                {
                    throw new JsonException($"Token '{reader.TokenType}' is not supported");
                }
            }
        }
    }
}
#endif
