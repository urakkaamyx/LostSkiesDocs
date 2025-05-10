# WildSkies.Service.AudioService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _physicsService | _game.code.core.services.physics.PhysicsService | Private |
| _audioConfig | WildSkies.Audio.AudioConfig | Private |
| _eventInstancesByType | System.Collections.Generic.Dictionary`2<WildSkies.Audio.AudioType,System.Collections.Generic.Dictionary`2<System.Int32,FMOD.Studio.EventInstance>> | Private |
| GenerateUniqueIdAttempts | System.Int32 | Private |
| FailedToGenerateIdCode | System.Int32 | Private |
| MasterVolume | System.String | Private |
| MusicVolume | System.String | Private |
| SfxVolume | System.String | Private |
| MainMenuMusicVolume | System.String | Private |
| GameMusicVolume | System.String | Private |
| UIEQCutoffParam | System.String | Private |
| nonUiSfxVol | System.String | Private |
| _currentEqCutoff | System.Single | Private |
| _nonUIEQCutoff | System.Single | Private |
| _uiEqCutoff | System.Boolean | Private |
| _nonUiSfxVol | System.Single | Private |
| _mainMenuActive | System.Boolean | Public |
| musicDynamic | WildSkies.Audio.AudioType | Public |
| musicDynamicId | System.Int32 | Public |
| _onAudioPlay | System.Action`2<UnityEngine.Vector3,WildSkies.Audio.AudioType> | Private |
| _onAudioParameterUpdate | System.Action`4<WildSkies.Audio.AudioType,UnityEngine.Vector3,System.String,System.Single> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **.ctor(_game.code.core.services.physics.PhysicsService physicsService)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **CreateEventInstance(WildSkies.Audio.AudioType audioType)**: FMOD.Studio.EventInstance (Public)
- **PlayOneShot(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position)**: System.Void (Public)
- **PlayOneShotWithParameters(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Public)
- **PlayOneShotWithParameters(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, UnityEngine.Transform entityTransform, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Public)
- **StartEvent(WildSkies.Audio.AudioType audioType, System.Int32 eventId)**: System.Void (Public)
- **StopEvent(WildSkies.Audio.AudioType audioType, System.Int32 eventId, FMOD.Studio.STOP_MODE stopMode)**: System.Void (Public)
- **UpdateEventParameters(WildSkies.Audio.AudioType audioType, System.Int32 eventId, UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, UnityEngine.Transform entityTransform, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Public)
- **UpdateEventParameters(WildSkies.Audio.AudioType audioType, System.Int32 eventId, UnityEngine.Vector3 position, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Public)
- **IsEventPlaying(WildSkies.Audio.AudioType audioType, System.Int32 eventId)**: System.Boolean (Public)
- **PlayImpactAudio(WildSkies.VfxType vfxType, WildSkies.IslandExport.SurfaceType surfaceType, UnityEngine.Vector3 position)**: System.Void (Public)
- **StopAllPlayerEvents()**: System.Void (Public)
- **SetMasterVolume(System.Single value)**: System.Void (Public)
- **GetMasterVolume()**: System.Single (Public)
- **SetMusicVolume(System.Single value)**: System.Void (Public)
- **GetMusicVolume()**: System.Single (Public)
- **SetSFXVolume(System.Single value)**: System.Void (Public)
- **GetSFXVolume()**: System.Single (Public)
- **SetMainMenuMusicVolume(System.Single value)**: System.Void (Public)
- **SetGameMusicVolume(System.Single value)**: System.Void (Public)
- **SubscribeToOnAudioPlay(System.Action`2<UnityEngine.Vector3,WildSkies.Audio.AudioType> onAudioPlay)**: System.Void (Public)
- **UnsubscribeToOnAudioPlay(System.Action`2<UnityEngine.Vector3,WildSkies.Audio.AudioType> onAudioPlay)**: System.Void (Public)
- **SubscribeToOnAudioParameterUpdate(System.Action`4<WildSkies.Audio.AudioType,UnityEngine.Vector3,System.String,System.Single> onAudioParameterUpdate)**: System.Void (Public)
- **UnsubscribeToOnAudioParameterUpdate(System.Action`4<WildSkies.Audio.AudioType,UnityEngine.Vector3,System.String,System.Single> onAudioParameterUpdate)**: System.Void (Public)
- **GetUniqueEventID(WildSkies.Audio.AudioType audioType, System.Int32& generatedId)**: System.Boolean (Public)
- **StartMusic()**: System.Void (Public)
- **StopMusic()**: System.Void (Public)
- **SetMusicState(System.Int32 state)**: System.Void (Public)
- **SetNonUiSfxVol(System.Single newValue)**: System.Void (Public)
- **SetUIEQCutoff(System.Boolean uiEnabled)**: System.Void (Public)
- **SetNonUIEQCutoffValue(System.Single newValue)**: System.Void (Public)

