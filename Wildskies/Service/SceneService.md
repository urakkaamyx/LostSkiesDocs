# WildSkies.Service.SceneService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| SceneHasChanged | System.Action`1<WildSkies.Service.SceneService/SceneLoadState> | Private |
| LobbySceneName | System.String | Public |
| WorldSceneName | System.String | Public |
| LoadingScreen | System.String | Public |
| _loadingScene | System.String | Private |
| _sceneToLoad | System.String | Private |
| _currentIslandScene | System.String | Private |
| _loadingState | WildSkies.Service.SceneService/SceneLoadState | Private |
| _currentLoadingOperation | UnityEngine.AsyncOperation | Private |
| _stopWatch | System.Diagnostics.Stopwatch | Private |
| _showLoadingScreen | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| IsSceneLoading | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **add_SceneHasChanged(System.Action`1<WildSkies.Service.SceneService/SceneLoadState> value)**: System.Void (Public)
- **remove_SceneHasChanged(System.Action`1<WildSkies.Service.SceneService/SceneLoadState> value)**: System.Void (Public)
- **get_IsSceneLoading()**: System.Boolean (Public)
- **TargetSceneName()**: System.String (Public)
- **CurrentIslandScene()**: System.String (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **LoadLobby()**: System.Void (Public)
- **LoadWorld()**: System.Void (Public)
- **LoadIsland(System.String islandSceneName)**: System.Void (Public)
- **UnloadIsland(System.String islandSceneName)**: System.Void (Public)
- **LoadNonPrimarySceneByName(System.String targetSceneName)**: System.Boolean (Public)
- **StartLoadingScene(System.String targetSceneName, System.Boolean showLoadingScreen)**: System.Void (Private)
- **LoadingScreenInPlace()**: System.Void (Private)
- **NotifySceneChange(WildSkies.Service.SceneService/SceneLoadState state)**: System.Void (Private)
- **Update()**: System.Void (Public)
- **SceneSuccessfullyLoaded()**: System.Void (Public)
- **GetWorldSceneName()**: System.String (Public)
- **AreWeLoadingOrInLobby()**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

