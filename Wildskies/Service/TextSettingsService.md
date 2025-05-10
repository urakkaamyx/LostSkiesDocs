# WildSkies.Service.TextSettingsService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| OnChangeSize | System.Action | Public |
| OnChangeColour | System.Action | Public |
| OnSetLocalNameVisible | System.Action | Public |
| OnSetRemoteNamesVisible | System.Action | Public |
| <CurrentSize>k__BackingField | System.Single | Private |
| <CurrentColour>k__BackingField | UnityEngine.Color | Private |
| <LocalNameIsVisible>k__BackingField | System.Boolean | Private |
| <RemoteNamesAreVisible>k__BackingField | System.Boolean | Private |
| DefaultSize | System.Single | Private |
| DefaultColour | UnityEngine.Color | Private |
| DefaultLocalPlayerNameVisibility | System.Boolean | Private |
| DefaultRemotePlayerNameVisibility | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| CurrentSize | System.Single | Public |
| CurrentColour | UnityEngine.Color | Public |
| LocalNameIsVisible | System.Boolean | Public |
| RemoteNamesAreVisible | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_CurrentSize()**: System.Single (Public)
- **set_CurrentSize(System.Single value)**: System.Void (Private)
- **get_CurrentColour()**: UnityEngine.Color (Public)
- **set_CurrentColour(UnityEngine.Color value)**: System.Void (Private)
- **get_LocalNameIsVisible()**: System.Boolean (Public)
- **set_LocalNameIsVisible(System.Boolean value)**: System.Void (Private)
- **get_RemoteNamesAreVisible()**: System.Boolean (Public)
- **set_RemoteNamesAreVisible(System.Boolean value)**: System.Void (Private)
- **Initialise()**: System.Int32 (Public)
- **ApplySavedSettings()**: System.Void (Private)
- **ApplyDefaultSettings()**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **SetColour(UnityEngine.Color colour)**: System.Void (Public)
- **SetSize(System.Single size)**: System.Void (Public)
- **SetLocalPlayerNameVisible(System.Boolean isVisible)**: System.Void (Public)
- **SetRemotePlayerNamesVisible(System.Boolean areVisible)**: System.Void (Public)
- **ResetSize()**: System.Void (Public)
- **ResetColour()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

