# WildSkies.AI.Attacks.EnemyGrapple

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _layerMask | UnityEngine.LayerMask | Private |
| _entityDeathHandling | EntityDeathHandling | Private |
| _playerSideGrapple | WildSkies.AI.Attacks.EnemyGrapplePlayerSide | Private |
| _hitPlayer | UnityEngine.Transform | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsActive | System.Boolean | Public |

## Methods

- **get_IsActive()**: System.Boolean (Public)
- **ContextMenu_DetachTest()**: System.Void (Public)
- **Awake()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnEntityDeath(UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **TryFireAtTarget(UnityEngine.Transform target, UnityEngine.Vector3& hitPoint, System.Single maxDistance)**: System.Boolean (Public)
- **DetachGrapple()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

