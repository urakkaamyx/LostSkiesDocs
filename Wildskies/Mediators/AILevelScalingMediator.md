# WildSkies.Mediators.AILevelScalingMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| _remotePlayerService | WildSkies.Service.IRemotePlayerService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |

## Methods

- **Initialise(WildSkies.Service.AILevelsService aiLevelsService, WildSkies.Service.IRemotePlayerService remotePlayerService, WildSkies.Service.ILocalPlayerService localPlayerService)**: System.Void (Public)
- **OnEffectiveDamageScaled(System.Single damage, System.Int32 weaponLevel, System.Int32 aiLevel, WildSkies.Service.AILevelsService/DamageDirection damageDirection)**: System.Int32 (Private)
- **OnAttackDamageScaled(System.Single damage)**: System.Int32 (Private)
- **GetPlayerCount()**: System.Int32 (Private)
- **Terminate()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

