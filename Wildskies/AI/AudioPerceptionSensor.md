# WildSkies.AI.AudioPerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _showGizmos | System.Boolean | Private |
| _occlusionResults | UnityEngine.RaycastHit[] | Private |
| _cooldownTimer | System.Single | Private |
| _cooldown | System.Single | Private |
| _radius | System.Single | Private |
| _subscribedToOnAudioPlay | System.Boolean | Private |
| _cooldownCancellationToken | System.Threading.CancellationTokenSource | Private |
| _cooldownTask | Cysharp.Threading.Tasks.UniTask | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _detectionPosition | UnityEngine.Vector3 | Private |
| _data | WildSkies.AI.AudioPerceptionData/AudioPerceptionConfiguration | Private |
| _currentParam | System.String | Private |
| _currentParamValue | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DetectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |
| CurrentData | WildSkies.AI.AudioPerceptionData/AudioPerceptionConfiguration | Public |
| CurrentParam | System.String | Public |
| CurrentParamValue | System.Single | Public |

## Methods

- **get_DetectedObjs()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **get_CurrentData()**: WildSkies.AI.AudioPerceptionData/AudioPerceptionConfiguration (Public)
- **get_CurrentParam()**: System.String (Public)
- **get_CurrentParamValue()**: System.Single (Public)
- **Initialise(WildSkies.Service.AudioService audioService)**: System.Void (Public)
- **OnDetection(UnityEngine.Vector3 position, WildSkies.Audio.AudioType audioType)**: System.Void (Protected)
- **OnParameterUpdate(WildSkies.Audio.AudioType type, UnityEngine.Vector3 position, System.String paramName, System.Single value)**: System.Void (Private)
- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **CancelAudioServiceSubscription()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **CooldownTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ResetSensor()**: System.Void (Public)
- **GetDetectionLocation()**: UnityEngine.Vector3 (Public)
- **SetUp()**: System.Void (Protected)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

