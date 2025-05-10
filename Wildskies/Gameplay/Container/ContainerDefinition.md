# WildSkies.Gameplay.Container.ContainerDefinition

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ID | System.String | Public |
| ContainerName | System.String | Public |
| Category | System.String | Public |
| Type | System.String | Public |
| Description | System.String | Public |
| MinSelections | System.Int32 | Public |
| MaxSelections | System.Int32 | Public |
| MinRarity | WildSkies.Gameplay.Items.InventoryRarityType | Public |
| MaxRarity | WildSkies.Gameplay.Items.InventoryRarityType | Public |
| LootPoolList | System.Collections.Generic.List`1<WildSkies.Gameplay.Loot.LootPoolDefinition> | Public |
| LootPoolSelectionWeightings | System.Collections.Generic.List`1<WildSkies.Gameplay.Container.ContainerDropRates> | Public |
| LootPoolMaxSelections | System.Collections.Generic.List`1<System.Int32> | Public |

## Methods

- **GetRandomLootPools(World.IslandController islandController)**: System.Collections.Generic.List`1<WildSkies.Gameplay.Loot.LootPoolDefinition> (Public)
- **GetRandomLootPools(World.IslandController islandController, System.Collections.Generic.List`1<System.Int32>& selectedWeightings, System.Random random)**: System.Collections.Generic.List`1<WildSkies.Gameplay.Loot.LootPoolDefinition> (Public)
- **SelectWeightedLootPool(System.Collections.Generic.List`1<WildSkies.Gameplay.Loot.LootPoolDefinition> selectedList, System.Collections.Generic.List`1<System.Int32> selectedWeightings, System.Random random)**: WildSkies.Gameplay.Loot.LootPoolDefinition (Public)
- **GetSelectionWeighting(System.Int32 itemIdx, WildSkies.WorldItems.Island/IslandDifficulty difficulty)**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

