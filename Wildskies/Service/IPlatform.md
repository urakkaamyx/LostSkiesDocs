# WildSkies.Service.IPlatform

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| ConsoleAllowed | System.Boolean | Public |
| PlatformName | System.String | Public |

## Methods

- **add_UsersChanged(System.Action value)**: System.Void (Public)
- **remove_UsersChanged(System.Action value)**: System.Void (Public)
- **get_ConsoleAllowed()**: System.Boolean (Public)
- **get_PlatformName()**: System.String (Public)
- **Initialise()**: System.Int32 (Public)
- **IsServiceReady()**: System.Boolean (Public)
- **IsUserSignedIn()**: System.Boolean (Public)
- **GetDisplayName()**: System.String (Public)
- **GetUniqueUserID()**: System.String (Public)
- **Update()**: System.Void (Public)
- **TryGetAllSaveSlotsForKey(System.String key)**: System.Void (Public)
- **TryGetNextAvailableSaveSlotForKey(System.String key)**: System.Void (Public)
- **SaveDataExistsForSlot(System.Int32 saveSlot, System.String key)**: System.Boolean (Public)
- **SaveData(System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Public)
- **LoadData(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Public)
- **ClearSaveData(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Public)
- **SetRichPresence(System.String message)**: System.Void (Public)
- **OpenStorePage()**: System.Void (Public)
- **HasAchievementBeenUnlockedRequest(WildSkies.Service.AchievementNames/Achievements achievementKey)**: System.Void (Public)
- **UnlockAchievement(WildSkies.Service.AchievementNames/Achievements achievementKey)**: System.Void (Public)
- **ClearAchievement(WildSkies.Service.AchievementNames/Achievements achievementKey)**: System.Void (Public)
- **GetPlatformLanguage()**: System.String (Public)
- **ShowSystemLoginPanel()**: System.Void (Public)
- **RetryFailedPlatformCalls()**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **GetPlatformFriendsInGame()**: System.Collections.Generic.List`1<PlatformFriendData> (Public)
- **OwnsApplication(System.Int32 targetAppID)**: System.Boolean (Public)
- **HasAccessToDLC(System.Int32 dlcID)**: System.Boolean (Public)

