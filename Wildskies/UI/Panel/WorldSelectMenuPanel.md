# Wildskies.UI.Panel.WorldSelectMenuPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.WorldSelectMenuPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.WorldSelectMenuPanelPayload | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _networkService | WildSkies.Service.NetworkService | Private |
| _platform | PlatformService | Private |
| _uiService | UISystem.IUIService | Private |
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _selectedRegion | System.String | Private |
| _createPrivacyLevel | System.String | Private |
| _joinRoomPrivacyLevel | System.String | Private |
| _requestIds | System.Collections.Generic.List`1<System.Guid> | Private |
| _requestId | System.Guid | Private |
| _loadFails | System.Collections.Generic.List`1<System.Int32> | Private |
| _existingSlots | System.Collections.Generic.List`1<System.Int32> | Private |
| _worldSelectEntries | System.Collections.Generic.List`1<WorldSelectEntry> | Private |
| _worldSaveDatas | System.Collections.Generic.List`1<WorldSaveData> | Private |
| _activeRoomViews | System.Collections.Generic.List`1<Coherence.UI.ConnectDialogRoomView> | Private |
| _selectedLobby | Steamworks.Data.Lobby | Private |
| _selectedLobbyId | Steamworks.SteamId | Private |
| _activeLobbies | System.Collections.Generic.Dictionary`2<Coherence.UI.ConnectDialogRoomView,Steamworks.Data.Lobby> | Private |
| _selectedRoom | Coherence.Cloud.RoomData | Private |
| _selectedRoomId | System.Int32 | Private |
| _fetchRoomsToken | System.Threading.CancellationTokenSource | Private |
| _hasSelectedPlay | System.Boolean | Private |
| _holdToDeleteTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |
| IsEmpty | System.Boolean | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **get_IsEmpty()**: System.Boolean (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **OnJoinPrivacyChanged(System.Int32 value)**: System.Void (Private)
- **PopulatePrivacyDropdown()**: System.Void (Private)
- **SelectByIndex(System.Int32 worldSelection)**: System.Void (Public)
- **OnWorldDeleteBtnClicked()**: System.Void (Private)
- **DeleteSelectedWorldData(System.Object data)**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **UpdateInput()**: System.Void (Private)
- **OnDiscordButtonClicked()**: System.Void (Private)
- **CheckStartJoinButtons()**: System.Void (Private)
- **OnStartGameBtnValueChanged(System.Boolean isOn)**: System.Void (Private)
- **OnJoinGameBtnValueChanged(System.Boolean isOn)**: System.Void (Private)
- **SetDiscordButtonNavigation(UnityEngine.UI.Selectable newUpSelection)**: System.Void (Private)
- **OnCreateWorldBtnClicked()**: System.Void (Private)
- **OnPlayButtonClicked()**: System.Void (Private)
- **GetRegion(System.Int32 value)**: System.String (Private)
- **OnCreateWorldConfirmed(System.String worldName)**: System.Void (Private)
- **OnGetExistingSlotsForKeyCompleted(System.Boolean success, System.String key, System.Collections.Generic.List`1<System.Int32> slots)**: System.Void (Private)
- **OnLoadCompleted(System.Boolean success, System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Private)
- **IsEmptySaveData(System.String saveData)**: System.Boolean (Private)
- **LoadRequestFinished()**: System.Void (Private)
- **SetWorldSelectEntriesNavigation()**: System.Void (Private)
- **CreateNewEntry(System.Int32 saveSlot, WorldSaveData worldSaveData)**: System.Void (Private)
- **CreateNewCompletedEntry(System.Int32 saveSlot, System.String contents)**: System.Void (Private)
- **SetAllTogglesOff()**: System.Void (Private)
- **OnUseRSLChanged(System.Boolean newValue)**: System.Void (Private)
- **OnHostingSelectionChange(System.Int32 newValue)**: System.Void (Private)
- **OnJoinRoomBtnClicked()**: System.Void (Private)
- **OnRefreshRoomsBtnClicked()**: System.Void (Private)
- **RefreshLobbies()**: System.Void (Private)
- **PopulateLobby(Steamworks.Data.Lobby lobbyData)**: System.Void (Private)
- **OnWorldJoinRegionChanged(System.Int32 index)**: System.Void (Private)
- **OnSelfHostedConfirmBtnClicked()**: System.Void (Private)
- **ClearRoomsList()**: System.Void (Private)
- **RefreshRooms(System.Collections.Generic.IReadOnlyList`1<Coherence.Cloud.RoomData> roomList)**: System.Void (Private)
- **RefreshJoinGameNavigation()**: System.Void (Private)
- **EnsureSingleRoomsRequest()**: System.Threading.CancellationToken (Private)
- **GetRooms(System.String region, System.String privacyLevel, System.Threading.CancellationToken token)**: System.Void (Private)
- **AddRoomItem(Coherence.Cloud.RoomData data)**: System.Void (Private)
- **PopulateRoomView(Coherence.UI.ConnectDialogRoomView roomView, Coherence.Cloud.RoomData roomData)**: System.Void (Private)
- **PopulateRoomView(Coherence.UI.ConnectDialogRoomView roomView, Steamworks.Data.Lobby lobbyData)**: System.Void (Private)
- **JoinRoomWithTags(System.String worldName, System.String privacyLevel, System.String region, System.String worldId)**: System.Void (Private)
- **InitLists()**: System.Void (Private)
- **GetNextAvailableWorldSlot()**: System.Int32 (Private)
- **GetWorldEntryCount()**: System.Int32 (Private)
- **GetFirstExistingEntryIndex()**: System.Int32 (Private)
- **GetLastExistingEntryIndex()**: System.Int32 (Private)
- **OnWorldEntryHighlighted(UnityEngine.UI.Toggle toggle)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

