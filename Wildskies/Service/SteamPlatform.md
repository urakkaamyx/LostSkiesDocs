# WildSkies.Service.SteamPlatform

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| StorePage | System.String | Private |
| RequireLogin | System.Boolean | Private |
| _steamAttemptedLogin | System.Boolean | Private |
| _appId | System.UInt32 | Private |
| _steamManager | SteamSample.SteamManager | Private |
| _uniqueUserId | System.String | Private |
| _platformFriendsInGame | System.Collections.Generic.List`1<PlatformFriendData> | Private |
| _existingSlotsTemp | System.Collections.Generic.List`1<System.Int32> | Private |
| _telemetryJoinTypeAsString | System.String | Private |
| _currentLobby | Steamworks.Data.Lobby | Private |
| _gameOverlayActivated | System.Boolean | Private |
| _consoleAllowed | System.Boolean | Private |
| _whiteListedAccounts | System.Collections.Generic.List`1<System.String> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ConsoleAllowed | System.Boolean | Public |
| GameOverlayActivated | System.Boolean | Public |
| TelemetryJoinTypeAsString | System.String | Public |

## Methods

- **get_ConsoleAllowed()**: System.Boolean (Public)
- **get_GameOverlayActivated()**: System.Boolean (Public)
- **get_TelemetryJoinTypeAsString()**: System.String (Public)
- **Initialise()**: System.Int32 (Public)
- **HandleStartupJoinRequest()**: System.Void (Private)
- **CharacterCheck()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnLobbyEntered(Steamworks.Data.Lobby lobby)**: System.Void (Private)
- **OnGameLobbyJoinRequested(Steamworks.Data.Lobby lobby, Steamworks.SteamId friendId)**: System.Void (Private)
- **JoinViaNetworkService(Steamworks.Data.Lobby lobby)**: Cysharp.Threading.Tasks.UniTask (Private)
- **JoinLobbyAsync(System.UInt64 lobbyId)**: Cysharp.Threading.Tasks.UniTask (Private)
- **IsServiceReady()**: System.Boolean (Public)
- **IsUserSignedIn()**: System.Boolean (Public)
- **GetDisplayName()**: System.String (Public)
- **GetUniqueUserID()**: System.String (Public)
- **OnSteamLoginResult(System.Boolean success)**: System.Void (Private)
- **OnGameOverlayStateChanged(System.Boolean isActive)**: System.Void (Private)
- **SetRichPresence(System.String message)**: System.Void (Public)
- **OpenStorePage()**: System.Void (Public)
- **GetPlatformEnvironment()**: System.String (Public)
- **LoadData(System.Int32 saveslot, System.String key, System.Guid requestId)**: System.Void (Public)
- **SaveData(System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Public)
- **ClearSaveData(System.Int32 saveslot, System.String key, System.Guid requestId)**: System.Void (Public)
- **WriteToFile(System.Int32 saveslot, System.String key, System.String saveData)**: System.Boolean (Private)
- **LoadFromFile(System.Int32 saveSlot, System.String key, System.String& saveData)**: System.Boolean (Private)
- **GeneratePath(System.Int32 saveslot, System.String key)**: System.String (Private)
- **GenerateCloudSyncPath(System.Int32 saveslot, System.String key)**: System.String (Private)
- **TryGetAllSaveSlotsForKey(System.String key)**: System.Void (Public)
- **TryGetNextAvailableSaveSlotForKey(System.String key)**: System.Void (Public)
- **GetAllSaveSlotsForKey(System.String key)**: System.Boolean (Private)
- **SaveDataExistsForSlot(System.Int32 saveslot, System.String key)**: System.Boolean (Public)
- **HasAchievementBeenUnlockedRequest(WildSkies.Service.AchievementNames/Achievements name)**: System.Void (Public)
- **UnlockAchievement(WildSkies.Service.AchievementNames/Achievements name)**: System.Void (Public)
- **ClearAchievement(WildSkies.Service.AchievementNames/Achievements name)**: System.Void (Public)
- **GetPlatformLanguage()**: System.String (Public)
- **GetIsoCodeForLanguage(System.String language)**: System.String (Private)
- **Terminate()**: System.Void (Public)
- **OnSteamDlcInstalled(Steamworks.AppId targetAppID)**: System.Void (Private)
- **OwnsApplication(System.Int32 targetAppID)**: System.Boolean (Public)
- **HasAccessToDLC(System.Int32 dlcID)**: System.Boolean (Public)
- **GetPlatformFriendsInGame()**: System.Collections.Generic.List`1<PlatformFriendData> (Public)
- **.ctor()**: System.Void (Public)

