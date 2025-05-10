# WildSkies.Gameplay.ShipBuilding.ShipPartPlacementMatrix

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _placementMatrix | System.UInt32[] | Private |
| _floorMaxAngle | System.Single | Private |
| _ceilingMaxAngle | System.Single | Private |
| _maxChildDepth | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| PlacementMatrix | System.UInt32[] | Public |
| FloorMaxAngle | System.Single | Public |
| CeilingMaxAngle | System.Single | Public |
| MaxChildDepth | System.Int32 | Public |

## Methods

- **get_PlacementMatrix()**: System.UInt32[] (Public)
- **get_FloorMaxAngle()**: System.Single (Public)
- **set_FloorMaxAngle(System.Single value)**: System.Void (Public)
- **get_CeilingMaxAngle()**: System.Single (Public)
- **set_CeilingMaxAngle(System.Single value)**: System.Void (Public)
- **get_MaxChildDepth()**: System.Int32 (Public)
- **set_MaxChildDepth(System.Int32 value)**: System.Void (Public)
- **IsPlaceable(WildSkies.ShipParts.ShipPartPlacementCategories srcObject, UnityEngine.Vector3 dstLocalNormal)**: System.Boolean (Public)
- **IsPlaceable(WildSkies.ShipParts.ShipPartPlacementCategories srcObject, WildSkies.ShipParts.ShipPartPlacementCategories dstObject, UnityEngine.Vector3 dstLocalNormal)**: System.Boolean (Public)
- **IsPlaceable(WildSkies.ShipParts.ShipPartPlacementCategories srcObject, WildSkies.ShipParts.ShipPartPlacementCategories dstObject, System.Boolean dstObjectValid, UnityEngine.Vector3 dstLocalNormal)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

