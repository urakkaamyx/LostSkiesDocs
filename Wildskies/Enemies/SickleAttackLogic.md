# WildSkies.Enemies.SickleAttackLogic

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _state | WildSkies.Enemies.SickleAttackLogic/State | Public |
| _networkedState | System.Int32 | Private |
| _stateValue | System.Int32 | Public |
| _sickleVFX | UnityEngine.ParticleSystem | Private |
| _sickleAttackProjectile | WildSkies.Enemies.SickleAttackProjectile | Private |
| _megaLogic | WildSkies.Enemies.MegaLogic | Private |
| _sickle | UnityEngine.Transform | Private |
| _sickleMountPoint | UnityEngine.Transform | Private |
| _laserStartPoint | UnityEngine.Transform | Private |
| _sickleRenderer | UnityEngine.Renderer | Private |
| _laserPointerRenderer | UnityEngine.LineRenderer | Private |
| _target | UnityEngine.Transform | Private |
| _laserFollowTarget | System.Boolean | Private |
| _renderLaserPointer | System.Boolean | Private |
| _sickleFollowMountPoint | System.Boolean | Private |
| _idleTimer | System.Single | Private |
| _turnToTargetTimer | System.Single | Private |
| _activateSickleTimer | System.Single | Private |
| _chargeMegaTimer | System.Single | Private |
| _fireSickleTimer | System.Single | Private |
| _windDownTimer | System.Single | Private |
| MaterialPowerKeyword | System.String | Private |
| IsSickleAttackReadyAnimatorBool | System.String | Private |
| ChargeUpAnimatorBool | System.String | Private |
| ShootAnimatorTrigger | System.String | Private |
| OnSickleReset | System.Action | Private |
| OnSickleFired | System.Action | Private |
| OnSickleAttackEnd | System.Action | Private |
| ChargeSickleRandomness | System.Single | Private |

## Methods

- **add_OnSickleReset(System.Action value)**: System.Void (Public)
- **remove_OnSickleReset(System.Action value)**: System.Void (Public)
- **add_OnSickleFired(System.Action value)**: System.Void (Public)
- **remove_OnSickleFired(System.Action value)**: System.Void (Public)
- **add_OnSickleAttackEnd(System.Action value)**: System.Void (Public)
- **remove_OnSickleAttackEnd(System.Action value)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **SetupSickleAttack()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **SickleFollowMountPoint()**: System.Void (Private)
- **PerfromSickleAttack()**: System.Void (Public)
- **PerformSickleAttackInstant()**: System.Void (Public)
- **UpdateStates()**: System.Void (Private)
- **SetTarget(WildSkies.Gameplay.ShipBuilding.ConstructedShipController target)**: System.Void (Private)
- **ClearTarget()**: System.Void (Private)
- **SlowDownAndTurnToTarget()**: System.Void (Private)
- **ResetSickle()**: System.Void (Private)
- **ShowSickle()**: System.Void (Private)
- **TurnToTarget()**: System.Void (Private)
- **ActivateSickle()**: System.Void (Private)
- **ChargeMega()**: System.Void (Private)
- **FireSickle()**: System.Void (Private)
- **WindDown()**: System.Void (Private)
- **MoveOn()**: System.Void (Private)
- **ToggleLaserPointer(System.Boolean value)**: System.Void (Private)
- **RenderLaserPointer()**: System.Void (Private)
- **StateValueSynced(System.Int32 oldValue, System.Int32 newValue)**: System.Void (Public)
- **ChangeState(WildSkies.Enemies.SickleAttackLogic/State state)**: System.Void (Public)
- **GetCurrentState()**: WildSkies.Enemies.SickleAttackLogic/State (Public)
- **PerfromStateAction(WildSkies.Enemies.SickleAttackLogic/State state)**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

