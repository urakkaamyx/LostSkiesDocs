# WildSkies.Mediators.SessionNetworkFxMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _projectileService | WildSkies.Service.ProjectileService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _vfxPoolService | WildSkies.Service.VfxPoolService | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |

## Methods

- **Initialise(WildSkies.Service.SessionService sessionService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.ProjectileService projectileService, WildSkies.Service.VfxPoolService vfxPoolService, WildSkies.Service.AudioService audioService, WildSkies.Service.NetworkFxService networkFxService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **OnLocalClientConnected(Coherence.Connection.ClientID clientID)**: System.Void (Private)
- **OnLocalClientDisconnected(Coherence.Connection.ConnectionCloseReason connectionCloseReason, System.Boolean attemptAutoReconnect)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

