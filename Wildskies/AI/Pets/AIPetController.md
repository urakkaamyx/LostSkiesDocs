# WildSkies.AI.Pets.AIPetController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _petData | WildSkies.AI.Pets.AIPetController/PetData | Private |
| _memoryHandler | AIMemoryHandler | Private |
| _targetAcquisition | AITargetAcquisition | Private |
| _physicsFlyingMovement | WildSkies.AI.PhysicsFlyingMovement | Private |
| _agentHeadTargeting | WildSkies.AI.AgentHeadTargeting | Private |
| _steeringSensor | Micosmo.SensorToolkit.SteeringSensor | Private |
| _attackHandler | WildSkies.AI.Attacks.AIAttackHandler | Private |
| _vfxHandler | WildSkies.AI.AIVFXHandler | Private |
| _sfxHandler | AISFXHandler | Private |
| _shipTracking | AIShipTracking | Private |
| _lootSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _raySensor | Micosmo.SensorToolkit.RaySensor | Private |
| _playerTarget | UnityEngine.Transform | Private |
| _playerSync | PlayerSync | Private |
| _playerAttackTokenHandler | AttackTokenHandler | Private |
| _playerAggroEntity | IAIAggroEntity | Private |
| _petStates | System.Collections.Generic.Dictionary`2<WildSkies.AI.Pets.AIPetController/PetStateType,WildSkies.AI.Pets.AIPetController/AIPetState> | Private |
| _petInterests | System.Collections.Generic.Dictionary`2<WildSkies.AI.Pets.AIPetController/PetInterestType,WildSkies.AI.Pets.AIPetController/PetInterestData> | Private |
| _currentPetStateType | WildSkies.AI.Pets.AIPetController/PetStateType | Private |
| _currentInterestType | WildSkies.AI.Pets.AIPetController/PetInterestType | Private |
| _events | AIEvents | Private |
| _lootHistory | System.Collections.Generic.Queue`1<UnityEngine.GameObject> | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _disposalService | WildSkies.Service.DisposalService | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| PlayerTarget | UnityEngine.Transform | Public |
| PlayerAttackTokenHandler | AttackTokenHandler | Public |
| PlayerAggroEntity | IAIAggroEntity | Public |
| ActiveInterest | WildSkies.AI.Pets.AIPetController/PetInterestData | Public |

## Methods

- **get_PlayerTarget()**: UnityEngine.Transform (Public)
- **get_PlayerAttackTokenHandler()**: AttackTokenHandler (Public)
- **get_PlayerAggroEntity()**: IAIAggroEntity (Public)
- **get_ActiveInterest()**: WildSkies.AI.Pets.AIPetController/PetInterestData (Public)
- **Start()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **SetState(WildSkies.AI.Pets.AIPetController/PetStateType stateType)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **AssignPlayer(Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Void (Public)
- **OnPlayerExitedShip()**: System.Void (Private)
- **IsInInterestHistory(UnityEngine.GameObject loot)**: System.Boolean (Public)
- **TryAddToInterestHistory(UnityEngine.GameObject loot)**: System.Boolean (Public)
- **TryGetAggroTarget(IAIAggroEntity& entity)**: System.Boolean (Public)
- **HasInterest(WildSkies.AI.Pets.AIPetController/PetInterestType interestType)**: System.Boolean (Public)
- **GetInterestData(WildSkies.AI.Pets.AIPetController/PetInterestType interestType)**: WildSkies.AI.Pets.AIPetController/PetInterestData (Public)
- **SetInterest(WildSkies.AI.Pets.AIPetController/PetInterestType interestType)**: System.Void (Public)
- **TeleportToPlayer()**: System.Void (Private)
- **OnEntityDamaged(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Single currentValue)**: System.Void (Private)
- **OnPlayerAggroed(IAIAggroEntity entity)**: System.Void (Private)
- **OnPlayerDeAggroed(IAIAggroEntity entity)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

