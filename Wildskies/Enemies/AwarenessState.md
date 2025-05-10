# WildSkies.Enemies.AwarenessState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _utilityStates | WildSkies.Enemies.AwarenessUtilityState[] | Private |
| Score | System.Single | Public |
| _cooldownScore | System.Int32 | Private |
| _cooldownTimer | System.Single | Private |
| _scoreMultiplier | System.Single | Private |
| _cooldownTime | System.Single | Private |
| _useScoreMultiplier | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CooldownTimerComplete | System.Boolean | Public |

## Methods

- **get_CooldownTimerComplete()**: System.Boolean (Public)
- **.ctor(WildSkies.Enemies.AwarenessUtilityState[] utilityStates, System.Int32 cooldownScore)**: System.Void (Public)
- **SetCooldownTime(System.Single cooldownTime)**: System.Void (Public)
- **SetUseScoreMultiplier(System.Boolean useScoreMultiplier)**: System.Void (Public)
- **StartCooldown()**: System.Void (Public)
- **UpdateCooldown()**: System.Void (Public)
- **GetAwarenessScore()**: System.Int32 (Public)
- **GetCooldownScore()**: System.Int32 (Private)

