# WildSkies.Gameplay.Crafting.ResourceSlot

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Protected |
| _icon | UnityEngine.UI.Image | Private |
| _name | TMPro.TMP_Text | Private |
| _amount | TMPro.TMP_Text | Private |
| _hasEnoughQuantityColour | UnityEngine.Color | Private |
| _needsMoreQuantityColour | UnityEngine.Color | Private |
| _itemDefinition | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _amountHeld | System.Int32 | Private |
| _amountNeeded | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| HasEnoughResources | System.Boolean | Public |

## Methods

- **get_HasEnoughResources()**: System.Boolean (Public)
- **Initialise(WildSkies.Gameplay.Items.ItemDefinition itemDefinition, System.Int32 amountNeeded)**: System.Void (Public)
- **UseResource()**: System.Void (Public)
- **Refresh()**: System.Void (Private)
- **RefreshDisplayText()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

