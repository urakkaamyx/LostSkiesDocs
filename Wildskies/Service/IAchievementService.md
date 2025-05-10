# WildSkies.Service.IAchievementService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| AchievementUnlockRequest | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Public |
| AchievementClearRequest | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Public |
| IsAchievementUnlockedRequest | System.Action`1<WildSkies.Service.AchievementNames/Achievements> | Public |

## Methods

- **get_AchievementUnlockRequest()**: System.Action`1<WildSkies.Service.AchievementNames/Achievements> (Public)
- **set_AchievementUnlockRequest(System.Action`1<WildSkies.Service.AchievementNames/Achievements> value)**: System.Void (Public)
- **get_AchievementClearRequest()**: System.Action`1<WildSkies.Service.AchievementNames/Achievements> (Public)
- **set_AchievementClearRequest(System.Action`1<WildSkies.Service.AchievementNames/Achievements> value)**: System.Void (Public)
- **get_IsAchievementUnlockedRequest()**: System.Action`1<WildSkies.Service.AchievementNames/Achievements> (Public)
- **set_IsAchievementUnlockedRequest(System.Action`1<WildSkies.Service.AchievementNames/Achievements> value)**: System.Void (Public)
- **AchievementUnlocked(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean success)**: System.Void (Public)
- **ProcessIsAchievementUnlockedResult(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean unlocked)**: System.Void (Public)
- **AchievementCleared(WildSkies.Service.AchievementNames/Achievements achievement, System.Boolean success)**: System.Void (Public)

