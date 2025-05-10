# Wildskies.UI.Conversation.ConversationCompendiumController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ConversationPanelTitle | System.String | Private |
| _titleText | Wildskies.UI.GallTextController | Public |
| _scrollRect | UnityEngine.UI.ScrollRect | Public |
| _conversationBubbleNPCPool | ObjectPool | Public |
| _conversationBubblePlayerPool | ObjectPool | Public |
| _endOfConversationText | UnityEngine.Transform | Public |
| _conversationPanelTitleString | UnityEngine.Localization.LocalizedString | Private |
| _npcDialogueBubbles | System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationBubble> | Private |
| _playerDialogueBubbles | System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationBubble> | Private |
| _currentConversationId | System.String | Private |

## Methods

- **ShowConversationHistory(System.String id, UnityEngine.Localization.LocalizedString title, System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory> conversationHistory)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **ClearBubbleEntries()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

