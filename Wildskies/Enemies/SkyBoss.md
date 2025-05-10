# WildSkies.Enemies.SkyBoss

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _skyBossService | WildSkies.Service.SkyBossService | Protected |
| _aiLevelsService | WildSkies.Service.AILevelsService | Protected |
| _rigidbody | UnityEngine.Rigidbody | Protected |
| ShipLeftRange | System.Action | Public |
| StateChanged | System.Action`1<WildSkies.Enemies.SkyBoss/State> | Public |
| ShipEnteredRange | System.Action`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Public |
| OnDamaged | System.Action | Public |
| OnKill | System.Action | Public |
| OnDestroyed | System.Action | Public |
| _currentState | WildSkies.Enemies.SkyBoss/State | Private |
| _ship | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| <LeaveRange>k__BackingField | System.Single | Private |
| _shipSync | Coherence.Toolkit.CoherenceSync | Private |
| targetShip | Coherence.Toolkit.CoherenceSync | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentState | WildSkies.Enemies.SkyBoss/State | Public |
| Rigidbody | UnityEngine.Rigidbody | Public |
| Ship | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Public |
| LeaveRange | System.Single | Public |
| ShipSync | Coherence.Toolkit.CoherenceSync | Public |

## Methods

- **get_CurrentState()**: WildSkies.Enemies.SkyBoss/State (Public)
- **get_Rigidbody()**: UnityEngine.Rigidbody (Public)
- **get_Ship()**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **set_Ship(WildSkies.Gameplay.ShipBuilding.ConstructedShipController value)**: System.Void (Public)
- **get_LeaveRange()**: System.Single (Public)
- **get_ShipSync()**: Coherence.Toolkit.CoherenceSync (Public)
- **Start()**: System.Void (Public)
- **KillSkyBoss()**: System.Void (Public)
- **DestroySkyBoss()**: System.Void (Public)
- **OnDestroy()**: System.Void (Public)
- **GetUpgradeLevel()**: System.Int32 (Public)
- **TargetLeftTrigger()**: System.Void (Public)
- **TargetEnteredTrigger(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **ChangeState(WildSkies.Enemies.SkyBoss/State newState)**: System.Void (Public)
- **ExitCurrentState()**: System.Void (Public)
- **OnTargetShipSynced(Coherence.Toolkit.CoherenceSync oldTarget, Coherence.Toolkit.CoherenceSync newTarget)**: System.Void (Public)
- **RequestTargetInfo()**: System.Void (Private)
- **SendTargetInfo()**: System.Void (Public)
- **ReceiveTargetInfo(UnityEngine.GameObject ship)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

