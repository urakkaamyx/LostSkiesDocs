# WildSkies.Gameplay.Effectors.AtlasLifter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _followPosition | System.Boolean | Private |
| _disconnectDistance | System.Single | Private |
| _emissionShaderString | System.String | Private |
| _emissionColorShaderString | System.String | Private |
| _emissionMaterialId | System.Int32[] | Private |
| _meshRenderer | UnityEngine.MeshRenderer[] | Private |
| _emissionRange | UnityEngine.Vector2 | Private |
| _flashAmount | System.Int32 | Private |
| _flashDuration | System.Single | Private |
| _delayAfterFlash | System.Single | Private |
| _delayBeforeFlash | System.Single | Private |
| _flashColor | UnityEngine.Color | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _defaultEmission | UnityEngine.Color | Public |
| PositionOffset | UnityEngine.Vector3 | Public |
| RotationOffset | UnityEngine.Quaternion | Public |
| _targetPosition | UnityEngine.Vector3 | Private |
| _hasTriggeredBlink | System.Boolean | Private |

## Methods

- **Start()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **FixedUpdate()**: System.Void (Public)
- **Initialize()**: System.Void (Public)
- **DamageEffector()**: System.Void (Public)
- **GetDefaultEmission()**: System.Void (Private)
- **CalculateOffsets()**: System.Void (Private)
- **UpdateEmission()**: System.Void (Private)
- **SetEmission(System.Single emissionIntensity)**: System.Void (Private)
- **UpdateLowPowerFlash()**: System.Void (Private)
- **FlashEmission(System.Boolean withDisconnect)**: System.Void (Private)
- **FollowConnectedObject()**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

