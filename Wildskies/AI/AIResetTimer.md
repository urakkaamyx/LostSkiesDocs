# WildSkies.AI.AIResetTimer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _persistentEntityHealth | WildSkies.Entities.Health.PersistentEntityHealth | Private |
| _resetTimerData | WildSkies.AI.AIResetTimerData | Private |
| _playerSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _useTimer | System.Boolean | Private |
| _remotePlayerService | WildSkies.Service.IRemotePlayerService | Private |
| _isInitialised | System.Boolean | Private |
| _timerActive | System.Boolean | Private |
| _deathHandling | EntityDeathHandling | Private |
| _timer | System.Single | Private |
| _numberOfRemotePlayers | System.Int32 | Private |
| _resetTimerCancellationTokenSource | System.Threading.CancellationTokenSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| TimerActive | System.Boolean | Public |
| Timer | System.Single | Public |
| HasRemotePlayers | System.Boolean | Private |

## Methods

- **get_TimerActive()**: System.Boolean (Public)
- **get_Timer()**: System.Single (Public)
- **get_HasRemotePlayers()**: System.Boolean (Private)
- **Init(Coherence.Toolkit.CoherenceSync sync, EntityDeathHandling deathHandling)**: System.Void (Public)
- **OnAuthorityGained()**: System.Void (Public)
- **OnAuthorityLost()**: System.Void (Public)
- **SetUseTimer(System.Boolean useTimer)**: System.Void (Public)
- **ForceReset()**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnEntityDeath(UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **OnRemotePlayerRegistered(PlayerNetwork playerNetwork)**: System.Void (Private)
- **OnRemotePlayerUnregistered(PlayerNetwork playerNetwork)**: System.Void (Private)
- **CancelTimer()**: System.Void (Private)
- **ResetTimer()**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)

