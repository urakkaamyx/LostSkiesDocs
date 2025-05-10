# Wildskies.UI.Hud.AmmoCountHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _zeroColor | UnityEngine.Color | Private |
| _viewModel | Wildskies.UI.Hud.AmmoCountHudViewModel | Private |
| _payload | Wildskies.UI.Hud.AmmoCountHudPayload | Private |
| AmmoItemString | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **PickedUpAmmo(Player.Inventory.IInventoryItem item)**: System.Void (Private)
- **UpdateAmmoValue(System.String itemID)**: System.Void (Private)
- **UpdateAmmoValue()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

