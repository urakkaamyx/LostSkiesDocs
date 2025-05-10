# WildSkies.TestScenes.CombatGym.CombatGymCombatRoom

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _aiCapibilityType | WildSkies.TestScenes.CombatGym.CombatGymCombatRoom/AICapability | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _Entities | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _switchPrefab | WildSkies.TestScenes.CombatGym.CombatGymDamageableSwitch | Private |
| _switchTransform | UnityEngine.Transform | Private |
| _entitiesTransform | UnityEngine.Transform | Private |
| _margin | UnityEngine.Vector2 | Private |
| _columnCount | System.Int32 | Private |
| _mantaBehaviour | BehaviorDesigner.Runtime.ExternalBehaviorTree | Private |
| _alphaBehaviour | BehaviorDesigner.Runtime.ExternalBehaviorTree | Private |
| _nautilusBehaviour | BehaviorDesigner.Runtime.ExternalBehaviorTree | Private |
| _turretBehaviour | BehaviorDesigner.Runtime.ExternalBehaviorTree | Private |
| _switches | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _currentInstantiatedEntities | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _currentMargin | UnityEngine.Vector2 | Private |
| _counter | System.Int32 | Private |

## Methods

- **Initialise(WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.SessionService sessionService)**: System.Void (Public)
- **ServicesReady()**: System.Void (Private)
- **InitSwitches()**: System.Void (Private)
- **SwitchSpawned(UnityEngine.GameObject theSwitch)**: System.Void (Private)
- **SpawnEntity(System.Int32 index)**: System.Void (Public)
- **EntitySpawned(UnityEngine.GameObject entity)**: System.Void (Private)
- **CleanUp()**: System.Void (Public)
- **RefillHealth()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

