# Wildskies.UI.Panel.Schematics.Upgrade.LevelUpRequirementsPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| UpgradedLevelPrefix | System.String | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _currentLevelText | Wildskies.UI.Panel.Schematics.Upgrade.LevelGaugeController | Private |
| _currentAndTargetXPText | Wildskies.UI.Panel.Schematics.Upgrade.LevelGaugeController | Private |
| _currentTechSlotToUseText | TMPro.TMP_Text | Private |
| _levelsAddImageFill | UnityEngine.UI.Image | Private |
| _addedXpImageFill | UnityEngine.UI.Image | Private |
| _addTechButton | UnityEngine.UI.Button | Private |
| _removeTechButton | UnityEngine.UI.Button | Private |
| _levelGauge | UnityEngine.UI.Image | Private |
| _xpGauge | UnityEngine.UI.Image | Private |
| _briefBookDefinition | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _guideBookDefinition | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _manualBookDefinition | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _briefTechSlot | Wildskies.UI.Panel.Schematics.Upgrade.SchematicUpgradeResourceSlot | Private |
| _guideTechSlot | Wildskies.UI.Panel.Schematics.Upgrade.SchematicUpgradeResourceSlot | Private |
| _manualTechSlot | Wildskies.UI.Panel.Schematics.Upgrade.SchematicUpgradeResourceSlot | Private |
| _levelString | UnityEngine.Localization.LocalizedString | Private |
| _currentLevel | System.Int32 | Private |
| _levelsToAdd | System.Int32 | Private |
| _currentXpToUse | System.Int32 | Private |
| _itemBlueprint | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Private |
| _currentSelectedTechSlot | Wildskies.UI.Panel.Schematics.Upgrade.SchematicUpgradeResourceSlot | Private |
| OnLevelToAddChanged | System.Action`1<System.Int32> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsActive | System.Boolean | Public |
| LevelsToAdd | System.Int32 | Public |
| CurrentXpToUse | System.Int32 | Public |

## Methods

- **get_IsActive()**: System.Boolean (Public)
- **get_LevelsToAdd()**: System.Int32 (Public)
- **get_CurrentXpToUse()**: System.Int32 (Public)
- **OnEnable()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **Refresh(WildSkies.Gameplay.Crafting.CraftableItemBlueprint itemBlueprint)**: System.Void (Public)
- **HasEnoughTechXp()**: System.Boolean (Public)
- **ResetUsedXpOnUpgrade()**: System.Void (Public)
- **OnAddTechButtonClicked()**: System.Void (Private)
- **OnRemoveTechButtonClicked()**: System.Void (Private)
- **OnBriefTechSlotClicked()**: System.Void (Private)
- **OnGuideTechSlotClicked()**: System.Void (Private)
- **OnManualTechSlotClicked()**: System.Void (Private)
- **SetCurrentLevel()**: System.Void (Private)
- **RefreshLevelsToAddFill()**: System.Void (Private)
- **RefreshLevelsToAddText()**: System.Void (Private)
- **SetCurrentAndTargetXpAmount()**: System.Void (Private)
- **RefreshXpAddedFill()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

