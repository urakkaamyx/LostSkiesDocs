# WildSkies.Service.BaseContextInstaller

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ServiceEvents | WildSkies.Service.ServiceEvents | Public |
| _pendingServices | System.Collections.Generic.List`1<WildSkies.Service.Interface.IAsyncService> | Private |
| _initialisedServices | System.Collections.Generic.List`1<WildSkies.Service.Interface.IBaseService> | Private |
| _updateLogic | UpdateLogic | Private |
| _contextBindingComplete | System.Boolean | Private |
| _allServicesFinishedInitialising | System.Boolean | Private |
| _lastErrorCode | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AllServicesFinishedInitialising | System.Boolean | Public |
| LastErrorCode | System.Int32 | Public |

## Methods

- **get_AllServicesFinishedInitialising()**: System.Boolean (Public)
- **get_LastErrorCode()**: System.Int32 (Public)
- **InstallBindings()**: System.Void (Public)
- **BindService(T service, System.Boolean bindBaseType)**: System.Boolean (Protected)
- **RegisterBoundService(System.Type serviceType)**: System.Boolean (Protected)
- **IsServiceInInitalizedList(System.Type serviceType)**: System.Boolean (Protected)
- **BindServiceAsType(T service)**: System.Boolean (Protected)
- **SetErrorCode(T service, WildSkies.Service.Interface.IService& serviceCast)**: System.Boolean (Private)
- **BuildAndBindService(WildSkies.Service.Interface.IServiceBuilder`1<T> serviceBuilder)**: System.Void (Protected)
- **HandleAsyncServices(System.Object service)**: System.Void (Private)
- **IsErrorCodeValid(System.Type serviceType, System.Int32 errorCode)**: System.Boolean (Private)
- **AsyncServiceFinished(WildSkies.Service.Interface.IAsyncService asyncService, System.Int32 errorCode)**: System.Void (Private)
- **ContextBindingComplete()**: System.Void (Protected)
- **CheckIfAllServicesAreReady()**: System.Void (Protected)
- **AllServicesHaveInstalled()**: System.Void (Private)
- **AllServicesAreReady()**: System.Void (Protected)
- **CreateMediators()**: System.Void (Protected)
- **InjectGameobject(UnityEngine.GameObject gameobject)**: System.Void (Public)
- **InjectObject(System.Object obj)**: System.Void (Public)
- **Resolve()**: T (Public)
- **Resolve(System.Type type)**: System.Object (Public)
- **OnDestroy()**: System.Void (Protected)
- **OnApplicationQuit()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

