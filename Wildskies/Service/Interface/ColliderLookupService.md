# WildSkies.Service.Interface.ColliderLookupService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| QueryBufferSize | System.Int32 | Private |
| _ropeListeners | System.Collections.Generic.Dictionary`2<UnityEngine.Collider,Services.IRopeListener> | Private |
| _damageables | System.Collections.Generic.Dictionary`2<UnityEngine.Collider,Entities.Weapons.IDamageable> | Private |
| _relayReceivers | System.Collections.Generic.Dictionary`2<UnityEngine.Collider,WildSkies.Puzzles.IRelayReceiver> | Private |
| _queryBuffer | UnityEngine.Collider[] | Private |
| _damageQueryResponseBuffer | WildSkies.Service.Interface.ColliderLookupService/DamageQueryResponse[] | Private |
| _processed | System.Collections.Generic.HashSet`1<Entities.Weapons.IDamageable> | Private |
| _damagableLayerMask | UnityEngine.LayerMask | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **AOEDamage(UnityEngine.Vector3 position, System.Single radius, System.Single damageAtCenter, System.Single damageAtEdge, WildSkies.Weapon.DamageType damageType, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, WildSkies.Service.Interface.ColliderLookupService/DamageQueryResponse[]& responses, Entities.Weapons.IDamageable[] ignoreComponents)**: System.Int32 (Public)
- **SphereQuery(UnityEngine.Vector3 position, System.Single radius, UnityEngine.LayerMask layerMaskForQuery, WildSkies.Service.Interface.ColliderLookupService/DamageQueryResult[]& results)**: System.Int32 (Public)
- **Add(UnityEngine.Collider collider, T component)**: System.Void (Public)
- **Add(UnityEngine.Collider collider, ColliderLookupBehaviour colliderLookupBehaviour)**: System.Void (Public)
- **Remove(UnityEngine.Collider collider)**: System.Void (Public)
- **TryGet(UnityEngine.Collider collider, T& result)**: System.Boolean (Public)
- **Get(UnityEngine.Collider collider)**: T (Public)
- **.ctor()**: System.Void (Public)

