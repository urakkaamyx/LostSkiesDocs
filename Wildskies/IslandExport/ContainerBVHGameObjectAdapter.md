# WildSkies.IslandExport.ContainerBVHGameObjectAdapter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bvh | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.GameObject> | Private |
| gameObjectToLeafMap | System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.GameObject>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.GameObject>.BVH | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.GameObject> | Private |

## Methods

- **WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.GameObject>.get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<UnityEngine.GameObject> (Private)
- **WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.GameObject>.set_BVH(WildSkies.IslandExport.ContainerBVH`1<UnityEngine.GameObject> value)**: System.Void (Private)
- **CheckMap(UnityEngine.GameObject obj)**: System.Void (Public)
- **GetLeaf(UnityEngine.GameObject obj)**: WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.GameObject> (Public)
- **GetObjectPos(UnityEngine.GameObject obj)**: UnityEngine.Vector3 (Public)
- **GetRadius(UnityEngine.GameObject obj)**: System.Single (Public)
- **GetBounds(UnityEngine.GameObject obj)**: UnityEngine.Bounds (Public)
- **GetScaledBoundingSphere(UnityEngine.GameObject obj)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **MapObjectToBVHLeaf(UnityEngine.GameObject obj, WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.GameObject> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(UnityEngine.GameObject changed)**: System.Void (Public)
- **UnmapObject(UnityEngine.GameObject obj)**: System.Void (Public)
- **GetInternalType(UnityEngine.GameObject obj)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

