# WildSkies.AI.LimpetIdlingState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _waitTime | System.Single | Private |
| _speed | System.Single | Private |
| _limpetTransform | UnityEngine.Transform | Private |
| _movement | WildSkies.AI.PhysicsFlyingMovement | Private |
| _animation | LimpetAnimation | Private |
| _shipTracking | AIShipTracking | Private |
| _destinationThreshold | System.Single | Private |
| _range | System.Single | Private |
| _homeOffset | UnityEngine.Vector3 | Private |
| _onStateComplete | System.Action | Private |
| _waitCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| _waitTimer | System.Single | Private |
| _targetOffset | UnityEngine.Vector3 | Private |
| _startTimer | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| State | WildSkies.AI.LimpetCritter/LimpetStates | Public |

## Methods

- **get_State()**: WildSkies.AI.LimpetCritter/LimpetStates (Public)
- **.ctor(WildSkies.AI.LimpetCritter/LimpetSettings settings, WildSkies.AI.PhysicsFlyingMovement movement, UnityEngine.Transform limpetTransform, UnityEngine.Vector3 homeOffset, AIShipTracking shipTracking, LimpetAnimation animation, System.Action onComplete)**: System.Void (Public)
- **EnterState()**: System.Void (Public)
- **ExitState()**: System.Void (Public)
- **DisableState()**: System.Void (Public)
- **UpdateState()**: System.Void (Public)
- **Wait()**: Cysharp.Threading.Tasks.UniTask (Private)
- **GetRandomOffset(System.Single range)**: UnityEngine.Vector3 (Private)
- **IsNearDestination(UnityEngine.Vector3 destination, System.Single threshold)**: System.Boolean (Private)

