# Wildskies.UI.Hud.ToolBarHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _itemPreview | UnityEngine.Transform | Private |
| _itemPreviewImage | UnityEngine.UI.Image | Private |
| _toolbarPrompts | Wildskies.UI.Toolbar.ToolbarPrompts | Private |
| _slots | Wildskies.UI.Hud.ToolBarHudSlot[] | Private |
| _currentHeldSlot | Wildskies.UI.Hud.ToolBarHudSlot | Private |
| _currentMousePos | UnityEngine.Vector2 | Private |
| _controllerAssigningItems | System.Boolean | Private |
| _initialized | System.Boolean | Private |
| _currentMouseOver | Wildskies.UI.Hud.ToolBarHudSlot | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Slots | Wildskies.UI.Hud.ToolBarHudSlot[] | Public |
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Slots()**: Wildskies.UI.Hud.ToolBarHudSlot[] (Public)
- **get_Type()**: UISystem.UIHudType (Public)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **OnMouseUp()**: System.Void (Public)
- **SetupSlots()**: System.Void (Private)
- **UnassignItem(System.Int32 id)**: System.Void (Private)
- **AssignItemToHighlightedSlot(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Private)
- **OnItemAssignedToSlot(Player.Inventory.IInventoryItem inventoryItem, Wildskies.UI.Hud.ToolBarHudSlot slot)**: System.Void (Private)
- **AssignItem(Player.Inventory.IInventoryItem inventoryItem, System.Action`2<Player.Inventory.IInventoryItem,System.Int32> callback)**: System.Void (Private)
- **EquipItemToSlot(Player.Inventory.IInventoryItem inventoryItem, System.Int32 id)**: System.Void (Private)
- **GetAvailableSlot()**: Wildskies.UI.Hud.ToolBarHudSlot (Private)
- **GetSlotByItem(Player.Inventory.IInventoryItem item)**: Wildskies.UI.Hud.ToolBarHudSlot (Private)
- **GetSlotByItem(WildSkies.Gameplay.Items.ItemDefinition item)**: Wildskies.UI.Hud.ToolBarHudSlot (Private)
- **HasSameItemAssigned(Player.Inventory.IInventoryItem item)**: System.Boolean (Private)
- **IsItemToolBarEquipment(Player.Inventory.IInventoryItem item)**: System.Boolean (Private)
- **UpdateInputPrompts()**: System.Void (Public)
- **OnSlotItemRemoved(Wildskies.UI.Hud.ToolBarHudSlot slot)**: System.Void (Private)
- **OnSlotItemHeld(Wildskies.UI.Hud.ToolBarHudSlot slot, UnityEngine.Vector2 mousePos)**: System.Void (Private)
- **OnSlotItemReleased()**: System.Void (Private)
- **GetMouseOverSlot()**: Wildskies.UI.Hud.ToolBarHudSlot (Private)
- **GetSlotById(System.Int32 id)**: Wildskies.UI.Hud.ToolBarHudSlot (Private)
- **GetHighlightedSlotID()**: System.Int32 (Private)
- **OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **OnToolBarIngameHighlight(System.Int32 ID, System.Boolean on)**: System.Void (Private)
- **OnToolbarInventorySetItemHighlight(System.Int32 ID, System.Boolean on)**: System.Void (Private)
- **ToggleSlotHighlight(System.Int32 ID, System.Boolean on)**: System.Void (Private)
- **HandleControllerAssigningItems(System.Boolean on)**: System.Void (Private)
- **OnToolBarMove(System.Boolean right)**: System.Void (Private)
- **OnInventoryClosed()**: System.Void (Private)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

