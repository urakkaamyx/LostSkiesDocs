# WildSkies.Mediators.SceneChangeNetworkMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _scene | WildSkies.Service.SceneService | Private |
| _network | WildSkies.Service.NetworkService | Private |
| _session | WildSkies.Service.SessionService | Private |
| _ui | UISystem.IUIService | Private |
| _localisation | WildSkies.Service.LocalisationService | Private |
| _pendingRequestedSceneChange | System.Boolean | Private |
| _startNewSessionOnSceneLoad | System.Boolean | Private |
| _displayFailedToReconnectDialog | System.Boolean | Private |
| _error | System.String | Private |
| _disconnecting | System.Boolean | Private |
| _playerIsOwner | System.Boolean | Private |
| FrameDelayToShowError | System.Int32 | Private |

## Methods

- **Initialise(WildSkies.Service.SceneService scene, WildSkies.Service.NetworkService network, WildSkies.Service.SessionService session, UISystem.IUIService uiService, WildSkies.Service.LocalisationService localisationService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnSceneChanged(WildSkies.Service.SceneService/SceneLoadState loadState)**: System.Void (Private)
- **ShowNetworkErrorPanel()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnRoomConnectionRequest(System.Boolean playerIsOwner, System.Boolean requireSceneChange)**: System.Void (Private)
- **OnSessionEnded(WildSkies.Service.SessionService/DisconnectionReason disconnectionReason, Coherence.Connection.ConnectionCloseReason connectionCloseReason)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

