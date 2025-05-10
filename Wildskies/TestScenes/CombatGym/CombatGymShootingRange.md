# WildSkies.TestScenes.CombatGym.CombatGymShootingRange

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| OnEntitiesSpawned | System.Action | Public |
| _inventoryServices | WildSkies.Service.IPlayerInventoryService | Private |
| _localPlayerServices | WildSkies.Service.ILocalPlayerService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _forwardAxis | UnityEngine.Vector3 | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _debugText | TMPro.TextMeshPro | Private |
| _lobotomisedBehaviour | BehaviorDesigner.Runtime.ExternalBehaviorTree | Private |
| _targetsParent | UnityEngine.Transform | Private |
| _spawnPositions | System.Collections.Generic.List`1<UnityEngine.Transform> | Private |
| _aiEntities | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _currentInstantiatedObjects | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _currentEntityIndex | System.Int32 | Private |

## Methods

- **Start()**: System.Void (Private)
- **CheckInstantiate()**: System.Void (Private)
- **DoInstantiation(System.Int32 index)**: System.Void (Private)
- **ChangeEntityType()**: System.Void (Public)
- **AddAmmo()**: System.Void (Public)
- **ItemCreated(UnityEngine.GameObject item)**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<CheckInstantiate>b__15_0()**: System.Boolean (Private)
- **<CheckInstantiate>b__15_1()**: System.Boolean (Private)

