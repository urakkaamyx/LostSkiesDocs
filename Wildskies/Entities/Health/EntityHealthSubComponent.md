# WildSkies.Entities.Health.EntityHealthSubComponent

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _damagedColliders | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _damagedVisuals | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _pristineColliders | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _pristineVisuals | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _searchForEntityHealthSubComponent | System.Boolean | Private |
| _searchForHeraldAttachable | System.Boolean | Private |
| _searchForHeraldMount | System.Boolean | Private |
| _damageTypeOverrides | WildSkies.Weapon.DamageTypeOverrideSettings | Private |
| _vfxType | WildSkies.VfxType | Private |
| _mainEntityHealth | WildSkies.Entities.Health.EntityHealth | Private |
| _skyBossHealth | SkyBossHealth | Private |
| _entityRendererController | EntityRendererController | Private |
| _damageMultiplier | System.Single | Private |
| _destroyedMultiplier | System.Single | Private |
| _destructible | System.Boolean | Private |
| _destroyed | System.Boolean | Private |
| _visuals | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _explosionRadius | System.Single | Private |
| _numberOfSmallExplosions | System.Int32 | Private |
| _minExplosionDelay | System.Single | Private |
| _maxExplosionDelay | System.Single | Private |
| _explosionTransform | UnityEngine.Transform | Private |
| _drawDebugLabel | System.Boolean | Private |
| _debugLabelOffset | UnityEngine.Vector3 | Private |
| _vfxService | WildSkies.Service.VfxPoolService | Private |
| _heraldSubModule | HeraldSubModule | Private |
| _health | System.Single | Private |
| _startHealth | System.Single | Private |
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| _level | System.Int32 | Private |
| _extraDamageOnDestruction | System.Single | Private |
| _connectedEntityHealthSubComponents | System.Collections.Generic.List`1<WildSkies.Entities.Health.EntityHealthSubComponent> | Private |
| _connectedHeraldAttachable | System.Collections.Generic.List`1<HeraldAttachable> | Private |
| _connectedHeraldMount | System.Collections.Generic.List`1<HeraldMount> | Private |
| OnDamage | System.Action`2<WildSkies.Entities.Health.EntityHealthSubComponent,System.Single> | Public |
| OnDestruction | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |
| Health | System.Single | Public |
| StartHealth | System.Single | Public |
| Destructible | System.Boolean | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **get_Health()**: System.Single (Public)
- **get_StartHealth()**: System.Single (Public)
- **get_Destructible()**: System.Boolean (Public)
- **SetMainEntityHealthReference(WildSkies.Entities.Health.EntityHealth mainEntityHealth, SkyBossHealth skyBossHealth)**: System.Void (Public)
- **SetMainEntityLevelling(WildSkies.Service.AILevelsService aiLevelsService, System.Int32 level)**: System.Void (Public)
- **ReduceHealth(System.Single value)**: System.Void (Public)
- **SetStartHealth(System.Single value)**: System.Void (Public)
- **ToggleDestroyedPart(System.Boolean destroyed)**: System.Void (Public)
- **ToggleVisuals(System.Boolean active)**: System.Void (Public)
- **SetHealth(System.Single value)**: System.Void (Public)
- **SetExtraDamageOnDestruction(System.Single value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **SearchForComponents()**: System.Void (Public)
- **ConnectEntityHealthSubComponents()**: System.Void (Public)
- **ConnectHeraldAttachable()**: System.Void (Public)
- **ConnectHeraldMount()**: System.Void (Public)
- **SetEntityRendererControllerReference(EntityRendererController entityRendererController)**: System.Void (Public)
- **SetDamageOverrideSettings(WildSkies.Weapon.DamageTypeOverrideSettings damageTypeOverrideSettings)**: System.Void (Public)
- **SetDestructible(System.Boolean destructible)**: System.Void (Public)
- **SetDamageMultiplier(System.Single damageMultiplier)**: System.Void (Public)
- **SetDestroyedDamageMultiplier(System.Single destryoedMultiplier)**: System.Void (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **DestroyObject()**: System.Void (Public)
- **PlayDestructionEffects()**: System.Void (Private)
- **DebugDamage()**: System.Void (Public)
- **DestroyBodypart()**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

