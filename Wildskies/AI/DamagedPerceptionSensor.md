# WildSkies.AI.DamagedPerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _entityHealth | WildSkies.Entities.Health.EntityHealth | Private |
| _estimatedOriginDistance | System.Single | Private |
| _fuzzyDetectionRange | System.Single | Private |
| _hitRangeSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _hitRangeMaxSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _ignoreRangeIfNoDetection | System.Boolean | Private |
| _enabled | System.Boolean | Private |
| _detectionLocation | UnityEngine.Vector3 | Private |
| _sensorDetectionPosition | UnityEngine.Vector3 | Private |
| _sensorHadDetection | System.Boolean | Private |
| _tempStaggerValue | System.Int32 | Private |
| OnDamagedEvent | System.Action | Public |

## Methods

- **SetUp()**: System.Void (Protected)
- **DebugTest()**: System.Void (Private)
- **OnDamaged(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 position, System.Single newNormalizedHealth)**: System.Void (Private)
- **GetDetectionLocation()**: UnityEngine.Vector3 (Public)
- **ResetSensor()**: System.Void (Public)
- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

