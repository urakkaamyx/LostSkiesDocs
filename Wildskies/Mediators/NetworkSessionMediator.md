# WildSkies.Mediators.NetworkSessionMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _session | WildSkies.Service.SessionService | Private |
| _network | WildSkies.Service.NetworkService | Private |

## Methods

- **Initialise(WildSkies.Service.SessionService sessionService, WildSkies.Service.NetworkService networkService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **NewSessionStarted(UnityEngine.SceneManagement.Scene scene, Coherence.Cloud.RoomData roomData, System.Boolean playerIsOwner, System.Nullable`1<Steamworks.Data.Lobby> lobby)**: System.Void (Private)
- **NewSessionStarted(UnityEngine.SceneManagement.Scene scene, Coherence.Cloud.RoomData roomData, System.Boolean playerIsOwner)**: System.Void (Private)
- **OnOwnerReconnected(Coherence.Connection.ClientID clientID)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

