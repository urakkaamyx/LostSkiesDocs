# WildSkies.Gameplay.ShipBuilding.ShipHullFace

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| SubVerts | WildSkies.Gameplay.ShipBuilding.SubVerts | Public |
| CurveSubVerts | WildSkies.Gameplay.ShipBuilding.SubVerts | Public |
| _defaultMaterialBack | UnityEngine.Material | Protected |
| _hologramDeckMaterial | UnityEngine.Material | Private |
| _solidDeckMaterial | UnityEngine.Material | Private |
| _faceFillStampMaterial | UnityEngine.Material | Private |
| <FaceFillStampIndex>k__BackingField | System.UInt16 | Private |
| _shipParent | UnityEngine.Transform | Private |
| _hullFace | WildSkies.Gameplay.ShipBuilding.HullFace | Private |
| _sharedFaces | WildSkies.Gameplay.ShipBuilding.HullFace[] | Private |
| _height | System.Single | Private |
| _heightOpp | System.Single | Private |
| _width | System.Single | Private |
| _widthOpp | System.Single | Private |
| _colliderMinOffset | System.Single | Private |
| _colliderMaxOffset | System.Single | Private |
| _rendererMinOffset | System.Single | Private |
| _rendererMaxOffset | System.Single | Private |
| _raySensorColliderMinOffset | System.Single | Private |
| _raySensorColliderMaxOffset | System.Single | Private |
| _deckPanelScale | System.Single | Private |
| _wallPanelScale | System.Single | Private |
| _heightAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Private |
| _widthAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Private |
| _meshFilter | UnityEngine.MeshFilter | Private |
| _rendererMesh | UnityEngine.Mesh | Private |
| _colliderMesh | UnityEngine.Mesh | Private |
| _raySensorColliderMesh | UnityEngine.Mesh | Private |
| _collider | UnityEngine.MeshCollider | Private |
| _isFaceFillStampMode | System.Boolean | Private |
| _isDoubleDeckedFace | System.Boolean | Private |
| _raySensorVisual | UnityEngine.GameObject | Private |
| _raySensorMeshFilter | UnityEngine.MeshFilter | Private |
| _raySensorRenderer | UnityEngine.MeshRenderer | Private |
| _raySensorCollider | UnityEngine.MeshCollider | Private |
| _raySensorColliderSubverts | WildSkies.Gameplay.ShipBuilding.SubVerts | Private |
| _extrudedBlockCollisions | UnityEngine.Collider[] | Private |
| _shipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Private |
| _meshBuilder | MeshBuilder | Private |
| _shipPart | WildSkies.Ship.ShipPart | Private |
| _v0ToV3OgLength | System.Single | Private |
| _v0ToV1OgLength | System.Single | Private |
| _reverseFrontTrisVerts | System.Boolean | Private |
| _reverseBackTrisVerts | System.Boolean | Private |
| _newFace | System.Boolean | Private |
| _estimatedRotation | UnityEngine.Quaternion | Private |
| _cacheV0 | UnityEngine.Vector3 | Private |
| _cacheV1 | UnityEngine.Vector3 | Private |
| _cacheV2 | UnityEngine.Vector3 | Private |
| _cacheV3 | UnityEngine.Vector3 | Private |
| _cacheCurveIsV0ToV1 | System.Boolean | Private |
| _cacheCurvynessV0ToV1 | System.Single | Private |
| _cacheCurvynessV0ToV3 | System.Single | Private |
| _cachefaceFillIndex | System.UInt16 | Private |
| _cacheCalculatedEdgeExpansion | System.Boolean | Private |
| _healthCallbackAdded | System.Boolean | Private |
| _panelOffsetId | System.Int32 | Private |
| _boundsOffsetId | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Data | WildSkies.Gameplay.ShipBuilding.HullFace | Public |
| IsPanel | System.Boolean | Public |
| IsDeck | System.Boolean | Public |
| FaceFillStampIndex | System.UInt16 | Public |
| ShipParent | UnityEngine.Transform | Public |
| HeightAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Public |
| WidthAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Public |
| Collider | UnityEngine.Collider | Public |
| IsDoubleDeckedFace | System.Boolean | Public |
| ShipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Public |
| EstimatedRotation | UnityEngine.Quaternion | Public |
| Height | System.Single | Public |
| IsActive | System.Boolean | Public |
| ShipPart | WildSkies.Ship.ShipPart | Public |

