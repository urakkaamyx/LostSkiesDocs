# WildSkies.AI.Attacks.ChargeAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| AttackType | WildSkies.AI.Attacks.AIAttackType | Private |
| _navAgent | WildSkies.AI.BossaNavAgent | Private |
| _addForceSensor | Micosmo.SensorToolkit.Sensor | Private |
| _potentialCollisionSensor | Micosmo.SensorToolkit.Sensor | Private |
| _playerControllerLayer | UnityEngine.LayerMask | Private |
| _ragdollLayer | UnityEngine.LayerMask | Private |
| _vfx | AIVFXChargeLoop | Private |
| _attackData | WildSkies.AI.ChargeAttackData | Private |
| _knockbackCancellationToken | System.Threading.CancellationTokenSource | Private |
| _knockbackTask | Cysharp.Threading.Tasks.UniTask | Private |
| _endChargeTime | System.Single | Private |
| _lastRammedPlayer | UnityEngine.GameObject | Private |
| _lastRammedTime | System.Single | Private |
| _movementBehaviour | ChargeWithTarget | Private |
| _numberOfFailedAttempts | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **Start()**: System.Void (Protected)
- **Update()**: System.Void (Protected)
- **OnFixedUpdate()**: System.Void (Public)
- **OnDisable()**: System.Void (Private)
- **WindUpCharge()**: System.Void (Private)
- **OnAnimationEvent(System.String eventId)**: System.Void (Private)
- **StartCharge()**: System.Void (Private)
- **OnMovementEnded(MovementBehaviourTypes type)**: System.Void (Private)
- **ChargeCollision()**: System.Void (Private)
- **EndCharge()**: System.Void (Private)
- **Attack(UnityEngine.Vector3 position)**: System.Void (Public)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **OnImpactExited(UnityEngine.AnimatorStateInfo animatorStateInfo)**: System.Void (Private)
- **EarlyCollision(UnityEngine.GameObject obj)**: System.Boolean (Private)
- **OnCollisionDetection(UnityEngine.GameObject obj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **EarlyAttack()**: System.Boolean (Private)
- **TryRamObj(UnityEngine.GameObject obj, System.Boolean ignoreGracePeriod, System.Boolean stationary)**: System.Boolean (Private)
- **CanHitPlayer(UnityEngine.GameObject obj, System.Boolean ignoreGracePeriod)**: System.Boolean (Private)
- **CanRam(UnityEngine.GameObject obj)**: System.Boolean (Private)
- **FindPlayerRoot(UnityEngine.GameObject obj, UnityEngine.GameObject& root)**: System.Boolean (Private)
- **TryDamageObject(UnityEngine.GameObject obj)**: System.Void (Private)
- **AddForceToObject(UnityEngine.GameObject obj, System.Boolean stationary)**: System.Void (Private)
- **GetHitForce(UnityEngine.GameObject obj, System.Boolean stationary)**: UnityEngine.Vector3 (Private)
- **.ctor()**: System.Void (Public)

