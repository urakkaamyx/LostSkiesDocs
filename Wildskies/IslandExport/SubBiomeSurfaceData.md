# WildSkies.IslandExport.SubBiomeSurfaceData

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _subBiome | WildSkies.IslandExport.SubBiomeType | Private |
| _agentTypeID | System.Int32 | Private |
| _totalArea | System.Single | Private |
| _showSceneGizmo | System.Boolean | Private |
| _tris | System.Collections.Generic.List`1<System.Int32> | Private |
| _triNormals | System.Collections.Generic.List`1<WildSkies.IslandExport.SerializableVector3> | Private |
| _verts | System.Collections.Generic.List`1<WildSkies.IslandExport.SerializableVector3> | Private |
| _areaMap | System.Collections.Generic.List`1<System.Single> | Private |
| _contiguousGroups | System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceGroup> | Private |
| _minContiguousGroupArea | System.Single | Private |
| _terrainLayer | System.Int32 | Private |
| _subBiomeSearchSurfaceGroup | WildSkies.IslandExport.SubBiomeSurfaceGroup | Private |
| _subBiomeGroupAreaOffsetComparer | WildSkies.IslandExport.CompareSubBiomeSurfaceGroupAreaOffset | Private |
| _subBiomeGroupAreaComparer | WildSkies.IslandExport.CompareSubBiomeSurfaceGroupArea | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| SubBiome | WildSkies.IslandExport.SubBiomeType | Public |
| AgentTypeID | System.Int32 | Public |
| TotalArea | System.Single | Public |
| ContiguousGroups | System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceGroup> | Public |

## Methods

- **get_SubBiome()**: WildSkies.IslandExport.SubBiomeType (Public)
- **get_AgentTypeID()**: System.Int32 (Public)
- **get_TotalArea()**: System.Single (Public)
- **get_ContiguousGroups()**: System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceGroup> (Public)
- **.ctor(WildSkies.IslandExport.SubBiomeType subBiome, System.Int32 agentTypeID, UnityEngine.AI.NavMeshTriangulation navMeshTriangulationData, System.Int32 areaIndex, System.Boolean flipNormals)**: System.Void (Public)
- **RemoveUnusedVerts()**: System.Void (Private)
- **CreateSurfaceGroups(System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData/TriRef> triGroups)**: System.Void (Private)
- **GetTriBounds(System.Int32 triIndex)**: UnityEngine.Bounds (Private)
- **GetContiguousTriangleGroups(System.Collections.Generic.List`1<System.Int32> unsortedTris)**: System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData/TriRef> (Private)
- **AddTriVertIndices(System.Int32 srcTriIdx, System.Collections.Generic.HashSet`1<System.Int32> currentGroupVertIndices, System.Collections.Generic.List`1<System.Int32> unsortedTris)**: System.Void (Private)
- **GetFirstEmptryTriGroup(System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData/TriRef> triGroups, System.Int32 searchOffset)**: System.Int32 (Private)
- **GetRandomGroup(System.Single minArea)**: System.Int32 (Public)
- **GetRandomPoint(UnityEngine.Transform parentTransform, WildSkies.IslandExport.SubBiomeSurfaceHit& surfaceHit, WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.TypedBoundingSphere> localSpaceExcludedAreas, System.Random random, System.Single requestedRadius, System.Boolean raycastToGround, System.Int32 maxAttempts)**: System.Boolean (Public)
- **GetRandomPoint(UnityEngine.Transform parentTransform, WildSkies.IslandExport.SubBiomeSurfaceHit& surfaceHit, System.Random random, System.Boolean raycastToGround)**: System.Boolean (Public)
- **GetRandomPoint(UnityEngine.Transform parentTransform, WildSkies.IslandExport.SubBiomeSurfaceHit& surfaceHit, System.Int32 surfaceGroupIndex, System.Random random, System.Boolean raycastToGround)**: System.Boolean (Public)
- **GetRandomPointInternal(UnityEngine.Transform parentTransform, WildSkies.IslandExport.SubBiomeSurfaceHit& surfaceHit, System.Single randomArea, System.Boolean raycastToGround, System.Random random)**: System.Boolean (Private)
- **DoesSphereOverlap(System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.TypedBoundingSphere>> intersectingNodesList, UnityEngine.Vector3 requestedPoint, System.Single requestedRadius)**: System.Boolean (Public)
- **RandomPointOnTriangle(System.Int32 triIdx, System.Random random)**: UnityEngine.Vector3 (Private)
- **GetTriArea(System.Collections.Generic.List`1<System.Int32> indices, System.Int32 triIdx, UnityEngine.Vector3& triNormal)**: System.Single (Private)
- **OnDrawGizmosSelected()**: System.Void (Public)
- **GenerateDebugMesh()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

