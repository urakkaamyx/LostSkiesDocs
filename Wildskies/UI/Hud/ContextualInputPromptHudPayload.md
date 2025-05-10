# Wildskies.UI.Hud.ContextualInputPromptHudPayload

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _playerStateEnum | Wildskies.UI.Hud.ContextualInputPromptHudPayload/PlayerStateEnum | Private |
| _mainActions | System.Collections.Generic.List`1<Wildskies.UI.Hud.InputActionData> | Private |
| _secondaryActions | System.Collections.Generic.List`1<Wildskies.UI.Hud.InputActionData> | Private |
| _blockedAxis | System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis> | Private |
| _hoveredGizmoArm | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm | Private |
| _mainActionsDirty | System.Boolean | Private |
| _secondaryActionsDirty | System.Boolean | Private |
| _availableActions | Wildskies.UI.Hud.InputActionData[] | Private |
| GamePadDevices | WildSkies.Service.InputService/CurrentDevice[] | Private |
| MouseAndKeyboardDevice | WildSkies.Service.InputService/CurrentDevice[] | Private |
| AllDevices | WildSkies.Service.InputService/CurrentDevice[] | Private |
| _selectedShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| _hoveredShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| _showingDeviceInput | WildSkies.Service.InputService/CurrentDevice | Private |
| _glider | Bossa.Dynamika.Utilities.ParagliderItem | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| MainActions | System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.InputActionData> | Public |
| SecondaryActions | System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.InputActionData> | Public |
| MainActionsDirty | System.Boolean | Public |
| SecondaryActionsDirty | System.Boolean | Public |

## Methods

- **get_MainActions()**: System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.InputActionData> (Public)
- **get_SecondaryActions()**: System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.InputActionData> (Public)
- **get_MainActionsDirty()**: System.Boolean (Public)
- **get_SecondaryActionsDirty()**: System.Boolean (Public)
- **DoesPlayerHaveGlider()**: System.Boolean (Public)
- **IsGliderDraining()**: System.Boolean (Public)
- **InitializeAvailableActions()**: System.Void (Private)
- **SetState(Wildskies.UI.Hud.ContextualInputPromptHudPayload/PlayerStateEnum targetStateEnum, System.Boolean overrideState)**: System.Void (Public)
- **GetState()**: Wildskies.UI.Hud.ContextualInputPromptHudPayload/PlayerStateEnum (Public)
- **UpdateActions()**: System.Void (Private)
- **ClearMainActionsDirtyFlag()**: System.Void (Public)
- **ClearSecondaryActionsDirtyFlag()**: System.Void (Public)
- **SetInputService(WildSkies.Service.InputService inputService)**: System.Void (Public)
- **SetBuildingService(WildSkies.Service.BuildingService buildingService)**: System.Void (Public)
- **SetLocalPlayerService(WildSkies.Service.ILocalPlayerService localPlayerService)**: System.Void (Public)
- **OnInputDeviceChanged(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **Dispose()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)
- **<InitializeAvailableActions>b__31_0()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_1()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_3()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_4()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_10()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_12()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_13()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_16()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_17()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_18()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_19()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_20()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_21()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_23()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_24()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_26()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_27()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_28()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_29()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_30()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_31()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_32()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_33()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__31_34()**: System.Boolean (Private)

