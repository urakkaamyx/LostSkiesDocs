# WildSkies.AI.Attacks.MegaDroneAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _megaLogic | WildSkies.Enemies.MegaLogic | Private |
| _droneTurret | MegaDroneTurret | Private |
| _debugState | WildSkies.AI.Attacks.AIAttack/AttackState | Private |
| _target | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _currentCooldown | System.Single | Private |
| _firingTask | Cysharp.Threading.Tasks.UniTask | Private |
| _firingDronesCancellationTokenSource | System.Threading.CancellationTokenSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **OnFixedUpdate()**: System.Void (Public)
- **Start()**: System.Void (Protected)
- **OnUpdate()**: System.Void (Public)
- **OnDestroy()**: System.Void (Public)
- **Cooldown()**: System.Void (Private)
- **Attack(UnityEngine.Vector3 position)**: System.Void (Public)
- **SetTarget(WildSkies.Gameplay.ShipBuilding.ConstructedShipController target)**: System.Void (Public)
- **ClearTarget()**: System.Void (Private)
- **OnDronesFired()**: System.Void (Private)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **FiringTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)

