# WildSkies.AI.TeleportDespawn

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _despawnParticles | UnityEngine.ParticleSystem | Private |
| _navAgent | WildSkies.AI.BossaNavAgent | Private |
| _agentAnimation | AgentAnimation | Private |
| _destroyVfxTime | System.Single | Private |
| _topOfJumpEventName | System.String | Private |
| _timeOutTime | System.Single | Private |
| _isRunning | System.Boolean | Private |
| _timeOutTimer | System.Single | Private |
| _teleportTimeOutCancellationToken | System.Threading.CancellationTokenSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DespawnType | WildSkies.AI.DespawnType | Public |

## Methods

- **get_DespawnType()**: WildSkies.AI.DespawnType (Public)
- **InitialiseBehaviour(WildSkies.Service.DisposalService disposalService)**: System.Void (Public)
- **Despawn()**: System.Void (Public)
- **OnAnimationEvent(System.String eventName)**: System.Void (Private)
- **OnAtTopOfJump()**: System.Void (Private)
- **OnReady()**: System.Void (Private)
- **OnEnable()**: System.Void (Private)
- **TimeOutTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnDisable()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

