# WildSkies.Service.InputService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| PriorityOrder | WildSkies.Service.InputService/InputMode[] | Private |
| InputTypeChanged | WildSkies.Service.InputService/HandleInputTypeChanged | Public |
| _playerInput | DynamikaCharacterInput | Private |
| _uiInput | UIInput | Private |
| _spectatorCamInput | SpectatorCamInput | Private |
| _droneCamInput | DroneCamInput | Private |
| _shipControls | ShipControllerInput | Private |
| _turretControls | TurretControlInput | Private |
| _mastControls | MastControlInput | Private |
| _craftingToolInput | CraftingToolInput | Private |
| InventoryButtonHoldTimeForCompendiumTutorial | System.Single | Public |
| InventoryButtonHoldTimeForMenuWheel | System.Single | Public |
| _currentDevice | WildSkies.Service.InputService/CurrentDevice | Private |
| _currentDeviceName | System.String | Private |
| _inputMode | WildSkies.Service.InputService/InputMode | Private |
| _priorityInput | WildSkies.Service.InputService/InputMode | Private |
| _isCurrentInputAGamepad | System.Boolean | Private |
| _invertProcessor | UnityEngine.InputSystem.Processors.InvertProcessor | Private |
| OnPlayerMapChanged | System.Action | Public |
| OnMouseSmoothingChanged | System.Action`1<System.Boolean> | Public |
| _cursorBehaviour | WildSkies.Service.InputService/CursorBehaviour | Private |
| _cursorTexture | WildSkies.Service.InputService/CursorTexture | Private |
| _initialised | System.Boolean | Private |
| Ps4StringCheck | System.String | Private |
| Ps5StringCheck | System.String | Private |
| XboxStringCheck | System.String | Private |
| KeyboardMouseString | System.String | Private |
| _grappleFreeAim | System.Boolean | Private |
| _grapplingHookTargetMemory | System.Boolean | Private |
| _aimMode | System.Int32 | Private |
| _defaultCursor | UnityEngine.Texture2D | Private |
| _grappleCursor | UnityEngine.Texture2D | Private |
| _shouldCursorBeVisible | System.Boolean | Private |
| _cursorLockMode | UnityEngine.CursorLockMode | Private |
| _stateFourCC | UnityEngine.InputSystem.Utilities.FourCC | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| PlayerInput | DynamikaCharacterInput | Public |
| UIInput | UIInput | Public |
| CurrentInputDevice | WildSkies.Service.InputService/CurrentDevice | Public |
| CurrentPriorityInput | WildSkies.Service.InputService/InputMode | Public |
| SpectatorCamInput | SpectatorCamInput | Public |
| DroneCamInput | DroneCamInput | Public |
| ShipControls | ShipControllerInput | Public |
| TurretControls | TurretControlInput | Public |
| MastControls | MastControlInput | Public |
| CraftingToolInput | CraftingToolInput | Public |
| IsCurrentInputAGamepad | System.Boolean | Public |
| IsCursorVisible | System.Boolean | Public |
| IsAimModeToggle | System.Boolean | Public |
| GrappleFreeAim | System.Boolean | Public |
| GrapplingHookTargetMemory | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_PlayerInput()**: DynamikaCharacterInput (Public)
- **get_UIInput()**: UIInput (Public)
- **get_CurrentInputDevice()**: WildSkies.Service.InputService/CurrentDevice (Public)
- **get_CurrentPriorityInput()**: WildSkies.Service.InputService/InputMode (Public)
- **get_SpectatorCamInput()**: SpectatorCamInput (Public)
- **get_DroneCamInput()**: DroneCamInput (Public)
- **get_ShipControls()**: ShipControllerInput (Public)
- **get_TurretControls()**: TurretControlInput (Public)
- **get_MastControls()**: MastControlInput (Public)
- **get_CraftingToolInput()**: CraftingToolInput (Public)
- **get_IsCurrentInputAGamepad()**: System.Boolean (Public)
- **get_IsCursorVisible()**: System.Boolean (Public)
- **get_IsAimModeToggle()**: System.Boolean (Public)
- **get_GrappleFreeAim()**: System.Boolean (Public)
- **get_GrapplingHookTargetMemory()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **GetInvertY()**: System.Boolean (Public)
- **SetInvertY(System.Boolean enable)**: System.Void (Public)
- **GetInvertX()**: System.Boolean (Public)
- **SetInvertX(System.Boolean enable)**: System.Void (Public)
- **GetAimMode()**: System.Int32 (Public)
- **SetAimMode(System.Int32 aimMode)**: System.Void (Public)
- **SetMouseXSensitivity(System.Single value)**: System.Void (Public)
- **GetMouseXSensitivity()**: System.Single (Public)
- **SetMouseYSensitivity(System.Single value)**: System.Void (Public)
- **GetMouseYSensitivity()**: System.Single (Public)
- **SetControllerXSensitivity(System.Single value)**: System.Void (Public)
- **GetControllerXSensitivity()**: System.Single (Public)
- **SetControllerYSensitivity(System.Single value)**: System.Void (Public)
- **GetControllerYSensitivity()**: System.Single (Public)
- **SetMouseADSSensitivity(System.Single value)**: System.Void (Public)
- **GetMouseADSSensitivity()**: System.Single (Public)
- **SetControllerADSSensitivity(System.Single value)**: System.Void (Public)
- **GetControllerADSSensitivity()**: System.Single (Public)
- **SetUseMouseAcceleration(System.Boolean useMouseAcceleration)**: System.Void (Public)
- **GetUseMouseAcceleration()**: System.Boolean (Public)
- **SetGrapplingHookTargetMemory(System.Boolean enable)**: System.Void (Public)
- **GetGrapplingHookTargetMemory()**: System.Boolean (Public)
- **SetFreeAimGrapplingHook(System.Boolean enable)**: System.Void (Public)
- **GetFreeAimGrapplingHook()**: System.Boolean (Public)
- **EnterInputMode(WildSkies.Service.InputService/InputMode mode, System.Boolean setPriority)**: System.Void (Public)
- **ExitInputMode(WildSkies.Service.InputService/InputMode mode)**: System.Void (Public)
- **SetDefaultPriorityInput()**: System.Void (Private)
- **OnInputEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr e, UnityEngine.InputSystem.InputDevice device)**: System.Void (Private)
- **LateUpdate()**: System.Void (Public)
- **SetGrapplingHookEquipped(System.Boolean isGrapplingHookEquipped)**: System.Void (Public)
- **SetShipyardNormalModeInputContext()**: System.Void (Public)
- **SetShipyardFaceModeInputContext()**: System.Void (Public)
- **SetShipyardEdgeModeInputContext()**: System.Void (Public)
- **SetShipyardVertexModeInputContext()**: System.Void (Public)
- **DisableAllDroneModes()**: System.Void (Public)
- **ResolveInputMode()**: System.Void (Private)
- **UpdateCursor()**: System.Void (Private)
- **PauseKeyDown()**: System.Boolean (Public)
- **TabNavigateLeftKeyDown()**: System.Boolean (Public)
- **TabNavigateRightKeyDown()**: System.Boolean (Public)
- **SubTabNavigateLeftKeyDown()**: System.Boolean (Public)
- **SubTabNavigateRightKeyDown()**: System.Boolean (Public)
- **CycleWindowLeftKeyDown()**: System.Boolean (Public)
- **CycleWindowRightKeyDown()**: System.Boolean (Public)
- **DebugKeyDown()**: System.Boolean (Public)
- **InventoryKeyDown()**: System.Boolean (Public)
- **InventoryKeyHeld()**: System.Boolean (Public)
- **InventoryKeyUp()**: System.Boolean (Public)
- **CharacterMenuKeyDown()**: System.Boolean (Public)
- **CompendiumMenuKeyDown()**: System.Boolean (Public)
- **CompendiumMenuKeyHeld()**: System.Boolean (Public)
- **CompendiumMenuKeyUp()**: System.Boolean (Public)
- **BuildingMenuKeyDown()**: System.Boolean (Public)
- **EquipmentWheelKeyDown()**: System.Boolean (Public)
- **EquipmentWheelKeyUp()**: System.Boolean (Public)
- **MapKeyDown()**: System.Boolean (Public)
- **SchematicsKeyDown()**: System.Boolean (Public)
- **BuildingModeKeyDown()**: System.Boolean (Public)
- **CloseInteractionUIKeyDown()**: System.Boolean (Public)
- **BackKeyUp()**: System.Boolean (Public)
- **PingPressed()**: System.Boolean (Public)
- **PingHeld()**: System.Boolean (Public)
- **PingCleared()**: System.Boolean (Public)
- **SetSelectedGameObject(UnityEngine.GameObject selectable)**: System.Void (Public)
- **GetCurrentlySelectedGameObject()**: UnityEngine.GameObject (Public)
- **UnsetSelectedGameObject()**: System.Void (Public)
- **SetCurrentInputDevice(UnityEngine.InputSystem.InputDevice device)**: System.Void (Private)
- **SetAllPlayerInputEnabled(System.Boolean isEnabled)**: System.Void (Public)
- **SetPlayerActionsForPlacementMode(System.Boolean isInPlacementMode)**: System.Void (Public)
- **ToggleCursorVisibleAndUnlocked()**: System.Void (Public)
- **SetCursorBehaviour(WildSkies.Service.InputService/CursorBehaviour targetBehaviour, WildSkies.Service.InputService/CursorTexture targetTexture)**: System.Void (Public)
- **UpdateCursorSettings()**: System.Void (Private)
- **ShouldCursorBeVisible()**: System.Boolean (Private)
- **GetCursorLockMode()**: UnityEngine.CursorLockMode (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

