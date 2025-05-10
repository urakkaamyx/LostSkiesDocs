# Wildskies.UI.Panel.CreateShipSelectPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _newShipTemplate | UnityEngine.TextAsset | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _viewModel | Wildskies.UI.Panel.CreateShipSelectPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.CreateShipSelectPanelPayload | Private |
| _selectedSomething | System.Boolean | Private |

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
- **OnNewShipButtonClicked()**: System.Void (Private)
- **OnBlueprintButtonClicked()**: System.Void (Private)
- **UpdatePanelNavigation(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

