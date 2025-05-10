# WildSkies.Service.AchievementService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <AchievementUnlockRequest>k__BackingField | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Private |
| <AchievementClearRequest>k__BackingField | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Private |
| <IsAchievementUnlockedRequest>k__BackingField | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Private |
| _waitingForIsUnlockedRequestResult | System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Collections.Generic.List`1<WildSkies.Service.AchievementService/AchievementResultCallback>> | Private |
| _waitingForUnlockResult | System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Collections.Generic.List`1<WildSkies.Service.AchievementService/AchievementResultCallback>> | Private |
| _waitingForClearResult | System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Collections.Generic.List`1<WildSkies.Service.AchievementService/AchievementResultCallback>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AchievementUnlockRequest | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Public |
| AchievementClearRequest | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Public |
| IsAchievementUnlockedRequest | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_AchievementUnlockRequest()**: System.Action`1<WildSkies.Service.AchievementNames/Achievements> (Public)
- **set_AchievementUnlockRequest(System.Action`1<WildSkies.Service.AchievementNames/Achievements> value)**: System.Void (Public)
- **get_AchievementClearRequest()**: System.Action`1<WildSkies.Service.AchievementNames/Achievements> (Public)
- **set_AchievementClearRequest(System.Action`1<WildSkies.Service.AchievementNames/Achievements> value)**: System.Void (Public)
- **get_IsAchievementUnlockedRequest()**: System.Action`1<WildSkies.Service.AchievementNames/Achievements> (Public)
- **set_IsAchievementUnlockedRequest(System.Action`1<WildSkies.Service.AchievementNames/Achievements> value)**: System.Void (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **UnlockAchievement(WildSkies.Service.AchievementNames/Achievements achievement, WildSkies.Service.AchievementService/AchievementResultCallback callback)**: System.Void (Public)
- **ClearAchievement(WildSkies.Service.AchievementNames/Achievements achievement, WildSkies.Service.AchievementService/AchievementResultCallback callback)**: System.Void (Public)
- **ClearAllAchievements()**: System.Void (Public)
- **UnlockAllAchievements()**: System.Void (Public)
- **RequestIsAchievementUnlocked(WildSkies.Service.AchievementNames/Achievements achievement, WildSkies.Service.AchievementService/AchievementResultCallback callback)**: System.Void (Public)
- **ProcessIsAchievementUnlockedResult(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean unlocked)**: System.Void (Public)
- **AchievementCleared(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean success)**: System.Void (Public)
- **AchievementUnlocked(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean success)**: System.Void (Public)
- **ClearCallbackLists(System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Collections.Generic.List`1<WildSkies.Service.AchievementService/AchievementResultCallback>> callbackDictionary)**: System.Void (Private)
- **ResultCallbacks(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean result, System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Collections.Generic.List`1<WildSkies.Service.AchievementService/AchievementResultCallback>> callbackDictionary)**: System.Void (Private)
- **AddCallback(WildSkies.Service.AchievementService/AchievementResultCallback callback, WildSkies.Service.AchievementNames/Achievements achievement, System.Collections.Generic.Dictionary`2<WildSkies.Service.AchievementNames/Achievements,System.Collections.Generic.List`1<WildSkies.Service.AchievementService/AchievementResultCallback>> callbackDictionary)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

