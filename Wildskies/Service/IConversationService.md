# WildSkies.Service.IConversationService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| OnPlayerEndedConversation | System.Action`1<System.String> | Public |
| OnGallDiscConversationAdded | System.Action`1<System.String> | Public |
| ConversationsHistory | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> | Public |

## Methods

- **get_OnPlayerEndedConversation()**: System.Action`1<System.String> (Public)
- **set_OnPlayerEndedConversation(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnGallDiscConversationAdded()**: System.Action`1<System.String> (Public)
- **set_OnGallDiscConversationAdded(System.Action`1<System.String> value)**: System.Void (Public)
- **get_ConversationsHistory()**: System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> (Public)
- **PlayerEndedConversation(System.Boolean wasGallDiscConversation, System.String conversationId)**: System.Void (Public)
- **GetNarrativeConversationData(System.String id, Wildskies.Gameplay.Conversation.NarrativeConversationData& dialogueData)**: System.Boolean (Public)
- **GetPlayerDialogueData(System.String id, Wildskies.Gameplay.Conversation.PlayerDialogueData& dialogueData)**: System.Boolean (Public)
- **AddGallDiscConversation(System.String id)**: System.Void (Public)
- **TryAddGallDiscConversationByTriggerId(System.String triggerId)**: System.Void (Public)
- **TryGetArkComputerInteractionConversation(System.String triggerId, System.String& conversationId)**: System.Boolean (Public)
- **GetNextGallDiscConversation()**: System.String (Public)
- **HasGallDiscConversation()**: System.Boolean (Public)
- **IsGallDiscConversation(System.String id)**: System.Boolean (Public)
- **SetConversationHistory(System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> history)**: System.Void (Public)
- **AddConversationHistoryEntry(System.String conversationHistoryId, System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory> conversationHistory)**: System.Void (Public)
- **GetConversationHistoryForId(System.String conversationHistoryId)**: System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory> (Public)
- **AddGallDiscDebugConversation(System.String id)**: System.Void (Public)

