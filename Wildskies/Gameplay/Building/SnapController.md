# WildSkies.Gameplay.Building.SnapController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _snapToObjectType | WildSkies.Gameplay.Building.SnapController/SnapObjectType | Private |
| _layerMask | UnityEngine.LayerMask | Private |
| _snapObject | UnityEngine.MeshRenderer | Private |
| _placementStampController | WildSkies.Gameplay.Building.PlacementStampController | Private |
| _perfectAlignment | System.Boolean | Private |
| _onlySnapVertical | System.Boolean | Private |
| _snapBounds | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.SnapController/SnapBound> | Private |
| _foundSnapObject | System.Boolean | Private |
| _results | UnityEngine.Collider[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| SnapToObjectType | WildSkies.Gameplay.Building.SnapController/SnapObjectType | Public |
| SnapObject | UnityEngine.MeshRenderer | Public |

## Methods

- **get_SnapToObjectType()**: WildSkies.Gameplay.Building.SnapController/SnapObjectType (Public)
- **get_SnapObject()**: UnityEngine.MeshRenderer (Public)
- **Update()**: System.Void (Private)
- **UpdateSnapping()**: System.Void (Private)
- **CalculateSnappingPosition(UnityEngine.Bounds myBounds, UnityEngine.Bounds snapBounds, System.Boolean perfectAlignment, UnityEngine.Vector3 boundOffset)**: UnityEngine.Vector3 (Private)
- **CalculateAxisOffset(System.Single minA, System.Single maxA, System.Single minB, System.Single maxB)**: System.Single (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

