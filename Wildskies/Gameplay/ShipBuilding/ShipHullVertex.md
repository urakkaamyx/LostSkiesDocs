# WildSkies.Gameplay.ShipBuilding.ShipHullVertex

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _collider | UnityEngine.SphereCollider | Private |
| VertHasMoved | System.Action | Public |
| SyncOthersForVertHasMoved | System.Action`1<System.Int32> | Public |
| _hullVertex | WildSkies.Gameplay.ShipBuilding.HullVertex | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Data | WildSkies.Gameplay.ShipBuilding.HullVertex | Public |

## Methods

- **get_Data()**: WildSkies.Gameplay.ShipBuilding.HullVertex (Public)
- **Setup(WildSkies.Gameplay.ShipBuilding.VertexBound boundData, WildSkies.Gameplay.ShipBuilding.HullVertex hullVertex)**: System.Void (Public)
- **GetVerts()**: WildSkies.Gameplay.ShipBuilding.HullVertex[] (Public)
- **SetVisible(System.Boolean isVisible)**: System.Void (Public)
- **GetVertPositions()**: System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> (Public)
- **GetPartPlacementCategory()**: WildSkies.ShipParts.ShipPartPlacementCategories (Public)
- **ApplyVertPositions(System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> positions)**: System.Void (Public)
- **EnterDefaultState()**: System.Void (Protected)
- **EnterMirroredState()**: System.Void (Protected)
- **EnterHoverState()**: System.Void (Protected)
- **EnterSelectedState()**: System.Void (Protected)
- **SetColliderSolidState()**: System.Void (Protected)
- **SetAbsoluteMovementValuesOneByOne(UnityEngine.Vector3 absoluteValue, System.Boolean reverseOrder, System.Boolean syncOthers)**: System.Void (Public)
- **SetAbsoluteMovementValues(UnityEngine.Vector3 absoluteValue, System.Boolean syncOthers)**: System.Void (Public)
- **AttemptMove(UnityEngine.Vector3 movement, System.Boolean finePlacement)**: UnityEngine.Vector3 (Public)
- **EnforceGridSnapping()**: System.Void (Public)
- **CalculateMove(UnityEngine.Vector3 movement, System.Boolean finePlacement, UnityEngine.Vector3& newPosition, UnityEngine.Vector3& mirroredValues, UnityEngine.Vector3& positionOffsetRelativeToBounds)**: System.Boolean (Public)
- **Move(UnityEngine.Vector3 newPosition, UnityEngine.Vector3 positionOffsetsRelativeToBounds)**: System.Void (Public)
- **HasNeighbouringConnectedVerts(UnityEngine.Vector3 axis)**: System.Boolean (Private)
- **FindRelativeMovementBound(UnityEngine.Vector3 movement, UnityEngine.Vector3& relativeBoundPosition, System.Boolean& requiresResetToVertexBoundPosition, System.Boolean& movementFlipped, System.Boolean absolute)**: System.Boolean (Public)
- **GetVertexBoundsOnMovementAxis(UnityEngine.Vector3 movement, WildSkies.Gameplay.ShipBuilding.VertexBound& negativeVert, WildSkies.Gameplay.ShipBuilding.VertexBound& positiveVert)**: System.Boolean (Public)
- **GetAbsoluteVertexBoundsOnMovementAxis(UnityEngine.Vector3 movement, WildSkies.Gameplay.ShipBuilding.VertexBound& negativeVert, WildSkies.Gameplay.ShipBuilding.VertexBound& positiveVert)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

