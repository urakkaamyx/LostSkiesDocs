# WildSkies.Gameplay.ShipBuilding.Drone

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <ShipyardDrone>k__BackingField | ShipyardDroneControl | Private |
| mirrorHelper | WildSkies.Gameplay.ShipBuilding.MirrorHelper | Public |
| SelectionIgnoreLayer | UnityEngine.LayerMask | Public |
| ShipFrameLayer | UnityEngine.LayerMask | Public |
| RaycastRange | System.Single | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _shipBuilderController | WildSkies.Gameplay.ShipBuilding.ShipBuilderController | Private |
| _virtualAxisGizmo | WildSkies.Gameplay.ShipBuilding.VirtualAxisGizmo | Private |
| _gizmoMouseManipulator | WildSkies.Gameplay.ShipBuilding.GizmoMouseManipulator | Private |
| _defaultOrbitDistance | System.Single | Private |
| _buildInputPayload | Wildskies.UI.Hud.ShipyardBuildInputHudPayload | Private |
| _selectedShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| _vertexCyclingDirection | System.Boolean | Private |
| _lastSelectedVertIndex | System.Int32 | Private |
| _lastSelectedNonVertex | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| ImpactPoint | UnityEngine.Vector3 | Private |
| EdgeDetectionSphereRadius | System.Single | Private |
| _lastDroneMode | WildSkies.Gameplay.ShipBuilding.Drone/Mode | Private |
| _debugLogging | System.Boolean | Private |
| _debugLoggingInfo | System.Text.StringBuilder | Private |
| savedShipCoords | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> | Private |
| savedMirroredShipCoords | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> | Private |
| savedCurvynessV0toV1 | System.Single | Private |
| savedCurvynessV0toV3 | System.Single | Private |
| savedCurveIsV0ToV1 | System.Boolean | Private |
| _hoveredShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Private |
| axisToPosNegMovement | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis,System.ValueTuple`2<UnityEngine.Vector3,UnityEngine.Vector3>> | Private |
| _currentAxisLimit | WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis | Private |
| inputValues | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis,System.Single> | Private |
| _overlapSphereResults | UnityEngine.Collider[] | Private |
| _hitResults | UnityEngine.RaycastHit[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentMode | WildSkies.Gameplay.ShipBuilding.Drone/Mode | Public |
| ShipyardDrone | ShipyardDroneControl | Public |
| BuildInputPayload | Wildskies.UI.Hud.ShipyardBuildInputHudPayload | Public |
| SelectedShipPart | WildSkies.Gameplay.ShipBuilding.ShipHullPart | Public |
| HasSelectedShipPart | System.Boolean | Public |
| DebugLogging | System.Boolean | Public |

## Methods

- **get_CurrentMode()**: WildSkies.Gameplay.ShipBuilding.Drone/Mode (Public)
- **get_ShipyardDrone()**: ShipyardDroneControl (Public)
- **set_ShipyardDrone(ShipyardDroneControl value)**: System.Void (Public)
- **get_BuildInputPayload()**: Wildskies.UI.Hud.ShipyardBuildInputHudPayload (Public)
- **get_SelectedShipPart()**: WildSkies.Gameplay.ShipBuilding.ShipHullPart (Public)
- **get_HasSelectedShipPart()**: System.Boolean (Public)
- **get_DebugLogging()**: System.Boolean (Public)
- **set_DebugLogging(System.Boolean value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **OnDisable()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **UpdateUIPayload()**: System.Void (Private)
- **GetTransformFullPath(UnityEngine.Transform current)**: System.String (Private)
- **OnShipYardActivated(System.Boolean active)**: System.Void (Private)
- **HandleShipBuildingInputs()**: System.Void (Private)
- **SelectVertex(WildSkies.Gameplay.ShipBuilding.ShipHullPart shipPart)**: System.Void (Private)
- **FindTopLeftVertex(WildSkies.Gameplay.ShipBuilding.HullVertex[] verts, System.Int32& lastSelectedVertIndex, System.Boolean& vertexCyclingDirection)**: System.Void (Private)
- **GetPartCameraDirection(WildSkies.Gameplay.ShipBuilding.ShipHullFace targetHullFace)**: WildSkies.Gameplay.ShipBuilding.HullFace/Direction (Private)
- **SetSelectedShipPart(WildSkies.Gameplay.ShipBuilding.ShipHullPart targetHullPart, System.Boolean shouldSelectOnGamePad)**: System.Void (Public)
- **HandlePlatformSpecificInputs()**: System.Void (Private)
- **ClearSelectedShipPart()**: System.Void (Public)
- **UpdateHoveredShipPart()**: System.Void (Private)
- **GetClosestValidShipPart(UnityEngine.RaycastHit[] hits, System.Int32 numHits)**: System.Int32 (Private)
- **IsShipPartOurs(WildSkies.Gameplay.ShipBuilding.ShipHullPart candidateShipPart)**: System.Boolean (Private)
- **TryAddBlock(WildSkies.Gameplay.ShipBuilding.ShipHullFace face, WildSkies.Gameplay.ShipBuilding.HullVertex[] mirroredVerts, WildSkies.Gameplay.ShipBuilding.HullBlock& resultHullBlock, WildSkies.Gameplay.ShipBuilding.HullBlock& resultMirroredHullBlock)**: System.Boolean (Private)
- **TryGetSameFaceFrom(WildSkies.Gameplay.ShipBuilding.HullBlock resultHullBlock, WildSkies.Gameplay.ShipBuilding.ShipHullFace original, WildSkies.Gameplay.ShipBuilding.ShipHullFace& resultShipHullFace)**: System.Boolean (Private)
- **DeleteBlock(WildSkies.Gameplay.ShipBuilding.ShipHullFace face, WildSkies.Gameplay.ShipBuilding.HullVertex[] mirroredVerts)**: System.Void (Private)
- **HandleModeChange()**: System.Void (Private)
- **UpdateSavedShipVertCoords(WildSkies.Gameplay.ShipBuilding.HullVertex[] mirroredVerts)**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **UpdateInputs()**: System.Void (Public)
- **HandleSelectedMovement(System.Boolean finePlacement)**: System.Void (Private)
- **UpdateGizmoPosition()**: System.Void (Private)
- **UpdateGizmoVisibility(System.Single speed, WildSkies.Gameplay.ShipBuilding.HullVertex[] verts, System.Boolean finePlacement)**: System.Void (Private)
- **GetStickAxes(System.Single& projectedLookAtAngleXZ)**: WildSkies.Gameplay.ShipBuilding.Drone/StickAxis[] (Private)
- **CanPerformMove(WildSkies.Gameplay.ShipBuilding.HullVertex[] verts, WildSkies.Gameplay.ShipBuilding.HullVertex hullVertex, UnityEngine.Vector3 movement, System.Int32 targetIndex, UnityEngine.Vector3[] newPositions, UnityEngine.Vector3[] mirroredValues, UnityEngine.Vector3[] positionsOffsetRelativeToBounds, System.Boolean finePlacement)**: System.Boolean (Private)
- **CheckForVertexCrossover(WildSkies.Gameplay.ShipBuilding.HullVertex vert, UnityEngine.Vector3 newPosition, UnityEngine.Vector3 movement)**: System.Boolean (Private)
- **AreVerticesCrossingOver(UnityEngine.Vector3 movement, UnityEngine.Vector3 posVert, UnityEngine.Vector3 negVert)**: System.Boolean (Private)
- **PreventMovingVerticesCollisions(UnityEngine.Vector3 movement, UnityEngine.Vector3 iNewPosition, System.Int32 index, WildSkies.Gameplay.ShipBuilding.HullVertex[] verts, UnityEngine.Vector3[] newPositions, UnityEngine.Vector3[] mirroredValues, UnityEngine.Vector3[] positionOffsetRelativeToBounds, System.Boolean finePlacement)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

