# WildSkies.Service.PlayerGuideService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| <UseTestAssets>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _allTasks | System.Collections.Generic.List`1<PlayerGuideTask> | Private |
| _allObjectives | System.Collections.Generic.List`1<PlayerGuideObjective> | Private |
| _dataFinishedLoading | System.Boolean | Private |
| _playerGuideData | WildSkies.Service.PlayerGuideData | Private |
| _playerGuideTaskProfile | PlayerGuideTaskProfile | Private |
| _taskDictionary | System.Collections.Generic.Dictionary`2<System.String,PlayerGuideTask> | Private |
| _objectivesDictionary | System.Collections.Generic.Dictionary`2<System.String,PlayerGuideObjective> | Private |
| _keysToAddIntegrityCheck | System.Collections.Generic.List`1<System.String> | Private |
| _keysToRemoveIntegrityCheck | System.Collections.Generic.List`1<System.String> | Private |
| _taskProfileLoaded | System.Boolean | Private |
| _tasksLoaded | System.Boolean | Private |
| _objectivesLoaded | System.Boolean | Private |
| <OnObjectiveCompleted>k__BackingField | System.Action`1<PlayerGuideObjective> | Private |
| <OnTaskCompleted>k__BackingField | System.Action`1<PlayerGuideTask> | Private |
| <OnObjectiveReset>k__BackingField | System.Action`1<PlayerGuideObjective> | Private |
| <OnTaskReset>k__BackingField | System.Action`1<PlayerGuideTask> | Private |
| <OnActiveTaskChanged>k__BackingField | System.Action`1<PlayerGuideTask> | Private |
| <OnGuideChanged>k__BackingField | System.Action`1<WildSkies.Service.PlayerGuideData> | Private |
| <ChangeTaskTransitionComplete>k__BackingField | System.Action`1<PlayerGuideTask> | Private |
| <OnDataLoaded>k__BackingField | System.Action | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| UseTestAssets | System.Boolean | Public |
| AddressableLocationKey | System.String | Private |
| TaskProfileAddress | System.String | Private |
| AllTasks | System.Collections.Generic.List`1<PlayerGuideTask> | Public |
| AllObjectives | System.Collections.Generic.List`1<PlayerGuideObjective> | Public |
| DataFinishedLoading | System.Boolean | Public |
| OnObjectiveCompleted | System.Action`1<PlayerGuideObjective> | Public |
| OnTaskCompleted | System.Action`1<PlayerGuideTask> | Public |
| OnObjectiveReset | System.Action`1<PlayerGuideObjective> | Public |
| OnTaskReset | System.Action`1<PlayerGuideTask> | Public |
| OnActiveTaskChanged | System.Action`1<PlayerGuideTask> | Public |
| OnGuideChanged | System.Action`1<WildSkies.Service.PlayerGuideData> | Public |
| ChangeTaskTransitionComplete | System.Action`1<PlayerGuideTask> | Public |
| OnDataLoaded | System.Action | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_UseTestAssets()**: System.Boolean (Public)
- **set_UseTestAssets(System.Boolean value)**: System.Void (Public)
- **get_AddressableLocationKey()**: System.String (Protected)
- **get_TaskProfileAddress()**: System.String (Private)
- **get_AllTasks()**: System.Collections.Generic.List`1<PlayerGuideTask> (Public)
- **get_AllObjectives()**: System.Collections.Generic.List`1<PlayerGuideObjective> (Public)
- **get_DataFinishedLoading()**: System.Boolean (Public)
- **get_OnObjectiveCompleted()**: System.Action`1<PlayerGuideObjective> (Public)
- **set_OnObjectiveCompleted(System.Action`1<PlayerGuideObjective> value)**: System.Void (Public)
- **get_OnTaskCompleted()**: System.Action`1<PlayerGuideTask> (Public)
- **set_OnTaskCompleted(System.Action`1<PlayerGuideTask> value)**: System.Void (Public)
- **get_OnObjectiveReset()**: System.Action`1<PlayerGuideObjective> (Public)
- **set_OnObjectiveReset(System.Action`1<PlayerGuideObjective> value)**: System.Void (Public)
- **get_OnTaskReset()**: System.Action`1<PlayerGuideTask> (Public)
- **set_OnTaskReset(System.Action`1<PlayerGuideTask> value)**: System.Void (Public)
- **get_OnActiveTaskChanged()**: System.Action`1<PlayerGuideTask> (Public)
- **set_OnActiveTaskChanged(System.Action`1<PlayerGuideTask> value)**: System.Void (Public)
- **get_OnGuideChanged()**: System.Action`1<WildSkies.Service.PlayerGuideData> (Public)
- **set_OnGuideChanged(System.Action`1<WildSkies.Service.PlayerGuideData> value)**: System.Void (Public)
- **get_ChangeTaskTransitionComplete()**: System.Action`1<PlayerGuideTask> (Public)
- **set_ChangeTaskTransitionComplete(System.Action`1<PlayerGuideTask> value)**: System.Void (Public)
- **get_OnDataLoaded()**: System.Action (Public)
- **set_OnDataLoaded(System.Action value)**: System.Void (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **OnLoadComplete()**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **LoadTaskProfile()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadTaskAddressables()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadObjectiveAddressables()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnTaskDataLoaded(PlayerGuideTask task)**: System.Void (Private)
- **OnObjectiveDataLoaded(PlayerGuideObjective objective)**: System.Void (Private)
- **SetPlayerGuideData(WildSkies.Service.PlayerGuideData saveData)**: System.Void (Public)
- **CreateNewPlayerGuideData()**: System.Void (Public)
- **SetActiveTask(System.String label)**: System.Void (Public)
- **SetNextActiveTask()**: System.Void (Private)
- **ClearActiveTask()**: System.Void (Public)
- **SetObjectiveComplete(System.String objectiveLabel)**: System.Void (Public)
- **CheckTaskComplete(PlayerGuideTask task)**: System.Void (Private)
- **TryAutocompletePreviousObjectives(PlayerGuideObjective objective)**: System.Void (Private)
- **SetTaskComplete(System.String label)**: System.Void (Public)
- **UpdateGuide()**: System.Void (Public)
- **IsObjectiveComplete(System.String label)**: System.Boolean (Public)
- **IsTaskComplete(System.String label)**: System.Boolean (Public)
- **HasCompletedAllTasks()**: System.Boolean (Public)
- **GetObjectiveByLabel(System.String label, PlayerGuideObjective& objective)**: System.Boolean (Public)
- **GetTaskByLabel(System.String label, PlayerGuideTask& task)**: System.Boolean (Public)
- **GetAllObjectivesInTask(System.String taskLabel)**: System.Collections.Generic.List`1<PlayerGuideObjective> (Public)
- **GetActiveTask()**: PlayerGuideTask (Public)
- **GetActiveObjectives()**: System.Collections.Generic.List`1<PlayerGuideObjective> (Public)
- **GetNextIncompleteTask()**: PlayerGuideTask (Public)
- **VerifyIntegrityOfSavedData(WildSkies.Service.PlayerGuideData loadedData)**: System.Void (Private)
- **VerifyDictionary(System.Collections.Generic.Dictionary`2<System.String,System.Boolean> addressablesDictionary, System.Collections.Generic.Dictionary`2<System.String,System.Boolean> loadedDictionary)**: System.Void (Private)
- **ResetObjective(System.String label)**: System.Void (Public)
- **ResetTask(System.String label)**: System.Void (Public)
- **CompleteAllObjectivesInTask(System.String label)**: System.Void (Public)
- **CompleteAllTasks()**: System.Void (Public)
- **ResetAllTasks()**: System.Void (Public)
- **AddTestTask(PlayerGuideTask testTask)**: System.Void (Public)
- **AddTestObjective(PlayerGuideObjective testObjective)**: System.Void (Public)
- **SetTaskByIndex(System.Int32 index)**: System.Void (Public)
- **CompleteTaskAtIndex(System.Int32 index)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

