# WildSkies.AI.Pets.PetAttackState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _attackHandler | WildSkies.AI.Attacks.AIAttackHandler | Private |
| _petController | WildSkies.AI.Pets.AIPetController | Private |
| _memoryHandler | AIMemoryHandler | Private |
| _steeringSensor | Micosmo.SensorToolkit.SteeringSensor | Private |
| _petData | WildSkies.AI.Pets.AIPetController/PetData | Private |
| _events | AIEvents | Private |
| _aggroList | System.Collections.Generic.List`1<UnityEngine.Transform> | Private |
| _aggroEntityTransform | UnityEngine.Transform | Private |

## Methods

- **.ctor(WildSkies.AI.Attacks.AIAttackHandler attackHandler, WildSkies.AI.Pets.AIPetController petController, AIMemoryHandler memoryHandler, Micosmo.SensorToolkit.SteeringSensor steeringSensor, WildSkies.AI.Pets.AIPetController/PetData petData)**: System.Void (Public)
- **OnEnter()**: System.Void (Public)
- **Attack()**: System.Void (Private)
- **OnExit()**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)

