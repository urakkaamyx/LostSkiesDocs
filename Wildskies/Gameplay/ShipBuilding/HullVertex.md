# WildSkies.Gameplay.ShipBuilding.HullVertex

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Controller | WildSkies.Gameplay.ShipBuilding.ShipHullVertex | Public |
| _id | System.Int32 | Private |
| OriginBoundPoint | WildSkies.Gameplay.ShipBuilding.VertexBound | Public |
| LinkedFaces | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Public |
| PositionOffsetsRelativeToBounds | SerializableTypes.SerializableVector3 | Public |
| VertexBoundZeroIndex | SerializableTypes.SerializableVector3Int | Public |
| LinkedFacesIDs | System.Collections.Generic.List`1<System.Int32> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ID | System.Int32 | Public |

## Methods

- **get_ID()**: System.Int32 (Public)
- **set_ID(System.Int32 value)**: System.Void (Private)
- **.ctor(System.Int32 id)**: System.Void (Public)
- **LinkedFacesContainVertex(WildSkies.Gameplay.ShipBuilding.HullVertex searchVertex)**: System.Boolean (Public)
- **Serialize(System.IO.BinaryWriter writer, System.Int32 key)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader, System.Int32 version)**: WildSkies.Gameplay.ShipBuilding.HullVertex (Public)
- **ResolveDependencies(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullFace> hullFaces)**: System.Void (Public)

