# Wildskies.UI.Panel.GallDiscDatapadViewer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| EXPECTED_CHARACTER_LIMIT | System.Int32 | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |
| MessageText | TMPro.TextMeshProUGUI | Private |
| DatapadBackgroundBlurCurtain | UnityEngine.MeshRenderer | Private |
| AnimatedDatapadContainer | UnityEngine.UI.Image | Private |
| DatapadCameraViewPitch | System.Single | Public |
| DatapadCameraViewYaw | System.Single | Public |
| _datapadOffset | UnityEngine.Vector3 | Private |
| _datapadYawOffset | System.Single | Private |
| _datapadViewDistance | System.Single | Private |
| _datapadViewSmoothSpeed | System.Single | Private |
| _datapadViewShoulderModifier | System.Single | Private |
| _datapadViewUpModifier | System.Single | Private |
| _cameraViewSpeedY | System.Single | Private |
| _cameraViewSpeedX | System.Single | Private |
| _backgroundBlurDuration | System.Single | Private |
| _backgroundBlurIntensity | System.Single | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _dynamikaCharacter | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _tweeners | System.Collections.Generic.List`1<DG.Tweening.Tweener> | Private |
| Smoothness | System.Int32 | Private |
| _interaction | WildSkies.Player.Interactions.DatapadInteraction | Private |
| _targetPlayerIsLocal | System.Boolean | Private |
| _gallDisc | Utilities.Weapons.GallDisc | Private |

## Methods

- **ActivateAndBindToCharacter(Utilities.Weapons.GallDisc gallDisc, Bossa.Dynamika.Character.DynamikaCharacter character, WildSkies.Player.Interactions.DatapadInteraction interaction, System.Boolean targetPlayerIsLocal)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **UpdateUI(UnityEngine.Vector3 datapadOffset, System.String message)**: System.Void (Private)
- **UpdateCamera()**: System.Void (Private)
- **ApplyDatapadCameraPosition()**: System.Void (Private)
- **UpdateBackgroundDepthBlurUp()**: System.Void (Private)
- **SetMessage(System.String message)**: System.Void (Private)
- **Deactivate()**: System.Void (Public)
- **ClearTweeners()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)
- **<UpdateUI>b__26_0()**: System.String (Private)
- **<UpdateUI>b__26_1(System.String x)**: System.Void (Private)
- **<UpdateBackgroundDepthBlurUp>b__29_0()**: System.Single (Private)
- **<UpdateBackgroundDepthBlurUp>b__29_1(System.Single x)**: System.Void (Private)

