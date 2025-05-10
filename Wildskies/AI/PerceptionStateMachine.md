# WildSkies.AI.PerceptionStateMachine

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _perceptionData | WildSkies.AI.PerceptionData | Private |
| _headSensors | UnityEngine.Transform | Private |
| _memory | AIMemoryHandler | Private |
| _headTargeting | WildSkies.AI.AgentHeadTargeting | Private |
| _sensors | WildSkies.AI.PerceptionSensor[] | Private |
| _sensorParent | UnityEngine.GameObject | Private |
| OnStateChangeEvent | WildSkies.AI.PerceptionStateMachine/OnStateChange | Private |
| <Events>k__BackingField | AIEvents | Private |
| _activeState | WildSkies.AI.PerceptionState | Private |
| _defaultState | WildSkies.AI.PerceptionState | Private |
| _states | System.Collections.Generic.List`1<WildSkies.AI.PerceptionState> | Private |
| _fallOffCancellationToken | System.Threading.CancellationTokenSource | Private |
| _fallOffDelayCancellationToken | System.Threading.CancellationTokenSource | Private |
| _targetDeathCancellationToken | System.Threading.CancellationTokenSource | Private |
| _fallOffDelayTask | Cysharp.Threading.Tasks.UniTask | Private |
| _fallOffTimerTask | Cysharp.Threading.Tasks.UniTask | Private |
| _targetDeathWaitTask | Cysharp.Threading.Tasks.UniTask | Private |
| _detectionScore | System.Single | Private |
| _currentIncreaseScore | System.Single | Private |
| _fallOffTimer | System.Single | Private |
| _fallOfDelayTimer | System.Single | Private |
| _targetDeathTimer | System.Single | Private |
| _currentScoreData | WildSkies.AI.PerceptionSensor/PerceptionScoreData | Private |
| _isRunning | System.Boolean | Private |
| _sensorsActive | System.Boolean | Private |
| _targetDied | System.Boolean | Private |
| _isInitialised | System.Boolean | Private |
| _aiFeedbackService | WildSkies.Service.AIFeedbackService | Private |
| _aiEntity | WildSkies.Entities.AIEntity | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _currentElementLODLevel | System.Int32 | Private |
| _targetDeathWaitTime | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ActiveState | WildSkies.AI.EPerceptionState | Public |
| IsDefaultState | System.Boolean | Public |
| Timer | System.Single | Public |
| TimerLength | System.Single | Public |
| DelayTimer | System.Single | Public |
| PerceptionData | WildSkies.AI.PerceptionData | Public |
| Sensors | WildSkies.AI.PerceptionSensor[] | Public |
| HasActiveState | System.Boolean | Public |
| HasDetection | System.Boolean | Public |
| HasVisualDetection | System.Boolean | Public |
| ActiveSensor | System.Int32 | Public |
| CurrentIncreaseScore | System.Single | Public |
| CurrentScoreData | WildSkies.AI.PerceptionSensor/PerceptionScoreData | Public |
| HeadTargeting | WildSkies.AI.AgentHeadTargeting | Public |
| AIEntity | WildSkies.Entities.AIEntity | Public |
| Transform | UnityEngine.Transform | Public |
| CurrentElementLODLevel | System.Int32 | Public |
| IsRunning | System.Boolean | Public |
| Events | AIEvents | Public |

## Methods

- **get_ActiveState()**: WildSkies.AI.EPerceptionState (Public)
- **get_IsDefaultState()**: System.Boolean (Public)
- **get_Timer()**: System.Single (Public)
- **get_TimerLength()**: System.Single (Public)
- **get_DelayTimer()**: System.Single (Public)
- **get_PerceptionData()**: WildSkies.AI.PerceptionData (Public)
- **get_Sensors()**: WildSkies.AI.PerceptionSensor[] (Public)
- **get_HasActiveState()**: System.Boolean (Public)
- **get_HasDetection()**: System.Boolean (Public)
- **get_HasVisualDetection()**: System.Boolean (Public)
- **get_ActiveSensor()**: System.Int32 (Public)
- **get_CurrentIncreaseScore()**: System.Single (Public)
- **get_CurrentScoreData()**: WildSkies.AI.PerceptionSensor/PerceptionScoreData (Public)
- **get_HeadTargeting()**: WildSkies.AI.AgentHeadTargeting (Public)
- **get_AIEntity()**: WildSkies.Entities.AIEntity (Public)
- **get_Transform()**: UnityEngine.Transform (Public)
- **get_CurrentElementLODLevel()**: System.Int32 (Public)
- **get_IsRunning()**: System.Boolean (Public)
- **add_OnStateChangeEvent(WildSkies.AI.PerceptionStateMachine/OnStateChange value)**: System.Void (Public)
- **remove_OnStateChangeEvent(WildSkies.AI.PerceptionStateMachine/OnStateChange value)**: System.Void (Public)
- **get_Events()**: AIEvents (Public)
- **set_Events(AIEvents value)**: System.Void (Private)
- **Init(WildSkies.Service.AIFeedbackService aiFeedbackService, AIEvents events)**: System.Void (Public)
- **OnTargetDeath(WildSkies.AI.Attacks.AIAttackType obj)**: System.Void (Private)
- **OnEnable()**: System.Void (Private)
- **DisableCleanUp()**: System.Void (Public)
- **DestroyCleanUp()**: System.Void (Public)
- **DisablePerception()**: System.Void (Public)
- **EnablePerception()**: System.Void (Public)
- **SetSensorsEnabled(System.Boolean enabled)**: System.Void (Public)
- **AddScoreImpulse(System.Int32 sensorId, WildSkies.AI.PerceptionSensor/ScoreType scoreType, System.Int32 baseScore)**: System.Void (Public)
- **AddToDetectionScore(System.Int32 sensorId, WildSkies.AI.PerceptionSensor/PerceptionScoreData scoreData)**: System.Void (Public)
- **SetSensorActive()**: System.Void (Public)
- **SetSensorInactive()**: System.Void (Public)
- **AnySensorActive()**: System.Boolean (Private)
- **SetIsRunning(System.Boolean isRunning)**: System.Void (Public)
- **CheckIfNextStateShouldSet()**: System.Void (Private)
- **UpdateAIMemory(WildSkies.AI.PerceptionSensor highestPrioritySensor)**: System.Void (Private)
- **SetState(WildSkies.AI.PerceptionState state)**: System.Void (Private)
- **GetHighestPrioritySensor(System.Int32 sensorId)**: WildSkies.AI.PerceptionSensor (Public)
- **GetHighestPrioritySensorOfType()**: WildSkies.AI.PerceptionSensor (Public)
- **TryGetFirstSensorOfType(T& sensor)**: System.Boolean (Public)
- **HasVisual()**: System.Boolean (Private)
- **ResetDetectionScore()**: System.Void (Private)
- **FallOffDelayTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **FallOffTimerTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **TargetDeathWaitCheck()**: Cysharp.Threading.Tasks.UniTask (Private)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

