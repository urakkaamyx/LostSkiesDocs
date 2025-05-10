# WildSkies.Enemies.HeraldLogic

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _heraldMovementController | HeraldMovementController | Private |
| _skyBossAttackHandler | WildSkies.AI.Attacks.SkyBossAttackHandler | Private |
| _heraldVisuals | HeraldVisuals | Private |
| _skyBossAudio | WildSkies.Enemies.SkyBossAudio | Private |
| _heraldDebugger | HeraldDebugger | Private |
| _heraldTypeData | HeraldsTypeData | Private |
| _heraldData | HeraldData | Private |
| _heraldHealthData | HeraldHealthData | Private |
| _behaviorTree | BehaviorDesigner.Runtime.BehaviorTree | Private |
| _attackHandler | WildSkies.AI.Attacks.SkyBossAttackHandler | Private |
| _attacksDisabled | System.Boolean | Private |
| MaxColliders | System.Int32 | Private |
| BehaviorTreeTargetString | System.String | Private |
| BehaviorTreeAttackingEnabledString | System.String | Private |
| _enterHitColliders | UnityEngine.Collider[] | Private |
| _heraldStates | System.Collections.Generic.List`1<HeraldState> | Private |
| _currentHeraldState | HeraldState | Private |
| _skyBossHealth | SkyBossHealth | Private |
| _stateChangeTimestamp | System.Single | Private |
| _physicsRootMotion | PhysicsRootMotion | Private |
| _networkAnimationSync | NetworkAnimationSync | Private |
| _furtherAwayCollider | UnityEngine.Collider | Private |
| _initialized | System.Boolean | Private |
| _colliders | UnityEngine.Collider[] | Private |
| _shipDetectionRange | System.Single | Private |
| _justDamagedTime | System.Single | Private |
| _searchShipCoroutine | UnityEngine.Coroutine | Private |
| heraldTypeId | System.Int32 | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| HeraldMovementController | HeraldMovementController | Public |
| HeraldVisuals | HeraldVisuals | Public |
| HeraldData | HeraldData | Public |
| HeraldsTypeData | HeraldsTypeData | Public |
| HeraldHealthData | HeraldHealthData | Public |
| SkyBossAttackHandler | WildSkies.AI.Attacks.SkyBossAttackHandler | Public |
| IsDead | System.Boolean | Public |
| Damaged | System.Boolean | Public |
| HasAllComponentsInitialised | System.Boolean | Public |
| HasInitialized | System.Boolean | Public |
| LeaveRange | System.Single | Public |

## Methods

- **get_HeraldMovementController()**: HeraldMovementController (Public)
- **get_HeraldVisuals()**: HeraldVisuals (Public)
- **get_HeraldData()**: HeraldData (Public)
- **get_HeraldsTypeData()**: HeraldsTypeData (Public)
- **get_HeraldHealthData()**: HeraldHealthData (Public)
- **get_SkyBossAttackHandler()**: WildSkies.AI.Attacks.SkyBossAttackHandler (Public)
- **get_IsDead()**: System.Boolean (Public)
- **get_Damaged()**: System.Boolean (Public)
- **get_HasAllComponentsInitialised()**: System.Boolean (Public)
- **get_HasInitialized()**: System.Boolean (Public)
- **get_LeaveRange()**: System.Single (Public)
- **Start()**: System.Void (Public)
- **SetupHeraldTypeById(System.Int32 id)**: System.Void (Public)
- **SetupHerald(HeraldData heraldData, HeraldHealthData heraldHealthData, OrbAttackTypeData orbAttackTypeData, MegaTurretData turretData, System.Boolean useStaticHerald, ModularHerald modularHeraldPrefab, UnityEngine.GameObject staticHeraldPrefab)**: System.Void (Private)
- **OnDestroy()**: System.Void (Public)
- **CacheColliders()**: System.Void (Private)
- **SetDetailedColliders(System.Boolean shouldBeEnabled)**: System.Void (Private)
- **AttacksInitialized()**: System.Void (Private)
- **OnHeraldTypeIdSynced(System.Int32 oldValue, System.Int32 newValue)**: System.Void (Public)
- **DestroyHerald()**: System.Void (Public)
- **OnHealthChanged()**: System.Void (Private)
- **Update()**: System.Void (Public)
- **UpdateJustDamagedTime()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Public)
- **SearchShip()**: System.Void (Private)
- **SearchShipEnumerator()**: System.Collections.IEnumerator (Private)
- **CheckShipEnter()**: System.Void (Private)
- **CheckShipDestroyed()**: System.Void (Private)
- **CheckShipExit()**: System.Void (Private)
- **TargetEnteredTrigger(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **TargetLeftTrigger()**: System.Void (Public)
- **NetworkStartFight()**: System.Void (Public)
- **NetworkEndFight(System.Boolean wasKilled)**: System.Void (Public)
- **ShipEnteredIsland()**: System.Void (Private)
- **ShipDestroyed()**: System.Void (Private)
- **SetBehaviorTreeVariables(System.Boolean reset)**: System.Void (Private)
- **SetupStates()**: System.Void (Private)
- **ChangeState(WildSkies.Enemies.SkyBoss/State newState)**: System.Void (Public)
- **GetState()**: T (Public)
- **ChangeHeraldState()**: System.Void (Private)
- **ExitCurrentState()**: System.Void (Public)
- **ToggleTurrets(System.Boolean value, System.Boolean forced)**: System.Void (Public)
- **OnDrawGizmosSelected()**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **PerformOrbAttack(System.Int32 attackType)**: System.Void (Public)
- **DebugKillBoss()**: System.Void (Public)
- **ToggleAttacks(System.Boolean value)**: System.Void (Public)
- **PerformTurretAttack()**: System.Void (Public)
- **TogglePositionLogging(System.Int32 positionLogInterval, System.Int32 maxPositionLogs)**: System.Void (Public)
- **GetUpgradeLevel()**: System.Int32 (Public)
- **.ctor()**: System.Void (Public)

