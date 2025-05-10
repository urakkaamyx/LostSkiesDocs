# Wildskies.UI.Panel.InventoryPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _inventoryType | InventoryType | Private |
| _storageInventoryWindow | Wildskies.UI.Panel.StorageContainerWindow | Private |
| _storageGridController | InventoryGridController | Private |
| _inventoryGridController | InventoryGridController | Private |
| _inventoryContainerWindow | InventoryContainerWindow | Private |
| _inventoryInput | InventoryInput | Private |
| _moveStackHoldTime | System.Single | Private |
| _currentPanelFocus | Wildskies.UI.Panel.InventoryPanel/InventoryPanelFocus | Private |
| _viewModel | InventoryPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.InventoryPanelPayload | Private |
| _gridControllerInitialized | System.Boolean | Private |
| _activeGridController | GridControllerBase | Private |
| _moveStackToStorageHoldTimer | System.Single | Private |
| _moveStackToInventoryHoldTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **RefreshNewItemMarkerOnInventoryTabs()**: System.Void (Private)
- **BeltInitialization()**: System.Void (Private)
- **StashInitialization()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isNewInputAGamepad)**: System.Void (Private)
- **SetCurrentPanelFocus()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **MoveAllButtonsInput()**: System.Void (Private)
- **SwitchInventory()**: System.Void (Private)
- **ShowInventoryTab()**: System.Void (Private)
- **ShowStashTab()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **ChangeInventoryWithGamepad()**: System.Void (Public)
- **FocusInventory()**: System.Void (Private)
- **FocusBelt()**: System.Void (Private)
- **FocusStash()**: System.Void (Private)
- **CancelMoveItemInHand()**: System.Void (Private)
- **FocusEquipment(UnityEngine.GameObject selectionOverride)**: System.Void (Public)
- **FocusStorage(UnityEngine.GameObject selectionOverride)**: System.Void (Private)
- **SetupTakeAllButtons()**: System.Void (Private)
- **MoveAllItemsToStorage()**: System.Void (Private)
- **MoveAllItemsToInventory()**: System.Void (Private)
- **MoveStacksToStorage()**: System.Void (Private)
- **MoveStacksToInventory()**: System.Void (Private)
- **SwitchInputControlToStorage()**: System.Void (Public)
- **SwitchInputControlToBelt()**: System.Void (Private)
- **SwitchInputControlToStash()**: System.Void (Private)
- **SwitchInputControlToMainInventory()**: System.Void (Private)
- **SetLegends(System.Boolean isInventoryFocused)**: System.Void (Public)
- **ShowToolTip(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **UpdateSplitStackVisuals()**: System.Void (Private)
- **UpdateRotateVisuals()**: System.Void (Public)
- **HideToolTip()**: System.Void (Public)
- **FillEatButton(System.Single holdTimer)**: System.Void (Public)
- **FillDropButton(System.Single holdTimer)**: System.Void (Public)
- **FillItemBackground(System.Single holdTimer, System.Boolean isDroppingItem)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

