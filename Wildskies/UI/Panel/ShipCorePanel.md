# Wildskies.UI.Panel.ShipCorePanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.ShipCorePanelViewModel | Private |
| _payload | Wildskies.UI.Panel.ShipCorePanelPayload | Private |
| _uiService | UISystem.IUIService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _greenColor | UnityEngine.Color | Private |
| _redColor | UnityEngine.Color | Private |
| ButtonHoldTime | System.Single | Private |
| _currentRegisterHoldTimer | System.Single | Private |
| _shipPartEntries | System.Collections.Generic.List`1<ShipPartEntry> | Private |
| _shipPartCountsPerType | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.HullObjectType,System.Collections.Generic.List`1<System.Single>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **UpdateInput()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isGamePad)**: System.Void (Private)
- **UpdateRegisterButton()**: System.Void (Private)
- **OnRegisterToShipClicked()**: System.Void (Private)
- **OnRegisterConfirmed(System.String shipName)**: System.Void (Private)
- **IsPlayerRegisteredToShip()**: System.Boolean (Private)
- **UpdateShipName(System.String shipName)**: System.Void (Private)
- **UpdateShipInfo()**: System.Void (Private)
- **UpdateShipParts()**: System.Void (Private)
- **InitShipPartDictionary()**: System.Void (Private)
- **ClearShipPartDictionary()**: System.Void (Private)
- **CreateShipPartEntry(System.String shipPartName, System.Int32 quantity, System.Single energy, System.Single weight)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

