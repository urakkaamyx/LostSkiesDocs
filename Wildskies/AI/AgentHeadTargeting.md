# WildSkies.AI.AgentHeadTargeting

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _head | UnityEngine.Transform | Private |
| _memoryHandler | AIMemoryHandler | Private |
| _lookAtIK | RootMotion.FinalIK.IK | Private |
| _droneFaceTarget | DroneFaceTarget | Private |
| _droneTurretRotators | DroneTurretRotation[] | Private |
| _aimSpeed | System.Single | Private |
| _aimRadius | System.Single | Private |
| _useDistanceForAimRadius | System.Boolean | Private |
| _useNonAttackTarget | System.Boolean | Private |
| _useAtRestCallback | System.Boolean | Private |
| _useWaitForInitialLineUp | System.Boolean | Private |
| _usePerfectTargeting | System.Boolean | Private |
| _yOffset | System.Single | Private |
| _startEnabled | System.Boolean | Private |
| _drawGizmos | System.Boolean | Private |
| _aimTarget | UnityEngine.Transform | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _arbitraryRestingDistance | System.Single | Private |
| _minDistForRest | System.Single | Private |
| _waitForInitialLineUp | System.Boolean | Private |
| _useOverrideTarget | System.Boolean | Private |
| _overrideTarget | UnityEngine.Vector3 | Private |
| _angle | System.Single | Private |
| _newTargetPosition | UnityEngine.Vector3 | Private |
| _defaultAimSmoothing | System.Single | Private |
| _defaultWeight | System.Single | Private |
| _defaultAimRadius | System.Single | Private |
| TargetPosition | UnityEngine.Vector3 | Public |
| IsEnabled | System.Boolean | Public |
| AllowDisableIK | System.Boolean | Public |
| AtRest | System.Boolean | Public |
| OnAtRestPosition | System.Action | Public |
| _headTargetingState | WildSkies.AI.AgentHeadTargeting/HeadTargetingState | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| HeadTransform | UnityEngine.Transform | Public |
| AimSpeed | System.Single | Public |
| UseOverride | System.Boolean | Public |
| DroneFaceTarget | DroneFaceTarget | Public |
| WaitForInitialLineUp | System.Boolean | Public |
| DebugHeadTargetingState | WildSkies.AI.AgentHeadTargeting/HeadTargetingState | Public |
| _noTargetPosition | UnityEngine.Vector3 | Private |

## Methods

- **get_HeadTransform()**: UnityEngine.Transform (Public)
- **get_AimSpeed()**: System.Single (Public)
- **get_UseOverride()**: System.Boolean (Public)
- **get_DroneFaceTarget()**: DroneFaceTarget (Public)
- **get_WaitForInitialLineUp()**: System.Boolean (Public)
- **get_DebugHeadTargetingState()**: WildSkies.AI.AgentHeadTargeting/HeadTargetingState (Public)
- **get__noTargetPosition()**: UnityEngine.Vector3 (Private)
- **Awake()**: System.Void (Private)
- **LateUpdate()**: System.Void (Private)
- **SetTargetPosition(UnityEngine.Vector3 target)**: System.Void (Private)
- **NoTargetMovement(UnityEngine.Vector3 target)**: System.Void (Private)
- **GetAdjustedTargetPosition(UnityEngine.Vector3 target)**: UnityEngine.Vector3 (Private)
- **SetEnabled(System.Boolean enabled)**: System.Void (Public)
- **SetAimSpeed(System.Single aimSpeed)**: System.Void (Public)
- **ResetAimSpeed()**: System.Void (Public)
- **SetAllowDisableIK(System.Boolean allowDisable)**: System.Void (Public)
- **UseOverrideTarget(System.Boolean useOverrideTarget, System.Single aimSpeed)**: System.Void (Public)
- **UseOverrideTarget(System.Boolean useOverrideTarget)**: System.Void (Public)
- **UpdateOverrideTarget(UnityEngine.Vector3 overrideTarget)**: System.Void (Public)
- **AssignVirtualTarget()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

