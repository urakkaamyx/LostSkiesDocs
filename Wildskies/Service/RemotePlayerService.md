# WildSkies.Service.RemotePlayerService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <RemotePlayerRegistered>k__BackingField | System.Action`1<PlayerNetwork> | Private |
| <RemotePlayerUnRegistered>k__BackingField | System.Action`1<PlayerNetwork> | Private |
| _remotePlayers | System.Collections.Generic.List`1<PlayerNetwork> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| RemotePlayerRegistered | System.Action`1<PlayerNetwork> | Public |
| RemotePlayerUnRegistered | System.Action`1<PlayerNetwork> | Public |
| RemotePlayers | System.Collections.Generic.List`1<PlayerNetwork> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_RemotePlayerRegistered()**: System.Action`1<PlayerNetwork> (Public)
- **set_RemotePlayerRegistered(System.Action`1<PlayerNetwork> value)**: System.Void (Public)
- **get_RemotePlayerUnRegistered()**: System.Action`1<PlayerNetwork> (Public)
- **set_RemotePlayerUnRegistered(System.Action`1<PlayerNetwork> value)**: System.Void (Public)
- **get_RemotePlayers()**: System.Collections.Generic.List`1<PlayerNetwork> (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RegisterRemotePlayer(PlayerNetwork remotePlayer)**: System.Void (Public)
- **UnregisterRemotePlayer(PlayerNetwork remotePlayer)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

