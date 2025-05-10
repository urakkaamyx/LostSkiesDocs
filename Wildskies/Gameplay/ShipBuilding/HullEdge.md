# WildSkies.Gameplay.ShipBuilding.HullEdge

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _id | System.Int32 | Private |
| Controller | WildSkies.Gameplay.ShipBuilding.ShipHullEdge | Public |
| Verts | WildSkies.Gameplay.ShipBuilding.HullVertex[] | Public |
| materialIndex | System.Byte | Public |
| beamTypeIndex | System.UInt16 | Public |
| VertsIDs | System.Int32[] | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ID | System.Int32 | Public |

## Methods

- **get_ID()**: System.Int32 (Public)
- **set_ID(System.Int32 value)**: System.Void (Private)
- **.ctor(System.Int32 id)**: System.Void (Public)
- **DetermineEdgeAxis(UnityEngine.Vector3& edgeAxisVector, WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis& edgeAxis)**: System.Void (Public)
- **ClipY(System.Single yOffset, UnityEngine.Vector3& clippedPoint)**: System.Boolean (Public)
- **ClipY(UnityEngine.Vector3 pt0, UnityEngine.Vector3 pt1, System.Single yOffset, UnityEngine.Vector3& clippedPoint)**: System.Boolean (Public)
- **Serialize(System.IO.BinaryWriter writer, System.Int32 key)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader, System.Int32 version)**: WildSkies.Gameplay.ShipBuilding.HullEdge (Public)
- **ResolveDependencies(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> hullVertices)**: System.Void (Public)

