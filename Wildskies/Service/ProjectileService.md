# WildSkies.Service.ProjectileService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| RicochetMinDotProduct | System.Single | Private |
| RicochetChance | System.Single | Private |
| Projectiles | System.Collections.Generic.List`1<WildSkies.Service.ProjectileService/ProjectileInstance> | Private |
| _hitBuffer | UnityEngine.RaycastHit[] | Private |
| _pools | System.Collections.Generic.Dictionary`2<WildSkies.Service.ProjectileType,WildSkies.Service.ProjectileService/ProjectilePool> | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **.ctor(UnityEngine.Transform parent, WildSkies.Service.PoolableProjectileData[] poolData, WildSkies.Service.Interface.ColliderLookupService colliderLookupService)**: System.Void (Public)
- **InitProjectile(WildSkies.Service.ProjectileType projectileType, WildSkies.Service.ProjectileService/ProjectileData data, System.Action`1<UnityEngine.RaycastHit> onHit, System.Int32 syncId, System.Boolean isRemote)**: System.Void (Public)
- **FixedUpdate()**: System.Void (Public)
- **StopProjectile(System.Int32 syncId)**: System.Void (Public)

