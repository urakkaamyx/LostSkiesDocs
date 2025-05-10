# WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _entityRendererService | EntityRendererService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _uiService | UISystem.IUIService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _deletingCentralBlockMessage | UnityEngine.Localization.LocalizedString | Private |
| _orphanedBlockMessage | UnityEngine.Localization.LocalizedString | Private |
| _intersectingBlockMessage | UnityEngine.Localization.LocalizedString | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _vertPrefab | UnityEngine.GameObject | Private |
| _edgePrefab | UnityEngine.GameObject | Private |
| _facePrefab | UnityEngine.GameObject | Private |
| _helmObjectDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Private |
| _cannonObjectDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Private |
| _coreObjectDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Private |
| _crudeMastObjectDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Private |
| _shipHull | WildSkies.Gameplay.ShipBuilding.ShipHull | Private |
| _grid | WildSkies.Gameplay.ShipBuilding.ShipyardGrid | Private |
| _mirrorAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Private |
| _parallelFaces | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _modifiedVertsUpdateCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| MODIFIED_BLOCKS_UPDATE_INTERVAL | System.Single | Private |
| MODIFIED_VERTS_MAX_CACHE_SIZE | System.Int32 | Private |
| MODIFIED_FACE_MAX_CACHE_SIZE | System.Int32 | Private |
| _modifiedVertsIDCache | System.Collections.Generic.List`1<System.Int32> | Private |
| _modifiedVertsRelativePositionCache | System.Collections.Generic.List`1<System.Byte> | Private |
| _modifiedFaceIDsCache | System.Collections.Generic.List`1<System.Int32> | Private |
| _minVertexDistance | System.Single | Private |
| _faceSegmentCount | System.Int32 | Private |
| _triggerPanelFaceSegmentCount | System.Int32 | Private |
| CurveIncrement | System.Single | Public |
| _maxCurvyness | System.Single | Private |
| _faceDeckPanelScale | System.Single | Private |
| _faceWallPanelScale | System.Single | Private |
| _faceColliderOffset | System.Single | Private |
| _faceRendererOffset | System.Single | Private |
| _facePullOffset | System.Single | Private |
| _zFightingOffset | System.Single | Private |
| _constructedShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| shipHullParent | UnityEngine.Transform | Private |
| verticesParent | UnityEngine.Transform | Private |
| edgesParent | UnityEngine.Transform | Private |
| facesParent | UnityEngine.Transform | Private |
| _detectorColliderMargin | UnityEngine.Vector3 | Private |
| _detectorColliderVerticalOffset | System.Single | Private |
| _playerDetectorCollider | UnityEngine.BoxCollider | Private |
| _networkShipyard | WildSkies.Gameplay.ShipBuilding.NetworkShipyard | Private |
| _shipParent | UnityEngine.Transform | Private |
| _shipMaterials | ShipMaterials | Private |
| _visualHullParent | UnityEngine.Transform | Private |
| _visualShipHullList | WildSkies.Gameplay.ShipBuilding.VisualShipHullList | Private |
| _faceFillList | WildSkies.Gameplay.ShipBuilding.FaceFillList | Private |
| _beamList | WildSkies.Gameplay.ShipBuilding.BeamList | Private |
| _shipPartPlacementMatrix | WildSkies.Gameplay.ShipBuilding.ShipPartPlacementMatrix | Private |
| _craftableRendererController | CraftableRendererController | Private |
| _initialEffectTime | System.Single | Private |
| _effectTimePerBlock | System.Single | Private |
| _maxEffectTime | System.Single | Private |
| _shipSource | WildSkies.Gameplay.ShipBuilding.ShipSource | Private |
| OnFrameCrafted | System.Action | Public |
| OnBlocksUpdated | System.Action | Public |
| OnHullDataLoaded | System.Action | Public |
| OnSectionsFull | System.Action | Public |
| OnShipPartAdded | System.Action`1<WildSkies.Ship.ShipPart> | Public |
| OnShipPartRemoved | System.Action`1<WildSkies.Ship.ShipPart> | Public |
| _vertModified | System.Boolean | Private |
| _timeToCraft | System.Single | Private |
| <IsBeingEdited>k__BackingField | System.Boolean | Private |
| <HullDataProcessed>k__BackingField | System.Boolean | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _shipPartBuildingUtils | WildSkies.Gameplay.ShipBuilding.ShipPartBuildingUtils | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| TimeToCraft | System.Single | Public |
| MaxCurvyness | System.Single | Public |
| MinVertexDistance | System.Single | Public |
| TriggerPanelFaceSegmentCount | System.Int32 | Public |
| FaceSegmentCount | System.Int32 | Public |
| Grid | WildSkies.Gameplay.ShipBuilding.ShipyardGrid | Public |
| ShipHull | WildSkies.Gameplay.ShipBuilding.ShipHull | Public |
| HullEdges | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullEdge> | Public |
| HullVertices | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> | Public |
| HullFaces | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullFace> | Public |
| HullBlocks | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullBlock> | Public |
| ShipBuilderController | WildSkies.Gameplay.ShipBuilding.ShipBuilderController | Public |
| ConstructedShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Public |
| ShipHullParent | UnityEngine.Transform | Public |
| CoherenceSync | Coherence.Toolkit.CoherenceSync | Public |
| ShipMaterials | ShipMaterials | Public |
| FaceFillList | WildSkies.Gameplay.ShipBuilding.FaceFillList | Public |
| BeamList | WildSkies.Gameplay.ShipBuilding.BeamList | Public |
| ShipSource | WildSkies.Gameplay.ShipBuilding.ShipSource | Public |
| FaceDeckPanelScale | System.Single | Public |
| FaceWallPanelScale | System.Single | Public |
| FaceColliderOffset | System.Single | Public |
| FaceRendererOffset | System.Single | Public |
| FacePullOffset | System.Single | Public |
| ZFightingOffset | System.Single | Public |
| IsBeingEdited | System.Boolean | Public |
| HullDataProcessed | System.Boolean | Public |

## Methods

- **get_TimeToCraft()**: System.Single (Public)
- **get_MaxCurvyness()**: System.Single (Public)
- **get_MinVertexDistance()**: System.Single (Public)
- **get_TriggerPanelFaceSegmentCount()**: System.Int32 (Public)
- **get_FaceSegmentCount()**: System.Int32 (Public)
- **get_Grid()**: WildSkies.Gameplay.ShipBuilding.ShipyardGrid (Public)
- **get_ShipHull()**: WildSkies.Gameplay.ShipBuilding.ShipHull (Public)
- **set_ShipHull(WildSkies.Gameplay.ShipBuilding.ShipHull value)**: System.Void (Public)
- **get_HullEdges()**: System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullEdge> (Public)
- **set_HullEdges(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullEdge> value)**: System.Void (Public)
- **get_HullVertices()**: System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> (Public)
- **set_HullVertices(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> value)**: System.Void (Public)
- **get_HullFaces()**: System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullFace> (Public)
- **set_HullFaces(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullFace> value)**: System.Void (Public)
- **get_HullBlocks()**: System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullBlock> (Public)
- **set_HullBlocks(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullBlock> value)**: System.Void (Public)
- **get_ShipBuilderController()**: WildSkies.Gameplay.ShipBuilding.ShipBuilderController (Public)
- **get_ConstructedShipController()**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **get_ShipHullParent()**: UnityEngine.Transform (Public)
- **get_CoherenceSync()**: Coherence.Toolkit.CoherenceSync (Public)
- **get_ShipMaterials()**: ShipMaterials (Public)
- **get_FaceFillList()**: WildSkies.Gameplay.ShipBuilding.FaceFillList (Public)
- **get_BeamList()**: WildSkies.Gameplay.ShipBuilding.BeamList (Public)
- **get_ShipSource()**: WildSkies.Gameplay.ShipBuilding.ShipSource (Public)
- **get_FaceDeckPanelScale()**: System.Single (Public)
- **get_FaceWallPanelScale()**: System.Single (Public)
- **get_FaceColliderOffset()**: System.Single (Public)
- **get_FaceRendererOffset()**: System.Single (Public)
- **get_FacePullOffset()**: System.Single (Public)
- **get_ZFightingOffset()**: System.Single (Public)
- **get_IsBeingEdited()**: System.Boolean (Public)
- **set_IsBeingEdited(System.Boolean value)**: System.Void (Private)
- **get_HullDataProcessed()**: System.Boolean (Public)
- **set_HullDataProcessed(System.Boolean value)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **SetEdgeCornersActive(System.Boolean active)**: System.Void (Public)
- **SetDocked(System.Boolean isDocked)**: System.Void (Public)
- **SwitchHullPartsToDefaultState(System.Boolean forceRendererState)**: System.Void (Public)
- **Awake()**: System.Void (Private)
- **InitShipHull()**: System.Void (Private)
- **SetHullEdgeResourceId(System.String resourceId)**: System.Void (Public)
- **SyncSetHullEdgeResourceId(System.String resourceId)**: System.Void (Public)
- **SetUncraftedDeckResourceId(System.String resourceId)**: System.Void (Public)
- **SyncSetUncraftedDeckResourceId(System.String resourceId)**: System.Void (Public)
- **CreateInitBlock()**: System.Void (Public)
- **CreateAdditionalTestBlocks(System.Int32 xSize, System.Int32 zSize)**: System.Void (Public)
- **ClearBlocks()**: System.Void (Public)
- **OnRemoteHullDataReceived(WildSkies.Gameplay.ShipBuilding.ShipHull shipHull, WildSkies.Gameplay.ShipBuilding.ShipSource shipSource, System.Boolean spawnHullObjects)**: System.Void (Public)
- **ProcessLoadedHullData(System.Boolean spawnHullObjects)**: System.Void (Private)
- **ApplyVisualShipHull()**: System.Void (Private)
- **CanCreateShipObject(WildSkies.Gameplay.Building.BuildableItemDefinition buildableItemDefinition, WildSkies.Gameplay.ShipBuilding.ShipHullFace face)**: WildSkies.Service.BuildResult (Public)
- **TryCreateShipObject(WildSkies.Gameplay.Building.BuildableItemDefinition buildableItemDefinition, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Int32 parentId, System.Int32 upgradeLevel, WildSkies.Gameplay.ShipBuilding.ShipHullFace face, UnityEngine.Vector3 faceBasedShipObjectLocalPosition, UnityEngine.Quaternion rotation, System.Collections.Generic.List`1<ShipPartComponentResources> shipPartComponentResourcesList, UnityEngine.GameObject& createdObject)**: System.Boolean (Public)
- **TryCreateShipPanel(WildSkies.Gameplay.Building.BuildableItemDefinition buildableItemDefinition, System.Collections.Generic.List`1<System.String> craftingItemIds, WildSkies.Gameplay.ShipBuilding.ShipHullFace face, System.Boolean frontFaceHit)**: System.Boolean (Public)
- **TryCreateShipBeam(WildSkies.Gameplay.ShipBuilding.ShipHullEdge edge)**: System.Boolean (Public)
- **CreateShipObject(WildSkies.Gameplay.Building.BuildableItemDefinition buildableItemDefinition, System.Collections.Generic.List`1<System.String> craftingItemIds, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WildSkies.Gameplay.ShipBuilding.HullFace hullFace, System.Int32 hullDataIndex, System.Int32 parentHullDataIndex, System.Int32 upgradeLevel, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList)**: UnityEngine.GameObject (Public)
- **UpdateHullObjectDetails(System.Boolean syncOthers, System.Boolean updateChildTransforms, System.Int32 oldFaceID, System.Int32 newFaceID, System.Int32 hullObjectDataListIndex, System.Int32 parentHullObjectDataListIndex, System.Int32 upgradeLevel, UnityEngine.GameObject shipPartGameObject, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotationQuat, System.Int32 hullObjectTypeValue, System.String itemId, System.String schematicId, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList)**: System.Void (Public)
- **ReplicateObjectSetupOnOthersAsync(System.Boolean updateChildTransforms, System.Int32 oldFaceID, System.Int32 newFaceID, System.Int32 hullObjectDataListIndex, System.Int32 parentHullObjectDataListIndex, System.Int32 upgradeLevel, UnityEngine.GameObject hullObject, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotationQuat, System.Int32 hullObjectTypeValue, System.String itemId, System.String schematicId, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList, System.Threading.CancellationToken cancellationToken)**: Cysharp.Threading.Tasks.UniTask (Private)
- **ObjectSetupCmd(System.Boolean syncOthers, System.Boolean updateChildTransforms, System.Int32 oldFaceID, System.Int32 newFaceID, System.Int32 hullObjectDataListIndex, System.Int32 parentHullObjectDataListIndex, System.Int32 upgradeLevel, UnityEngine.GameObject shipPartGameObject, UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotationQuat, System.Int32 hullObjectTypeValue, System.String itemId, System.String schematicId, System.Byte[] craftingItemIdsByteArr, System.Int32 mainComponentIndex, System.Byte[] componentIdsByteArr, System.Byte[] resourceIdsByteArr)**: System.Void (Public)
- **CreateUniqueID(System.Int32 hullObjectDataListIndex)**: System.String (Private)
- **RegisterUniqueId(System.String uniqueId)**: System.Void (Private)
- **FindHullObjectsFromDataList(System.Int32 faceId)**: System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullObjectData> (Public)
- **FindHullObjectsFromDataList(WildSkies.Gameplay.ShipBuilding.HullObjectType hullObjectType)**: System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullObjectData> (Public)
- **SetMirrorValue(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis mirrorAxis)**: System.Void (Public)
- **NetworkedAddBlocks(System.Int32 faceId, System.Int32 mirroredFaceID)**: System.Void (Public)
- **TryAddBlock(WildSkies.Gameplay.ShipBuilding.ShipHullFace face, WildSkies.Gameplay.ShipBuilding.HullBlock& resultHullBlock, System.Boolean fromNetwork)**: System.Boolean (Public)
- **GetBlockBounds(UnityEngine.Vector2Int x, UnityEngine.Vector2Int y, UnityEngine.Vector2Int z)**: UnityEngine.Bounds (Public)
- **CreateBlock(UnityEngine.Vector2Int x, UnityEngine.Vector2Int y, UnityEngine.Vector2Int z, System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipHullVertex>& newVertices)**: WildSkies.Gameplay.ShipBuilding.HullBlock (Public)
- **IsFaceWithSharedVertices(WildSkies.Gameplay.ShipBuilding.HullVertex vert1, WildSkies.Gameplay.ShipBuilding.HullVertex vert2, WildSkies.Gameplay.ShipBuilding.HullVertex vert3, WildSkies.Gameplay.ShipBuilding.HullVertex vert4)**: System.Boolean (Public)
- **CreateVert(WildSkies.Gameplay.ShipBuilding.VertexBound vertexBound, System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipHullVertex> newVertices)**: WildSkies.Gameplay.ShipBuilding.ShipHullVertex (Private)
- **CreateEdge(WildSkies.Gameplay.ShipBuilding.HullVertex vert1, WildSkies.Gameplay.ShipBuilding.HullVertex vert2)**: WildSkies.Gameplay.ShipBuilding.ShipHullEdge (Private)
- **CreateShipFace(WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert1, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert2, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert3, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert4, System.Boolean negOffset)**: WildSkies.Gameplay.ShipBuilding.ShipHullFace (Private)
- **GetMeanVector(UnityEngine.Vector3[] positions)**: UnityEngine.Vector3 (Private)
- **GetMirroreddVerts(WildSkies.Gameplay.ShipBuilding.HullVertex[] verts, WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis& mirrorAxis)**: WildSkies.Gameplay.ShipBuilding.HullVertex[] (Public)
- **GetShipEdge(WildSkies.Gameplay.ShipBuilding.HullVertex vert1, WildSkies.Gameplay.ShipBuilding.HullVertex vert2)**: WildSkies.Gameplay.ShipBuilding.HullEdge (Public)
- **GetShipFace(WildSkies.Gameplay.ShipBuilding.HullVertex[] vertices)**: WildSkies.Gameplay.ShipBuilding.HullFace (Public)
- **GetShipFace(WildSkies.Gameplay.ShipBuilding.ShipHullVertex[] vertices)**: WildSkies.Gameplay.ShipBuilding.HullFace (Public)
- **GetCentreBlock()**: WildSkies.Gameplay.ShipBuilding.HullBlock (Private)
- **GetNumConnectedBlocks(WildSkies.Gameplay.ShipBuilding.HullBlock originBlock, System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullBlock> ignoreBlockList)**: System.Int32 (Private)
- **VisitConnectedBlocks(WildSkies.Gameplay.ShipBuilding.HullBlock curBlock, System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullBlock> visitedBlocks)**: System.Void (Private)
- **DeleteBlockViaFaceID(System.Int32 faceID)**: System.Void (Public)
- **DeleteBlock(WildSkies.Gameplay.ShipBuilding.ShipHullFace selectedFace)**: System.Boolean (Public)
- **DeleteBlock(System.Int32 blockId)**: System.Boolean (Public)
- **DeleteBlock(WildSkies.Gameplay.ShipBuilding.HullBlock deleteBlock)**: System.Boolean (Public)
- **GetShipBlock(WildSkies.Gameplay.ShipBuilding.HullFace shipFace, WildSkies.Gameplay.ShipBuilding.HullBlock& foundBlock)**: System.Boolean (Public)
- **AddVertToModifiedVertCache(System.Int32 vertID)**: System.Void (Private)
- **AddFaceToModifiedCurvesCache(System.Int32 faceID)**: System.Void (Public)
- **StartModifiedBlocksAsyncUpdate()**: System.Void (Private)
- **StopModifiedVertsAsyncUpdate()**: System.Void (Private)
- **SendModifiedBlocksTimer()**: Cysharp.Threading.Tasks.UniTaskVoid (Private)
- **SendModifiedBlocks()**: System.Void (Private)
- **GetModifiedVerts()**: System.ValueTuple`2<System.Byte[],System.Byte[]> (Private)
- **GetModifiedFaces()**: System.ValueTuple`3<System.Byte[],System.Byte[],System.Byte[]> (Private)
- **UpdateModifiedBlocksCommand(System.Byte[] modifiedVertsIDsCompressed, System.Byte[] modifiedVertsRelativePositionsCompressed, System.Byte[] modifiedFaceIDsCompressed, System.Byte[] modifiedFaceCurvesAmountArrayCompressed, System.Byte[] modifiedFaceCurvesAxisArrayCompressed)**: System.Void (Public)
- **ApplyModifiedVertPositions(System.Byte[] modifiedVertsIDsCompressed, System.Byte[] modifiedVertsRelativePositionsCompressed)**: System.Void (Private)
- **ApplyModifiedFaceCurves(System.Byte[] modifiedFaceIDsCompressed, System.Byte[] modifiedFaceCurvesAmountArrayCompressed, System.Byte[] modifiedFaceCurvesAxisArrayCompressed)**: System.Void (Private)
- **UpdatePlayerDetectorCollider()**: System.Void (Public)
- **CalculateBounds(System.Collections.Generic.List`1<UnityEngine.Vector3> vertices, UnityEngine.Vector3 margin, UnityEngine.Vector3 offset)**: System.ValueTuple`2<UnityEngine.Vector3,UnityEngine.Vector3> (Public)
- **ReturnFaceResources(System.Int32 faceID)**: System.Void (Public)
- **AuthorityReturnFaceResources(System.Int32 faceID)**: System.Void (Public)
- **CreateResourceSpawner(UnityEngine.Vector3 worldPos, System.Int32 ID, System.Byte materialIndex, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Boolean halfQuantity)**: System.Void (Private)
- **SetFaceMaterialIndices(System.Int32 faceID, System.Byte materialIndexFront, System.Byte materialIndexBack, System.Collections.Generic.List`1<System.String> craftingItemIdsFront, System.Collections.Generic.List`1<System.String> craftingItemIdsBack)**: System.Void (Public)
- **NextFaceMaterialIndex(System.Int32 faceID, WildSkies.Gameplay.ShipBuilding.HullFace/Direction faceDirection)**: System.Void (Public)
- **SyncSetFaceMaterialIndices(System.Int32 faceID, System.Byte materialIndexFront, System.Byte materialIndexBack, System.Byte[] craftingItemIdsFrontByteArr, System.Byte[] craftingItemIdsBackByteArr)**: System.Void (Public)
- **NextFaceFillIndex(System.Int32 faceID)**: System.Void (Public)
- **GetFaceFillIndex(System.Int32 faceID)**: System.UInt16 (Public)
- **SetFaceFillIndex(System.Int32 faceID, System.UInt16 fillIndex)**: System.Void (Public)
- **SyncSetFaceFillIndex(System.Int32 faceID, System.UInt16 fillIndex)**: System.Void (Public)
- **NextBeamMaterialIndex(System.Int32 edgeID)**: System.Void (Public)
- **SyncSetBeamMaterialIndex(System.Int32 edgeID, System.Byte materialIndex)**: System.Void (Public)
- **NextBeamTypeIndex(System.Int32 edgeID)**: System.Void (Public)
- **GetBeamTypeIndex(System.Int32 edgeID)**: System.UInt16 (Public)
- **SetBeamTypeIndex(System.Int32 edgeID, System.UInt16 beamTypeIndex)**: System.Void (Public)
- **SyncSetBeamTypeIndex(System.Int32 edgeID, System.UInt16 beamTypeIndex)**: System.Void (Public)
- **HideAttachedFaceEdges(System.Int32 faceID)**: System.Void (Public)
- **UpdateShipBeingEdited(System.Boolean isBeingEdited)**: System.Void (Public)
- **UpdateShipPartsCraftedState()**: System.Void (Private)
- **IsShipCrafted()**: System.Boolean (Public)
- **GetSolidBlockCount()**: System.Int32 (Public)
- **GetHologramBlockCount()**: System.Int32 (Public)
- **GetNumDeckPanels(WildSkies.Gameplay.ShipBuilding.ShipFrameCraftingType craftingType)**: System.Int32 (Public)
- **GetNumValidDeckPanels(System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullFace> faceList)**: System.Int32 (Private)
- **GetTotalBeamLength(WildSkies.Gameplay.ShipBuilding.ShipFrameCraftingType craftingType)**: System.Single (Public)
- **GetTotalBeamLength(System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullEdge> edgeList)**: System.Single (Private)
- **GetTotalBlockCount()**: System.Int32 (Public)
- **SetAllBlocksSolid(System.Boolean syncOthers)**: System.Void (Public)
- **GetPanelFaceFillIndexFromRotationStep(System.Int32 rotationStep)**: System.Int32 (Public)
- **RunCraftingEffect()**: System.Void (Private)
- **SwitchToHologram()**: System.Void (Private)
- **RemoveShipPart(WildSkies.Ship.ShipPart shipPart)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

