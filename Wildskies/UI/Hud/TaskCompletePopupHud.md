# Wildskies.UI.Hud.TaskCompletePopupHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |
| _viewModel | Wildskies.UI.Hud.TaskCompletePopupHudViewModel | Private |
| _payload | Wildskies.UI.Hud.TaskCompletePopupHudPayload | Private |
| _priorityNotifications | System.Collections.Generic.Queue`1<LocalisedStringData> | Private |
| _currentStringData | LocalisedStringData | Private |
| _messagesInQueue | System.Single | Private |
| _targetAlpha | System.Single | Private |
| _currentArguments | System.Object[] | Private |
| OnPopupExpired | System.Action | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Show(IPayload payload)**: System.Void (Public)
- **SetText(UnityEngine.Localization.Locale _)**: System.Void (Protected)
- **OnPanelShown(UISystem.UIPanelType panelType)**: System.Void (Private)
- **OnPanelHidden(UISystem.UIPanelType panelType)**: System.Void (Private)
- **PopNotification()**: System.Void (Private)
- **ProcessMessageQueue()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

