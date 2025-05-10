# WildSkies.Mediators.SessionCameraImpulseMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sessionService | WildSkies.Service.SessionService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |

## Methods

- **Initialise(WildSkies.Service.SessionService sessionService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.CameraImpulseService cameraImpulseService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnLocalClientConnected(Coherence.Connection.ClientID clientID)**: System.Void (Private)
- **OnLocalClientDisconnected(Coherence.Connection.ConnectionCloseReason connectionCloseReason, System.Boolean attemptAutoReconnect)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

