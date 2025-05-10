# Wildskies.UI.Hud.PlayerChallengeHudViewModel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _countdownTimer | ChallengeCountdownTimer | Private |
| _challengeTimer | UnityEngine.GameObject | Private |
| _challengeTimerLabel | UnityEngine.UI.Text | Private |
| _challengeName | UnityEngine.UI.Text | Private |
| _completeTime | UnityEngine.UI.Text | Private |
| _complete | UnityEngine.GameObject | Private |
| _activePlayerChallenge | WildSkies.Puzzles.PlayerChallenge | Private |
| _countdownInProgress | System.Boolean | Private |
| _flashCompleteCount | System.Int32 | Private |
| _flashCompleteSpeed | System.Single | Private |
| nfi | System.Globalization.NumberFormatInfo | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CountdownActive | System.Boolean | Public |

## Methods

- **get_CountdownActive()**: System.Boolean (Public)
- **FloatToTimerString(System.Single value)**: System.String (Public)
- **StartCountdown(WildSkies.Puzzles.PlayerChallenge playerChallenge)**: System.Void (Public)
- **OnDisable()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FlashCompleteMessage()**: System.Collections.IEnumerator (Private)
- **ClearHud()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

