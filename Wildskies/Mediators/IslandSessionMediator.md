# WildSkies.Mediators.IslandSessionMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _islandService | WildSkies.Service.IIslandService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _networkCommandService | NetworkCommandService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _localClientId | System.String | Private |

## Methods

- **Initialise(WildSkies.Service.IIslandService islandService, WildSkies.Service.SessionService sessionService, NetworkCommandService networkCommandService, WildSkies.Service.WildSkiesInstantiationService instantiationService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnLocalClientConnected(Coherence.Connection.ClientID clientID)**: System.Void (Private)
- **OnRemotePlayerLeft(Coherence.Connection.ClientID clientID, System.String playerName)**: System.Void (Private)
- **RemotePlayerLeft(Coherence.Connection.ClientID clientID, System.String playerName)**: System.Void (Private)
- **OnReceiveIslandAuthorityState(System.Collections.Generic.Dictionary`2<System.String,System.String> authoredIslands)**: System.Void (Private)
- **OnIslandAuthorityRequested(System.String islandAuthorityId, System.String islandName)**: System.Void (Private)
- **OnIslandAuthorityReleased(System.String islandAuthorityId, System.String islandName)**: System.Void (Private)
- **SendIslandAuthorityRequestWithDelay(System.String islandAuthorityId, System.String islandName)**: System.Void (Private)
- **OnReceiveIslandAuthorityRequest(System.String islandAuthorityId, System.String islandName)**: System.Void (Private)
- **OnReceiveIslandAuthorityRelease(System.String islandAuthorityId, System.String islandName)**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<SendIslandAuthorityRequestWithDelay>b__13_0()**: System.Boolean (Private)

