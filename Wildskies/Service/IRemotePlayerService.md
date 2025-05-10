# WildSkies.Service.IRemotePlayerService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| RemotePlayers | System.Collections.Generic.List`1<PlayerNetwork> | Public |
| RemotePlayerRegistered | System.Action`1<PlayerNetwork> | Public |
| RemotePlayerUnRegistered | System.Action`1<PlayerNetwork> | Public |

## Methods

- **get_RemotePlayers()**: System.Collections.Generic.List`1<PlayerNetwork> (Public)
- **get_RemotePlayerRegistered()**: System.Action`1<PlayerNetwork> (Public)
- **set_RemotePlayerRegistered(System.Action`1<PlayerNetwork> value)**: System.Void (Public)
- **get_RemotePlayerUnRegistered()**: System.Action`1<PlayerNetwork> (Public)
- **set_RemotePlayerUnRegistered(System.Action`1<PlayerNetwork> value)**: System.Void (Public)
- **RegisterRemotePlayer(PlayerNetwork remotePlayer)**: System.Void (Public)
- **UnregisterRemotePlayer(PlayerNetwork remotePlayer)**: System.Void (Public)

