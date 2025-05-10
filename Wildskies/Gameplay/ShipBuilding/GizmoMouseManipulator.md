# WildSkies.Gameplay.ShipBuilding.GizmoMouseManipulator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| SPHERE_CAST_RADIUS | System.Single | Private |
| _xAxisCollider | UnityEngine.Collider | Private |
| _yAxisCollider | UnityEngine.Collider | Private |
| _zAxisCollider | UnityEngine.Collider | Private |
| _gizmoLayerMask | UnityEngine.LayerMask | Private |
| _maxDistance | System.Single | Private |
| _movementFactor | System.Single | Private |
| _gizmoManipulatorColliderLayerMask | UnityEngine.LayerMask | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _debugLogging | System.Boolean | Private |
| _debugLoggingInfo | System.Text.StringBuilder | Private |
| _hasCachedVirtualAxisGizmo | System.Boolean | Private |
| _cachedVirtualAxisGizmo | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo | Private |
| _hasCachedShipBuilderController | System.Boolean | Private |
| _cachedShipBuilderController | WildSkies.Gameplay.ShipBuilding.ShipBuilderController | Private |
| _results | UnityEngine.RaycastHit[] | Private |
| _colliderToGizmoArm | System.Collections.Generic.Dictionary`2<UnityEngine.Collider,WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm> | Private |
| _hoveredGizmoArm | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm | Private |
| _manipulatingGizmoArm | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm | Private |
| _previousWorldPosition | System.Nullable`1<UnityEngine.Vector3> | Private |
| _axisFlipped | System.Boolean | Private |
| _axisDelta | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DebugLogging | System.Boolean | Public |
| VirtualAxisGizmo | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo | Private |
| ShipBuilderController | WildSkies.Gameplay.ShipBuilding.ShipBuilderController | Private |
| ManipulatingAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Public |
| HoveringAxis | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Public |
| AxisDelta | System.Single | Public |
| IsManipulatingGizmo | System.Boolean | Public |

## Methods

- **get_DebugLogging()**: System.Boolean (Public)
- **set_DebugLogging(System.Boolean value)**: System.Void (Public)
- **get_VirtualAxisGizmo()**: WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo (Private)
- **get_ShipBuilderController()**: WildSkies.Gameplay.ShipBuilding.ShipBuilderController (Private)
- **get_ManipulatingAxis()**: WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis (Public)
- **get_HoveringAxis()**: WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis (Public)
- **get_AxisDelta()**: System.Single (Public)
- **get_IsManipulatingGizmo()**: System.Boolean (Public)
- **Awake()**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **HandleInput()**: System.Void (Private)
- **TryGetManipulatorWorldHitPosition(UnityEngine.Vector3& worldPosition)**: System.Boolean (Private)
- **HandleGizmoHoveredGizmoArmDetection()**: System.Void (Private)
- **SetHoveredGizmo(WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmoArm currentHoveredGizmo)**: System.Void (Private)
- **SetGizmoManipulatorColliderEnabled(WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis axis, System.Boolean isEnabled)**: System.Void (Private)
- **GetTransformFullPath(UnityEngine.Transform current)**: System.String (Private)
- **.ctor()**: System.Void (Public)

