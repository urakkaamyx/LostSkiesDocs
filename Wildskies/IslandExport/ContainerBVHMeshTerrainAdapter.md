# WildSkies.IslandExport.ContainerBVHMeshTerrainAdapter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bvh | WildSkies.IslandExport.ContainerBVH`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> | Private |
| meshTerrainToLeafMap | System.Collections.Generic.Dictionary`2<AwesomeTechnologies.MeshTerrains.MeshTerrain,WildSkies.IslandExport.ContainerBVHNode`1<AwesomeTechnologies.MeshTerrains.MeshTerrain>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WildSkies.IslandExport.IContainerBVHNodeAdapter<AwesomeTechnologies.MeshTerrains.MeshTerrain>.BVH | WildSkies.IslandExport.ContainerBVH`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> | Private |

## Methods

- **WildSkies.IslandExport.IContainerBVHNodeAdapter<AwesomeTechnologies.MeshTerrains.MeshTerrain>.get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> (Private)
- **WildSkies.IslandExport.IContainerBVHNodeAdapter<AwesomeTechnologies.MeshTerrains.MeshTerrain>.set_BVH(WildSkies.IslandExport.ContainerBVH`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> value)**: System.Void (Private)
- **CheckMap(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: System.Void (Public)
- **GetLeaf(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: WildSkies.IslandExport.ContainerBVHNode`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> (Public)
- **GetObjectPos(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: UnityEngine.Vector3 (Public)
- **GetRadius(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: System.Single (Public)
- **GetBounds(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: UnityEngine.Bounds (Public)
- **GetScaledBoundingSphere(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **MapObjectToBVHLeaf(AwesomeTechnologies.MeshTerrains.MeshTerrain obj, WildSkies.IslandExport.ContainerBVHNode`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(AwesomeTechnologies.MeshTerrains.MeshTerrain changed)**: System.Void (Public)
- **UnmapObject(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: System.Void (Public)
- **GetInternalType(AwesomeTechnologies.MeshTerrains.MeshTerrain obj)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

