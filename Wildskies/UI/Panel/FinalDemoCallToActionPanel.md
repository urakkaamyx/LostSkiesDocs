# Wildskies.UI.Panel.FinalDemoCallToActionPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _networkService | WildSkies.Service.NetworkService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _viewModel | Wildskies.UI.Panel.FinalDemoCallToActionPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.FinalDemoCallToActionPanelPayload | Private |
| _videoClipOperation | UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.Video.VideoClip> | Private |
| _isFullScreen | System.Boolean | Private |
| _originalAnchorMin | UnityEngine.Vector2 | Private |
| _originalAnchorMax | UnityEngine.Vector2 | Private |
| _originalPivot | UnityEngine.Vector2 | Private |
| _originalSizeDelta | UnityEngine.Vector2 | Private |
| _originalAnchoredPosition | UnityEngine.Vector2 | Private |
| _defaultWidth | System.Single | Private |
| _defaultHeight | System.Single | Private |
| _aspectRatioFitter | UnityEngine.UI.AspectRatioFitter | Private |
| _videoAspectRatio | System.Single | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _uiService | UISystem.IUIService | Private |
| _loc | WildSkies.Service.LocalisationService | Private |
| _videoRectTransform | UnityEngine.RectTransform | Private |
| _videoParentImage | UnityEngine.UI.Image | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **OnDisable()**: System.Void (Private)
- **OpenWishlistPage()**: System.Void (Public)
- **QuitToMainMenu()**: System.Void (Public)
- **QuitToDesktop()**: System.Void (Public)
- **ToggleFullscreenVideo()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **CloseFinalDemoCallToActionPanel()**: System.Void (Public)
- **VideoLoadCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.Video.VideoClip> obj)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

