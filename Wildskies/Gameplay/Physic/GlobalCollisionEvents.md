# WildSkies.Gameplay.Physic.GlobalCollisionEvents

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _isActive | System.Boolean | Private |
| _layerMask | UnityEngine.LayerMask | Private |
| _preLogMultiplier | System.Single | Private |
| _magnitudeCutoff | System.Single | Private |
| _postLogMultiplier | System.Single | Private |
| _maxMagnitude | System.Single | Private |
| _decayForPhysicsShakes | System.Single | Private |
| _magnitudeDamageMultiplier | System.Single | Private |
| _minDebugLogMagnitude | System.Single | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| _uiService | UISystem.IUIService | Private |
| _cameraTransform | UnityEngine.Transform | Private |
| _lastDeltaTimes | System.Single[] | Private |

## Methods

- **Start()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **GetDeltaTimeString()**: System.String (Private)
- **PhysicsOnContactEvent(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray`1/ReadOnly<UnityEngine.ContactPairHeader> contactPairs)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

