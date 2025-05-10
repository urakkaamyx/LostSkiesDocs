# WildSkies.Entities.AIEntity

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _config | WildSkies.AI.AIConfig | Private |
| _levelHandler | WildSkies.AI.AILevelHandler | Private |
| _levelEntityReplacement | AILevelEntityReplacement | Private |
| _perceptionStateMachine | WildSkies.AI.PerceptionStateMachine | Private |
| _memoryHandler | AIMemoryHandler | Private |
| _agentHeadTargeting | WildSkies.AI.AgentHeadTargeting | Private |
| _targetAcquisition | AITargetAcquisition | Private |
| _shipTracking | AIShipTracking | Private |
| _agent | WildSkies.AI.Agent | Private |
| _attacks | WildSkies.AI.Attacks.AIAttackHandler | Private |
| _formationHandler | AIFormationHandler | Private |
| _stagger | WildSkies.AI.AIStagger | Private |
| _stunnedBehaviour | WildSkies.AI.AIStunnedBehaviour | Private |
| _buffHandler | WildSkies.AI.AIBuffHandler | Private |
| _repairableEntity | RepairableEntity | Private |
| _combatMusicZoneSensor | WildSkies.AI.AICombatMusicZoneSensor | Private |
| _animation | AgentAnimation | Private |
| _entityRendererController | EntityRendererController | Private |
| _sfxHandler | AISFXHandler | Private |
| _footstepAudio | AIFootstepAudio | Protected |
| _vfxHandler | WildSkies.AI.AIVFXHandler | Private |
| _visualController | AIVisualController | Private |
| _behaviourTreeController | BehaviourTreeController | Private |
| _despawnBehaviour | WildSkies.AI.AIDespawnBehaviour | Private |
| _fallingDespawnBehaviour | WildSkies.AI.FallingDespawnBehaviour | Private |
| _deployBehaviour | WildSkies.AI.DeployBehaviour | Private |
| _spawnBehaviour | WildSkies.AI.AISpawnBehaviour | Private |
| _idleBehaviourHandler | WildSkies.AI.AIIdleBehaviourHandler | Private |
| _entityDeathHandling | EntityDeathHandling | Private |
| _deathBehaviour | WildSkies.AI.AIDeathBehaviour | Private |
| _burrowEmergeBehaviour | AIBurrowEmergeBehaviour | Private |
| _skinnedMeshRenderers | UnityEngine.SkinnedMeshRenderer[] | Private |
| _lootHandler | WildSkies.AI.AILootHandler | Private |
| _resetTimer | WildSkies.AI.AIResetTimer | Private |
| _useRagdoll | System.Boolean | Private |
| _isDestroyedOnDeath | System.Boolean | Private |
| _scanTimer | System.Single | Private |
| _isScanned | System.Boolean | Private |
| _isPinged | System.Boolean | Private |
| <CurrentElementLODLevel>k__BackingField | System.Int32 | Private |
| _disposalService | WildSkies.Service.DisposalService | Private |
| _aiFeedbackService | WildSkies.Service.AIFeedbackService | Private |
| _groupService | WildSkies.Service.AIGroupService | Private |
| _buffService | WildSkies.Service.BuffService | Private |
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| _aiRagdollService | IAIRagdollService | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |
| _events | AIEvents | Private |
| _timeToDestroy | System.Single | Private |
| _spawnerId | System.String | Private |
| <ExclusionRadius>k__BackingField | System.Single | Private |
| <SpawnGroupId>k__BackingField | System.Guid | Private |
| <GroupId>k__BackingField | System.Int32 | Private |
| <IsGroupLeader>k__BackingField | System.Boolean | Private |
| _hasBeenInitialised | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CompendiumEntryId | System.String | Public |
| ScanProgress | System.Single | Public |
| IsScanned | System.Boolean | Public |
| Attacks | WildSkies.AI.Attacks.AttackHandlerBase | Public |
| DespawnBehaviour | WildSkies.AI.AIDespawnBehaviour | Public |
| IdleBehaviour | WildSkies.AI.AIIdleBehaviourHandler | Public |
| DeployBehaviour | WildSkies.AI.DeployBehaviour | Public |
| SpawnBehaviour | WildSkies.AI.AISpawnBehaviour | Public |
| Config | WildSkies.AI.AIConfig | Public |
| ShipTracking | AIShipTracking | Public |
| VisualController | AIVisualController | Public |
| TargetAcquisition | AITargetAcquisition | Public |
| BurrowEmergeBehaviour | AIBurrowEmergeBehaviour | Public |
| LootHandler | WildSkies.AI.AILootHandler | Public |
| ResetTimer | WildSkies.AI.AIResetTimer | Public |
| EntityLevel | System.Int32 | Public |
| Agent | WildSkies.AI.Agent | Public |
| Transform | UnityEngine.Transform | Public |
| EntityType | WildSkies.Entities.AIEntityType | Public |
| EntityDeathHandling | EntityDeathHandling | Public |
| DamageInMemory | System.Boolean | Public |
| IsAlpha | System.Boolean | Public |
| CurrentElementLODLevel | System.Int32 | Public |
| EntityRendererController | EntityRendererController | Public |
| Memory | IAIMemory | Public |
| FormationHandler | IAIFormationHandler | Public |
| Events | AIEvents | Public |
| GroupService | WildSkies.Service.AIGroupService | Public |
| Stagger | WildSkies.AI.AIStagger | Public |
| StunnedBehaviour | WildSkies.AI.AIStunnedBehaviour | Public |
| LevelHandler | WildSkies.AI.AILevelHandler | Public |
| LevelEntityReplacement | AILevelEntityReplacement | Public |
| BuffHandler | WildSkies.AI.AIBuffHandler | Public |
| LocalisedName | System.String | Public |
| SpawnerId | System.String | Public |
| ExclusionRadius | System.Single | Public |
| SpawnGroupId | System.Guid | Public |
| GroupId | System.Int32 | Public |
| IsGroupLeader | System.Boolean | Public |
| LeaderRank | System.Int32 | Public |

