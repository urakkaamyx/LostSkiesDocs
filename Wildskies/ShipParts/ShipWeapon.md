# WildSkies.ShipParts.ShipWeapon

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Protected |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| <AimDirection>k__BackingField | UnityEngine.Vector3 | Private |
| _cameraSettings | Bossa.Cinematika.Controllers.PilotCinematikaController/Settings | Private |
| _smoothingSpeed | System.Single | Protected |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _animator | UnityEngine.Animator | Protected |
| _interactable | NetworkInteractable | Private |
| _ikTargets | Bossa.Dynamika.IK.IKTargetTransform[] | Private |
| _hardAttachTarget | UnityEngine.Transform | Private |
| _cameraTarget | UnityEngine.Transform | Private |
| _yawRotator | UnityEngine.Transform | Protected |
| _pitchRotator | UnityEngine.Transform | Protected |
| <HasSetUp>k__BackingField | System.Boolean | Private |
| _targetYaw | System.Single | Public |
| _targetPitch | System.Single | Public |
| _moveSpeed | System.Single | Public |
| _ikMovementHash | System.Int32 | Private |
| _shipTurretMove | WildSkies.Audio.AudioType | Private |
| _shipTurretMoveId | System.Int32 | Private |
| _previousMovementSpeed | UnityEngine.Vector2 | Private |
| _speedMultiplier | System.Single | Private |
| _hasSetup | System.Boolean | Private |
| _currentPilot | Bossa.Dynamika.Character.DynamikaCharacter | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IkTargets | Bossa.Dynamika.IK.IKTargetTransform[] | Public |
| AimDirection | UnityEngine.Vector3 | Public |
| CameraSettings | Bossa.Cinematika.Controllers.PilotCinematikaController/Settings | Public |
| CameraTarget | UnityEngine.Transform | Public |
| Sync | Coherence.Toolkit.CoherenceSync | Public |
| Interactable | NetworkInteractable | Public |
| HasSetUp | System.Boolean | Public |

## Methods

- **get_IkTargets()**: Bossa.Dynamika.IK.IKTargetTransform[] (Public)
- **get_AimDirection()**: UnityEngine.Vector3 (Public)
- **set_AimDirection(UnityEngine.Vector3 value)**: System.Void (Public)
- **get_CameraSettings()**: Bossa.Cinematika.Controllers.PilotCinematikaController/Settings (Public)
- **get_CameraTarget()**: UnityEngine.Transform (Public)
- **get_Sync()**: Coherence.Toolkit.CoherenceSync (Public)
- **get_Interactable()**: NetworkInteractable (Public)
- **get_HasSetUp()**: System.Boolean (Public)
- **set_HasSetUp(System.Boolean value)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **SetPilot(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Public)
- **TakeControl(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Public)
- **SetRangeOfMotion(System.Single pitch, System.Single yaw)**: System.Void (Public)
- **StopPiloting()**: System.Void (Public)
- **FixedUpdate()**: System.Void (Public)
- **FirePressed()**: System.Void (Public)
- **FireReleased()**: System.Void (Public)
- **FireHeld()**: System.Void (Public)
- **OnDestroy()**: System.Void (Protected)
- **SetAudioState(System.Boolean isOn)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

