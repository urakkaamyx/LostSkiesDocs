# WildSkies.AI.ShipPerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _shipTracking | AIShipTracking | Private |
| _detectionRange | System.Single | Private |
| _minConfidenceInRange | System.Single | Private |
| _isActive | System.Boolean | Private |
| _ship | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _detectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DetectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |

## Methods

- **get_DetectedObjs()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **SetUp()**: System.Void (Protected)
- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **OnShipAssigned(WildSkies.Gameplay.ShipBuilding.ConstructedShipController obj)**: System.Void (Private)
- **ResetSensor()**: System.Void (Public)
- **GetDetectionLocation()**: UnityEngine.Vector3 (Public)
- **.ctor()**: System.Void (Public)

