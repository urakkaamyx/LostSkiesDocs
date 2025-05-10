# WildSkies.Mediators.TelemetrySessionInfoMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sessionService | WildSkies.Service.SessionService | Private |
| _telemetryService | WildSkies.Service.ITelemetryService | Private |

## Methods

- **Initialise(WildSkies.Service.ITelemetryService telemetryService, WildSkies.Service.SessionService sessionService)**: System.Void (Public)
- **OnEndSession(WildSkies.Service.SessionService/DisconnectionReason arg1, Coherence.Connection.ConnectionCloseReason arg2)**: System.Void (Private)
- **SetTelemetryParameters(Coherence.Connection.ClientID obj)**: System.Void (Private)
- **UpdateSubPartyID(System.Guid subpartyId)**: System.Void (Private)
- **GetPartyID()**: System.String (Private)
- **GetSubPartyID()**: System.String (Private)
- **GetIslandID()**: System.String (Private)
- **Terminate()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

