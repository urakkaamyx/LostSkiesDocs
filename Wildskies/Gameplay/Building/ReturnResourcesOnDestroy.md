# WildSkies.Gameplay.Building.ReturnResourcesOnDestroy

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _lootDropService | WildSkies.Service.LootDropService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _lootSpawnBounceForce | System.Single | Private |
| _minTimeBetweenSpawns | System.Single | Private |
| _maxTimeBetweenSpawns | System.Single | Private |
| _spawnYOffset | System.Single | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _craftingStationInventory | CraftingStationInventory | Private |
| _objectInventory | ObjectInventory | Private |
| _returnedStorageItems | System.Boolean | Private |
| _returnedResources | System.Boolean | Private |
| _resourcesToReturn | System.Collections.Generic.Dictionary`2<System.String,System.Int32> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ReturnedAllResources | System.Boolean | Public |

## Methods

- **get_ReturnedAllResources()**: System.Boolean (Public)
- **Start()**: System.Void (Private)
- **ReturnResources(System.String schematicId, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList, System.Single craftingQuantityScale)**: System.Void (Public)
- **ReturnItemsFromCraftingQueue(System.Single craftingQuantityScale)**: System.Void (Private)
- **ReturnItemsFromStorage()**: System.Void (Private)
- **SpawnStorageItems()**: System.Void (Private)
- **ReturnCraftedItemResources(System.String itemId, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList, System.Boolean ownResources, System.Single craftingQuantityScale)**: System.Void (Private)
- **SpawnBuildResources(System.String schematicItemId, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList, System.Boolean ownResources, System.Single craftingQuantityScale)**: System.Void (Private)
- **GatherItemsResources(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList, System.Int32 craftingComponentOffset, System.Collections.Generic.Dictionary`2<System.String,System.Int32> gatheredResources)**: System.Void (Private)
- **GetOverridenSchematic(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList, System.Int32 craftingComponentOffset)**: WildSkies.Gameplay.Crafting.CraftableItemBlueprint (Private)
- **SpawnItem(System.String itemId, System.Int32 quantity)**: System.Void (Private)
- **GetRandomDirection()**: UnityEngine.Vector3 (Private)
- **.ctor()**: System.Void (Public)
- **<SpawnItem>b__24_0(UnityEngine.GameObject _, LootableInteraction resource)**: System.Void (Private)

