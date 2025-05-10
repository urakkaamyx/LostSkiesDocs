# WildSkies.Mediators.UISessionMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _ui | UISystem.IUIService | Private |
| _session | WildSkies.Service.SessionService | Private |
| _scene | WildSkies.Service.SceneService | Private |

## Methods

- **Initialise(UISystem.IUIService uiservice, WildSkies.Service.SessionService sessionService, WildSkies.Service.SceneService scene)**: System.Void (Public)
- **OnSceneHasChanged(WildSkies.Service.SceneService/SceneLoadState state)**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **OnLocalClientDisconnected(Coherence.Connection.ConnectionCloseReason connectionCloseReason, System.Boolean attemptingReconnecting)**: System.Void (Private)
- **OnRemotePlayerJoined(System.String clientId, System.String playerName)**: System.Void (Private)
- **OnRemotePlayerLeft(Coherence.Connection.ClientID clientId, System.String playerName)**: System.Void (Private)
- **OnAttemptingReconnect()**: System.Void (Private)
- **OnLocalPlayerReconnectedAfterDisconnect()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

