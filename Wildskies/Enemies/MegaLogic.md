# WildSkies.Enemies.MegaLogic

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _megaService | WildSkies.Service.MegaService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _megaData | MegaData | Private |
| _megaModel | UnityEngine.Transform | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| _animator | UnityEngine.Animator | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _megaMovementController | MegaMovementController | Private |
| _megaAltitudeController | MegaAltitudeController | Private |
| _megaIdleWaypoints | MegaIdleWaypoints | Private |
| _megaPathfinding | MegaPathfinding | Private |
| _megaHealth | MegaHealth | Private |
| _awarnessStateFactory | WildSkies.Enemies.AwarenessStateFactory | Private |
| _behaviorTree | BehaviorDesigner.Runtime.BehaviorTree | Private |
| _sickleAttack | WildSkies.Enemies.SickleAttackLogic | Private |
| _orbAttack | MegaOrbAttackLogic | Private |
| _megaTurretAttack | WildSkies.AI.Attacks.MegaTurretAttack | Private |
| _turretSpawnPoints | UnityEngine.Transform[] | Private |
| _showInfoOverlayGUI | System.Boolean | Private |
| _megaStates | System.Collections.Generic.List`1<MegaState> | Private |
| _currentMegaState | MegaState | Private |
| _currentState | WildSkies.Enemies.MegaLogic/State | Private |
| _areaState | WildSkies.Enemies.MegaLogic/AreaState | Private |
| _stateChangeTimestamp | System.Single | Private |
| _stateDuration | System.Single | Private |
| _megaTurrets | System.Collections.Generic.List`1<MegaTurret> | Private |
| enterHitColliders | UnityEngine.Collider[] | Private |
| _inAttack | System.Boolean | Private |
| _ship | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| MaxColliders | System.Int32 | Private |
| BehaviorTreeTargetString | System.String | Private |
| ShipEnteredRange | System.Action`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Public |
| ShipLeftRange | System.Action | Public |
| StateChanged | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| MegaAltitudeController | MegaAltitudeController | Public |
| MegaMovementController | MegaMovementController | Public |
| MegaHealth | MegaHealth | Public |
| MegaIdleWaypoints | MegaIdleWaypoints | Public |
| MegaPathfinding | MegaPathfinding | Public |
| Rigidbody | UnityEngine.Rigidbody | Public |
| Animator | UnityEngine.Animator | Public |
| MegaModel | UnityEngine.Transform | Public |
| MegaData | MegaData | Public |
| Ship | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Public |
| MegaTransform | UnityEngine.Transform | Public |
| CoherenceSync | Coherence.Toolkit.CoherenceSync | Public |
| SickleAttackLogic | WildSkies.Enemies.SickleAttackLogic | Public |
| MegaOrbAttackLogic | MegaOrbAttackLogic | Public |
| CurrentState | WildSkies.Enemies.MegaLogic/State | Public |

## Methods

- **get_MegaAltitudeController()**: MegaAltitudeController (Public)
- **get_MegaMovementController()**: MegaMovementController (Public)
- **get_MegaHealth()**: MegaHealth (Public)
- **get_MegaIdleWaypoints()**: MegaIdleWaypoints (Public)
- **get_MegaPathfinding()**: MegaPathfinding (Public)
- **get_Rigidbody()**: UnityEngine.Rigidbody (Public)
- **get_Animator()**: UnityEngine.Animator (Public)
- **get_MegaModel()**: UnityEngine.Transform (Public)
- **get_MegaData()**: MegaData (Public)
- **get_Ship()**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **get_MegaTransform()**: UnityEngine.Transform (Public)
- **get_CoherenceSync()**: Coherence.Toolkit.CoherenceSync (Public)
- **get_SickleAttackLogic()**: WildSkies.Enemies.SickleAttackLogic (Public)
- **get_MegaOrbAttackLogic()**: MegaOrbAttackLogic (Public)
- **get_CurrentState()**: WildSkies.Enemies.MegaLogic/State (Public)
- **GetCurrentMegaState()**: MegaState (Public)
- **GetStateDuration()**: System.Single (Public)
- **SetIsInAttack(System.Boolean value)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **SetupTelemetry()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **KillMega()**: System.Void (Public)
- **ToggleTurrets(System.Boolean value)**: System.Void (Public)
- **DestroyMega()**: System.Void (Public)
- **SpawnTurrets()**: System.Void (Private)
- **TargetEnteredTrigger(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Private)
- **TargetLeftTrigger()**: System.Void (Private)
- **ShipEnteredIsland()**: System.Void (Private)
- **ShipDestroyed()**: System.Void (Private)
- **SearchShip()**: System.Void (Private)
- **SetBehaviorTreeVariables(System.Boolean reset)**: System.Void (Private)
- **IsDead()**: System.Boolean (Public)
- **GetAreaState()**: WildSkies.Enemies.MegaLogic/AreaState (Public)
- **SetStartStates()**: System.Void (Private)
- **SetupMegaStates()**: System.Void (Private)
- **ChangeState(WildSkies.Enemies.MegaLogic/State newState)**: System.Void (Public)
- **ChangeMegaState()**: System.Void (Private)
- **OnGUI()**: System.Void (Private)
- **ToggleInfoOverlay()**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

