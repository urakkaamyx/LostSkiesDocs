# WildSkies.AI.LimpetStunnedState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _waitTime | System.Single | Private |
| _onStateComplete | System.Action | Private |
| _movement | WildSkies.AI.PhysicsFlyingMovement | Private |
| _animation | LimpetAnimation | Private |
| _waitCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| _waitTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| State | WildSkies.AI.LimpetCritter/LimpetStates | Public |

## Methods

- **get_State()**: WildSkies.AI.LimpetCritter/LimpetStates (Public)
- **.ctor(WildSkies.AI.LimpetCritter/LimpetSettings settings, WildSkies.AI.PhysicsFlyingMovement movement, LimpetAnimation limpetAnimation, System.Action onComplete)**: System.Void (Public)
- **EnterState()**: System.Void (Public)
- **ExitState()**: System.Void (Public)
- **DisableState()**: System.Void (Public)
- **UpdateState()**: System.Void (Public)
- **Wait()**: Cysharp.Threading.Tasks.UniTask (Private)

