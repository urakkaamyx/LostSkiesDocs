# WildSkies.Service.Conversation.ConversationPlayerResponseController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _conversationService | WildSkies.Service.IConversationService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _playerResponseEntryPool | ObjectPool | Private |
| _conversationExitPrefab | UnityEngine.GameObject | Private |
| OnPlayerResponseReceived | System.Action`1<Wildskies.Gameplay.Conversation.PlayerDialogueData> | Public |
| _playerResponseEntries | System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationPlayerResponseEntry> | Private |
| _initialized | System.Boolean | Private |
| _navigation | UnityEngine.UI.Navigation | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Initialized | System.Boolean | Public |

## Methods

- **get_Initialized()**: System.Boolean (Public)
- **Initialize(System.String[] responsesIds)**: System.Void (Public)
- **InputTypeChanged(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **SetEntriesGamepadNavigation()**: System.Void (Private)
- **HideEntriesGamepadSelection()**: System.Void (Private)
- **SetEntriesGamepadSelection()**: System.Void (Private)
- **Show()**: System.Void (Public)
- **Clear()**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **ShowConversationExit()**: System.Void (Public)
- **HideConversationExit()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

