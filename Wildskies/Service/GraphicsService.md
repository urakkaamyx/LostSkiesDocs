# WildSkies.Service.GraphicsService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _graphicsSettings | IGraphicsSettings | Private |
| <StartingTimeStep>k__BackingField | System.Single | Private |
| SettingChanged | System.Action`2<GraphicsSettingOptions/SettingOption,System.Object> | Public |
| FinishedMonitorSwitch | System.Action | Public |
| SessionService | WildSkies.Service.SessionService | Public |
| InGameSceneName | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| StartingTimeStep | System.Single | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| SettingsExist | System.Boolean | Public |
| QualityProfiles | QualityProfile[] | Public |
| DisabledSettingsInGame | GraphicsSettingOptions/SettingOption[] | Public |

## Methods

- **get_StartingTimeStep()**: System.Single (Public)
- **set_StartingTimeStep(System.Single value)**: System.Void (Private)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_SettingsExist()**: System.Boolean (Public)
- **get_QualityProfiles()**: QualityProfile[] (Public)
- **get_DisabledSettingsInGame()**: GraphicsSettingOptions/SettingOption[] (Public)
- **IsInGame()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **AssignCamera(UnityEngine.Rendering.HighDefinition.HDAdditionalCameraData camData)**: System.Void (Public)
- **ChangeSetting(GraphicsSettingOptions/SettingOption setting, System.Object value)**: System.Void (Public)
- **RestoreDefaultSettings()**: System.Void (Public)
- **OnApplicationQuit()**: System.Void (Public)
- **GetGraphicOptions(GraphicsSettingOptions/SettingOption setting)**: System.String[] (Public)
- **GetLocalisedGraphicOptions(GraphicsSettingOptions/SettingOption setting)**: LocalisedStringID[] (Public)
- **SetQualitySettingFromProfile(QualityProfile profile)**: System.Void (Public)
- **ParseQualitySettingFromString(QualityProfile/QualitySetting setting)**: System.Object (Public)
- **GetSetting(GraphicsSettingOptions/SettingOption setting)**: System.Object (Public)
- **GetStaticSettingValueString(GraphicsSettingOptions/SettingOption setting, System.Int32 value)**: System.String (Public)
- **SaveSettings()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

