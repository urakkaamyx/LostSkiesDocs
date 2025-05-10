# WildSkies.Gameplay.Building.PlacementStampController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| AssociatedPrefab | UnityEngine.GameObject | Public |
| AssociatedAssetDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Public |
| Prewarm | System.Boolean | Public |
| GenerateDynamicStamp | System.Boolean | Public |
| GenerateDynamicStampClearanceVolumes | System.Boolean | Public |
| CombineCollidersWithSameParent | System.Boolean | Public |
| DynamicVisualsParent | UnityEngine.GameObject | Public |
| DynamicClearanceVolumesParent | UnityEngine.GameObject | Public |
| _generatedStampTemplates | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> | Private |
| _craftableRendererController | CraftableRendererController | Private |
| _clearanceArea | WildSkies.Gameplay.Building.ClearanceVolumeParent | Private |
| _controllerRotationSpeed | System.Single | Private |
| _lerpSpeed | System.Single | Private |
| _hasBeenPlaced | System.Boolean | Private |
| _wasPreviouslyValid | System.Boolean | Private |
| _surfaceNormal | UnityEngine.Vector3 | Private |
| _targetYRotation | UnityEngine.Quaternion | Private |
| _surfaceRotation | UnityEngine.Quaternion | Private |
| DegreeTolerance | System.Single | Private |
| _adjustedPosition | UnityEngine.Vector3 | Private |
| OnRotate | System.Action | Public |
| _parentRotation | UnityEngine.Quaternion | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ClearanceArea | WildSkies.Gameplay.Building.ClearanceVolumeParent | Public |
| AdjustedPosition | UnityEngine.Vector3 | Public |
| TargetYRotation | UnityEngine.Quaternion | Public |

## Methods

- **get_ClearanceArea()**: WildSkies.Gameplay.Building.ClearanceVolumeParent (Public)
- **get_AdjustedPosition()**: UnityEngine.Vector3 (Public)
- **set_AdjustedPosition(UnityEngine.Vector3 value)**: System.Void (Public)
- **get_TargetYRotation()**: UnityEngine.Quaternion (Public)
- **set_TargetYRotation(UnityEngine.Quaternion value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **Rotate(System.Single value, System.Boolean usingGamepad)**: System.Void (Public)
- **SetNormal(UnityEngine.Vector3 normal)**: System.Void (Public)
- **ResetYRotation()**: System.Void (Public)
- **SetParentRotation(UnityEngine.Quaternion parentRotation)**: System.Void (Public)
- **StartBuild()**: System.Void (Public)
- **StopBuild()**: System.Void (Public)
- **UpdateRotation()**: System.Void (Private)
- **SetRotation(System.Boolean snap)**: System.Void (Private)
- **InitialiseHologram()**: System.Void (Public)
- **Activate(UnityEngine.Vector3 position)**: System.Void (Public)
- **Deactivate()**: System.Void (Public)
- **SetIsVisible(System.Boolean isVisible, System.Boolean initialState)**: System.Void (Public)
- **SetValidState(System.Boolean isValid, System.Single stateTransitionDuration)**: System.Void (Public)
- **IsObstructed()**: System.Boolean (Public)
- **IsCached(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> stampTemplates)**: System.Boolean (Public)
- **SetGeneratedStampTemplates(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> stampTemplates)**: System.Void (Public)
- **RemoveDynamicStampObjects()**: System.Void (Public)
- **DestroyChildObjects(UnityEngine.Transform t)**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

