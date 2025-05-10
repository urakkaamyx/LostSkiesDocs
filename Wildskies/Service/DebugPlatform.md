# WildSkies.Service.DebugPlatform

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _debugAchievementStore | System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Boolean> | Private |
| _existingSlotsTemp | System.Collections.Generic.List`1<System.Int32> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ConsoleAllowed | System.Boolean | Public |

## Methods

- **get_ConsoleAllowed()**: System.Boolean (Public)
- **IsUserSignedIn()**: System.Boolean (Public)
- **GetDisplayName()**: System.String (Public)
- **GetUniqueUserID()**: System.String (Public)
- **Terminate()**: System.Void (Public)
- **GetPlatformFriendsInGame()**: System.Collections.Generic.List`1<PlatformFriendData> (Public)
- **Initialise()**: System.Int32 (Public)
- **IsServiceReady()**: System.Boolean (Public)
- **LoadData(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Public)
- **SaveData(System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Public)
- **ClearSaveData(System.Int32 saveslot, System.String key, System.Guid requestId)**: System.Void (Public)
- **TryGetAllSaveSlotsForKey(System.String key)**: System.Void (Public)
- **TryGetNextAvailableSaveSlotForKey(System.String key)**: System.Void (Public)
- **GetAllSaveSlotsForKey(System.String key)**: System.Boolean (Private)
- **SaveDataExistsForSlot(System.Int32 saveslot, System.String key)**: System.Boolean (Public)
- **WriteToFile(System.Int32 saveslot, System.String key, System.String saveData)**: System.Boolean (Private)
- **LoadFromFile(System.Int32 saveSlot, System.String key, System.String& saveData)**: System.Boolean (Private)
- **GetPlatformEnvironment()**: System.String (Public)
- **GeneratePath(System.Int32 saveslot, System.String key)**: System.String (Private)
- **SetRichPresence(System.String message)**: System.Void (Public)
- **OpenStorePage()**: System.Void (Public)
- **HasAchievementBeenUnlockedRequest(WildSkies.Service.AchievementNames/Achievements achievementKey)**: System.Void (Public)
- **UnlockAchievement(WildSkies.Service.AchievementNames/Achievements achievementKey)**: System.Void (Public)
- **ClearAchievement(WildSkies.Service.AchievementNames/Achievements achievementKey)**: System.Void (Public)
- **GetPlatformLanguage()**: System.String (Public)
- **.ctor()**: System.Void (Public)

