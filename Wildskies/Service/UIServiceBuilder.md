# WildSkies.Service.UIServiceBuilder

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _errorCode | System.Int32 | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _finishedInitialisation | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **Build()**: UISystem.IUIService (Public)
- **CheckErrorCode()**: System.Int32 (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **OnServiceReady(UISystem.IUIService uiService, System.Int32 errorCode)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

