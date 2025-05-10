# WildSkies.Ship.ShipCore

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _teleporterOn | System.Boolean | Public |
| _selfRightingStrength | System.Single | Private |
| _selfRightingWidth | System.Single | Private |
| _maxSelfRightingForce | System.Single | Private |
| _coreTorque | UnityEngine.Vector3 | Private |
| _coreTorqueMassless | UnityEngine.Vector3 | Private |
| _respawnLocation | UnityEngine.Vector3 | Private |
| _forwardPower | System.Single | Private |
| _verticalPower | System.Single | Private |
| _teleporter | UnityEngine.GameObject | Private |
| _teleporterVfx | UnityEngine.ParticleSystem | Private |
| _verticalDamping | System.Single | Private |
| _coreWeightLift | System.Single | Private |
| _coreEnergyCapacity | System.Single | Private |
| _canInteract | System.Boolean | Private |
| _curLiftForce | System.Single | Private |
| _liftVelocity | System.Single | Private |
| _vertical | System.Single | Private |
| _lastVel | UnityEngine.Vector3 | Private |
| _shipControlState | WildSkies.Ship.ShipControl/ShipControlState | Private |
| _compensationForce | System.Single | Private |
| _verticalDampingVelocity | System.Single | Private |
| _coreStress | System.Single | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Load | System.Single | Public |
| CoreWeightLift | System.Single | Public |
| IsWeightOverloaded | System.Boolean | Public |
| EnergyUsage | System.Single | Public |
| CoreEnergyCapacity | System.Single | Public |
| IsEnergyOverloaded | System.Boolean | Public |
| RespawnPosition | UnityEngine.Vector3 | Public |
| RespawnLocalPosition | UnityEngine.Vector3 | Public |

## Methods

- **get_Load()**: System.Single (Public)
- **get_CoreWeightLift()**: System.Single (Public)
- **set_CoreWeightLift(System.Single value)**: System.Void (Public)
- **get_IsWeightOverloaded()**: System.Boolean (Public)
- **get_EnergyUsage()**: System.Single (Public)
- **get_CoreEnergyCapacity()**: System.Single (Public)
- **set_CoreEnergyCapacity(System.Single value)**: System.Void (Public)
- **get_IsEnergyOverloaded()**: System.Boolean (Public)
- **get_RespawnPosition()**: UnityEngine.Vector3 (Public)
- **get_RespawnLocalPosition()**: UnityEngine.Vector3 (Public)
- **Update()**: System.Void (Private)
- **OnShipControlUpdate(WildSkies.Ship.ShipControl/ShipControlState state)**: System.Void (Public)
- **OnDrawGizmosSelected()**: System.Void (Private)
- **OnShipControlFixedUpdate()**: System.Void (Public)
- **ApplyCoreForward()**: System.Void (Private)
- **ApplyVertical()**: System.Void (Private)
- **ApplyTorques()**: System.Void (Private)
- **SelfRighting()**: System.Void (Private)
- **UpdateFloatingAndCounterForce()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

