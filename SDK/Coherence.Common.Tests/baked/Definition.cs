// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
    using System.Collections.Generic;
    using Coherence.ProtocolDef;
    using Coherence.Brook;
    using Coherence.Connection;
    using Coherence.Entities;
    using Coherence.Serializer;
    using Coherence.Log;
    using Coherence.SimulationFrame;


    [UnityEngine.Scripting.Preserve]

    public class Definition : IDefinition
    {
        public const string schemaId = "eb36ca3f2c8625f26988f73c4059d553c2c3447f";
        public const uint InternalWorldPosition = 0;
        public const uint InternalWorldOrientation = 1;
        public const uint InternalLocalUserComponent = 2;
        public const uint InternalWorldPositionQuery = 3;
        public const uint InternalArchetypeComponent = 4;
        public const uint InternalPersistence = 5;
        public const uint InternalConnectedEntity = 6;
        public const uint InternalUniqueID = 7;
        public const uint InternalConnection = 8;
        public const uint InternalConnectionScene = 9;
        public const uint InternalGlobal = 10;
        public const uint InternalGlobalQuery = 11;
        public const uint InternalTag = 12;
        public const uint InternalTagQuery = 13;
        public const uint InternalPreserveChildren = 14;
        public const uint InternalScene = 15;
        public const uint InternalByteArrayTest = 16;
        public const uint InternalIntComponent = 17;
        public const uint InternalFloatComponent = 18;
        public const uint InternalOrderedComp = 19;
        public const uint InternalOrdered2Comp = 20;
        public const uint InternalMultiComponent = 21;
        public const uint InternalSimFramesComponent = 22;
        public const uint InternalAuthorityRequest = 0;
        public const uint InternalAuthorityTransfer = 1;
        public const uint InternalQuerySynced = 2;
        public const uint InternalAdoptOrphan = 3;
        public const uint InternalPersistenceReady = 4;
        public const uint InternalSceneIndexChanged = 5;
        public const uint InternalEntityRefsCommand = 9;
        public const uint InternalBoolInput = 0;
        public const uint InternalIntInput = 1;
        public const uint InternalFloatInput = 2;
        public const uint InternalQuaternionInput = 3;
        public const uint InternalVector2Input = 4;
        public const uint InternalVector3Input = 5;
        public const uint InternalStringInput = 6;
        public const uint InternalMultiInput = 7;
        public const uint InternalCompressedInput = 8;

        private static readonly Dictionary<uint, string> componentNamesForTypeIds = new Dictionary<uint, string>()
        {
            { 0, "WorldPosition" },
            { 1, "WorldOrientation" },
            { 2, "LocalUserComponent" },
            { 3, "WorldPositionQuery" },
            { 4, "ArchetypeComponent" },
            { 5, "Persistence" },
            { 6, "ConnectedEntity" },
            { 7, "UniqueID" },
            { 8, "Connection" },
            { 9, "ConnectionScene" },
            { 10, "Global" },
            { 11, "GlobalQuery" },
            { 12, "Tag" },
            { 13, "TagQuery" },
            { 14, "PreserveChildren" },
            { 15, "Scene" },
            { 16, "ByteArrayTest" },
            { 17, "IntComponent" },
            { 18, "FloatComponent" },
            { 19, "OrderedComp" },
            { 20, "Ordered2Comp" },
            { 21, "MultiComponent" },
            { 22, "SimFramesComponent" },
        };

        public static string ComponentNameForTypeId(uint typeId)
        {
            if (componentNamesForTypeIds.TryGetValue(typeId, out string componentName))
            {
                return componentName;
            }
            else
            {
                return "";
            }
        }

        public static readonly Dictionary<uint, MessageTarget> CommandRoutingByType = new Dictionary<uint, MessageTarget>()
        {
            { Definition.InternalAuthorityRequest , MessageTarget.All },
            { Definition.InternalAuthorityTransfer , MessageTarget.All },
            { Definition.InternalQuerySynced , MessageTarget.All },
            { Definition.InternalAdoptOrphan , MessageTarget.All },
            { Definition.InternalPersistenceReady , MessageTarget.All },
            { Definition.InternalSceneIndexChanged , MessageTarget.All },
            { Definition.InternalEntityRefsCommand , MessageTarget.All },
        };

        public ICoherenceComponentData ReadComponentUpdate(uint componentType, AbsoluteSimulationFrame referenceSimulationFrame,
            IInBitStream bitStream, Logger logger)
        {
            var inProtocolStream = new InProtocolBitStream(bitStream);

            switch (componentType)
            {
                case InternalWorldPosition:
                    return WorldPosition.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalWorldOrientation:
                    return WorldOrientation.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalLocalUserComponent:
                    return LocalUserComponent.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalWorldPositionQuery:
                    return WorldPositionQuery.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalArchetypeComponent:
                    return ArchetypeComponent.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalPersistence:
                    return Persistence.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalConnectedEntity:
                    return ConnectedEntity.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalUniqueID:
                    return UniqueID.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalConnection:
                    return Connection.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalConnectionScene:
                    return ConnectionScene.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalGlobal:
                    return Global.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalGlobalQuery:
                    return GlobalQuery.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalTag:
                    return Tag.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalTagQuery:
                    return TagQuery.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalPreserveChildren:
                    return PreserveChildren.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalScene:
                    return Scene.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalByteArrayTest:
                    return ByteArrayTest.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalIntComponent:
                    return IntComponent.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalFloatComponent:
                    return FloatComponent.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalOrderedComp:
                    return OrderedComp.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalOrdered2Comp:
                    return Ordered2Comp.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalMultiComponent:
                    return MultiComponent.Deserialize(referenceSimulationFrame, inProtocolStream);
                case InternalSimFramesComponent:
                    return SimFramesComponent.Deserialize(referenceSimulationFrame, inProtocolStream);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(componentType),
                        $"Missing serialization implementation for a component: {componentType}");
            }
        }

        public uint WriteComponentUpdate(ICoherenceComponentData data, uint serializeAs, bool isRefSimFrameValid,
            AbsoluteSimulationFrame referenceSimulationFrame, IOutProtocolBitStream protocolStream, Logger logger)
        {
            switch (serializeAs)
            {
                case InternalWorldPosition:
                    return WorldPosition.Serialize((WorldPosition)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalWorldOrientation:
                    return WorldOrientation.Serialize((WorldOrientation)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalLocalUserComponent:
                    return LocalUserComponent.Serialize((LocalUserComponent)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalWorldPositionQuery:
                    return WorldPositionQuery.Serialize((WorldPositionQuery)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalArchetypeComponent:
                    return ArchetypeComponent.Serialize((ArchetypeComponent)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalPersistence:
                    return Persistence.Serialize((Persistence)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalConnectedEntity:
                    return ConnectedEntity.Serialize((ConnectedEntity)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalUniqueID:
                    return UniqueID.Serialize((UniqueID)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalConnection:
                    return Connection.Serialize((Connection)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalConnectionScene:
                    return ConnectionScene.Serialize((ConnectionScene)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalGlobal:
                    return Global.Serialize((Global)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalGlobalQuery:
                    return GlobalQuery.Serialize((GlobalQuery)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalTag:
                    return Tag.Serialize((Tag)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalTagQuery:
                    return TagQuery.Serialize((TagQuery)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalPreserveChildren:
                    return PreserveChildren.Serialize((PreserveChildren)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalScene:
                    return Scene.Serialize((Scene)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalByteArrayTest:
                    return ByteArrayTest.Serialize((ByteArrayTest)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalIntComponent:
                    return IntComponent.Serialize((IntComponent)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalFloatComponent:
                    return FloatComponent.Serialize((FloatComponent)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalOrderedComp:
                    return OrderedComp.Serialize((OrderedComp)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalOrdered2Comp:
                    return Ordered2Comp.Serialize((Ordered2Comp)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalMultiComponent:
                    return MultiComponent.Serialize((MultiComponent)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                case InternalSimFramesComponent:
                    return SimFramesComponent.Serialize((SimFramesComponent)data, isRefSimFrameValid, referenceSimulationFrame, protocolStream, logger);
                default:
                    logger.Error(Coherence.Log.Error.DefinitionMissingComponentImplementation, ("component", data.GetComponentType()));
                    return 0;
            }
        }

        private IEntityCommand ReadCommand(uint commandType, Entity entity, MessageTarget target, IInProtocolBitStream bitStream, Logger logger)
        {
            switch (commandType)
            {
                case Definition.InternalAuthorityRequest:
                    return AuthorityRequest.Deserialize(bitStream, entity, target);
                case Definition.InternalAuthorityTransfer:
                    return AuthorityTransfer.Deserialize(bitStream, entity, target);
                case Definition.InternalQuerySynced:
                    return QuerySynced.Deserialize(bitStream, entity, target);
                case Definition.InternalAdoptOrphan:
                    return AdoptOrphan.Deserialize(bitStream, entity, target);
                case Definition.InternalPersistenceReady:
                    return PersistenceReady.Deserialize(bitStream, entity, target);
                case Definition.InternalSceneIndexChanged:
                    return SceneIndexChanged.Deserialize(bitStream, entity, target);
                case Definition.InternalEntityRefsCommand:
                    return EntityRefsCommand.Deserialize(bitStream, entity, target);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(commandType),
                        $"Missing serialization implementation for a command: {commandType}");
            }
        }

        private IEntityInput ReadInput(uint inputType, Entity entity, long frame, IInProtocolBitStream bitStream, Logger logger)
        {
            switch (inputType)
            {
                case Definition.InternalBoolInput:
                    return BoolInput.Deserialize(bitStream, entity, frame);
                case Definition.InternalIntInput:
                    return IntInput.Deserialize(bitStream, entity, frame);
                case Definition.InternalFloatInput:
                    return FloatInput.Deserialize(bitStream, entity, frame);
                case Definition.InternalQuaternionInput:
                    return QuaternionInput.Deserialize(bitStream, entity, frame);
                case Definition.InternalVector2Input:
                    return Vector2Input.Deserialize(bitStream, entity, frame);
                case Definition.InternalVector3Input:
                    return Vector3Input.Deserialize(bitStream, entity, frame);
                case Definition.InternalStringInput:
                    return StringInput.Deserialize(bitStream, entity, frame);
                case Definition.InternalMultiInput:
                    return MultiInput.Deserialize(bitStream, entity, frame);
                case Definition.InternalCompressedInput:
                    return CompressedInput.Deserialize(bitStream, entity, frame);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(inputType),
                        $"Missing serialization implementation for an input: {inputType}");
            }
        }

        public IEntityCommand[]	ReadCommands(IInBitStream bitStream, Logger logger)
        {
            var numMessages = bitStream.ReadUint8();

            var commandData = new IEntityCommand[numMessages];

            for (var i = 0; i < numMessages; i++)
            {
                var entityID = DeserializerTools.DeserializeEntity(bitStream);
                var messageTarget = DeserializerTools.DeserializeMessageTarget(bitStream);
                var componentType = DeserializerTools.DeserializeComponentTypeID(bitStream);
                var inBitStream = new Coherence.Serializer.InProtocolBitStream(bitStream);
                commandData[i] = ReadCommand(componentType, entityID, messageTarget, inBitStream, logger);
            }

            return commandData;
        }

        public IEntityInput[] ReadInputs(IInBitStream bitStream, Logger logger)
        {
            var numMessages = bitStream.ReadUint8();

            var inputData = new IEntityInput[numMessages];

            for (var i = 0; i < numMessages; i++)
            {
                var entityID = DeserializerTools.DeserializeEntity(bitStream);
                var routing = DeserializerTools.DeserializeMessageTarget(bitStream);
                var componentType = DeserializerTools.DeserializeComponentTypeID(bitStream);
                var inBitStream = new Coherence.Serializer.InProtocolBitStream(bitStream);
                var frame = (long)bitStream.ReadUint64();
                var input = ReadInput(componentType, entityID, frame, inBitStream, logger);
                input.Routing = routing;
                inputData[i] = input;
            }

            return inputData;
        }

        public IEntityCommand ReadCommand(IInBitStream bitStream, Logger logger)
        {
            var entityID = DeserializerTools.DeserializeEntity(bitStream);
            var messageTarget = DeserializerTools.DeserializeMessageTarget(bitStream);
            var componentType = DeserializerTools.DeserializeComponentTypeID(bitStream);
            var inBitStream = new Coherence.Serializer.InProtocolBitStream(bitStream);

            return ReadCommand(componentType, entityID, messageTarget, inBitStream, logger);
        }

        public void WriteCommand(IEntityCommand data, uint commandType, IOutProtocolBitStream bitStream, Logger logger)
        {
            switch (commandType)
            {
                case Definition.InternalAuthorityRequest:
                    AuthorityRequest.Serialize((AuthorityRequest)data, bitStream);
                    break;
                case Definition.InternalAuthorityTransfer:
                    AuthorityTransfer.Serialize((AuthorityTransfer)data, bitStream);
                    break;
                case Definition.InternalQuerySynced:
                    QuerySynced.Serialize((QuerySynced)data, bitStream);
                    break;
                case Definition.InternalAdoptOrphan:
                    AdoptOrphan.Serialize((AdoptOrphan)data, bitStream);
                    break;
                case Definition.InternalPersistenceReady:
                    PersistenceReady.Serialize((PersistenceReady)data, bitStream);
                    break;
                case Definition.InternalSceneIndexChanged:
                    SceneIndexChanged.Serialize((SceneIndexChanged)data, bitStream);
                    break;
                case Definition.InternalEntityRefsCommand:
                    EntityRefsCommand.Serialize((EntityRefsCommand)data, bitStream);
                    break;
                default:
                    logger.Error(Coherence.Log.Error.DefinitionMissingCommandImplementation, ("command", commandType));
                    break;
            }
        }

        public void WriteInput(IEntityInput data, uint inputType, IOutProtocolBitStream bitStream, Logger logger)
        {
            var inputData = (InputData)data;
            bitStream.WriteLong(inputData.Frame);

            switch (inputType)
            {
                case Definition.InternalBoolInput:
                    BoolInput.Serialize((BoolInput)inputData.Input, bitStream);
                    break;
                case Definition.InternalIntInput:
                    IntInput.Serialize((IntInput)inputData.Input, bitStream);
                    break;
                case Definition.InternalFloatInput:
                    FloatInput.Serialize((FloatInput)inputData.Input, bitStream);
                    break;
                case Definition.InternalQuaternionInput:
                    QuaternionInput.Serialize((QuaternionInput)inputData.Input, bitStream);
                    break;
                case Definition.InternalVector2Input:
                    Vector2Input.Serialize((Vector2Input)inputData.Input, bitStream);
                    break;
                case Definition.InternalVector3Input:
                    Vector3Input.Serialize((Vector3Input)inputData.Input, bitStream);
                    break;
                case Definition.InternalStringInput:
                    StringInput.Serialize((StringInput)inputData.Input, bitStream);
                    break;
                case Definition.InternalMultiInput:
                    MultiInput.Serialize((MultiInput)inputData.Input, bitStream);
                    break;
                case Definition.InternalCompressedInput:
                    CompressedInput.Serialize((CompressedInput)inputData.Input, bitStream);
                    break;
                default:
                    logger.Error(Coherence.Log.Error.DefinitionMissingInputImplementation, ("input", inputType));
                    break;
            }
        }

        public IEntityCommand CreateAuthorityRequest(Entity entity, ClientID requester, AuthorityType authType)
        {
            return new AuthorityRequest(entity, (uint)requester, (int)authType);
        }

        public IEntityCommand CreateAdoptOrphanCommand()
        {
            return new AdoptOrphan();
        }

        public bool TryGetAuthorityRequestCommand(IEntityCommand entityCommand,
            out ClientID requester, out AuthorityType authType)
        {
            if (entityCommand is AuthorityRequest request)
            {
                requester = (ClientID)request.requester;
                authType = (AuthorityType)request.authorityType;

                return true;
            }

            requester = default;
            authType = default;

            return false;
        }

        public IEntityCommand CreateAuthorityTransfer(Entity entity, ClientID newAuthority, bool accepted, AuthorityType authType)
        {
            return new AuthorityTransfer(entity, (uint)newAuthority, accepted, (int)authType);
        }

        public bool TryGetAuthorityTransferCommand(IEntityCommand entityCommand, out ClientID newAuthority,
            out bool transferAccepted, out AuthorityType authType)
        {
            if (entityCommand is AuthorityTransfer transfer)
            {
                newAuthority = (ClientID)transfer.newAuthority;
                transferAccepted = transfer.accepted;
                authType = (AuthorityType)transfer.authorityType;

                return true;
            }

            newAuthority = default;
            transferAccepted = default;
            authType = default;

            return false;
        }

        public ICoherenceComponentData GeneratePersistenceData()
        {
            var persistence = new Persistence();

            return persistence;
        }

        public ICoherenceComponentData GenerateCoherenceUUIDData(string uuid, AbsoluteSimulationFrame simFrame)
        {
            var uniqueID = new UniqueID();
            uniqueID.uuid = uuid;
            uniqueID.uuidSimulationFrame = simFrame;
            uniqueID.FieldsMask = 0b1;

            return uniqueID;
        }

        public ICoherenceComponentData CreateGlobalComponent()
        {
            return new Global();
        }

        public ICoherenceComponentData GenerateGlobalQueryComponent()
        {
            return new GlobalQuery();
        }

        public string ExtractCoherenceUUID(ICoherenceComponentData data)
        {
            var uniqueID = (UniqueID)data;
            return uniqueID.uuid;
        }

        public bool IsConnectedEntity(ICoherenceComponentData data)
        {
            return data.GetComponentType() == Definition.InternalConnectedEntity;
        }

        public Entity ExtractConnectedEntityID(ICoherenceComponentData data)
        {
            var connectedEntity = (ConnectedEntity)data;

            return connectedEntity.value;
        }

        public string ExtractCoherenceTag(ICoherenceComponentData data)
        {
            var tag = (Tag)data;
            return tag.tag;
        }

        public bool TryGetSceneIndexChangedCommand(IEntityCommand entityCommand, out int sceneIndex)
        {
            if (entityCommand is SceneIndexChanged changed)
            {
                sceneIndex = (int)changed.sceneIndex;

                return true;
            }

            sceneIndex = default;

            return false;
        }

        public IEntityCommand CreateSceneIndexChangedCommand(Entity entity, int sceneIndex)
        {
            return new SceneIndexChanged(entity, sceneIndex);
        }

        public bool IsSendOrderedComponent(uint componentID)
        {
            switch(componentID)
            {
                case 6:
                    return true;
                case 19:
                    return true;
                case 20:
                    return true;
                default:
                    return false;
            }
        }
}


}
