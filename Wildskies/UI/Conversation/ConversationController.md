# Wildskies.UI.Conversation.ConversationController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _conversationService | WildSkies.Service.IConversationService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _npcRespondingAudio | WildSkies.Audio.AudioType | Private |
| _npcRespondingEventId | System.Int32 | Private |
| _bubbleCharacterAnimationTime | System.Single | Private |
| _scrollRect | UnityEngine.UI.ScrollRect | Private |
| _arkComputerScrollView | ArkComputerScrollView | Private |
| _playerResponseController | WildSkies.Service.Conversation.ConversationPlayerResponseController | Private |
| _conversationHeader | TMPro.TextMeshProUGUI | Private |
| _conversationHeaderGall | TMPro.TextMeshProUGUI | Private |
| _conversationBubbleNPCPool | ObjectPool | Public |
| _conversationBubblePlayerPool | ObjectPool | Public |
| OnConversationFinished | System.Action | Public |
| _isShowingConversation | System.Boolean | Private |
| _npcDialogueBubbles | System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationBubble> | Private |
| _playerDialogueBubbles | System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationBubble> | Private |
| _currentConversationCache | System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory> | Private |
| _dialogueQueue | System.Collections.Generic.Queue`1<UnityEngine.Localization.LocalizedString> | Private |
| _showNPCBubbleCancellationToken | System.Threading.CancellationTokenSource | Private |
| _currentAnimationTween | DG.Tweening.Tweener | Private |
| _currConversationId | System.String | Private |
| _currConversationHistoryId | System.String | Private |
| _isBubbleAnimating | System.Boolean | Private |
| _showingPlayerResponse | System.Boolean | Private |
| _isGallDiskConversation | System.Boolean | Private |
| _clickToEnd | System.Boolean | Private |
| _dialoguesCount | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsShowingConversation | System.Boolean | Public |

## Methods

- **get_IsShowingConversation()**: System.Boolean (Public)
- **Start()**: System.Void (Public)
- **StartConversation(System.String conversationId)**: System.Void (Public)
- **SetHeaderText(UnityEngine.Localization.LocalizedString name)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **ConversationHasPlayerResponse(Wildskies.Gameplay.Conversation.NarrativeConversationData conversationData)**: System.Boolean (Private)
- **MoveOnConversation()**: System.Void (Private)
- **ShowNpcDialogueBubble(UnityEngine.Localization.LocalizedString[] dialogues)**: System.Void (Private)
- **ShowNpcDialogueBubble(UnityEngine.Localization.LocalizedString dialogue)**: System.Void (Private)
- **OnCompleteBubbleAnimation()**: System.Void (Private)
- **ShowPlayerDialogueBubble(UnityEngine.Localization.LocalizedString dialogue)**: System.Void (Private)
- **ShowPlayerResponseOptions(System.String[] responsesIds)**: System.Void (Private)
- **OnPlayerResponseReceived(Wildskies.Gameplay.Conversation.PlayerDialogueData playerDialogueData)**: System.Void (Private)
- **GetCompendiumFriendlyId(System.String fullID)**: System.String (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<ShowNpcDialogueBubble>b__38_0()**: System.Boolean (Private)
- **<ShowNpcDialogueBubble>b__38_1()**: System.Void (Private)

