# WildSkies.Service.ICraftingService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| UseTestAssets | System.Boolean | Public |
| OnSchematicsChangedEvent | System.Action | Public |
| OnShipFrameCraftConfirmed | System.Action | Public |
| OnResetSchematicUpgradeAttempted | System.Action`1<System.String> | Public |
| OnLearnSchematic | System.Action`2<System.String,System.Boolean> | Public |
| OnDebugLearnSchematicAttempted | System.Action`2<System.String,System.Boolean> | Public |
| OnLearnSchematicFromItem | System.Action`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> | Public |
| OnLearnCraftingMethod | System.Action`1<WildSkies.Gameplay.Crafting.CraftingMethod> | Public |
| OnForgetSchematicAttempted | System.Action`1<System.String> | Public |
| OnSelectionChanged | System.Action`1<CraftableItemListEntry> | Public |
| RawSchematicDataList | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> | Public |
| FreeCrafting | System.Boolean | Public |

## Methods

- **get_UseTestAssets()**: System.Boolean (Public)
- **get_OnSchematicsChangedEvent()**: System.Action (Public)
- **set_OnSchematicsChangedEvent(System.Action value)**: System.Void (Public)
- **get_OnShipFrameCraftConfirmed()**: System.Action (Public)
- **set_OnShipFrameCraftConfirmed(System.Action value)**: System.Void (Public)
- **get_OnResetSchematicUpgradeAttempted()**: System.Action`1<System.String> (Public)
- **set_OnResetSchematicUpgradeAttempted(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnLearnSchematic()**: System.Action`2<System.String,System.Boolean> (Public)
- **set_OnLearnSchematic(System.Action`2<System.String,System.Boolean> value)**: System.Void (Public)
- **get_OnDebugLearnSchematicAttempted()**: System.Action`2<System.String,System.Boolean> (Public)
- **set_OnDebugLearnSchematicAttempted(System.Action`2<System.String,System.Boolean> value)**: System.Void (Public)
- **get_OnLearnSchematicFromItem()**: System.Action`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> (Public)
- **set_OnLearnSchematicFromItem(System.Action`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> value)**: System.Void (Public)
- **get_OnLearnCraftingMethod()**: System.Action`1<WildSkies.Gameplay.Crafting.CraftingMethod> (Public)
- **set_OnLearnCraftingMethod(System.Action`1<WildSkies.Gameplay.Crafting.CraftingMethod> value)**: System.Void (Public)
- **get_OnForgetSchematicAttempted()**: System.Action`1<System.String> (Public)
- **set_OnForgetSchematicAttempted(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnSelectionChanged()**: System.Action`1<CraftableItemListEntry> (Public)
- **set_OnSelectionChanged(System.Action`1<CraftableItemListEntry> value)**: System.Void (Public)
- **get_RawSchematicDataList()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> (Public)
- **get_FreeCrafting()**: System.Boolean (Public)
- **LearnSchematic(System.String schematicId)**: System.Void (Public)
- **DebugLearnSchematic(System.String schematicId)**: System.Void (Public)
- **ForgetSchematic(System.String schematicId)**: System.Void (Public)
- **ResetSchematicUpgrade(System.String schematicId)**: System.Void (Public)
- **LearnCraftingMethod(WildSkies.Gameplay.Crafting.CraftingMethod craftingMethod)**: System.Void (Public)
- **TryGetSchematicById(System.String id, WildSkies.Gameplay.Crafting.CraftableItemBlueprint& schematic)**: System.Boolean (Public)
- **TryGetItemCategoryById(System.String id, WildSkies.Gameplay.Items.ItemCraftingCategory& category)**: System.Boolean (Public)
- **TryGetItemSubcategory(System.String categoryId, System.String subcategoryId, WildSkies.Gameplay.Items.ItemCraftingSubCategory& subCategory)**: System.Boolean (Public)
- **TryGetSchematicByOutputItemId(System.String itemId, WildSkies.Gameplay.Crafting.CraftableItemBlueprint& schematic)**: System.Boolean (Public)
- **GetAllSchematicsOfType(WildSkies.Gameplay.Crafting.CraftingMethod type, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetAllSchematics(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetAssociatedSchematicForItem(System.String itemId, WildSkies.Gameplay.Crafting.CraftableItemBlueprint& schematic)**: System.Boolean (Public)
- **LearnAllSchematics()**: System.Void (Public)
- **ForgetAllSchematics()**: System.Void (Public)
- **SetCraftingFree(System.Boolean isFree)**: System.Void (Public)
- **AddBlueprint(WildSkies.Gameplay.Crafting.CraftableItemBlueprint blueprint)**: System.Void (Public)
- **SetSelectedResourcesToCraftItem(System.Collections.Generic.List`1<SelectedResourceData> resourcesToCraft)**: System.Void (Public)
- **GetSelectedResourcesToCraftItem()**: System.Collections.Generic.List`1<SelectedResourceData> (Public)

