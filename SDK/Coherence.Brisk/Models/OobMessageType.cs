// Copyright (c) coherence ApS.
// See the license file in the package root for more information.

namespace Coherence.Brisk.Models
{
    using System;

    public enum OobMessageType : byte
    {
        ChangeSendFrequencyRequest = 1,
        KeepAlive = 2,
        // Unused = 3,
        // Unused = 4,
        // Unused = 5,
        // Unused = 6,
        ConnectRequest = 7,
        ConnectResponse = 8,
        DisconnectRequest = 9,
        // Unused = 10,
        Ack = 11,
    }
}
