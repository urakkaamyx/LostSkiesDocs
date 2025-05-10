# WildSkies.Service.TimeService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _model | TimeServiceModel | Private |
| _notifications | Services.TimeServiceNotifications | Private |
| _clock | WildSkies.Service.TimeServiceClock | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetDay(System.UInt16 day)**: System.Void (Public)
- **SetTime(System.Single currentTime)**: System.Void (Public)
- **SetDayLength(System.UInt16 lengthInMinutes)**: System.Void (Public)
- **GetDay()**: System.UInt16 (Public)
- **GetTime()**: System.Single (Public)
- **GetTimeAsString()**: System.String (Public)
- **GetTimePeriod()**: TimePeriod (Public)
- **AddTimePeriod(TimePeriod period, System.Single startTime)**: System.Void (Public)
- **AddNotification(System.Single time, System.Action callback)**: System.Int32 (Public)
- **AddNotification(TimePeriod timePeriod, System.Action callback)**: System.Int32 (Public)
- **RemoveNotification(System.Int32 id)**: System.Void (Public)
- **ClearNotifications()**: System.Void (Public)
- **TryInvokeTimeNotifications(System.UInt16 previousDay)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

