# WildSkies.Service.TimerDemo

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| TimerDurationInMinutes | System.Int32 | Public |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| WorldTimeLeft | System.Int32 | Public |
| _uiService | UISystem.IUIService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _hasNotifiedThirtySecondsRemaining | System.Boolean | Private |
| _timerRunning | System.Boolean | Private |
| _internalTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ShowTimer | System.Boolean | Public |
| CurrentTimeFormatted | System.String | Public |

## Methods

- **get_ShowTimer()**: System.Boolean (Public)
- **get_CurrentTimeFormatted()**: System.String (Public)
- **SyncWorldTime(System.Int32 before, System.Int32 newValue)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **OnSaveRequested(System.Int32 arg1, System.String arg2, System.String arg3, System.Guid arg4)**: System.Void (Private)
- **PlayerLeftFirstIsland()**: System.Void (Public)
- **StartTimer()**: System.Void (Public)
- **GetTimeLeft()**: System.Int32 (Private)
- **ShowTaskCompleteNotification()**: System.Void (Private)
- **EndDemo()**: System.Void (Public)
- **AesEnc(System.String plainText)**: System.String (Private)
- **AesDec(System.String cipherText)**: System.String (Private)
- **.ctor()**: System.Void (Public)

