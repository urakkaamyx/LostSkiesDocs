# WildSkies.AI.Pets.PetFollowState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _steeringSensor | Micosmo.SensorToolkit.SteeringSensor | Private |
| _petData | WildSkies.AI.Pets.AIPetController/PetData | Private |
| _petController | WildSkies.AI.Pets.AIPetController | Private |
| _agentHeadTargeting | WildSkies.AI.AgentHeadTargeting | Private |
| _lootSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _events | AIEvents | Private |
| _raySensor | Micosmo.SensorToolkit.RaySensor | Private |
| _interestTarget | UnityEngine.Transform | Private |
| _currentDetection | UnityEngine.GameObject | Private |
| _lookAtLootTimer | System.Single | Private |

## Methods

- **.ctor(Micosmo.SensorToolkit.SteeringSensor steeringSensor, WildSkies.AI.Pets.AIPetController/PetData petData, WildSkies.AI.Pets.AIPetController petController, WildSkies.AI.AgentHeadTargeting agentHeadTargeting, Micosmo.SensorToolkit.RangeSensor lootSensor, Micosmo.SensorToolkit.RaySensor raySensor, AIEvents events)**: System.Void (Public)
- **OnEnter()**: System.Void (Public)
- **OnExit()**: System.Void (Public)
- **OnLootDetectorPulsed()**: System.Void (Private)
- **OnInterestInSight(UnityEngine.GameObject detectedObj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **OnLostInterestDetection(UnityEngine.GameObject detectedObj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **OnUpdate()**: System.Void (Public)
- **LookAtLoot()**: System.Void (Private)
- **FollowPlayer()**: System.Void (Private)

