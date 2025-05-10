# WildSkies.Mediators.SessionLargeMessageMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sessionService | WildSkies.Service.SessionService | Private |
| _largeMessageService | WildSkies.Service.LargeMessageService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |

## Methods

- **Initialise(WildSkies.Service.SessionService sessionService, WildSkies.Service.LargeMessageService largeMessageService, WildSkies.Service.WildSkiesInstantiationService instantiationService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnLocalClientConnected(Coherence.Connection.ClientID clientID)**: System.Void (Private)
- **OnLocalClientDisconnected(Coherence.Connection.ConnectionCloseReason connectionCloseReason, System.Boolean attemptAutoReconnect)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

