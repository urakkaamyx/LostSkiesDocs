# WildSkies.Gameplay.ShipBuilding.HullFace

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _id | System.Int32 | Private |
| Controller | WildSkies.Gameplay.ShipBuilding.ShipHullFace | Public |
| Verts | WildSkies.Gameplay.ShipBuilding.HullVertex[] | Public |
| FaceAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Public |
| CurveIsV0ToV1 | System.Boolean | Public |
| CurvynessV0ToV1 | System.Single | Public |
| CurvynessV0ToV3 | System.Single | Public |
| negOffset | System.Boolean | Public |
| materialIndexFront | System.Byte | Public |
| materialIndexBack | System.Byte | Public |
| craftingItemIdsFront | System.Collections.Generic.List`1<System.String> | Public |
| craftingItemIdsBack | System.Collections.Generic.List`1<System.String> | Public |
| faceFillIndex | System.UInt16 | Public |
| VertsIDs | System.Int32[] | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ID | System.Int32 | Public |

## Methods

- **get_ID()**: System.Int32 (Public)
- **set_ID(System.Int32 value)**: System.Void (Private)
- **.ctor(System.Int32 id)**: System.Void (Public)
- **MatchesFace(WildSkies.Gameplay.ShipBuilding.HullFace matchFace)**: System.Boolean (Public)
- **ContainsVertex(WildSkies.Gameplay.ShipBuilding.HullVertex searchVertex)**: System.Boolean (Public)
- **Serialize(System.IO.BinaryWriter writer, System.Int32 key)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader, System.Int32 version)**: WildSkies.Gameplay.ShipBuilding.HullFace (Public)
- **ResolveDependencies(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> hullVertices)**: System.Void (Public)

