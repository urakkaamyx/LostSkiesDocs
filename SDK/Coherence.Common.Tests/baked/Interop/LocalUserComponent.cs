// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
    using System;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using Coherence.ProtocolDef;
    using Coherence.Serializer;
    using Coherence.SimulationFrame;
    using Coherence.Entities;
    using Coherence.Utils;
    using Coherence.Brook;
    using Coherence.Core;
    using Logger = Coherence.Log.Logger;
    using UnityEngine;
    using Coherence.Toolkit;
    public struct LocalUserComponent : ICoherenceComponentData
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct Interop
        {
            [FieldOffset(0)]
            public System.Int32 localIndex;
        }

        public void ResetFrame(AbsoluteSimulationFrame frame)
        {
            FieldsMask |= LocalUserComponent.localIndexMask;
            localIndexSimulationFrame = frame;
        }

        public static unsafe LocalUserComponent FromInterop(IntPtr data, Int32 dataSize, InteropAbsoluteSimulationFrame* simFrames, Int32 simFramesCount)
        {
            if (dataSize != 4) {
                throw new Exception($"Given data size is not equal to the struct size. ({dataSize} != 4) " +
                    "for component with ID 2");
            }

            if (simFramesCount != 0) {
                throw new Exception($"Given simFrames size is not equal to the expected length. ({simFramesCount} != 0) " +
                    "for component with ID 2");
            }

            var orig = new LocalUserComponent();

            var comp = (Interop*)data;

            orig.localIndex = comp->localIndex;

            return orig;
        }


        public static uint localIndexMask => 0b00000000000000000000000000000001;
        public AbsoluteSimulationFrame localIndexSimulationFrame;
        public System.Int32 localIndex;

        public uint FieldsMask { get; set; }
        public uint StoppedMask { get; set; }
        public uint GetComponentType() => 2;
        public int PriorityLevel() => 100;
        public const int order = 0;
        public uint InitialFieldsMask() => 0b00000000000000000000000000000001;
        public bool HasFields() => true;
        public bool HasRefFields() => false;


        public long[] GetSimulationFrames() {
            return null;
        }

        public int GetFieldCount() => 1;


        
        public HashSet<Entity> GetEntityRefs()
        {
            return default;
        }

        public uint ReplaceReferences(Entity fromEntity, Entity toEntity)
        {
            return 0;
        }
        
        public IEntityMapper.Error MapToAbsolute(IEntityMapper mapper)
        {
            return IEntityMapper.Error.None;
        }

        public IEntityMapper.Error MapToRelative(IEntityMapper mapper)
        {
            return IEntityMapper.Error.None;
        }

        public ICoherenceComponentData Clone() => this;
        public int GetComponentOrder() => order;
        public bool IsSendOrdered() => false;

        private static readonly System.Int32 _localIndex_Min = -2147483648;
        private static readonly System.Int32 _localIndex_Max = 2147483647;

        public AbsoluteSimulationFrame? GetMinSimulationFrame()
        {
            AbsoluteSimulationFrame? min = null;


            return min;
        }

        public ICoherenceComponentData MergeWith(ICoherenceComponentData data)
        {
            var other = (LocalUserComponent)data;
            var otherMask = other.FieldsMask;

            FieldsMask |= otherMask;
            StoppedMask &= ~(otherMask);

            if ((otherMask & 0x01) != 0)
            {
                this.localIndexSimulationFrame = other.localIndexSimulationFrame;
                this.localIndex = other.localIndex;
            }

            otherMask >>= 1;
            StoppedMask |= other.StoppedMask;

            return this;
        }

        public uint DiffWith(ICoherenceComponentData data)
        {
            throw new System.NotSupportedException($"{nameof(DiffWith)} is not supported in Unity");
        }

        public static uint Serialize(LocalUserComponent data, bool isRefSimFrameValid, AbsoluteSimulationFrame referenceSimulationFrame, IOutProtocolBitStream bitStream, Logger logger)
        {
            if (bitStream.WriteMask(data.StoppedMask != 0))
            {
                bitStream.WriteMaskBits(data.StoppedMask, 1);
            }

            var mask = data.FieldsMask;

            if (bitStream.WriteMask((mask & 0x01) != 0))
            {

                Coherence.Utils.Bounds.Check(data.localIndex, _localIndex_Min, _localIndex_Max, "LocalUserComponent.localIndex", logger);

                data.localIndex = Coherence.Utils.Bounds.Clamp(data.localIndex, _localIndex_Min, _localIndex_Max);

                var fieldValue = data.localIndex;



                bitStream.WriteIntegerRange(fieldValue, 32, -2147483648);
            }

            mask >>= 1;

            return mask;
        }

        public static LocalUserComponent Deserialize(AbsoluteSimulationFrame referenceSimulationFrame, InProtocolBitStream bitStream)
        {
            var stoppedMask = (uint)0;
            if (bitStream.ReadMask())
            {
                stoppedMask = bitStream.ReadMaskBits(1);
            }

            var val = new LocalUserComponent();
            if (bitStream.ReadMask())
            {

                val.localIndex = bitStream.ReadIntegerRange(32, -2147483648);
                val.FieldsMask |= LocalUserComponent.localIndexMask;
            }

            val.StoppedMask = stoppedMask;

            return val;
        }


        public override string ToString()
        {
            return $"LocalUserComponent(" +
                $" localIndex: { this.localIndex }" +
                $" Mask: { System.Convert.ToString(FieldsMask, 2).PadLeft(1, '0') }, " +
                $"Stopped: { System.Convert.ToString(StoppedMask, 2).PadLeft(1, '0') })";
        }
    }

}