## Methods

- **get_Data()**: WildSkies.Gameplay.ShipBuilding.HullFace (Public)
- **get_IsPanel()**: System.Boolean (Public)
- **get_IsDeck()**: System.Boolean (Public)
- **get_FaceFillStampIndex()**: System.UInt16 (Public)
- **set_FaceFillStampIndex(System.UInt16 value)**: System.Void (Private)
- **get_ShipParent()**: UnityEngine.Transform (Public)
- **get_HeightAxis()**: WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis (Public)
- **get_WidthAxis()**: WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis (Public)
- **get_Collider()**: UnityEngine.Collider (Public)
- **get_IsDoubleDeckedFace()**: System.Boolean (Public)
- **get_ShipFrameBuilder()**: WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder (Public)
- **get_EstimatedRotation()**: UnityEngine.Quaternion (Public)
- **get_Height()**: System.Single (Public)
- **get_IsActive()**: System.Boolean (Public)
- **get_ShipPart()**: WildSkies.Ship.ShipPart (Public)
- **Setup(WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder shipFrameBuilder, System.Boolean negOffset, WildSkies.Gameplay.ShipBuilding.HullFace hullFace, UnityEngine.Transform shipParent, System.Boolean newFace, EntityRendererService entityRendererService)**: System.Void (Public)
- **UpdateShipPartStats()**: System.Void (Public)
- **GetPartPlacementCategory()**: WildSkies.ShipParts.ShipPartPlacementCategories (Public)
- **SetupFaceNeighbours()**: System.Void (Public)
- **GetVerts()**: WildSkies.Gameplay.ShipBuilding.HullVertex[] (Public)
- **HasFaceFill()**: System.Boolean (Public)
- **GetFaceFillType()**: FaceFillType (Public)
- **GetVertPositions()**: System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> (Public)
- **GetFaceNormal(System.Boolean useFaceOffset)**: UnityEngine.Vector3 (Public)
- **GetFaceCentre()**: UnityEngine.Vector3 (Public)
- **ApplyVertPositions(System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> positions)**: System.Void (Public)
- **UpdateCollider()**: System.Void (Private)
- **RecalculateEdgeTypes()**: System.Void (Public)
- **ResetFrameCurvyness()**: System.Void (Private)
- **UpdateTrisVertReverse()**: System.Void (Private)
- **SetFaceOffset()**: System.Void (Public)
- **SetVertex(WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert1, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert2, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert3, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert4)**: System.Void (Public)
- **CleanUpCallbacks()**: System.Void (Public)
- **CreateMesh()**: System.Void (Public)
- **CreateMainFace(System.Collections.Generic.List`1<UnityEngine.Vector2> uvs, System.Int32 faceSegmentCount, System.Boolean isFrontFace)**: System.Void (Private)
- **CreateSideFace(System.Collections.Generic.List`1<UnityEngine.Vector2> uvs, System.Int32 sideIndex, System.Int32 faceSegmentCount)**: System.Void (Private)
- **FindSubvertsBetweenVertices(UnityEngine.Vector3 vert1Pos, UnityEngine.Vector3 vert2Pos, System.Int32 faceSegmentCount)**: System.Collections.Generic.List`1<UnityEngine.Vector3> (Private)
- **AddCurvePositioning(WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert1, WildSkies.Gameplay.ShipBuilding.ShipHullVertex vert2, System.Collections.Generic.List`1<UnityEngine.Vector3> vertices, System.Boolean v0ToV1Curve, System.Single fullLength)**: System.Collections.Generic.List`1<UnityEngine.Vector3> (Private)
- **LinkedFacesHaveMatchingEdge(WildSkies.Gameplay.ShipBuilding.HullVertex edgePoint0, WildSkies.Gameplay.ShipBuilding.HullVertex edgePoint1, System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> linkedFaces)**: System.Boolean (Private)
- **UpdateMesh()**: System.Void (Public)
- **ShouldColliderBeEnabled()**: System.Boolean (Private)
- **HasLinkedDeckFloor()**: System.Boolean (Public)
- **RemoveDoubleDecks()**: System.Void (Public)
- **UpdateFrontFace(System.Single offset, System.Single percentPerSegment, System.Collections.Generic.List`1<UnityEngine.Vector3> vertices, System.Int32 faceSegmentCount, System.Single curvynessV0ToV1, System.Collections.Generic.List`1<UnityEngine.Vector3> v0ToV1Subverts, System.Collections.Generic.List`1<UnityEngine.Vector3> v1ToV2Subverts, System.Collections.Generic.List`1<UnityEngine.Vector3> v3ToV2Subverts, System.Collections.Generic.List`1<UnityEngine.Vector3> v0ToV3Subverts)**: System.Void (Private)
- **UpdateBackFace(System.Single offset, System.Single percentPerSegment, System.Collections.Generic.List`1<UnityEngine.Vector3> vertices, System.Int32 faceSegmentCount, System.Collections.Generic.List`1<UnityEngine.Vector3> v1ToV2Subverts, System.Collections.Generic.List`1<UnityEngine.Vector3> v0ToV3Subverts)**: System.Void (Private)
- **UpdateSideFace(System.Single minOffset, System.Single maxOffset, System.Collections.Generic.List`1<UnityEngine.Vector3> offsetFromSubverts, System.Collections.Generic.List`1<UnityEngine.Vector3> frontFaceSubverts, System.Collections.Generic.List`1<UnityEngine.Vector3> vertices, System.Int32 faceSegmentCount)**: System.Void (Private)
- **IsCurrentMeshUpToDate()**: System.Boolean (Private)
- **Extrude(WildSkies.Gameplay.ShipBuilding.HullBlock& resultHullBlock, WildSkies.Gameplay.ShipBuilding.ShipHullFace/FaceExtrusionError& errorCode)**: System.Boolean (Public)
- **ExtrudeInOffset(UnityEngine.Vector3Int offset, System.Boolean round0Up, WildSkies.Gameplay.ShipBuilding.HullBlock& resultHullBlock, WildSkies.Gameplay.ShipBuilding.ShipHullFace/FaceExtrusionError& errorCode)**: System.Boolean (Private)
- **SnapInvalidGridVerts(UnityEngine.Vector3 axis, WildSkies.Gameplay.ShipBuilding.HullBlock block)**: System.Void (Private)
- **FaceHasVert(WildSkies.Gameplay.ShipBuilding.HullVertex vert)**: System.Boolean (Public)
- **GetPanelMaterial(System.Boolean frontFace)**: UnityEngine.Material (Public)
- **UpdatePanelMaterials()**: System.Void (Public)
- **DoesMaterialCastShadows()**: System.Boolean (Private)
- **UpdateDefaultMaterial()**: System.Void (Public)
- **SetDefaultCraftingItems(WildSkies.Service.BuildingService buildingService, WildSkies.Service.IItemService itemService)**: System.Void (Public)
- **UpdateMaterialTinting(UnityEngine.Material[] materialInstances)**: System.Void (Private)
- **SetSharedMaterials()**: System.Void (Private)
- **SetColliderSolidState()**: System.Void (Protected)
- **SetMaterialSolidState()**: System.Void (Protected)
- **EnterDefaultState()**: System.Void (Protected)
- **EnterMirroredState()**: System.Void (Protected)
- **EnterHoverState()**: System.Void (Protected)
- **EnterSelectedState()**: System.Void (Protected)
- **EnterFaceStampMode()**: System.Void (Public)
- **ExitFaceStampMode()**: System.Void (Public)
- **RotateFaceHologram(System.Int32 step)**: System.Void (Public)
- **SetFaceFillStampIndex(System.UInt16 newFaceFillIndex)**: System.Void (Public)
- **UpdateMeshForFaceFill()**: System.Void (Public)
- **SetCalculateEdgeExpansion(System.Boolean calculateEdgeExpansion)**: System.Void (Public)
- **RecalculateEdgeExpansion(System.Boolean includeLinkedFaces)**: System.Void (Public)
- **UpdateWidthHeight()**: System.Void (Private)
- **UpdateFaceHealthForRenderer()**: System.Void (Private)
- **UpdateDefaultMaterialVector(System.Int32 propertyId, UnityEngine.Vector4 value)**: System.Void (Private)
- **UpdateDefaultMaterialFloat(System.Int32 propertyId, System.Single value)**: System.Void (Private)
- **UpdateSharedFaceHealthsForRenderer()**: System.Void (Public)
- **UpdateSharedFaceHealthsForRenderer(System.Single newHealthNormalized)**: System.Void (Private)
- **DebugDrawRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Single length)**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

