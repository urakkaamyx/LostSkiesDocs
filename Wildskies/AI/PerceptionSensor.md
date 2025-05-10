# WildSkies.AI.PerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _baseScore | System.Int32 | Protected |
| _scoringType | WildSkies.AI.PerceptionSensor/ScoreType | Protected |
| _onlyScoreIfState | System.Boolean | Protected |
| _scoreStates | WildSkies.AI.EPerceptionState[] | Protected |
| _stateScores | WildSkies.AI.PerceptionSensor/StateScore[] | Protected |
| _maxConfidence | System.Single | Protected |
| _minConfidence | System.Single | Protected |
| <CurrentElementLODLevel>k__BackingField | System.Int32 | Private |
| _sensorId | System.Int32 | Private |
| OnSetInactive | System.Action | Private |
| OnAddToScore | System.Action`2<System.Int32,WildSkies.AI.PerceptionSensor/PerceptionScoreData> | Private |
| OnImpulse | System.Action`3<System.Int32,WildSkies.AI.PerceptionSensor/ScoreType,System.Int32> | Private |
| _confidence | System.Single | Protected |
| _perceptionData | WildSkies.AI.PerceptionData | Protected |
| _currentState | WildSkies.AI.EPerceptionState | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| Id | System.Int32 | Public |
| HasDetection | System.Boolean | Public |
| Confidence | System.Single | Public |
| DetectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |
| CurrentElementLODLevel | System.Int32 | Public |

## Methods

- **get_Id()**: System.Int32 (Public)
- **get_HasDetection()**: System.Boolean (Public)
- **get_Confidence()**: System.Single (Public)
- **get_DetectedObjs()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **get_CurrentElementLODLevel()**: System.Int32 (Public)
- **set_CurrentElementLODLevel(System.Int32 value)**: System.Void (Protected)
- **Init(System.Int32 id, WildSkies.AI.PerceptionData perceptionData, System.Action onSetInactive, System.Action`2<System.Int32,WildSkies.AI.PerceptionSensor/PerceptionScoreData> onAddToScore, System.Action`3<System.Int32,WildSkies.AI.PerceptionSensor/ScoreType,System.Int32> onImpulse)**: System.Void (Public)
- **OnStateChanged(WildSkies.AI.EPerceptionState state)**: System.Void (Public)
- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **ResetSensor()**: System.Void (Public)
- **SetUp()**: System.Void (Protected)
- **SetSensorInactive()**: System.Void (Protected)
- **AddToDetectionScore(WildSkies.AI.PerceptionSensor/PerceptionScoreData data)**: System.Void (Protected)
- **SetConfidence(System.Single value)**: System.Void (Protected)
- **IsInScoreState()**: System.Boolean (Protected)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **.ctor()**: System.Void (Protected)

