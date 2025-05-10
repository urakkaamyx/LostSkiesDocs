# WildSkies.IslandExport.ContainerBVHNode`1

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Box | UnityEngine.Bounds | Public |
| Parent | WildSkies.IslandExport.ContainerBVHNode`1<T> | Public |
| Left | WildSkies.IslandExport.ContainerBVHNode`1<T> | Public |
| Right | WildSkies.IslandExport.ContainerBVHNode`1<T> | Public |
| Depth | System.Int32 | Public |
| NodeNumber | System.Int32 | Public |
| GObjects | System.Collections.Generic.List`1<T> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsLeaf | System.Boolean | Public |
| EachRot | System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1/Rot<T>> | Private |
| EachAxis | System.Collections.Generic.List`1<WildSkies.IslandExport.Axis> | Private |

## Methods

- **ToString()**: System.String (Public)
- **PickSplitAxis()**: WildSkies.IslandExport.Axis (Private)
- **get_IsLeaf()**: System.Boolean (Public)
- **NextAxis(WildSkies.IslandExport.Axis cur)**: WildSkies.IslandExport.Axis (Private)
- **RefitObjectChanged(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, T obj)**: System.Void (Public)
- **ExpandVolume(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, UnityEngine.Vector3 objectpos, System.Single radius)**: System.Void (Private)
- **AssignVolume(UnityEngine.Vector3 objectpos, System.Single radius)**: System.Void (Private)
- **ComputeVolume(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda)**: System.Void (Protected)
- **RefitVolume(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda)**: System.Boolean (Protected)
- **SA(UnityEngine.Bounds box)**: System.Single (Protected)
- **SA(UnityEngine.Bounds& box)**: System.Single (Protected)
- **SA(WildSkies.IslandExport.ContainerBVHNode`1<T> node)**: System.Single (Protected)
- **SA(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, T obj)**: System.Single (Protected)
- **AABBofPair(WildSkies.IslandExport.ContainerBVHNode`1<T> nodea, WildSkies.IslandExport.ContainerBVHNode`1<T> nodeb)**: UnityEngine.Bounds (Protected)
- **SAofPair(WildSkies.IslandExport.ContainerBVHNode`1<T> nodea, WildSkies.IslandExport.ContainerBVHNode`1<T> nodeb)**: System.Single (Protected)
- **SAofPair(UnityEngine.Bounds boxa, UnityEngine.Bounds boxb)**: System.Single (Protected)
- **AABBofOBJ(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, T obj)**: UnityEngine.Bounds (Protected)
- **SAofList(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, System.Collections.Generic.List`1<T> list)**: System.Single (Protected)
- **get_EachRot()**: System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1/Rot<T>> (Private)
- **TryRotate(WildSkies.IslandExport.ContainerBVH`1<T> bvh)**: System.Void (Protected)
- **get_EachAxis()**: System.Collections.Generic.List`1<WildSkies.IslandExport.Axis> (Private)
- **SplitNode(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda)**: System.Void (Protected)
- **SplitIfNecessary(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda)**: System.Void (Protected)
- **Add(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, T newOb, UnityEngine.Bounds& newObBox, System.Single newObSAH)**: System.Void (Protected)
- **AddObjectPushdown(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, T newOb)**: System.Void (Protected)
- **Add(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, T newOb, UnityEngine.Bounds& newObBox, System.Single newObSAH)**: System.Void (Protected)
- **CountContainerBVHNodes()**: System.Int32 (Protected)
- **Remove(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, T newOb)**: System.Void (Protected)
- **SetDepth(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, System.Int32 newdepth)**: System.Void (Private)
- **RemoveLeaf(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, WildSkies.IslandExport.ContainerBVHNode`1<T> removeLeaf)**: System.Void (Protected)
- **RootNode()**: WildSkies.IslandExport.ContainerBVHNode`1<T> (Protected)
- **FindOverlappingLeaves(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, UnityEngine.Vector3 origin, System.Single radius, System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> overlapList)**: System.Void (Protected)
- **BoundsIntersectsSphere(UnityEngine.Bounds bounds, UnityEngine.Vector3 origin, System.Single radius)**: System.Boolean (Private)
- **FindOverlappingLeaves(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, UnityEngine.Bounds aabb, System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> overlapList)**: System.Void (Protected)
- **ToBounds()**: UnityEngine.Bounds (Protected)
- **ChildExpanded(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, WildSkies.IslandExport.ContainerBVHNode`1<T> child)**: System.Void (Protected)
- **ChildRefit(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, System.Boolean propagate)**: System.Void (Protected)
- **ChildRefit(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nAda, WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, System.Boolean propagate)**: System.Void (Protected)
- **.ctor(WildSkies.IslandExport.ContainerBVH`1<T> bvh)**: System.Void (Protected)
- **.ctor(WildSkies.IslandExport.ContainerBVH`1<T> bvh, System.Collections.Generic.List`1<T> gobjectlist)**: System.Void (Protected)
- **.ctor(WildSkies.IslandExport.ContainerBVH`1<T> bvh, WildSkies.IslandExport.ContainerBVHNode`1<T> lparent, System.Collections.Generic.List`1<T> gobjectlist, WildSkies.IslandExport.Axis lastSplitAxis, System.Int32 curdepth)**: System.Void (Private)

