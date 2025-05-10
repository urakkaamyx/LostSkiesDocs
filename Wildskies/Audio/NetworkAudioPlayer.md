# WildSkies.Audio.NetworkAudioPlayer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ParameterSeparator | System.Char | Private |
| MaxByteArraySize | System.Int32 | Private |
| MaxNumberOfParameters | System.Int32 | Private |
| _parameterNames | System.String[] | Private |
| _parameterValues | System.Single[] | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _eventInstancesByType | System.Collections.Generic.Dictionary`2<WildSkies.Audio.AudioType,System.Collections.Generic.Dictionary`2<System.Int32,FMOD.Studio.EventInstance>> | Private |
| PositionThreshold | System.Single | Private |
| ParameterThreshold | System.Single | Private |

## Methods

- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **SendPlayOneShotCommand(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position)**: System.Void (Public)
- **SendPlayOneShotWithParametersCommand(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Public)
- **SendStartEventCommand(WildSkies.Audio.AudioType audioType, System.Int32 eventId)**: System.Void (Public)
- **SendStopEventCommand(WildSkies.Audio.AudioType audioType, System.Int32 eventId, FMOD.Studio.STOP_MODE stopMode)**: System.Void (Public)
- **SendUpdateEventParametersCommand(WildSkies.Audio.AudioType audioType, System.Int32 eventId, UnityEngine.Vector3 position, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Public)
- **PlayOneShot(System.Int32 audioType, UnityEngine.Vector3 position)**: System.Void (Public)
- **PlayOneShotWithParameters(System.Int32 audioType, UnityEngine.Vector3 position, System.Byte[] parameterNames, System.Byte[] parameterValues)**: System.Void (Public)
- **StartEvent(System.Int32 audioType, System.Int32 eventId)**: System.Void (Public)
- **StopEvent(System.Int32 audioType, System.Int32 eventId, System.Int32 stopMode)**: System.Void (Public)
- **UpdateEventParameters(System.Int32 audioType, System.Int32 eventId, UnityEngine.Vector3 position, System.Byte[] parameterNames, System.Byte[] parameterValues)**: System.Void (Public)
- **GetEventInstance(WildSkies.Audio.AudioType audioType, System.Int32 eventId)**: FMOD.Studio.EventInstance (Private)
- **AskOwnerForEventInstances()**: System.Void (Private)
- **EventInstancesRequestedCmd()**: System.Void (Public)
- **SerializeParameters(System.ValueTuple`2<System.String,System.Single>[] parameters, System.Byte[]& parameterNames, System.Byte[]& parameterValues)**: System.Void (Public)
- **DeserializeParameters(System.Byte[] parameterNames, System.Byte[] parameterValues, System.ValueTuple`2<System.String,System.Single>[]& parameters)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

