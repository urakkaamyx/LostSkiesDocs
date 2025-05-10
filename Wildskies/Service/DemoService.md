# WildSkies.Service.DemoService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sessionService | WildSkies.Service.SessionService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _islandService | WildSkies.Service.IIslandService | Private |
| _uiService | UISystem.IUIService | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| _playerGuideService | WildSkies.Service.IPlayerGuideService | Private |
| _firstFlightObjectiveLabel | System.String | Private |
| _timerDemoOperation | UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.GameObject> | Private |
| <ServiceErrorCode>k__BackingField | System.Int32 | Private |
| <CanGameRunIfServiceFailed>k__BackingField | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **OnDisable()**: System.Void (Private)
- **OnObjectiveCompleted(PlayerGuideObjective objective)**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **InitializeDemoStart()**: System.Void (Private)
- **ShowInitialCallToAction()**: System.Void (Private)
- **ShowFinalCallToAction()**: System.Void (Private)
- **TimerDemoLoadCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.GameObject> obj)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

