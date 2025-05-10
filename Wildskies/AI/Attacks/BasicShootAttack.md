# WildSkies.AI.Attacks.BasicShootAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bulletOrigin | UnityEngine.Transform | Protected |
| _inaccuracyHorizontal | System.Single | Private |
| _inaccuracyVertical | System.Single | Private |
| _hitPhysicsImpulse | System.Single | Private |
| _damageType | WildSkies.Weapon.DamageType | Private |
| _maxBulletsSimulated | System.Int32 | Private |
| _tracerPrefab | UnityEngine.LineRenderer | Private |
| _tracerLengthMin | System.Single | Private |
| _tracerLengthMax | System.Single | Private |
| _bulletSpeed | System.Single | Private |
| _tracerChance | System.Single | Private |
| _bulletDamageMax | System.Single | Private |
| _bulletDamageMin | System.Single | Private |
| _distanceFallOffStart | System.Single | Private |
| _distanceFallOffEnd | System.Single | Private |
| _tracers | UnityEngine.LineRenderer[] | Private |
| _bullets | WildSkies.AI.Attacks.AIShootAttack/Bullet[] | Private |
| _currentIndex | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **Start()**: System.Void (Protected)
- **OnFixedUpdate()**: System.Void (Public)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **Attack(UnityEngine.Vector3 position)**: System.Void (Public)
- **Shoot(UnityEngine.Vector3 origin)**: System.Void (Public)
- **BulletHit(UnityEngine.RaycastHit hitInfo)**: System.Void (Protected)
- **.ctor()**: System.Void (Public)

