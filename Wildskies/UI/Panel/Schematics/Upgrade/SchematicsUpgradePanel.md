# Wildskies.UI.Panel.Schematics.Upgrade.SchematicsUpgradePanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _schematicStatsPanel | Wildskies.UI.Panel.Schematics.Upgrade.SchematicStatsPanel | Private |
| _levelUpRequirementsPanel | Wildskies.UI.Panel.Schematics.Upgrade.LevelUpRequirementsPanel | Private |
| _upgradeRequirementsPanel | Wildskies.UI.Panel.Schematics.Upgrade.UpgradeRequirementsPanel | Private |
| _maxLevelPanel | Wildskies.UI.Panel.Schematics.Upgrade.MaxLevelPanel | Private |
| _upgradeButton | Wildskies.UI.Panel.Schematics.Upgrade.ConfirmationButton | Private |
| _upgradeLabel | UnityEngine.Localization.LocalizedString | Private |
| _enhanceLabel | UnityEngine.Localization.LocalizedString | Private |
| _currentSelectedItem | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Private |
| OnUpgrade | System.Action`2<System.Int32,System.Int32> | Public |

## Methods

- **RefreshOnItemSelected(WildSkies.Gameplay.Crafting.CraftableItemBlueprint currentSchematic)**: System.Void (Public)
- **OnLevelToAddValueChanged(System.Int32 levelsToAdd)**: System.Void (Private)
- **RefreshRequirementsPanel()**: System.Void (Private)
- **OnUpgradeButtonClicked()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

