# WildSkies.IslandExport.ContainerBVHTypedSphereAdapter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bvh | WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.TypedBoundingSphere> | Private |
| _gameObjectToLeafMap | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.TypedBoundingSphere,WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.TypedBoundingSphere>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WildSkies.IslandExport.IContainerBVHNodeAdapter<WildSkies.IslandExport.TypedBoundingSphere>.BVH | WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.TypedBoundingSphere> | Private |

## Methods

- **WildSkies.IslandExport.IContainerBVHNodeAdapter<WildSkies.IslandExport.TypedBoundingSphere>.get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.TypedBoundingSphere> (Private)
- **WildSkies.IslandExport.IContainerBVHNodeAdapter<WildSkies.IslandExport.TypedBoundingSphere>.set_BVH(WildSkies.IslandExport.ContainerBVH`1<WildSkies.IslandExport.TypedBoundingSphere> value)**: System.Void (Private)
- **GetObjectPos(WildSkies.IslandExport.TypedBoundingSphere sphere)**: UnityEngine.Vector3 (Public)
- **GetRadius(WildSkies.IslandExport.TypedBoundingSphere sphere)**: System.Single (Public)
- **GetBounds(WildSkies.IslandExport.TypedBoundingSphere sphere)**: UnityEngine.Bounds (Public)
- **GetScaledBoundingSphere(WildSkies.IslandExport.TypedBoundingSphere sphere)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **MapObjectToBVHLeaf(WildSkies.IslandExport.TypedBoundingSphere sphere, WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.TypedBoundingSphere> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(WildSkies.IslandExport.TypedBoundingSphere changed)**: System.Void (Public)
- **UnmapObject(WildSkies.IslandExport.TypedBoundingSphere sphere)**: System.Void (Public)
- **CheckMap(WildSkies.IslandExport.TypedBoundingSphere sphere)**: System.Void (Public)
- **GetLeaf(WildSkies.IslandExport.TypedBoundingSphere sphere)**: WildSkies.IslandExport.ContainerBVHNode`1<WildSkies.IslandExport.TypedBoundingSphere> (Public)
- **GetInternalType(WildSkies.IslandExport.TypedBoundingSphere sphere)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

