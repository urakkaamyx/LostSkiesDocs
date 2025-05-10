# WildSkies.AI.TouchPerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _aiStagger | WildSkies.AI.AIStagger | Protected |
| _cooldownTimer | System.Single | Private |
| _cooldownCancellationToken | System.Threading.CancellationTokenSource | Private |
| _cooldownTask | Cysharp.Threading.Tasks.UniTask | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DetectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |

## Methods

- **get_DetectedObjs()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **SetUp()**: System.Void (Protected)
- **OnDetection()**: System.Void (Protected)
- **CooldownTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ResetSensor()**: System.Void (Public)
- **.ctor()**: System.Void (Protected)

