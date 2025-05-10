# WildSkies.Gameplay.Building.BuildableStampUtils

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| pts | UnityEngine.Vector3[] | Private |
| ptScales | UnityEngine.Vector3[] | Private |

## Methods

- **RemoveAllComponentsButRenderers(UnityEngine.GameObject newStamp, System.Collections.Generic.List`1<UnityEngine.Transform> exclusions)**: System.Void (Public)
- **CheckForExclusions(UnityEngine.Component[] components, System.Collections.Generic.List`1<UnityEngine.Transform> exclusions)**: System.Void (Private)
- **RemoveScripts(UnityEngine.Component[] components)**: System.Void (Private)
- **SetRenderersToGhostLayer(UnityEngine.GameObject newStamp)**: System.Void (Public)
- **CleanUpEmptyGameObjects(UnityEngine.Component[] components, System.Collections.Generic.List`1<UnityEngine.Transform> exclusions)**: System.Void (Private)
- **CleanUpStaticComponents(UnityEngine.GameObject visualsParent)**: System.Void (Public)
- **GenerateClearanceVolumes(UnityEngine.GameObject colliderParent, UnityEngine.GameObject clearanceVolumeParent, System.Boolean generateClearanceVolumes, System.Boolean combineCollidersWithSameParent, System.Boolean destroyColliders)**: System.Void (Public)
- **AddGroundClearanceToBounds(UnityEngine.Bounds& colliderBounds, System.Single minYBoundClearance)**: System.Boolean (Private)
- **AddColliderToBounds(UnityEngine.GameObject clearanceVolumeParent, UnityEngine.Collider collider, UnityEngine.Bounds& colliderBounds, System.Boolean& boundsInitialised)**: System.Void (Private)
- **GetColliderMetadata(UnityEngine.Collider collider, System.Boolean& ignoreCollider, UnityEngine.Vector3& colliderScale)**: System.Void (Private)
- **ParseScaleString(System.String scaleStr)**: UnityEngine.Vector3 (Private)
- **.cctor()**: System.Void (Private)

