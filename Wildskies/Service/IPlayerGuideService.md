# WildSkies.Service.IPlayerGuideService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| AllTasks | System.Collections.Generic.List`1<PlayerGuideTask> | Public |
| AllObjectives | System.Collections.Generic.List`1<PlayerGuideObjective> | Public |
| UseTestAssets | System.Boolean | Public |
| OnObjectiveCompleted | System.Action`1<PlayerGuideObjective> | Public |
| OnObjectiveReset | System.Action`1<PlayerGuideObjective> | Public |
| OnTaskCompleted | System.Action`1<PlayerGuideTask> | Public |
| OnTaskReset | System.Action`1<PlayerGuideTask> | Public |
| OnActiveTaskChanged | System.Action`1<PlayerGuideTask> | Public |
| OnGuideChanged | System.Action`1<WildSkies.Service.PlayerGuideData> | Public |
| ChangeTaskTransitionComplete | System.Action`1<PlayerGuideTask> | Public |
| OnDataLoaded | System.Action | Public |
| DataFinishedLoading | System.Boolean | Public |

## Methods

- **get_AllTasks()**: System.Collections.Generic.List`1<PlayerGuideTask> (Public)
- **get_AllObjectives()**: System.Collections.Generic.List`1<PlayerGuideObjective> (Public)
- **get_UseTestAssets()**: System.Boolean (Public)
- **get_OnObjectiveCompleted()**: System.Action`1<PlayerGuideObjective> (Public)
- **set_OnObjectiveCompleted(System.Action`1<PlayerGuideObjective> value)**: System.Void (Public)
- **get_OnObjectiveReset()**: System.Action`1<PlayerGuideObjective> (Public)
- **set_OnObjectiveReset(System.Action`1<PlayerGuideObjective> value)**: System.Void (Public)
- **get_OnTaskCompleted()**: System.Action`1<PlayerGuideTask> (Public)
- **set_OnTaskCompleted(System.Action`1<PlayerGuideTask> value)**: System.Void (Public)
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
- **get_DataFinishedLoading()**: System.Boolean (Public)
- **SetPlayerGuideData(WildSkies.Service.PlayerGuideData guideData)**: System.Void (Public)
- **CreateNewPlayerGuideData()**: System.Void (Public)
- **SetActiveTask(System.String label)**: System.Void (Public)
- **ClearActiveTask()**: System.Void (Public)
- **SetObjectiveComplete(System.String objectiveLabel)**: System.Void (Public)
- **SetTaskComplete(System.String label)**: System.Void (Public)
- **UpdateGuide()**: System.Void (Public)
- **GetActiveTask()**: PlayerGuideTask (Public)
- **GetNextIncompleteTask()**: PlayerGuideTask (Public)
- **GetActiveObjectives()**: System.Collections.Generic.List`1<PlayerGuideObjective> (Public)
- **GetTaskByLabel(System.String label, PlayerGuideTask& objective)**: System.Boolean (Public)
- **GetObjectiveByLabel(System.String label, PlayerGuideObjective& objective)**: System.Boolean (Public)
- **GetAllObjectivesInTask(System.String taskLabel)**: System.Collections.Generic.List`1<PlayerGuideObjective> (Public)
- **IsObjectiveComplete(System.String label)**: System.Boolean (Public)
- **IsTaskComplete(System.String label)**: System.Boolean (Public)
- **HasCompletedAllTasks()**: System.Boolean (Public)
- **ResetTask(System.String label)**: System.Void (Public)
- **ResetObjective(System.String label)**: System.Void (Public)
- **CompleteAllObjectivesInTask(System.String taskLabel)**: System.Void (Public)
- **ResetAllTasks()**: System.Void (Public)
- **CompleteAllTasks()**: System.Void (Public)
- **AddTestTask(PlayerGuideTask task)**: System.Void (Public)
- **AddTestObjective(PlayerGuideObjective objective)**: System.Void (Public)
- **SetTaskByIndex(System.Int32 index)**: System.Void (Public)
- **CompleteTaskAtIndex(System.Int32 index)**: System.Void (Public)

