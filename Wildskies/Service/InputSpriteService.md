# WildSkies.Service.InputSpriteService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _parsedIconData | WildSkies.Service.InputSpriteService/ParsedIconData | Private |
| _keyBindingIconDictionaries | KeyBindingIconDictionaries | Private |
| _hasFinishedInitialising | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| GamepadString | System.String | Private |
| AddressableName | System.String | Private |
| ModifierString | System.String | Private |
| KeyboardString | System.String | Private |
| IsCurrentInputAGamepad | System.Boolean | Private |
| CurrentInputDevice | WildSkies.Service.InputService/CurrentDevice | Private |
| _cycleInteractionKeys | System.String[] | Private |
| _wasdKeys | System.String[] | Private |
| _arrowKeys | System.String[] | Private |
| _filteredBindingsAux | System.Collections.Generic.List`1<UnityEngine.InputSystem.InputBinding> | Private |
| _inputIconData | KeyBindingIconDictionaries/InputIconData | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **GetInputIconData(UnityEngine.InputSystem.InputAction action, System.Boolean modifier)**: KeyBindingIconDictionaries/InputIconData (Public)
- **GetInputIconDataModifier(UnityEngine.InputSystem.InputAction action)**: KeyBindingIconDictionaries/InputIconData (Private)
- **GetIconForInput(System.String inputName)**: KeyBindingIconDictionaries/InputIconData (Public)
- **ParseInputAction(UnityEngine.InputSystem.InputAction inputAction, System.String compositeSeparator, System.String[] specifyCompositeNames, System.Boolean onlyFirstResult)**: System.String (Public)
- **ParseInputAction(UnityEngine.InputSystem.InputAction inputAction, WildSkies.Service.InputService/CurrentDevice device, System.String compositeSeparator, System.String[] specifyCompositeNames, System.Boolean onlyFirstResult)**: System.String (Public)
- **Terminate()**: System.Void (Public)
- **ClearCache()**: System.Void (Public)
- **LoadAddressable()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnInputDeviceChanged(WildSkies.Service.InputService/CurrentDevice currentDevice, System.Boolean isGamepad)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **FilterInputAction(UnityEngine.InputSystem.InputAction inputAction)**: UnityEngine.InputSystem.InputAction (Private)
- **ContainsWASD(UnityEngine.InputSystem.InputAction inputAction)**: System.Boolean (Private)
- **ContainsCycleInteractionKeys(UnityEngine.InputSystem.InputAction inputAction)**: System.Boolean (Private)
- **CreateFilteredBindings(UnityEngine.InputSystem.InputAction inputAction, System.String[] keysToCheck)**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

