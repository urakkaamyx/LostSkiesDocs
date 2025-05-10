# WildSkies.Gameplay.ShipBuilding.ShipyardGrid

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| XBoundSize | System.Single | Public |
| YBoundSize | System.Single | Public |
| ZBoundSize | System.Single | Public |
| XHalfSize | System.Int32 | Public |
| YHalfSize | System.Int32 | Public |
| ZHalfSize | System.Int32 | Public |
| HeightOffset | System.Single | Public |
| _drawGridGizmos | System.Boolean | Private |
| positions | WildSkies.Gameplay.ShipBuilding.VertexBound[,,] | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Center | UnityEngine.Vector3 | Public |

## Methods

- **get_Center()**: UnityEngine.Vector3 (Public)
- **Awake()**: System.Void (Private)
- **GetVertexBoundForGridIndex(UnityEngine.Vector3Int pos, System.Boolean round0Up)**: WildSkies.Gameplay.ShipBuilding.VertexBound (Public)
- **GetVertexPositionForGridIndex(UnityEngine.Vector3Int pos)**: UnityEngine.Vector3 (Public)
- **GetVertexBoundForGridIndex(System.Int32 xGridBased, System.Int32 yGridBased, System.Int32 zGridBased, System.Boolean round0Up)**: WildSkies.Gameplay.ShipBuilding.VertexBound (Public)
- **GetVertexBoundForZeroBasedIndex(UnityEngine.Vector3Int posZeroBased)**: WildSkies.Gameplay.ShipBuilding.VertexBound (Public)
- **GetVertexBoundForZeroBasedIndex(System.Int32 xZeroBased, System.Int32 yZeroBased, System.Int32 zZeroBased)**: WildSkies.Gameplay.ShipBuilding.VertexBound (Public)
- **ConvertGridIndexToZeroBasedIndex(System.Int32 value, System.Int32 halfRange, System.Boolean roundUp)**: System.Int32 (Private)
- **ConvertZeroBasedIndexToGridIndex(System.Int32 value, System.Int32 halfRange)**: System.Int32 (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

