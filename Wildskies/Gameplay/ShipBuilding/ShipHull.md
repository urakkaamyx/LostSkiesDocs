# WildSkies.Gameplay.ShipBuilding.ShipHull

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ShipDesignName | System.String | Public |
| MAX_ITEM_OBJECTS | System.Int32 | Private |
| IsCrafted | System.Boolean | Public |
| ShipSaveSlot | System.Int32 | Public |
| ShipHullVersion | System.Int32 | Public |
| ShipHullUUID | System.String | Public |
| HullVertices | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullVertex> | Public |
| HullEdges | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullEdge> | Public |
| HullFaces | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullFace> | Public |
| HullBlocks | System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Gameplay.ShipBuilding.HullBlock> | Public |
| _nextVertexID | System.Int32 | Private |
| _nextEdgeID | System.Int32 | Private |
| _nextFaceID | System.Int32 | Private |
| _nextBlockID | System.Int32 | Private |
| ShipStatsPresetId | System.Int32 | Public |
| UseVisualShipHull | System.Boolean | Public |
| VisualShipHullAttachmentIndex | System.Int32 | Public |
| _debugLogging | System.Boolean | Private |
| _hullObjectDataList | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullObjectData> | Public |
| HullObjectDataList | WildSkies.Gameplay.ShipBuilding.HullObjectData[] | Public |
| _hullEdgeDefaultResourceId | System.String | Private |
| _deckPanelDefaultResourceId | System.String | Private |
| HullEdgeCraftingItemIds | System.Collections.Generic.List`1<System.String> | Public |
| _hullFaceCount | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.HullFace,System.Int32> | Private |
| _tempFaces | WildSkies.Gameplay.ShipBuilding.HullFace[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| NewVertexID | System.Int32 | Public |
| NewEdgeID | System.Int32 | Public |
| NewFaceID | System.Int32 | Public |
| NewBlockID | System.Int32 | Public |

## Methods

- **GetVertex(System.Int32 id)**: WildSkies.Gameplay.ShipBuilding.HullVertex (Public)
- **GetEdge(System.Int32 id)**: WildSkies.Gameplay.ShipBuilding.HullEdge (Public)
- **GetFace(System.Int32 id)**: WildSkies.Gameplay.ShipBuilding.HullFace (Public)
- **GetBlock(System.Int32 id)**: WildSkies.Gameplay.ShipBuilding.HullBlock (Public)
- **get_NewVertexID()**: System.Int32 (Public)
- **get_NewEdgeID()**: System.Int32 (Public)
- **get_NewFaceID()**: System.Int32 (Public)
- **get_NewBlockID()**: System.Int32 (Public)
- **.ctor(System.Int32 version)**: System.Void (Public)
- **ResetIDs()**: System.Void (Public)
- **SolveRetroCompabilityIfNeeded()**: System.Void (Public)
- **AddHullObjectData(WildSkies.Gameplay.ShipBuilding.HullObjectData hullObjectData)**: System.Int32 (Public)
- **GetNextHullObjectDataIndex()**: System.Int32 (Public)
- **SetHullObjectData(WildSkies.Gameplay.ShipBuilding.HullObjectData hullObjectData, System.Int32 index)**: System.Boolean (Public)
- **GetHullObjectParents(System.Int32 childIndex)**: System.Collections.Generic.HashSet`1<System.Int32> (Public)
- **GetHullObjectChildren(System.Int32 parentIndex, System.Boolean recursive)**: System.Collections.Generic.HashSet`1<System.Int32> (Public)
- **AddHullObjectChildrenRecursive(System.Collections.Generic.HashSet`1<System.Int32> visitedIndices, System.Int32 parentIndex, System.Boolean recursive)**: System.Void (Private)
- **PrepareForDesignSave()**: System.Void (Public)
- **MigrateData()**: System.Void (Public)
- **UpgradeShipVersion()**: System.Void (Public)
- **MigratePanelFills()**: System.Void (Public)
- **CalculateStructuralBeams()**: System.Void (Public)
- **GetNumAttachedFaces(WildSkies.Gameplay.ShipBuilding.HullEdge edge, System.Collections.Generic.HashSet`1<System.Int32> flatFaces)**: System.Int32 (Private)
- **GetNumFlatFaces(System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.HullFace> faces, System.Collections.Generic.HashSet`1<System.Int32> flatFaces, System.Boolean faceOffset)**: System.Int32 (Private)
- **GetLinkedEdges(WildSkies.Gameplay.ShipBuilding.HullVertex[] verts)**: System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullEdge> (Public)
- **GetHullEdgeResourceId()**: System.String (Public)
- **SetHullEdgeResourceId(System.String resourceId)**: System.Void (Public)
- **GetDominantDeckResourceId()**: System.String (Public)
- **SetUncraftedDeckResourceId(System.String resourceId)**: System.Void (Public)
- **SaveToPresetIndex(System.Int32 targetPresetIndex, WildSkies.Gameplay.ShipBuilding.ShipHull shipHullToSave)**: System.Void (Public)
- **TryLoadFromPresetIndex(System.Int32 targetPresetIndex, WildSkies.Gameplay.ShipBuilding.ShipHull& resultShipHull)**: System.Boolean (Public)
- **HasPresetAtIndex(System.Int32 targetPresetIndex)**: System.Boolean (Public)
- **ClearHullObjectData(System.Int32 objectHullDataListIndex)**: System.Void (Public)
- **GetSharedFaces(WildSkies.Gameplay.ShipBuilding.HullVertex[] verts)**: System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullFace> (Public)
- **GetSharedEdges(WildSkies.Gameplay.ShipBuilding.HullVertex[] verts)**: System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.HullEdge> (Public)
- **GetSharedFaces(WildSkies.Gameplay.ShipBuilding.HullFace face, System.Boolean sameAxis)**: WildSkies.Gameplay.ShipBuilding.HullFace[] (Public)
- **RotateToPrimaryAxis(System.Int32 primaryAxis)**: UnityEngine.Matrix4x4 (Private)
- **Serialize(System.IO.BinaryWriter writer)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader)**: WildSkies.Gameplay.ShipBuilding.ShipHull (Public)
- **.cctor()**: System.Void (Private)

