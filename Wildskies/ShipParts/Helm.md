# WildSkies.ShipParts.Helm

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <CurrentPilot>k__BackingField | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| <Ship>k__BackingField | WildSkies.Ship.ShipControl | Private |
| _uiService | UISystem.IUIService | Private |
| _cameraSettings | Bossa.Cinematika.Controllers.PilotCinematikaController/Settings | Private |
| _hardAttachTarget | UnityEngine.Transform | Private |
| _cameraTarget | UnityEngine.Transform | Private |
| _ikTargets | Bossa.Dynamika.IK.IKTargetTransform[] | Private |
| _controlStick | UnityEngine.Transform | Private |
| _controlStickAngleRanges | UnityEngine.Vector3 | Private |
| _throttleHandle | UnityEngine.Transform | Private |
| _throttleAngleRange | System.Single | Private |
| _verticalMarker | UnityEngine.Transform | Private |
| _verticalRange | System.Single | Private |
| _localPlayer | WildSkies.Player.ILocalPlayer | Private |
| _controlStickStartAngles | UnityEngine.Vector3 | Private |
| _verticalMarkerStartPosition | UnityEngine.Vector3 | Private |
| _throttleHandleStartAngles | UnityEngine.Vector3 | Private |
| _hullObject | WildSkies.Gameplay.ShipBuilding.ShipHullObject | Private |
| _helmNotAttachedString | UnityEngine.Localization.LocalizedString | Private |
| _uncraftedSectionsRemovedString | UnityEngine.Localization.LocalizedString | Private |
| _missingCoreCannotPilotString | UnityEngine.Localization.LocalizedString | Private |
| _shipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CameraSettings | Bossa.Cinematika.Controllers.PilotCinematikaController/Settings | Public |
| CurrentPilot | Bossa.Dynamika.Character.DynamikaCharacter | Public |
| Ship | WildSkies.Ship.ShipControl | Public |
| LeftHandPose | System.String | Public |
| RightHandPose | System.String | Public |
| IkTargets | Bossa.Dynamika.IK.IKTargetTransform[] | Public |
| Sync | Coherence.Toolkit.CoherenceSync | Public |
| CameraTarget | UnityEngine.Transform | Public |

## Methods

- **get_CameraSettings()**: Bossa.Cinematika.Controllers.PilotCinematikaController/Settings (Public)
- **get_CurrentPilot()**: Bossa.Dynamika.Character.DynamikaCharacter (Public)
- **set_CurrentPilot(Bossa.Dynamika.Character.DynamikaCharacter value)**: System.Void (Public)
- **get_Ship()**: WildSkies.Ship.ShipControl (Public)
- **set_Ship(WildSkies.Ship.ShipControl value)**: System.Void (Public)
- **get_LeftHandPose()**: System.String (Public)
- **get_RightHandPose()**: System.String (Public)
- **get_IkTargets()**: Bossa.Dynamika.IK.IKTargetTransform[] (Public)
- **get_Sync()**: Coherence.Toolkit.CoherenceSync (Public)
- **get_CameraTarget()**: UnityEngine.Transform (Public)
- **Awake()**: System.Void (Protected)
- **CanInteract()**: System.Boolean (Public)
- **Interact(Bossa.Dynamika.Character.DynamikaCharacter characterInteract)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **StopPiloting()**: System.Void (Public)
- **SetupShipReference(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

