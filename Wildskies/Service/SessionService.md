# WildSkies.Service.SessionService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _events | SessionEvents | Private |
| RoomName | System.String | Public |
| _remotePlayerConnections | System.Collections.Generic.List`1<WildSkies.Service.SessionService/RemotePlayerConnection> | Private |
| _disconnectedPlayers | System.Collections.Generic.List`1<WildSkies.Service.SessionService/RemotePlayerConnection> | Private |
| _monoBridge | Coherence.Toolkit.CoherenceBridge | Private |
| _localConnection | Coherence.Toolkit.CoherenceClientConnection | Private |
| _replicatorConnection | Coherence.Toolkit.CoherenceClientConnection | Private |
| _simulatorConnection | Coherence.Toolkit.CoherenceClientConnection | Private |
| _ownerPlatformId | System.String | Private |
| _privacyLevel | System.String | Private |
| _roomData | Coherence.Cloud.RoomData | Private |
| _currentReconnectionAttempts | System.Int32 | Private |
| _attemptAutoReconnect | System.Boolean | Private |
| _isReconnecting | System.Boolean | Private |
| _ownerIsDisconnected | System.Boolean | Private |
| _playerIsOwner | System.Boolean | Private |
| SessionId | System.String | Public |
| _disconnecting | System.Boolean | Private |
| _currentOwnerIdRequestCount | System.Int32 | Private |
| _steamNetworkingEndPoint | Coherence.Connection.EndpointData | Private |
| _activeLobby | System.Nullable`1<Steamworks.Data.Lobby> | Private |
| _currentWorldId | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Events | SessionEvents | Public |
| RemotePlayerConnections | System.Collections.Generic.List`1<WildSkies.Service.SessionService/RemotePlayerConnection> | Public |
| OwnerPlatformId | System.String | Public |
| PrivacyLevel | System.String | Public |
| LocalClientID | Coherence.Connection.ClientID | Public |
| LocalClientIDFromMonoBridge | System.Nullable`1<Coherence.Connection.ClientID> | Public |
| RoomID | System.UInt16 | Public |
| MonoBridge | Coherence.Toolkit.CoherenceBridge | Public |
| PlayerIsOwner | System.Boolean | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| RoomData | Coherence.Cloud.RoomData | Public |

## Methods

- **get_Events()**: SessionEvents (Public)
- **set_Events(SessionEvents value)**: System.Void (Private)
- **get_RemotePlayerConnections()**: System.Collections.Generic.List`1<WildSkies.Service.SessionService/RemotePlayerConnection> (Public)
- **get_OwnerPlatformId()**: System.String (Public)
- **get_PrivacyLevel()**: System.String (Public)
- **get_LocalClientID()**: Coherence.Connection.ClientID (Public)
- **get_LocalClientIDFromMonoBridge()**: System.Nullable`1<Coherence.Connection.ClientID> (Public)
- **get_RoomID()**: System.UInt16 (Public)
- **get_MonoBridge()**: Coherence.Toolkit.CoherenceBridge (Public)
- **get_PlayerIsOwner()**: System.Boolean (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_RoomData()**: Coherence.Cloud.RoomData (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **StartNewSession(UnityEngine.SceneManagement.Scene scene, Coherence.Cloud.RoomData roomData, System.Boolean playerIsOwner)**: System.Void (Public)
- **StartNewSession(UnityEngine.SceneManagement.Scene scene, Coherence.Cloud.RoomData roomData, System.Boolean playerIsOwner, System.Nullable`1<Steamworks.Data.Lobby> lobby)**: System.Void (Public)
- **SetCurrentWorldId(System.String worldId)**: System.Void (Public)
- **ConnectionError(Coherence.Toolkit.CoherenceBridge monoBridge, Coherence.Connection.ConnectionException connectionException)**: System.Void (Private)
- **ReceivedOwnerReconnected(System.String ownerId)**: System.Void (Public)
- **IsLocalClientConnected()**: System.Boolean (Public)
- **NumberOfConnections()**: System.Int32 (Public)
- **IsInitialised()**: System.Boolean (Public)
- **Disconnect(WildSkies.Service.SessionService/DisconnectionReason reason, Coherence.Connection.ConnectionCloseReason connectionCloseReason)**: System.Void (Public)
- **DebugDisconnect()**: System.Void (Public)
- **ReceiveRemotePlayerDetails(System.String name, System.String clientId)**: System.Void (Public)
- **ConnectionCreated(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **ConnectionDestroyed(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **RemotePlayerJoined(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **RemotePlayerLeft(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **GetRemotePlayerConnection(System.String clientId, System.Boolean includeDisconnected, WildSkies.Service.SessionService/RemotePlayerConnection& rpc)**: System.Boolean (Private)
- **ReplicatorConnectionCreated(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **ReplicatorConnectionDestroyed(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **SimulatorConnectionCreated(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **SimulatorConnectionDestroyed(Coherence.Toolkit.CoherenceClientConnection clientConnection)**: System.Void (Private)
- **LocalClientConnected(Coherence.Toolkit.CoherenceBridge monoBridge)**: System.Void (Private)
- **LocalClientDisconnected(Coherence.Toolkit.CoherenceBridge monoBridge, Coherence.Connection.ConnectionCloseReason connectionCloseReason)**: System.Void (Private)
- **AttemptReconnect(Coherence.Connection.ConnectionCloseReason connectionCloseReason)**: Cysharp.Threading.Tasks.UniTask (Private)
- **RequestRemotePlayerDetails(System.String clientId)**: Cysharp.Threading.Tasks.UniTask (Private)
- **SendOwnerReconnected()**: System.Void (Private)
- **FloatingOriginShifted(Coherence.Toolkit.FloatingOriginShiftArgs floatingOriginShiftArgs)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

