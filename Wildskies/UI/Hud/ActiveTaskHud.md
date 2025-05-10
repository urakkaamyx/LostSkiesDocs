# Wildskies.UI.Hud.ActiveTaskHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerGuideService | WildSkies.Service.IPlayerGuideService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _viewModel | Wildskies.UI.Hud.ActiveTaskViewModel | Private |
| _delayToChangeTaskShown | System.Single | Private |
| _delayTimeLeft | System.Single | Private |
| _currentObjectiveListEntries | System.Collections.Generic.List`1<Wildskies.UI.Hud.ObjectiveListEntry> | Private |
| _taskQueue | System.Collections.Generic.Queue`1<PlayerGuideTask> | Private |
| tempQueue | System.Collections.Generic.Queue`1<PlayerGuideTask> | Private |
| _currentlyShownTask | PlayerGuideTask | Private |
| _targetAlpha | System.Single | Private |
| _isChangingTask | System.Boolean | Private |
| _initialised | System.Boolean | Private |
| _fadeTimeElapsed | System.Single | Private |
| ChangeTaskTransitionComplete | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **SetText(UnityEngine.Localization.Locale _)**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **UpdateActiveTask(PlayerGuideTask newTask)**: System.Void (Private)
- **DisplayNextTask()**: System.Void (Private)
- **PopulateObjectives()**: System.Void (Private)
- **ClearActiveTask()**: System.Void (Private)
- **ClearObjectives()**: System.Void (Private)
- **Fade()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

