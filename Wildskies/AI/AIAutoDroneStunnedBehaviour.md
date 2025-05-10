# WildSkies.AI.AIAutoDroneStunnedBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _flyingAgent | WildSkies.AI.BossaFlyingAgent | Private |
| _animation | AgentAnimation | Private |
| _turretRotations | DroneTurretRotation[] | Private |
| _weakspots | UnityEngine.GameObject[] | Private |
| _weakspotSkinnedMeshRenderers | UnityEngine.SkinnedMeshRenderer[] | Private |
| _otherSkinnedMeshRenderers | UnityEngine.SkinnedMeshRenderer[] | Private |
| _flashingPanels | System.Boolean | Private |
| _weakspotMaterials | System.Collections.Generic.List`1<UnityEngine.Material> | Private |
| _otherMaterials | System.Collections.Generic.List`1<UnityEngine.Material> | Private |
| _originalEmissiveIntensities | System.Collections.Generic.Dictionary`2<UnityEngine.Material,System.Single> | Private |
| EnableCablePulsePropertyID | System.Int32 | Private |
| EnableBodyPulsePropertyID | System.Int32 | Private |
| EmissiveIntensityID | System.Int32 | Private |
| EmissiveIntensityOnDroneShaderNotEyeID | System.Int32 | Private |

## Methods

- **Init()**: System.Void (Private)
- **Awake()**: System.Void (Private)
- **OnStartBehaviour()**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)
- **OnEndBehaviour()**: System.Void (Public)
- **NetworkSetWeakspotsActive(System.Boolean active)**: System.Void (Public)
- **CycleFullPulseMode(System.Boolean enable)**: System.Void (Private)
- **CycleEmissive(System.Boolean enable)**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

