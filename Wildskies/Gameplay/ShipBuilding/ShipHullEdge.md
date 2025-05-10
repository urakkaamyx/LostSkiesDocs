# WildSkies.Gameplay.ShipBuilding.ShipHullEdge

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| PrimitiveColliderOverlap | System.Single | Private |
| CornerMesh | UnityEngine.GameObject | Private |
| _cornerMeshRenderer | UnityEngine.MeshRenderer | Private |
| _cornerMeshFilter | UnityEngine.MeshFilter | Private |
| _cornerMeshTemplate | WildSkies.Gameplay.ShipBuilding.BeamCrossSection | Private |
| _beamTypeStampMaterial | UnityEngine.Material | Private |
| <BeamTypeStampIndex>k__BackingField | System.UInt16 | Private |
| <IsCornerEnabled>k__BackingField | System.Boolean | Private |
| _primitiveCollider | UnityEngine.CapsuleCollider | Private |
| _placementCollider | UnityEngine.MeshCollider | Private |
| _shipParent | UnityEngine.Transform | Private |
| _startPoints | UnityEngine.Vector3[] | Private |
| _endPoints | UnityEngine.Vector3[] | Private |
| _beamAngle | System.Single | Private |
| _uScale | System.Single | Private |
| _vScale | System.Single | Private |
| _cornerMeshMinMaxAngle | UnityEngine.Vector2 | Private |
| _cornerMeshMinRailLength | System.Single | Private |
| _cornerMeshMinEdgeLength | System.Single | Private |
| _debugLogging | System.Boolean | Private |
| _hullEdge | WildSkies.Gameplay.ShipBuilding.HullEdge | Private |
| _mesh | UnityEngine.Mesh | Private |
| _cornerMesh | UnityEngine.Mesh | Private |
| _meshFilter | UnityEngine.MeshFilter | Private |
| _cornerPoints | System.Collections.Generic.List`1<UnityEngine.Vector3> | Private |
| _linkedFaces | System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _outerFaces | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _innerFaces | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _faceAxisX | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _faceAxisY | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _faceAxisZ | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Private |
| _newVerts | System.Collections.Generic.List`1<UnityEngine.Vector3> | Private |
| _linePoints | System.Collections.Generic.List`1<UnityEngine.Vector3> | Private |
| _triangles | System.Collections.Generic.List`1<System.Int32> | Private |
| _uvs | System.Collections.Generic.List`1<UnityEngine.Vector2> | Private |
| _shipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Private |
| _meshBuilder | MeshBuilder | Private |
| _shipPart | WildSkies.Ship.ShipPart | Private |
| _edgeAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Private |
| _edgeAxisVector | UnityEngine.Vector3 | Private |
| _isBeamTypeStampMode | System.Boolean | Private |
| _isExternal | System.Boolean | Private |
| _flipBeamCrossSectionFlags | System.Int32 | Private |
| _trisIndices | System.Int32[] | Private |
| _trisIndicesCCW | System.Int32[] | Private |
| _cacheCurveModified | System.Boolean | Private |
| _cacheV0 | UnityEngine.Vector3 | Private |
| _cacheV1 | UnityEngine.Vector3 | Private |
| _cacheBeamTypeIndex | System.UInt16 | Private |
| _cacheBeamAngle | System.Single | Private |
| _cacheIsExternal | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Data | WildSkies.Gameplay.ShipBuilding.HullEdge | Public |
| IsUprightBeam | System.Boolean | Public |
| EdgeAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Public |
| BeamTypeStampIndex | System.UInt16 | Public |
| IsCornerEnabled | System.Boolean | Public |
| IsExternal | System.Boolean | Public |
| ShipParent | UnityEngine.Transform | Public |
| ShipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Public |
| EdgeAxisVector | UnityEngine.Vector3 | Public |
| MeshFilter | UnityEngine.MeshFilter | Public |
| ShipPart | WildSkies.Ship.ShipPart | Public |

## Methods

- **get_Data()**: WildSkies.Gameplay.ShipBuilding.HullEdge (Public)
- **get_IsUprightBeam()**: System.Boolean (Public)
- **get_EdgeAxis()**: WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis (Public)
- **get_BeamTypeStampIndex()**: System.UInt16 (Public)
- **set_BeamTypeStampIndex(System.UInt16 value)**: System.Void (Private)
- **get_IsCornerEnabled()**: System.Boolean (Public)
- **set_IsCornerEnabled(System.Boolean value)**: System.Void (Private)
- **get_IsExternal()**: System.Boolean (Public)
- **get_ShipParent()**: UnityEngine.Transform (Public)
- **get_ShipFrameBuilder()**: WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder (Public)
- **get_EdgeAxisVector()**: UnityEngine.Vector3 (Public)
- **get_MeshFilter()**: UnityEngine.MeshFilter (Public)
- **get_ShipPart()**: WildSkies.Ship.ShipPart (Public)
- **Setup(WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder shipFrameBuilder, UnityEngine.Transform shipParent, WildSkies.Gameplay.ShipBuilding.HullEdge hullEdge, WildSkies.Gameplay.ShipBuilding.HullVertex vert1, WildSkies.Gameplay.ShipBuilding.HullVertex vert2)**: System.Void (Public)
- **UpdateShipPartStats()**: System.Void (Public)
- **AlignPrimitiveCollider()**: System.Void (Private)
- **SetVertex(WildSkies.Gameplay.ShipBuilding.HullVertex vert1, WildSkies.Gameplay.ShipBuilding.HullVertex vert2)**: System.Void (Public)
- **InitialiseShipPart()**: System.Void (Public)
- **GetBeamCrossSection()**: WildSkies.Gameplay.ShipBuilding.BeamCrossSection (Public)
- **GetPartPlacementCategory()**: WildSkies.ShipParts.ShipPartPlacementCategories (Public)
- **GetBeamData()**: WildSkies.Gameplay.ShipBuilding.BeamData (Public)
- **DoesBeamFaceInwards()**: System.Boolean (Public)
- **HasVisibleBeam()**: System.Boolean (Public)
- **IsStructuralBeam()**: System.Boolean (Public)
- **CleanUpCallbacks()**: System.Void (Public)
- **GetVerts()**: WildSkies.Gameplay.ShipBuilding.HullVertex[] (Public)
- **GetLinkedFaces(System.Boolean fullyConnectedFacesOnly)**: System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullFace> (Public)
- **GetVertPositions()**: System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> (Public)
- **ApplyVertPositions(System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> positions)**: System.Void (Public)
- **CreateFrameMesh()**: System.Void (Private)
- **UpdateFrame()**: System.Void (Public)
- **IsCurrentMeshUpToDate()**: System.Boolean (Private)
- **RecalculateEdgeType()**: System.Void (Public)
- **RemoveFrameCurve()**: System.Void (Public)
- **CreateCurvedFrameMesh(System.Collections.Generic.List`1<UnityEngine.Vector3> linePoints)**: System.Void (Private)
- **CalculateLocalSpaceUV(UnityEngine.Vector3 vertPos, UnityEngine.Quaternion edgeInverseRot, System.Single uScaleMultiplier, System.Single v)**: UnityEngine.Vector2 (Private)
- **GetBeamLength()**: System.Single (Public)
- **UpdateBeamAngle()**: System.Boolean (Public)
- **UpdateExternal()**: System.Void (Private)
- **CalculateFrameVerts()**: System.Void (Private)
- **GenerateFlatBetweenMesh(System.Collections.Generic.List`1<UnityEngine.Vector3> curvedSubverts, System.Collections.Generic.List`1<UnityEngine.Vector3> flatSubverts)**: System.Void (Public)
- **GenerateBetweenMesh(WildSkies.Gameplay.ShipBuilding.ShipHullEdge/FaceCurve faceCurve, System.Collections.Generic.List`1<UnityEngine.Vector3> faceXCurveSubverts, System.Collections.Generic.List`1<UnityEngine.Vector3> faceYCurveSubVerts, System.Collections.Generic.List`1<UnityEngine.Vector3> faceZCurveSubVerts)**: System.Void (Public)
- **UpdateCornerMeshes()**: System.Void (Public)
- **AddExtrudedTriangle(WildSkies.Gameplay.ShipBuilding.BeamData beamData, UnityEngine.Vector3 cornerVert, UnityEngine.Vector3 upVec, UnityEngine.Vector3 rightVec)**: System.Void (Private)
- **CalculateBeamAngle()**: System.Void (Private)
- **CalculateFrameOuterFaces()**: System.Void (Private)
- **CreateBetweenMesh()**: System.Boolean (Private)
- **CreateMeshForParallelFrames(System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> faceAxis)**: System.Boolean (Private)
- **CreateMesh()**: System.Void (Public)
- **CreateSideMesh(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 nextStartPoint, UnityEngine.Vector3 nextEndPoint, UnityEngine.Quaternion edgeInverseRot, System.Single v0, System.Single v1)**: System.Void (Private)
- **UpdateMaterialTinting(System.Collections.Generic.List`1<UnityEngine.Material> materialInstances)**: System.Void (Private)
- **SetSharedMaterials()**: System.Void (Private)
- **SetColliderSolidState()**: System.Void (Protected)
- **SetMaterialSolidState()**: System.Void (Protected)
- **UpdateDefaultMaterial()**: System.Void (Public)
- **EnterBeamTypeStampMode()**: System.Void (Public)
- **ExitBeamTypeStampMode()**: System.Void (Public)
- **SetBeamTypeStampIndex(System.UInt16 newBeamTypeIndex)**: System.Void (Public)
- **UpdateMeshForBeamType()**: System.Void (Public)
- **SetCornerActive(System.Boolean active)**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **OnDrawGizmosSelected()**: System.Void (Private)
- **Equals(WildSkies.Gameplay.ShipBuilding.HullVertex vert1, WildSkies.Gameplay.ShipBuilding.HullVertex vert2)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

