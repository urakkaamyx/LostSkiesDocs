# WildSkies.Gameplay.ShipBuilding.HullBlock

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _id | System.Int32 | Private |
| _isCrafted | System.Boolean | Private |
| Vertices | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullVertex> | Public |
| Edges | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullEdge> | Public |
| Faces | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> | Public |
| _deckHalfHeight | System.Single | Private |
| VerticesIDs | System.Collections.Generic.List`1<System.Int32> | Public |
| EdgesIDs | System.Collections.Generic.List`1<System.Int32> | Public |
| FacesIDs | System.Collections.Generic.List`1<System.Int32> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsCrafted | System.Boolean | Public |
| ID | System.Int32 | Public |

## Methods

- **get_IsCrafted()**: System.Boolean (Public)
- **set_IsCrafted(System.Boolean value)**: System.Void (Public)
- **get_ID()**: System.Int32 (Public)
- **set_ID(System.Int32 value)**: System.Void (Private)
- **.ctor(System.Int32 id)**: System.Void (Public)
- **SetCraftedState(System.Boolean isCrafted, System.Boolean isDocked, System.Boolean isBeingEdited)**: System.Void (Public)
- **UpdateShipPartsCraftedState(System.Boolean isDocked, System.Boolean isBeingEdited)**: System.Void (Public)
- **AddOutlineToMeshBuilder(ScaffoldMeshBuilder meshBuilder, System.Single yOffset, UnityEngine.Vector3 worldPosition, System.Boolean showDebugTris)**: System.Boolean (Public)
- **Get2dBounds(UnityEngine.Vector2& gridMin, UnityEngine.Vector2& gridMax)**: System.Void (Private)
- **GetGridPos()**: SerializableTypes.SerializableVector3Int (Public)
- **IsCentreBlock()**: System.Boolean (Public)
- **DoesBlockIntersectY(System.Single yOffset)**: System.Boolean (Private)
- **ClipBlockEdges(System.Single yOffset)**: System.Collections.Generic.HashSet`1<UnityEngine.Vector2> (Private)
- **CreateInverseConvexOutlineMesh(UnityEngine.Vector2 gridMin, UnityEngine.Vector2 gridMax, System.Single yOffset, System.Collections.Generic.List`1<UnityEngine.Vector2> convexHullPts, ScaffoldMeshBuilder meshBuilder, UnityEngine.Vector3 worldPosition, System.Boolean showDebugTris)**: System.Void (Private)
- **AddDebugQuad(UnityEngine.Vector2 pt0, UnityEngine.Vector2 pt1, UnityEngine.Vector2 pt2, UnityEngine.Vector2 pt3, System.Single yOffset, UnityEngine.Vector3 worldPosition)**: System.Void (Private)
- **Serialize(System.IO.BinaryWriter writer, System.Int32 key)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader, System.Int32 version)**: WildSkies.Gameplay.ShipBuilding.HullBlock (Public)
- **ResolveDependencies(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> hullVertices, System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullEdge> hullEdges, System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullFace> hullFaces)**: System.Void (Public)
- **.cctor()**: System.Void (Private)

