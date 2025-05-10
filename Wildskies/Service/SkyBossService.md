# WildSkies.Service.SkyBossService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _skyBosses | System.Collections.Generic.List`1<WildSkies.Enemies.IBoss> | Private |
| _activeSkyBosses | System.Collections.Generic.List`1<WildSkies.Enemies.IBoss> | Private |
| OnFightEnded | System.Action`2<WildSkies.Enemies.IBoss,System.Boolean> | Public |
| OnFightJoined | System.Action`1<WildSkies.Enemies.IBoss> | Public |
| OnFightExited | System.Action`1<WildSkies.Enemies.IBoss> | Public |
| OnSetPieceStarted | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| SkyBosses | System.Collections.Generic.List`1<WildSkies.Enemies.IBoss> | Public |
| ActiveSkyBosses | System.Collections.Generic.List`1<WildSkies.Enemies.IBoss> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_SkyBosses()**: System.Collections.Generic.List`1<WildSkies.Enemies.IBoss> (Public)
- **get_ActiveSkyBosses()**: System.Collections.Generic.List`1<WildSkies.Enemies.IBoss> (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RegisterSkyBoss(WildSkies.Enemies.IBoss skyBoss)**: System.Void (Public)
- **UnregisterSkyBoss(WildSkies.Enemies.IBoss skyBoss)**: System.Void (Public)
- **StartFight(WildSkies.Enemies.IBoss skyBoss)**: System.Void (Public)
- **EndFight(WildSkies.Enemies.IBoss skyBoss, System.Boolean wasKilled)**: System.Void (Public)
- **IsBossInFight(WildSkies.Enemies.IBoss skyBoss)**: System.Boolean (Public)
- **GetIndexOfSkyBoss(WildSkies.Enemies.IBoss skyBoss)**: System.Int32 (Public)
- **TryHavePlayerJoinBossFight(PlayerSync playerSync, WildSkies.Enemies.IBoss& boss)**: System.Boolean (Public)
- **TryHavePlayerLeaveBossFight(PlayerSync playerSync, WildSkies.Enemies.IBoss boss)**: System.Boolean (Public)
- **JoinFight(WildSkies.Enemies.IBoss skyBoss)**: System.Void (Private)
- **LeaveFight(WildSkies.Enemies.IBoss skyBoss)**: System.Void (Private)
- **IsPlayerInFight(System.Int32 bossIndex, PlayerSync playerSync)**: System.Boolean (Public)
- **IsPlayerNearBoss(PlayerSync playerSync, WildSkies.Enemies.SkyBoss& skyBoss)**: System.Boolean (Public)
- **IsPlayerNearBoss(PlayerSync playerSync, WildSkies.Enemies.SkyBoss boss)**: System.Boolean (Public)
- **IsPlayerNearBoss(PlayerSync playerSync, System.Int32 index)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

