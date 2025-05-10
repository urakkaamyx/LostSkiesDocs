# WildSkies.Gameplay.Building.ClearanceVolume

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _buildingService | WildSkies.Service.BuildingService | Private |
| _isObstructed | System.Boolean | Private |
| _overrideObstruction | System.Boolean | Private |
| _collider | UnityEngine.Collider | Private |
| _ownClearanceVolumeColliders | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _clearanceVolumeHits | UnityEngine.Collider[] | Private |
| _currentObstructions | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _currentCastHits | System.Int32 | Private |
| _collidableLayers | UnityEngine.LayerMask | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsObstructed | System.Boolean | Public |
| OverrideObstruction | System.Boolean | Public |
| Collider | UnityEngine.Collider | Public |

## Methods

- **get_IsObstructed()**: System.Boolean (Public)
- **set_IsObstructed(System.Boolean value)**: System.Void (Public)
- **get_OverrideObstruction()**: System.Boolean (Public)
- **set_OverrideObstruction(System.Boolean value)**: System.Void (Public)
- **get_Collider()**: UnityEngine.Collider (Public)
- **Awake()**: System.Void (Private)
- **Initialise(System.Collections.Generic.List`1<UnityEngine.Collider> allClearanceVolumeColliders)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **PerformBoxCollisionCheck(UnityEngine.BoxCollider boxCollider)**: System.Void (Private)
- **PerformSphereCollisionCheck(UnityEngine.SphereCollider sphereCollider)**: System.Void (Private)
- **PerformCapsuleCollisionCheck(UnityEngine.CapsuleCollider capsuleCollider)**: System.Void (Private)
- **CheckHitsForObstruction()**: System.Void (Private)
- **HittingAssetsOwnColliders(UnityEngine.Collider other)**: System.Boolean (Private)
- **RefreshCurrentObstructionList()**: System.Void (Private)
- **ResolveDependencies()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

