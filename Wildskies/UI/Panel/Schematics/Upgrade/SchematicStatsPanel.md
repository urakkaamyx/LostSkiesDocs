# Wildskies.UI.Panel.Schematics.Upgrade.SchematicStatsPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _name | Wildskies.UI.GallTextController | Private |
| _icon | UnityEngine.UI.Image | Private |
| _statsEntriesContainer | UnityEngine.Transform | Private |
| _statsEntryPool | ObjectPool | Private |
| _upgradeCounter | UnityEngine.UI.Toggle[] | Private |
| _statsEntries | System.Collections.Generic.List`1<Wildskies.UI.Panel.Schematics.Upgrade.SchematicsStatsEntry> | Private |
| _itemBlueprint | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Private |
| _itemDefinition | WildSkies.Gameplay.Items.IItemDefinition | Private |

## Methods

- **Refresh(WildSkies.Gameplay.Crafting.CraftableItemBlueprint itemBlueprint, Wildskies.UI.Panel.Schematics.Upgrade.StatsPanelToShow statsPanelToShow, System.Int32 levelsToAdd)**: System.Void (Public)
- **SetItemInfo()**: System.Void (Private)
- **SetItemCurrentUpgradeCount()**: System.Void (Private)
- **ShowLevelsToAddStatsEntries(System.Int32 levelsToAdd)**: System.Void (Private)
- **ShowLevelGateStatsEntries()**: System.Void (Private)
- **PopulateStatsEntriesForGate(System.Func`2<System.String,WildSkies.Weapon.StatData> getStatDefaultValue, System.Collections.Generic.Dictionary`2<System.String,System.Single> currentLevelItemStatsData, System.Collections.Generic.Dictionary`2<System.String,System.Single> levelGateStats)**: System.Void (Private)
- **ShowOnlyCurrentLevelEntries()**: System.Void (Private)
- **PopulateStatsEntries(System.Func`2<System.String,WildSkies.Weapon.StatData> getStatDefaultValue, System.Collections.Generic.Dictionary`2<System.String,System.Single> currentLevelItemStatsData, System.Collections.Generic.Dictionary`2<System.String,System.Single> newLevelStats)**: System.Void (Private)
- **AddStatsEntry(System.String name, System.Single defaultValue, System.Single upgradedValue)**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **ClearEntries()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

