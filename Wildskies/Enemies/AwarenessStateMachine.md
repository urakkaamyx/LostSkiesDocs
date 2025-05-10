# WildSkies.Enemies.AwarenessStateMachine

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _cooldownTime | System.Single | Private |
| _useScoreMultiplier | System.Boolean | Private |
| _stateFactory | WildSkies.Enemies.AwarenessStateFactory | Private |
| _states | WildSkies.Enemies.EAwarenessState[] | Private |
| _showInfoOverlayGUI | System.Boolean | Private |
| _debugStates | System.Collections.Generic.List`1<WildSkies.Enemies.AwarenessDebugState> | Private |
| _currentState | WildSkies.Enemies.EAwarenessState | Private |
| _stateMap | System.Collections.Generic.Dictionary`2<WildSkies.Enemies.EAwarenessState,WildSkies.Enemies.AwarenessState> | Private |

## Methods

- **Init()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **SetStateStarted(WildSkies.Enemies.EAwarenessState state)**: System.Void (Public)
- **SetStateExited(WildSkies.Enemies.EAwarenessState state)**: System.Void (Public)
- **GetStateUtility(WildSkies.Enemies.EAwarenessState state)**: System.Int32 (Public)
- **OnGUI()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

