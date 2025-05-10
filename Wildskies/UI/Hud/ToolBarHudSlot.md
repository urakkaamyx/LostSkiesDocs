# Wildskies.UI.Hud.ToolBarHudSlot

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| EquipPulse | System.Int32 | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _reservedSlot | System.Boolean | Private |
| _icon | UnityEngine.UI.Image | Private |
| _frame | UnityEngine.UI.Image | Private |
| _text | TMPro.TMP_Text | Private |
| _previewTransform | UnityEngine.Transform | Private |
| _content | UnityEngine.Transform | Private |
| _normalColor | UnityEngine.Color | Private |
| _highlightedColor | UnityEngine.Color | Private |
| OnItemRemoved | System.Action`1<Wildskies.UI.Hud.ToolBarHudSlot> | Public |
| OnItemHeld | System.Action`2<Wildskies.UI.Hud.ToolBarHudSlot,UnityEngine.Vector2> | Public |
| OnItemAssigned | System.Action`2<Player.Inventory.IInventoryItem,Wildskies.UI.Hud.ToolBarHudSlot> | Public |
| OnItemReleased | System.Action | Public |
| _id | System.Int32 | Private |
| _mouseOver | System.Boolean | Private |
| _highlighted | System.Boolean | Private |
| _scaleLerp | System.Single | Private |
| _associatedItem | Player.Inventory.IInventoryItem | Private |
| _animator | UnityEngine.Animator | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AssociatedItem | Player.Inventory.IInventoryItem | Public |
| HasItemAssigned | System.Boolean | Public |
| IsSlotReserved | System.Boolean | Public |
| IsHighlighted | System.Boolean | Public |
| MouseOver | System.Boolean | Public |
| PreviewPosition | UnityEngine.Vector3 | Public |
| ID | System.Int32 | Public |

## Methods

- **get_AssociatedItem()**: Player.Inventory.IInventoryItem (Public)
- **get_HasItemAssigned()**: System.Boolean (Public)
- **get_IsSlotReserved()**: System.Boolean (Public)
- **get_IsHighlighted()**: System.Boolean (Public)
- **get_MouseOver()**: System.Boolean (Public)
- **get_PreviewPosition()**: UnityEngine.Vector3 (Public)
- **get_ID()**: System.Int32 (Public)
- **set_ID(System.Int32 value)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **UpdatePrompt()**: System.Void (Public)
- **AssignItem(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **RemoveAssignedItem()**: System.Void (Public)
- **UpdateText(UnityEngine.Localization.Locale _)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **OnMouseUp()**: System.Void (Public)
- **UpdateHandleHover()**: System.Void (Private)
- **OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **Highlight(System.Boolean on)**: System.Void (Public)
- **ToggleEquipPulseAnimation(System.Boolean isOn)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

