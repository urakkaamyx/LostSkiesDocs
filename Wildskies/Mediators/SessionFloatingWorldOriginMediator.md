# WildSkies.Mediators.SessionFloatingWorldOriginMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sessionService | WildSkies.Service.SessionService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _loggingService | LoggingService | Private |

## Methods

- **Initialise(WildSkies.Service.SessionService sessionService, WildSkies.Service.FloatingWorldOriginService floatingWorldOriginService, LoggingService loggingService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnFloatingWorldOriginShifted(UnityEngine.Vector3 floatingWorldOrigin)**: System.Void (Private)
- **OnNetworkFloatingOriginShifted(UnityEngine.Vector3 floatingWorldOrigin)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

