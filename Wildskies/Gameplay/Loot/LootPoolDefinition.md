# WildSkies.Gameplay.Loot.LootPoolDefinition

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ID | System.String | Public |
| LootPoolName | System.String | Public |
| MinItemsToDrop | System.Int32 | Public |
| MaxItemsToDrop | System.Int32 | Public |
| ItemList | System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition> | Public |
| ItemSelectionWeightings | System.Collections.Generic.List`1<WildSkies.Gameplay.Loot.LootPoolDropRates> | Public |

## Methods

- **.ctor(System.String a_LootPoolName)**: System.Void (Public)
- **GetNumItems()**: System.Int32 (Public)
- **GetRandomItem(System.Int32& amountToDrop, WildSkies.Gameplay.Items.InventoryRarityType MinRarity, WildSkies.Gameplay.Items.InventoryRarityType MaxRarity, World.IslandController islandController, System.Int32 seed, System.Random random)**: WildSkies.Gameplay.Items.ItemDefinition (Public)
- **HasValidItems(WildSkies.Gameplay.Items.InventoryRarityType MinRarity, WildSkies.Gameplay.Items.InventoryRarityType MaxRarity, World.IslandController islandController)**: System.Boolean (Public)
- **GetDropRate(System.Int32 itemIdx, WildSkies.WorldItems.Island/IslandDifficulty difficulty, System.String region)**: System.Single (Public)

