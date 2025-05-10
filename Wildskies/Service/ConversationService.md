# WildSkies.Service.ConversationService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ConversationAddressablesKey | System.String | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _gallDiscConversationTriggers | System.Collections.Generic.Dictionary`2<System.String,System.String> | Private |
| _conversationData | System.Collections.Generic.Dictionary`2<System.String,Wildskies.Gameplay.Conversation.NarrativeConversationData> | Private |
| _playerDialogueData | System.Collections.Generic.Dictionary`2<System.String,Wildskies.Gameplay.Conversation.PlayerDialogueData> | Private |
| _pendingGallDiscConversations | System.Collections.Generic.List`1<System.String> | Private |
| <OnPlayerEndedConversation>k__BackingField | System.Action`1<System.String> | Private |
| <OnGallDiscConversationAdded>k__BackingField | System.Action`1<System.String> | Private |
| _conversationsHistory | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| OnPlayerEndedConversation | System.Action`1<System.String> | Public |
| OnGallDiscConversationAdded | System.Action`1<System.String> | Public |
| WildSkies.Service.IConversationService.ConversationsHistory | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> | Private |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_OnPlayerEndedConversation()**: System.Action`1<System.String> (Public)
- **set_OnPlayerEndedConversation(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnGallDiscConversationAdded()**: System.Action`1<System.String> (Public)
- **set_OnGallDiscConversationAdded(System.Action`1<System.String> value)**: System.Void (Public)
- **WildSkies.Service.IConversationService.get_ConversationsHistory()**: System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> (Private)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnDataLoaded(UnityEngine.Object loadedAsset)**: System.Void (Private)
- **TryAddGallDiscTriggerDictionary(Wildskies.Gameplay.Conversation.GallDiscConversationTriggerData triggerData)**: System.Void (Private)
- **GetNarrativeConversationData(System.String id, Wildskies.Gameplay.Conversation.NarrativeConversationData& dialogueData)**: System.Boolean (Public)
- **GetPlayerDialogueData(System.String id, Wildskies.Gameplay.Conversation.PlayerDialogueData& dialogueData)**: System.Boolean (Public)
- **AddGallDiscConversation(System.String id)**: System.Void (Public)
- **TryAddGallDiscConversationByTriggerId(System.String triggerId)**: System.Void (Public)
- **TryGetArkComputerInteractionConversation(System.String triggerId, System.String& conversationId)**: System.Boolean (Public)
- **GetNextGallDiscConversation()**: System.String (Public)
- **HasGallDiscConversation()**: System.Boolean (Public)
- **IsGallDiscConversation(System.String id)**: System.Boolean (Public)
- **PlayerEndedConversation(System.Boolean wasGallDiscConversation, System.String conversationHistoryId)**: System.Void (Public)
- **SetConversationHistory(System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory>> history)**: System.Void (Public)
- **AddConversationHistoryEntry(System.String conversationHistoryId, System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory> conversationHistory)**: System.Void (Public)
- **GetConversationHistoryForId(System.String conversationHistoryId)**: System.Collections.Generic.List`1<WildSkies.Service.Conversation.ConversationHistory> (Public)
- **AddGallDiscDebugConversation(System.String id)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

