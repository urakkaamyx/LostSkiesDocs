# WildSkies.Service.ServiceEvents

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| AllServicesReady | System.Action | Private |
| ServiceFailedToInitialise | System.Action`1<System.Int32> | Private |

## Methods

- **add_AllServicesReady(System.Action value)**: System.Void (Public)
- **remove_AllServicesReady(System.Action value)**: System.Void (Public)
- **add_ServiceFailedToInitialise(System.Action`1<System.Int32> value)**: System.Void (Public)
- **remove_ServiceFailedToInitialise(System.Action`1<System.Int32> value)**: System.Void (Public)
- **TriggerAllServicesReady()**: System.Void (Public)
- **TriggerServiceFailedToInitialise(System.Int32 errorCode)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

