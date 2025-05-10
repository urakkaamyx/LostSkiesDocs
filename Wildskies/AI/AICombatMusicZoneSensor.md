# WildSkies.AI.AICombatMusicZoneSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _rangeSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _perceptionStateMachine | WildSkies.AI.PerceptionStateMachine | Private |
| _targetAcquisition | AITargetAcquisition | Private |
| _referenceSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _detectedObjects | System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,WildSkies.AI.AICombatMusicZoneSensor/DetectedObject> | Private |
| _isEnabled | System.Boolean | Private |
| _currentLODLevel | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentElementLODLevel | System.Int32 | Public |

## Methods

- **get_CurrentElementLODLevel()**: System.Int32 (Public)
- **OnEnable()**: System.Void (Public)
- **OnDisable()**: System.Void (Public)
- **OnDeath(Bossa.Core.Entity.Entity entity, UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **OnPerceptionStateChanged(WildSkies.AI.EPerceptionState state)**: System.Void (Private)
- **OnHasKnownTarget(AITargetType type, System.Boolean hasTarget)**: System.Void (Private)
- **EnableSensor()**: System.Void (Private)
- **ResetSensor()**: System.Void (Private)
- **OnPulsed()**: System.Void (Private)
- **OnDetected(UnityEngine.GameObject detectedObj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **OnLostDetection(UnityEngine.GameObject detectedObj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

