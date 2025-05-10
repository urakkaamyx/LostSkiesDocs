# WildSkies.Mediators.PlatformAchievementMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _platformService | PlatformService | Private |
| _achievementService | WildSkies.Service.IAchievementService | Private |

## Methods

- **Initialise(PlatformService platformService, WildSkies.Service.IAchievementService achievementService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnIsAchievementUnlocked(System.Boolean unlocked, WildSkies.Service.AchievementNames/Achievements achievement)**: System.Void (Private)
- **OnIsAchievementUnlockedRequest(WildSkies.Service.AchievementNames/Achievements achievement)**: System.Void (Private)
- **OnAchievementUnlocked(System.Boolean unlocked, WildSkies.Service.AchievementNames/Achievements achievement)**: System.Void (Private)
- **OnAchievementCleared(System.Boolean success, WildSkies.Service.AchievementNames/Achievements achievement)**: System.Void (Private)
- **OnAchievementUnlockRequest(WildSkies.Service.AchievementNames/Achievements achievement)**: System.Void (Private)
- **OnAchievementClearRequest(WildSkies.Service.AchievementNames/Achievements achievement)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

