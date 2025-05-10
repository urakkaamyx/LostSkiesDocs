# WildSkies.Puzzles.PlayerChallenge

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| OnChallengeBegin | System.Action | Public |
| OnChallengeComplete | System.Action | Public |
| OnChallengeFailed | System.Action | Public |
| _challengeActive | System.Boolean | Private |
| _startTime | System.Single | Private |
| <Timer>k__BackingField | System.Single | Private |
| <Complete>k__BackingField | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| OutputsAllowed | System.Boolean | Public |
| TimeLeft | System.Single | Public |
| IsActive | System.Boolean | Public |
| StartTime | System.Single | Public |
| Timer | System.Single | Public |
| Complete | System.Boolean | Public |

## Methods

- **get_OutputsAllowed()**: System.Boolean (Public)
- **get_TimeLeft()**: System.Single (Public)
- **get_IsActive()**: System.Boolean (Public)
- **get_StartTime()**: System.Single (Public)
- **get_Timer()**: System.Single (Public)
- **set_Timer(System.Single value)**: System.Void (Public)
- **get_Complete()**: System.Boolean (Public)
- **set_Complete(System.Boolean value)**: System.Void (Public)
- **CompleteChallenge()**: System.Void (Public)
- **AddTime(System.Single timeToAdd)**: System.Void (Public)
- **BeginChallenge()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **FailedChallenge()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **SetFromSerialisedData(System.Boolean complete, System.Single timer, System.Boolean isActive, System.Single startTime)**: System.Void (Public)
- **.ctor()**: System.Void (Protected)

