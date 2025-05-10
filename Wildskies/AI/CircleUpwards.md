# WildSkies.AI.CircleUpwards

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _maxAltitude | System.Single | Private |
| _orbitRadius | System.Single | Private |
| _orbitPositionOffset | UnityEngine.Vector3 | Private |
| _target | UnityEngine.Vector3 | Private |
| _startingAltitude | System.Single | Private |
| _currentAltitude | System.Single | Private |
| _orbitAngle | System.Single | Private |
| _ascendSpeed | System.Single | Private |
| _minHeightDiff | System.Single | Private |
| _maxAltitudeVector | UnityEngine.Vector3 | Private |
| _orbitSettings | AIMovementConfig/OrbitSettingsData | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/OrbitSettingsData orbitSettings, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **UpdateOrbiting()**: System.Void (Private)
- **SetOrbitValues(UnityEngine.Vector3 target, System.Single orbitRadius, System.Single maxAltitude, System.Single ascendSpeed, System.Single startingAltitude)**: System.Void (Public)
- **SetOrbitTarget()**: System.Void (Private)
- **UpdateAltitude()**: System.Void (Private)

