# WildSkies.Puzzles.RelayNodeControl

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| RequestInteract | System.EventHandler | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _relayNode | WildSkies.Puzzles.RelayNode | Private |
| _cameraTarget | UnityEngine.Transform | Private |
| _playerAttachPoint | UnityEngine.Transform | Private |
| _ikTargets | Bossa.Dynamika.IK.IKTargetTransform[] | Private |
| _cameraSettings | Bossa.Cinematika.Controllers.PilotCinematikaController/Settings | Private |
| _base | UnityEngine.Transform | Private |
| _barrel | UnityEngine.Transform | Private |
| _isControlled | System.Boolean | Private |
| _isControlledBy | Bossa.Dynamika.Character.DynamikaCharacter | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| BaseRotation | UnityEngine.Quaternion | Public |
| BarrelRotation | UnityEngine.Quaternion | Public |

## Methods

- **add_RequestInteract(System.EventHandler value)**: System.Void (Public)
- **remove_RequestInteract(System.EventHandler value)**: System.Void (Public)
- **get_BaseRotation()**: UnityEngine.Quaternion (Public)
- **set_BaseRotation(UnityEngine.Quaternion value)**: System.Void (Public)
- **get_BarrelRotation()**: UnityEngine.Quaternion (Public)
- **set_BarrelRotation(UnityEngine.Quaternion value)**: System.Void (Public)
- **Interact(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **CanInteract()**: System.Boolean (Public)
- **GetGameInteractId()**: System.String (Public)
- **StopControl()**: System.Void (Public)
- **ResetPosition()**: System.Void (Public)
- **SetRotations(UnityEngine.Quaternion baseRotation, UnityEngine.Quaternion barrelRotation)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

