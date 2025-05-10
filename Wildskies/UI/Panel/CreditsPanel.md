# Wildskies.UI.Panel.CreditsPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _idleScrollSpeed | System.Single | Private |
| _activeInputSpeed | System.Single | Private |
| _userInputTimeThreshold | System.Single | Private |
| _smoothSpeed | System.Single | Private |
| _mouseSpeedMultiplier | System.Single | Private |
| _viewModel | Wildskies.UI.Panel.CreditsPanelViewModel | Private |
| _currentScrollSpeed | System.Single | Private |
| _idleTime | System.Single | Private |
| _creditsParsed | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **ParseCredits()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **OnBackPerformed(UnityEngine.InputSystem.InputAction/CallbackContext obj)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

