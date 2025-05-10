# WildSkies.Inventory.InventorySplitStackController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _itemIcon | UnityEngine.UI.Image | Private |
| _oldStackText | TMPro.TMP_Text | Private |
| _newStackText | TMPro.TMP_Text | Private |
| _stackAmountSlider | UnityEngine.UI.Slider | Private |
| _cancelButton | UnityEngine.UI.Button | Private |
| _acceptButton | UnityEngine.UI.Button | Private |
| _mnkButtonsContainer | UnityEngine.GameObject | Private |
| _gamepadButtonsContainer | UnityEngine.GameObject | Private |
| _stackAmount | System.Int32 | Private |
| _currOldStackAmount | System.Int32 | Private |
| _currNewStackAmount | System.Int32 | Private |
| _gridController | GridControllerBase | Private |
| _associatedInventory | Player.Inventory.DefaultInventory | Private |
| _currentItem | Player.Inventory.IInventoryItem | Private |

## Methods

- **Show(GridControllerBase gridController, Player.Inventory.DefaultInventory associatedInventory, Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Public)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **CheckSplitStackInput()**: System.Void (Public)
- **OnAcceptButtonClicked()**: System.Void (Private)
- **OnItemWasAdded(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Private)
- **OnCancelButtonClicked()**: System.Void (Private)
- **OnSliderValueChanged(System.Single value)**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isGamepad)**: System.Void (Private)
- **UpdateTextVisuals()**: System.Void (Private)
- **UpdateInputVisuals()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

