# WildSkies.AI.AdvancedCritter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _config | CritterFSM/CritterConfig | Protected |
| _deathHandling | EntityDeathHandling | Protected |
| _targetAcquisition | AITargetAcquisition | Private |
| _attackHandler | WildSkies.AI.Attacks.AttackHandlerBase | Private |
| _movement | PhysicsMovementBase | Protected |
| _entityRendererController | EntityRendererController | Protected |
| _disposalService | WildSkies.Service.DisposalService | Protected |
| _vfxPoolService | WildSkies.Service.VfxPoolService | Protected |
| _scanTimer | System.Single | Private |
| _isScanned | System.Boolean | Private |
| _isPinged | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AIDefinition | WildSkies.Gameplay.AI.AIDefinition | Public |
| Config | CritterFSM/CritterConfig | Public |
| Attacks | WildSkies.AI.Attacks.AttackHandlerBase | Public |
| TargetAcquisition | AITargetAcquisition | Public |
| EntityRendererController | EntityRendererController | Public |
| CompendiumEntryId | System.String | Public |
| ScanProgress | System.Single | Public |
| IsScanned | System.Boolean | Public |

## Methods

- **get_AIDefinition()**: WildSkies.Gameplay.AI.AIDefinition (Public)
- **get_Config()**: CritterFSM/CritterConfig (Public)
- **get_Attacks()**: WildSkies.AI.Attacks.AttackHandlerBase (Public)
- **get_TargetAcquisition()**: AITargetAcquisition (Public)
- **get_EntityRendererController()**: EntityRendererController (Public)
- **get_CompendiumEntryId()**: System.String (Public)
- **get_ScanProgress()**: System.Single (Public)
- **get_IsScanned()**: System.Boolean (Public)
- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Protected)
- **OnAuthorityChange()**: System.Void (Public)
- **Scan()**: System.Void (Public)
- **StopScan()**: System.Void (Public)
- **Ping()**: System.Void (Public)
- **OnEntityDeath(UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **OnKillEntity()**: System.Void (Public)
- **DespawnEntity()**: System.Void (Public)
- **OnDisposeEntity()**: System.Void (Public)
- **SetHasDroppedLoot(System.Boolean hasDroppedLoot)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

