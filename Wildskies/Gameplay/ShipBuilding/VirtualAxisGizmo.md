# WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _idleResetFocusedAxis | System.Single | Private |
| _gizmoMouseManipulator | WildSkies.Gameplay.ShipBuilding.GizmoMouseManipulator | Private |
| _availableAxisArms | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm[] | Private |
| _focusedAxis | System.Nullable`1<WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis> | Private |
| _focusedAxisStartUse | System.Single | Private |
| _axisToOthers | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis,WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis[]> | Private |
| _uiPayload | Wildskies.UI.Hud.ShipyardBuildInputHudPayload | Private |
| _selectedShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| GizmoMouseManipulator | WildSkies.Gameplay.ShipBuilding.GizmoMouseManipulator | Public |
| IsVisible | System.Boolean | Public |
| SelectedShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Public |

## Methods

- **get_GizmoMouseManipulator()**: WildSkies.Gameplay.ShipBuilding.GizmoMouseManipulator (Public)
- **get_IsVisible()**: System.Boolean (Public)
- **get_SelectedShipPart()**: WildSkies.Gameplay.ShipBuilding.ShipHullPart (Public)
- **Awake()**: System.Void (Protected)
- **InitializeAxis()**: System.Void (Private)
- **HideAll(System.Boolean animated)**: System.Void (Public)
- **SetPosition(UnityEngine.Vector3 targetPosition)**: System.Void (Public)
- **SetAxisVisible(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis, System.Boolean showPositive, System.Boolean showNegative)**: System.Void (Public)
- **SetAxisExpanded(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis, System.Boolean showPositive, System.Boolean showNegative)**: System.Void (Public)
- **SetAllAxisExpanded(System.Boolean positive, System.Boolean negative)**: System.Void (Public)
- **SetAxisExpanded(System.Boolean showX, System.Boolean showNegativeX, System.Boolean showY, System.Boolean showNegativeY, System.Boolean showZ, System.Boolean showNegativeZ, System.Boolean animated)**: System.Void (Private)
- **SetAxisVisible(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis, WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo/AxisDirection direction, System.Boolean visible, System.Boolean animated)**: System.Void (Private)
- **SetAxisExpanded(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis, WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo/AxisDirection direction, System.Boolean visible, System.Single delay, System.Boolean animated)**: System.Void (Private)
- **TryGetAxis(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis, WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo/AxisDirection direction, WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm& resultArm)**: System.Boolean (Private)
- **ResetFocusedAxis()**: System.Void (Private)
- **SetFocusedAxis(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis)**: System.Void (Public)
- **SetVisibleAxis(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis)**: System.Void (Public)
- **SetAllAxisVisible(System.Boolean positive, System.Boolean negative)**: System.Void (Public)
- **ConvertAxisByCurrentRotation(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis targetAxis)**: WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis (Private)
- **LateUpdate()**: System.Void (Private)
- **UpdateFocusedAxis()**: System.Void (Private)
- **UpdateGizmoRotationFromCamera(UnityEngine.Transform cameraTransform, System.Boolean animated)**: System.Void (Public)
- **SetUIPayload(Wildskies.UI.Hud.ShipyardBuildInputHudPayload buildInputPayload)**: System.Void (Public)
- **SetHoveredArm(WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm hoveredGizmoArm)**: System.Void (Public)
- **SetCurrentShipPart(WildSkies.Gameplay.ShipBuilding.ShipHullPart selectedShipPart)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

