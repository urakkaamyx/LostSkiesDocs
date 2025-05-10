# WildSkies.IslandExport.ScaledBoundingSphere

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sphere | UnityEngine.BoundingSphere | Private |
| _inverseRotation | UnityEngine.Quaternion | Private |
| _scale | UnityEngine.Vector3 | Private |
| _exclusionRadius | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Sphere | UnityEngine.BoundingSphere | Public |
| Rotation | UnityEngine.Quaternion | Public |
| InverseRotation | UnityEngine.Quaternion | Public |
| Scale | UnityEngine.Vector3 | Public |
| ExclusionRadius | System.Single | Public |

## Methods

- **get_Sphere()**: UnityEngine.BoundingSphere (Public)
- **get_Rotation()**: UnityEngine.Quaternion (Public)
- **get_InverseRotation()**: UnityEngine.Quaternion (Public)
- **get_Scale()**: UnityEngine.Vector3 (Public)
- **get_ExclusionRadius()**: System.Single (Public)
- **Empty()**: WildSkies.IslandExport.ScaledBoundingSphere (Public)
- **.ctor(UnityEngine.BoundingSphere sphere, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, System.Single exclusionRadius)**: System.Void (Public)
- **GetMaxScale()**: System.Single (Public)
- **GetMaxScaleVector()**: UnityEngine.Vector3 (Public)
- **Excludes(UnityEngine.Vector3 pos)**: System.Boolean (Public)
- **Contains(UnityEngine.Vector3 pos)**: System.Boolean (Public)

