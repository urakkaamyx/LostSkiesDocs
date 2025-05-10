# Wildskies.UI.Hud.WarningPopupHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Hud.WarningPopupHudViewModel | Private |
| _payload | Wildskies.UI.Hud.WarningPopupHudPayload | Private |
| _activeNotifications | System.Collections.Generic.Queue`1<WarningPopupMessage> | Private |
| OnPopupExpired | System.Action`1<UnityEngine.GameObject> | Private |
| _severityColours | System.Collections.Generic.Dictionary`2<Wildskies.UI.Hud.WarningPopupSeverity,UnityEngine.Color> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **PopNotification()**: System.Void (Private)
- **ReturnMessageToPool(UnityEngine.GameObject popup)**: System.Void (Private)
- **ClearAllMessages()**: System.Void (Private)
- **ClearOldestMessage()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **GetWarningMessage()**: WarningPopupMessage (Private)
- **.ctor()**: System.Void (Public)

