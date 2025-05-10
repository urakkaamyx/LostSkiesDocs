# WildSkies.IslandExport.IContainerBVHNodeAdapter`1

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| BVH | WildSkies.IslandExport.ContainerBVH`1<T> | Public |

## Methods

- **get_BVH()**: WildSkies.IslandExport.ContainerBVH`1<T> (Public)
- **set_BVH(WildSkies.IslandExport.ContainerBVH`1<T> value)**: System.Void (Public)
- **GetObjectPos(T obj)**: UnityEngine.Vector3 (Public)
- **GetRadius(T obj)**: System.Single (Public)
- **GetBounds(T obj)**: UnityEngine.Bounds (Public)
- **GetScaledBoundingSphere(T obj)**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **MapObjectToBVHLeaf(T obj, WildSkies.IslandExport.ContainerBVHNode`1<T> leaf)**: System.Void (Public)
- **OnPositionOrSizeChanged(T changed)**: System.Void (Public)
- **UnmapObject(T obj)**: System.Void (Public)
- **CheckMap(T obj)**: System.Void (Public)
- **GetInternalType(T obj)**: System.Int32 (Public)
- **GetLeaf(T obj)**: WildSkies.IslandExport.ContainerBVHNode`1<T> (Public)

