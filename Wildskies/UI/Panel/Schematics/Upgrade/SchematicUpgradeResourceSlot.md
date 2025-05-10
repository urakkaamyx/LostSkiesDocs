# Wildskies.UI.Panel.Schematics.Upgrade.SchematicUpgradeResourceSlot

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Protected |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _icon | UnityEngine.UI.Image | Private |
| _name | TMPro.TMP_Text | Private |
| _amount | TMPro.TMP_Text | Private |
| _button | UnityEngine.UI.Button | Private |
| _hasEnoughQuantityColour | UnityEngine.Color | Private |
| _needsMoreQuantityColour | UnityEngine.Color | Private |
| _selectionBorder | UnityEngine.GameObject | Private |
| _itemDefinition | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _amountHeld | System.Int32 | Private |
| _amountToUse | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AmountToUse | System.Int32 | Public |
| Button | UnityEngine.UI.Button | Public |

## Methods

- **get_AmountToUse()**: System.Int32 (Public)
- **get_Button()**: UnityEngine.UI.Button (Public)
- **Initialise(WildSkies.Gameplay.Items.ItemDefinition itemDefinition)**: System.Void (Public)
- **OnInputTypeChanged(System.Boolean isGamepad)**: System.Void (Private)
- **Refresh()**: System.Void (Private)
- **GetXpGain()**: System.Int32 (Public)
- **TryIncrementAmountToUse()**: System.Boolean (Public)
- **TryDecrementAmountToUse()**: System.Boolean (Public)
- **RefreshDisplayText()**: System.Void (Private)
- **ResetUsedAmountOnUpgrade()**: System.Void (Public)
- **ReturnUnusedResourceToInventory()**: System.Void (Public)
- **HasEnoughResourceToUse(System.Int32 amountXpNeeded)**: System.Boolean (Public)
- **SetSelected(System.Boolean selected)**: System.Void (Public)
- **OnSelect(UnityEngine.EventSystems.BaseEventData eventData)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

