# WildSkies.Service.IslandLightingService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Path | System.String | Private |
| _currentLoadedLightScene | UnityEngine.SceneManagement.Scene | Private |
| _canLoadData | System.Boolean | Private |
| _requestedBundle | UnityEngine.AssetBundle | Private |
| _requestedScenePath | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RequestLoad(System.String file)**: System.Void (Public)
- **SceneLoadCompleted(UnityEngine.AsyncOperation asyncOperation)**: System.Void (Private)
- **LoadLighting(System.String requestedFile)**: System.Void (Private)
- **AssetBundleLoaded(UnityEngine.AsyncOperation obj)**: System.Void (Private)
- **Clear()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

