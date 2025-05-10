# Wildskies.UI.Panel.Schematics.Upgrade.UpgradeRequirementsPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| LevelsToAddOnGate | System.Int32 | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _currentLevelText | TMPro.TMP_Text | Private |
| _upgradeToUnlockTipText | TMPro.TMP_Text | Private |
| _resourcesEntriesContainer | UnityEngine.Transform | Private |
| _resourcesEntryPool | ObjectPool | Private |
| _levelString | UnityEngine.Localization.LocalizedString | Private |
| _upgradeToIncreaseTipString | UnityEngine.Localization.LocalizedString | Private |
| _resourceSlotEntries | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.ResourceSlot> | Private |
| _itemBlueprint | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Private |
| _missingOneOrMoreResources | System.Boolean | Private |
| _levelsToAdd | System.Int32 | Private |
| _currentXpToUse | System.Int32 | Private |
| _nextGateLevel | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsActive | System.Boolean | Public |
| MissingOneOrMoreResources | System.Boolean | Public |
| LevelsToAdd | System.Int32 | Public |
| CurrentXpToUse | System.Int32 | Public |

## Methods

- **get_IsActive()**: System.Boolean (Public)
- **get_MissingOneOrMoreResources()**: System.Boolean (Public)
- **get_LevelsToAdd()**: System.Int32 (Public)
- **get_CurrentXpToUse()**: System.Int32 (Public)
- **Refresh(WildSkies.Gameplay.Crafting.CraftableItemBlueprint item)**: System.Void (Public)
- **SetCurrentLevel()**: System.Void (Private)
- **SetUpgradeToTipText()**: System.Void (Private)
- **AddGateRequirementEntry(WildSkies.Gameplay.Items.Level.UpgradeGateRequirements requirement)**: System.Void (Private)
- **UseResources()**: System.Void (Public)
- **ClearResourceSlotPool()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

