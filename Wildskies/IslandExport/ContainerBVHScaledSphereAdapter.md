# WildSkies.IslandExport.ContainerBVHScaledSphereAdapter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bvh | WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.ScaledBoundingSphere> | Private |
| gameObjectToLeafMap | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.ScaledBoundingSphere,WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.ScaledBoundingSphere>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WildSkies.IslandExport.IContainerBVHNodeAdapter<WildSkies.IslandExport.ScaledBoundingSphere>.BVH | WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.ScaledBoundingSphere> | Private |

## Methods

- **WildSkies.IslandExport.IContainerBVHNodeAdapter<WildSkies.IslandExport.ScaledBoundingSphere>.get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.ScaledBoundingSphere> (Private)
- **WildSkies.IslandExport.IContainerBVHNodeAdapter<WildSkies.IslandExport.ScaledBoundingSphere>.set_BVH(WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.ScaledBoundingSphere> value)**: System.Void (Private)
- **CheckMap(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: System.Void (Public)
- **GetLeaf(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.ScaledBoundingSphere> (Public)
- **GetObjectPos(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: UnityEngine.Vector3 (Public)
- **GetRadius(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: System.Single (Public)
- **GetScaledBoundingSphere(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **GetBounds(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: UnityEngine.Bounds (Public)
- **MapObjectToBVHLeaf(WildSkies.IslandExport.ScaledBoundingSphere sphere, WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.ScaledBoundingSphere> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(WildSkies.IslandExport.ScaledBoundingSphere changed)**: System.Void (Public)
- **UnmapObject(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: System.Void (Public)
- **GetInternalType(WildSkies.IslandExport.ScaledBoundingSphere sphere)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

