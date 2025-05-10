# WildSkies.IslandExport.ContainerBVHSphereAdapter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bvh | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.BoundingSphere> | Private |
| gameObjectToLeafMap | System.Collections.Generic.Dictionary`2<UnityEngine.BoundingSphere,WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.BoundingSphere>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.BoundingSphere>.BVH | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.BoundingSphere> | Private |

## Methods

- **WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.BoundingSphere>.get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<UnityEngine.BoundingSphere> (Private)
- **WildSkies.IslandExport.IContainerBVHNodeAdapter<UnityEngine.BoundingSphere>.set_BVH(WildSkies.IslandExport.ContainerBVH`1<UnityEngine.BoundingSphere> value)**: System.Void (Private)
- **CheckMap(UnityEngine.BoundingSphere sphere)**: System.Void (Public)
- **GetLeaf(UnityEngine.BoundingSphere sphere)**: WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.BoundingSphere> (Public)
- **GetObjectPos(UnityEngine.BoundingSphere sphere)**: UnityEngine.Vector3 (Public)
- **GetRadius(UnityEngine.BoundingSphere sphere)**: System.Single (Public)
- **GetBounds(UnityEngine.BoundingSphere sphere)**: UnityEngine.Bounds (Public)
- **GetScaledBoundingSphere(UnityEngine.BoundingSphere sphere)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **MapObjectToBVHLeaf(UnityEngine.BoundingSphere sphere, WildSkies.IslandExport.ContainerBVHNode`1<UnityEngine.BoundingSphere> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(UnityEngine.BoundingSphere changed)**: System.Void (Public)
- **UnmapObject(UnityEngine.BoundingSphere sphere)**: System.Void (Public)
- **GetInternalType(UnityEngine.BoundingSphere sphere)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

