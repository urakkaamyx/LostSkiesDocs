# WildSkies.IslandExport.ContainerBVHBoxAdapter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bvh | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.Bounds> | Private |
| gameObjectToLeafMap | System.Collections.Generic.Dictionary`2<UnityEngine.Bounds,WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.Bounds>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.Bounds>.BVH | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.Bounds> | Private |

## Methods

- **WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.Bounds>.get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<UnityEngine.Bounds> (Private)
- **WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.Bounds>.set_BVH(WildSkies.IslandExport.ContainerBVH`1<UnityEngine.Bounds> value)**: System.Void (Private)
- **CheckMap(UnityEngine.Bounds box)**: System.Void (Public)
- **GetLeaf(UnityEngine.Bounds box)**: WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.Bounds> (Public)
- **GetObjectPos(UnityEngine.Bounds box)**: UnityEngine.Vector3 (Public)
- **GetRadius(UnityEngine.Bounds box)**: System.Single (Public)
- **GetBounds(UnityEngine.Bounds box)**: UnityEngine.Bounds (Public)
- **GetScaledBoundingSphere(UnityEngine.Bounds box)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **MapObjectToBVHLeaf(UnityEngine.Bounds box, WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.Bounds> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(UnityEngine.Bounds changed)**: System.Void (Public)
- **UnmapObject(UnityEngine.Bounds box)**: System.Void (Public)
- **GetInternalType(UnityEngine.Bounds box)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

