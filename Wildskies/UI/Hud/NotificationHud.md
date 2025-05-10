# Wildskies.UI.Hud.NotificationHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |
| _viewModel | Wildskies.UI.Hud.NotificationHudViewModel | Private |
| _payload | NotificationHudPayload | Private |
| _activeNotifications | System.Collections.Generic.Queue`1<NotificationPopupObject> | Private |
| _priorityNotifications | System.Collections.Generic.Queue`1<Wildskies.UI.Hud.NotificationData> | Private |
| _tutorialNotifications | System.Collections.Generic.Stack`1<Wildskies.UI.Hud.NotificationData> | Private |
| OnPopupExpired | System.Action`1<UnityEngine.GameObject> | Private |
| OnPriorityPopupExpired | System.Action | Private |
| _messagesInQueue | System.Single | Private |
| _currentNotification | NotificationPopupObject | Private |
| _itemId | System.String | Private |
| _entryId | System.String | Private |
| _tutorialEntryId | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |
| ItemId | System.String | Public |
| EntryId | System.String | Public |
| TutorialEntryId | System.String | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **get_ItemId()**: System.String (Public)
- **get_EntryId()**: System.String (Public)
- **get_TutorialEntryId()**: System.String (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnPanelShown(UISystem.UIPanelType panelType)**: System.Void (Private)
- **OnPanelHidden(UISystem.UIPanelType panelType)**: System.Void (Private)
- **Show(IPayload payload)**: System.Void (Public)
- **PopPriorityNotification()**: System.Void (Private)
- **CopyArguments(System.Object[] originalArgs)**: System.Object[] (Private)
- **PopTutorialNotification()**: System.Void (Private)
- **PopNotification()**: System.Void (Private)
- **ClearNotification(UnityEngine.GameObject popup)**: System.Void (Private)
- **ClearAllNotifications()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **GetNotificationPopup()**: NotificationPopupObject (Private)
- **ProcessPriorityMessageQueue()**: System.Void (Private)
- **ProcessTutorialMessageStack()**: System.Void (Private)
- **ShowPriorityNotifications()**: System.Void (Private)
- **ClearAllPriorityNotifications()**: System.Void (Public)
- **ClearAllTutorialNotifications()**: System.Void (Private)
- **SetText(UnityEngine.Localization.Locale _)**: System.Void (Protected)
- **OnInputTypeChanged(System.Boolean isGamepad)**: System.Void (Private)
- **IsPriorityPopupShowing()**: System.Boolean (Public)
- **IsTutorialPopupShowing()**: System.Boolean (Public)
- **HideTutorialPopup()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

