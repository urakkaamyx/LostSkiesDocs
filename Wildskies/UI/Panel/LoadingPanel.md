# Wildskies.UI.Panel.LoadingPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| LoadingProgessText | System.String | Public |
| _viewModel | Wildskies.UI.Panel.LoadingPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.LoadingPanelPayload | Private |
| _uiService | UISystem.IUIService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _sceneService | WildSkies.Service.SceneService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _fadeOutTimer | System.Single | Private |
| _currentSpinDirection | System.Int32 | Private |
| _isLoading | System.Boolean | Private |
| _isWaitingForInput | System.Boolean | Private |
| _hasFaded | System.Boolean | Private |
| _startAlphas | System.Single[] | Private |
| _currentFadeAlpha | System.Single | Private |
| _currentFadeColor | UnityEngine.Color | Private |
| _transparentWhite | UnityEngine.Color | Private |
| WaitTime | System.Single | Private |
| _waitTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |
| IsLoading | System.Boolean | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **get_IsLoading()**: System.Boolean (Public)
- **UpdateLoadingText(System.String text)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **SetAlphas(System.Single alpha)**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **WorldLoadingComplete(System.String arg1, System.Int32 arg2, System.Int32 arg3)**: System.Void (Private)
- **TogglePlayerKinematic(System.Boolean isKinematic)**: System.Void (Private)
- **FadeOut()**: System.Void (Private)
- **OnClickSteamWishlist()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

