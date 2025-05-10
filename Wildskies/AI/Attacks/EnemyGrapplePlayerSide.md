# WildSkies.AI.Attacks.EnemyGrapplePlayerSide

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _rope | EnemyRopeTension | Private |
| _ropeVisual | TubeRenderer | Private |
| _virtualTarget | UnityEngine.Transform | Private |
| _reelInSpeed | System.Single | Private |
| _attachPointOnPlayer | UnityEngine.Vector3 | Private |
| _character | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _attachPoint | UnityEngine.Transform | Private |
| _grappleStart | UnityEngine.GameObject | Private |
| _hitPlayer | UnityEngine.Transform | Private |
| VisualTargetPosition | UnityEngine.Vector3 | Public |
| GrappleRopeActive | System.Boolean | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsActive | System.Boolean | Public |

## Methods

- **get_IsActive()**: System.Boolean (Public)
- **ContextMenu_DetachTest()**: System.Void (Public)
- **Start()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **DetachGrapple(System.Boolean triggerOverNetwork)**: System.Void (Public)
- **HitTarget(UnityEngine.RaycastHit hit, UnityEngine.Transform grappleStart, UnityEngine.GameObject enemyObject, System.Single maxDistance)**: System.Void (Public)
- **NAEnemyHitTarget(UnityEngine.GameObject enemyObject, UnityEngine.Vector3 startWorldPoint, UnityEngine.Vector3 endWorldPoint, UnityEngine.Vector3 visualEndWorldPoint)**: System.Void (Public)
- **UpdateRopeVisual(UnityEngine.GameObject enemyObject, System.Boolean triggerOverNetwork)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

