# WildSkies.Service.NetworkService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| NewSessionStartRequest | System.Action`4<UnityEngine.SceneManagement.Scene,Coherence.Cloud.RoomData,System.Boolean,System.Nullable`1<Steamworks.Data.Lobby>> | Public |
| UseSteamNetworking | System.Boolean | Public |
| UseRSL | System.Boolean | Public |
| Error | System.Action`1<LocalisedStringID> | Public |
| RoomConnectionRequest | System.Action`2<System.Boolean,System.Boolean> | Public |
| _maxPlayers | System.Int32 | Private |
| _availableRooms | System.Collections.Generic.List`1<Coherence.Cloud.RoomData> | Private |
| _roomDataForJoin | Coherence.Cloud.RoomData | Private |
| _lobbyForJoin | Steamworks.Data.Lobby | Private |
| MaxCoherenceCallAttempts | System.Int32 | Public |
| RetryCoherenceCallDelay | System.Int32 | Public |
| _currentCallAttemptsLock | System.Threading.SemaphoreSlim | Private |
| _currentCallAttempts | System.Int32 | Private |
| _ongoingJoinRequestProcessing | System.Boolean | Private |
| _roomsService | Coherence.Cloud.IRoomsService | Private |
| _coherenceCloudService | Coherence.Cloud.CloudService | Private |
| _localRoomsService | Coherence.Cloud.ReplicationServerRoomsService | Private |
| checkCloudReadinessDelayMs | System.Int32 | Private |
| _rsl | Coherence.ReplicationServerLite | Private |
| _cmdProcess | System.Diagnostics.Process | Private |
| _showCmd | System.Boolean | Private |
| _cachedLocalIp | System.String | Private |
| _rs | Coherence.Toolkit.ReplicationServer.IReplicationServer | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| RoomDataForJoin | Coherence.Cloud.RoomData | Public |
| MaxPlayers | System.Int32 | Public |
| OngoingJoinRequestProcessDepending | System.Boolean | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_RoomDataForJoin()**: Coherence.Cloud.RoomData (Public)
- **get_MaxPlayers()**: System.Int32 (Public)
- **get_OngoingJoinRequestProcessDepending()**: System.Boolean (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **HasAuthority(Coherence.Toolkit.CoherenceSync coherenceSync)**: System.Boolean (Public)
- **HandleJoinRequest(System.String joinInfo)**: System.Threading.Tasks.Task (Public)
- **JoinNewRoomWithTag(System.String roomName, System.String[] tags)**: System.Threading.Tasks.Task (Public)
- **CreateTaggedRoomOptions(System.String roomName, System.String[] tags)**: Coherence.Cloud.RoomCreationOptions (Public)
- **CreateAndJoinNewRoom(System.String roomName, Coherence.Cloud.RoomCreationOptions options, System.Boolean requireSceneChange)**: System.Threading.Tasks.Task (Public)
- **CreateRoom(System.String roomName, Coherence.Cloud.RoomCreationOptions options)**: System.Threading.Tasks.Task`1<System.Nullable`1<Coherence.Cloud.RoomData>> (Public)
- **SetupRoomData(Coherence.Cloud.RoomData selectedRoom, System.Boolean playerIsOwner, System.Boolean requireSceneChange, System.Boolean checkForJoinRequest)**: System.Void (Public)
- **SetupLobbyData(Steamworks.Data.Lobby selectedLobby)**: System.Void (Public)
- **StartNewSession(UnityEngine.SceneManagement.Scene scene, System.Boolean playerIsOwner)**: System.Void (Public)
- **ResolveRoomsService(System.Boolean local)**: System.Threading.Tasks.Task (Private)
- **GetRooms(System.String region, System.String[] tags)**: System.Threading.Tasks.Task`1<System.Collections.Generic.List`1<Coherence.Cloud.RoomData>> (Public)
- **StartProcessJoinRequest()**: System.Boolean (Private)
- **StopReplicationServer()**: System.Void (Public)
- **StartReplicationServer()**: System.Void (Public)
- **InitialiseLocalRoomService(System.String ip, System.Nullable`1<System.Int32> port)**: System.Void (Public)
- **GetLocalIpAddress()**: System.String (Public)
- **IsRoomReady(System.String room)**: System.Threading.Tasks.Task`1<System.Nullable`1<System.Boolean>> (Public)
- **GetRoom(System.String room)**: System.Threading.Tasks.Task`1<System.Nullable`1<Coherence.Cloud.RoomData>> (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

