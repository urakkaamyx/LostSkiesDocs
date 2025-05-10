# WildSkies.ShipParts.MapTable

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Position | UnityEngine.Vector2 | Public |
| Zoom | System.Single | Public |
| _shipIconSprite | UnityEngine.Sprite | Private |
| _playerIconSprite | UnityEngine.Sprite | Private |
| _refreshPlayersDelay | System.Single | Private |
| _colors | UnityEngine.Color[] | Private |
| _accelSpeed | System.Single | Private |
| _decelSpeedHeld | System.Single | Private |
| _decelSpeedFree | System.Single | Private |
| _zoomDecelSpeed | System.Single | Private |
| _minZoom | System.Single | Private |
| _maxZoom | System.Single | Private |
| _minZoomSpeed | System.Single | Private |
| _maxZoomSpeed | System.Single | Private |
| _moveSpeedMultiplier | System.Single | Private |
| _scrollMultiplier | System.Single | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _mapTableVisuals | WildSkies.MapTable.MapTableVisuals | Private |
| _infoLayer | WildSkies.MapTable.MapTableInfoLayer | Private |
| _shipService | WildSkies.Service.ShipsService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _remotePlayerService | WildSkies.Service.IRemotePlayerService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _shipInfoData | WildSkies.MapTable.MapTableInfoLayer/MapInfoData | Private |
| _playerInfoDatas | System.Collections.Generic.Dictionary`2<PlayerNetwork,WildSkies.MapTable.MapTableInfoLayer/MapInfoData> | Private |
| _islandInfoDatas | System.Collections.Generic.List`1<WildSkies.MapTable.MapTableInfoLayer/MapInfoData> | Private |
| _initialized | System.Boolean | Private |
| _refreshPlayersTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AccelSpeed | System.Single | Public |
| DecelSpeedFree | System.Single | Public |
| MinZoomSpeed | System.Single | Public |
| DecelSpeedHeld | System.Single | Public |
| MaxZoomSpeed | System.Single | Public |
| ScrollMultiplier | System.Single | Public |
| ZoomDecelSpeed | System.Single | Public |
| NoveSpeedMultiplier | System.Single | Public |
| InvZoomNormalized | System.Single | Public |
| PlayerInfoDatas | System.Collections.Generic.Dictionary`2<PlayerNetwork,WildSkies.MapTable.MapTableInfoLayer/MapInfoData> | Public |

## Methods

- **get_AccelSpeed()**: System.Single (Public)
- **get_DecelSpeedFree()**: System.Single (Public)
- **get_MinZoomSpeed()**: System.Single (Public)
- **get_DecelSpeedHeld()**: System.Single (Public)
- **get_MaxZoomSpeed()**: System.Single (Public)
- **get_ScrollMultiplier()**: System.Single (Public)
- **get_ZoomDecelSpeed()**: System.Single (Public)
- **get_NoveSpeedMultiplier()**: System.Single (Public)
- **get_InvZoomNormalized()**: System.Single (Public)
- **get_PlayerInfoDatas()**: System.Collections.Generic.Dictionary`2<PlayerNetwork,WildSkies.MapTable.MapTableInfoLayer/MapInfoData> (Public)
- **Start()**: System.Void (Private)
- **Init()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **RefreshPlayers()**: System.Void (Private)
- **RefreshPlayersCmd()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<Init>b__50_0()**: System.Boolean (Private)
- **<Init>b__50_1()**: System.Boolean (Private)
- **<Init>b__50_2()**: System.Boolean (Private)
- **<Init>b__50_3(System.String s, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **<Init>b__50_4(System.String s, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **<Init>b__50_5(System.String s, System.String s1)**: System.Void (Private)
- **<Init>b__50_6(Coherence.Connection.ClientID s, System.String s1)**: System.Void (Private)
- **<OnDestroy>b__51_0(System.String s, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **<OnDestroy>b__51_1(System.String s, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **<OnDestroy>b__51_2(System.String s, System.String s1)**: System.Void (Private)
- **<OnDestroy>b__51_3(Coherence.Connection.ClientID s, System.String s1)**: System.Void (Private)

