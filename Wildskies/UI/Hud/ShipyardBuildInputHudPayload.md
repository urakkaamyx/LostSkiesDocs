# Wildskies.UI.Hud.ShipyardBuildInputHudPayload

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _buildStateEnum | Wildskies.UI.Hud.ShipyardBuildInputHudPayload/BuildStateEnum | Private |
| _mainActions | System.Collections.Generic.List`1<Wildskies.UI.Hud.ActionData> | Private |
| _secondaryActions | System.Collections.Generic.List`1<Wildskies.UI.Hud.ActionData> | Private |
| _blockedAxis | System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis> | Private |
| _hoveredGizmoArm | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm | Private |
| _mainActionsDirty | System.Boolean | Private |
| _secondaryActionsDirty | System.Boolean | Private |
| _availableActions | Wildskies.UI.Hud.ActionData[] | Private |
| GamePadDevices | WildSkies.Service.InputService/CurrentDevice[] | Private |
| MouseAndKeyboardDevice | WildSkies.Service.InputService/CurrentDevice[] | Private |
| AllDevices | WildSkies.Service.InputService/CurrentDevice[] | Private |
| _selectedShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| _hoveredShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| _showingDeviceInput | WildSkies.Service.InputService/CurrentDevice | Private |
| ShipTableString | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| MainActions | System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.ActionData> | Public |
| SecondaryActions | System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.ActionData> | Public |
| MainActionsDirty | System.Boolean | Public |
| SecondaryActionsDirty | System.Boolean | Public |

## Methods

- **get_MainActions()**: System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.ActionData> (Public)
- **get_SecondaryActions()**: System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.ActionData> (Public)
- **get_MainActionsDirty()**: System.Boolean (Public)
- **get_SecondaryActionsDirty()**: System.Boolean (Public)
- **InitializeAvailableActions()**: System.Void (Private)
- **CanShowCurveControls()**: System.Boolean (Private)
- **SetState(Wildskies.UI.Hud.ShipyardBuildInputHudPayload/BuildStateEnum targetStateEnum)**: System.Void (Public)
- **UpdateActions()**: System.Void (Private)
- **ClearMainActionsDirtyFlag()**: System.Void (Public)
- **ClearSecondaryActionsDirtyFlag()**: System.Void (Public)
- **SetInputService(WildSkies.Service.InputService inputService)**: System.Void (Public)
- **OnInputDeviceChanged(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **SetAxisBlocked(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis, System.Boolean isBlocked)**: System.Void (Public)
- **SetHoveredArm(WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm hoveredGizmoArm)**: System.Void (Public)
- **Dispose()**: System.Void (Public)
- **SetHoveredShipPart(WildSkies.Gameplay.ShipBuilding.ShipHullPart hoveredShipPart)**: System.Void (Public)
- **SetSelectedShipPart(WildSkies.Gameplay.ShipBuilding.ShipHullPart selectedShipPart)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)
- **<InitializeAvailableActions>b__27_0()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_1()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_2()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_3()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_4()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_5()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_6()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_7()**: System.Boolean (Private)
- **<InitializeAvailableActions>b__27_8()**: System.Boolean (Private)

