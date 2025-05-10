# WildSkies.Gameplay.Building.CraftingToolPlacementData

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| TerrainLayer | System.String | Private |
| NonCollidingLayer | System.String | Private |
| PanelRaycastDeadzoneDistance | System.Single | Private |
| MaxRaycastDistance | System.Single | Private |
| <IsPlacingPanel>k__BackingField | System.Boolean | Private |
| <IsPlacingBeam>k__BackingField | System.Boolean | Private |
| SelectedAssetDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Public |
| PlacementMatrix | WildSkies.Gameplay.ShipBuilding.ShipPartPlacementMatrix | Public |
| SelectedAssetCraftingItemIds | System.Collections.Generic.List`1<System.String> | Public |
| UpgradeLevel | System.Int32 | Public |
| SelectedAssetController | WildSkies.Gameplay.Building.PlacementStampController | Public |
| ignoreCollisionWithGameObjects | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |
| LookAtPoint | WildSkies.Gameplay.Building.LookAtPointData | Public |
| RotationSteps | System.Int32 | Public |
| ShipPanelRotationSteps | System.Int32 | Public |
| _placementRange | System.Single | Private |
| _isLookingAtSomething | System.Boolean | Private |
| _isCompatibleSurface | System.Boolean | Private |
| _currentCameraPos | UnityEngine.Vector3 | Private |
| _buildableLayers | UnityEngine.LayerMask | Private |
| _raycastHits | UnityEngine.RaycastHit[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsPlacingAsset | System.Boolean | Public |
| IsPlacingPanel | System.Boolean | Public |
| IsPlacingBeam | System.Boolean | Public |
| BroadRotationMultiplier | System.Int32 | Public |
| RightAngleRotationMultiplier | System.Int32 | Public |

## Methods

- **get_IsPlacingAsset()**: System.Boolean (Public)
- **get_IsPlacingPanel()**: System.Boolean (Public)
- **set_IsPlacingPanel(System.Boolean value)**: System.Void (Private)
- **get_IsPlacingBeam()**: System.Boolean (Public)
- **set_IsPlacingBeam(System.Boolean value)**: System.Void (Private)
- **get_BroadRotationMultiplier()**: System.Int32 (Public)
- **get_RightAngleRotationMultiplier()**: System.Int32 (Public)
- **GetLookAtData(System.Boolean ignoreSnapping, UnityEngine.Transform camera, UnityEngine.Transform player)**: System.Void (Public)
- **GetSnappedHitPoint(UnityEngine.RaycastHit hit)**: UnityEngine.Vector3 (Private)
- **UpdateCameraPosition(UnityEngine.Transform camera)**: System.Void (Public)
- **TryGetBuildableAssetLookingAt(UnityEngine.RaycastHit& raycastHit)**: System.Void (Private)
- **TryGetShipHullFaceLookingAt(UnityEngine.Transform camera, UnityEngine.RaycastHit raycastHit)**: System.Void (Private)
- **TryGetShipHullEdgeLookingAt(UnityEngine.RaycastHit raycastHit)**: System.Void (Private)
- **IsPlacementPosValid()**: System.Boolean (Private)
- **IsCompatibleSurfaceType()**: System.Boolean (Private)
- **GetShipHullPart()**: WildSkies.Gameplay.ShipBuilding.ShipHullPart (Public)
- **GetShipFacePart()**: WildSkies.Gameplay.ShipBuilding.ShipHullFace (Public)
- **GetShipEdgePart()**: WildSkies.Gameplay.ShipBuilding.ShipHullEdge (Public)
- **GetShipHullObject()**: WildSkies.Gameplay.ShipBuilding.ShipHullObject (Public)
- **IsLookingAtShip()**: System.Boolean (Private)
- **UpdateIsPlacingPanel()**: System.Void (Public)
- **UpdateIsPlacingBeam()**: System.Void (Public)
- **PlaceableOnFace()**: System.Boolean (Private)
- **IsLookingAtIsland()**: System.Boolean (Private)
- **GetDesiredHitPoint(UnityEngine.Transform camera, UnityEngine.Vector3 raycastDir, UnityEngine.Transform player, UnityEngine.RaycastHit& raycastHit)**: System.Boolean (Private)
- **CameraRaycast(UnityEngine.Transform origin, UnityEngine.Vector3 raycastDir, UnityEngine.RaycastHit& hit)**: System.Boolean (Private)
- **CameraRaycastAll(UnityEngine.Transform origin, UnityEngine.Vector3 raycastDir, System.Int32& hitCount)**: System.Boolean (Private)
- **IsHitPointInRange()**: System.Boolean (Public)
- **GetClosestHitExcludingBuildableAssets(System.Int32 hitCount, System.Single minDistance, System.Boolean isPlacingAsset)**: UnityEngine.RaycastHit (Private)
- **IsFaceAxis(System.Int32 i, WildSkies.Gameplay.ShipBuilding.AxisEnum/Axis axis)**: System.Boolean (Private)
- **IsFace(System.Int32 i)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

