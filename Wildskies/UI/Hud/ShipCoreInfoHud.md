# Wildskies.UI.Hud.ShipCoreInfoHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _itemService | WildSkies.Service.IItemService | Protected |
| _itemStatService | WildSkies.Service.IItemStatService | Protected |
| _craftingService | WildSkies.Service.ICraftingService | Protected |
| _buildingService | WildSkies.Service.BuildingService | Protected |
| _viewModel | Wildskies.UI.Hud.ShipCoreInfoHudViewModel | Private |
| _payload | Wildskies.UI.Hud.ShipCoreInfoHudPayload | Private |
| _yellowColor | UnityEngine.Color | Private |
| _redColor | UnityEngine.Color | Private |
| _itemWeight | System.Single | Private |
| _itemEnergy | System.Single | Private |
| _itemWeightLimitIncrease | System.Single | Private |
| _itemCoreEnergyCapacity | System.Single | Private |
| _yellowColorHTMLString | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **UpdateShipInfo()**: System.Void (Private)
- **CalculateShipPartStats()**: System.Void (Private)
- **UpdateUI()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

