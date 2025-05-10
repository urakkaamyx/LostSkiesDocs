# WildSkies.IslandExport.ContainerBVH`1

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| rootBVH | WildSkies.IslandExport.ContainerBVHNode`1<T> | Public |
| nAda | WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> | Public |
| LEAF_OBJ_MAX | System.Int32 | Public |
| nodeCount | System.Int32 | Public |
| maxDepth | System.Int32 | Public |
| refitNodes | System.Collections.Generic.HashSet`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> | Public |

## Methods

- **TraverseInternal(WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, WildSkies.IslandExport.NodeTraversalTest hitTest, System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> hitlist)**: System.Void (Private)
- **TraverseEntireTreeInternalType(WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, System.Int32 internalType, System.Collections.Generic.List`1<T> hitlist)**: System.Void (Private)
- **TraverseRayInternal(WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, UnityEngine.Ray ray, System.Collections.Generic.SortedList`2<System.Single,WildSkies.IslandExport.ContainerBVHNode`1<T>> hitlist)**: System.Void (Private)
- **DoesTriIntersectNodeBoundsInternal(WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, System.Boolean& triIntersects)**: System.Void (Private)
- **DoesTriIntersectNodeSphereInternal(WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, System.Boolean& triIntersects, System.Boolean& triExcluded)**: System.Void (Private)
- **Traverse(WildSkies.IslandExport.NodeTraversalTest hitTest)**: System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> (Public)
- **TraverseRay(UnityEngine.Ray ray)**: System.Collections.Generic.SortedList`2<System.Single,WildSkies.IslandExport.ContainerBVHNode`1<T>> (Public)
- **GetObjectsOfInternalType(System.Int32 internalType)**: System.Collections.Generic.List`1<T> (Public)
- **DoesTriIntersectNodeBounds(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)**: System.Boolean (Public)
- **DoesTriIntersectNodeSphere(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)**: System.Boolean (Public)
- **TraverseSphere(UnityEngine.Vector3 point, System.Single radius)**: System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> (Public)
- **TraverseBounds(UnityEngine.Bounds box)**: System.Collections.Generic.List`1<WildSkies.IslandExport.ContainerBVHNode`1<T>> (Public)
- **Optimize()**: System.Void (Public)
- **Add(T newObj)**: System.Void (Public)
- **AddRange(System.Collections.Generic.IEnumerable`1<T> newObjs)**: System.Void (Public)
- **MarkForUpdate(T toUpdate)**: System.Void (Public)
- **Remove(T newObj)**: System.Void (Public)
- **RemoveRange(System.Collections.Generic.IEnumerable`1<T> newObjs)**: System.Void (Public)
- **Reset()**: System.Void (Public)
- **CountContainerBVHNodes()**: System.Int32 (Public)
- **.ctor(WildSkies.IslandExport.IContainerBVHNodeAdapter`1<T> nodeAdaptor, System.Collections.Generic.List`1<T> objects, System.Int32 LEAF_OBJ_MAX)**: System.Void (Public)
- **AddDebugBVHBoundsRecursive(WildSkies.IslandExport.ContainerBVHNode`1<T> n, System.Int32 depth)**: System.Void (Private)
- **AddDebugObjectsRecursive(UnityEngine.Transform parentObj, WildSkies.IslandExport.ContainerBVHNode`1<T> curNode, WildSkies.IslandExport.BVHDebugObjectType debugObjectType, System.Int32 depth)**: System.Void (Private)
- **AddDebugObjects(WildSkies.IslandExport.BVHDebugObjectType debugObjectType)**: System.Void (Public)
- **AddDebugBVHBounds()**: System.Void (Public)
- **<Optimize>b__18_2(WildSkies.IslandExport.ContainerBVHNode`1<T> n)**: System.Void (Private)
- **<Optimize>b__18_3(WildSkies.IslandExport.ContainerBVHNode`1<T> n)**: System.Void (Private)