## Methods

- **get_CompendiumEntryId()**: System.String (Public)
- **get_ScanProgress()**: System.Single (Public)
- **get_IsScanned()**: System.Boolean (Public)
- **get_Attacks()**: WildSkies.AI.Attacks.AttackHandlerBase (Public)
- **get_DespawnBehaviour()**: WildSkies.AI.AIDespawnBehaviour (Public)
- **get_IdleBehaviour()**: WildSkies.AI.AIIdleBehaviourHandler (Public)
- **get_DeployBehaviour()**: WildSkies.AI.DeployBehaviour (Public)
- **get_SpawnBehaviour()**: WildSkies.AI.AISpawnBehaviour (Public)
- **get_Config()**: WildSkies.AI.AIConfig (Public)
- **get_ShipTracking()**: AIShipTracking (Public)
- **get_VisualController()**: AIVisualController (Public)
- **get_TargetAcquisition()**: AITargetAcquisition (Public)
- **get_BurrowEmergeBehaviour()**: AIBurrowEmergeBehaviour (Public)
- **get_LootHandler()**: WildSkies.AI.AILootHandler (Public)
- **get_ResetTimer()**: WildSkies.AI.AIResetTimer (Public)
- **get_EntityLevel()**: System.Int32 (Public)
- **get_Agent()**: WildSkies.AI.Agent (Public)
- **get_Transform()**: UnityEngine.Transform (Public)
- **get_EntityType()**: WildSkies.Entities.AIEntityType (Public)
- **get_EntityDeathHandling()**: EntityDeathHandling (Public)
- **get_DamageInMemory()**: System.Boolean (Public)
- **get_IsAlpha()**: System.Boolean (Public)
- **get_CurrentElementLODLevel()**: System.Int32 (Public)
- **set_CurrentElementLODLevel(System.Int32 value)**: System.Void (Private)
- **get_EntityRendererController()**: EntityRendererController (Public)
- **get_Memory()**: IAIMemory (Public)
- **get_FormationHandler()**: IAIFormationHandler (Public)
- **get_Events()**: AIEvents (Public)
- **get_GroupService()**: WildSkies.Service.AIGroupService (Public)
- **get_Stagger()**: WildSkies.AI.AIStagger (Public)
- **get_StunnedBehaviour()**: WildSkies.AI.AIStunnedBehaviour (Public)
- **get_LevelHandler()**: WildSkies.AI.AILevelHandler (Public)
- **get_LevelEntityReplacement()**: AILevelEntityReplacement (Public)
- **get_BuffHandler()**: WildSkies.AI.AIBuffHandler (Public)
- **get_LocalisedName()**: System.String (Public)
- **get_SpawnerId()**: System.String (Public)
- **get_ExclusionRadius()**: System.Single (Public)
- **set_ExclusionRadius(System.Single value)**: System.Void (Public)
- **get_SpawnGroupId()**: System.Guid (Public)
- **set_SpawnGroupId(System.Guid value)**: System.Void (Public)
- **get_GroupId()**: System.Int32 (Public)
- **set_GroupId(System.Int32 value)**: System.Void (Public)
- **get_IsGroupLeader()**: System.Boolean (Public)
- **set_IsGroupLeader(System.Boolean value)**: System.Void (Public)
- **get_LeaderRank()**: System.Int32 (Public)
- **Init(WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.NetworkService networkService, WildSkies.Service.DisposalService disposalService, WildSkies.Service.NetworkFxService networkFxService, WildSkies.Service.AIFeedbackService aiFeedbackService, WildSkies.Service.AIGroupService groupService, IAIRagdollService aiRagdollService, WildSkies.Service.CameraImpulseService cameraImpulseService, WildSkies.Service.Interface.ColliderLookupService colliderLookupService, WildSkies.Service.AILevelsService aiLevelsService, WildSkies.Service.BuffService buffService, WildSkies.Service.FloatingWorldOriginService floatingWorldOriginService, WildSkies.Service.LocalisationService localisationService)**: System.Void (Private)
- **Start()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnAuthorityChange()**: System.Void (Public)
- **OnStateRemote()**: System.Void (Public)
- **OnDisposeEntity()**: System.Void (Public)
- **OnKillEntity()**: System.Void (Public)
- **DespawnEntity()**: System.Void (Public)
- **SetTimeToDestroy(System.Single time)**: System.Void (Public)
- **ResetEntity()**: System.Void (Public)
- **KillEntity()**: System.Void (Private)
- **DisposeEntity()**: System.Void (Private)
- **SpawnAsDead()**: System.Void (Public)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **Scan()**: System.Void (Public)
- **StopScan()**: System.Void (Public)
- **Ping()**: System.Void (Public)
- **SetSpawnerId(System.String spawnerId)**: System.Void (Public)
- **SetHasDroppedLoot(System.Boolean hasDroppedLoot)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

