# WildSkies.Puzzles.LaserNode

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| AlwaysPowered | System.Boolean | Public |
| Powered | System.Boolean | Private |
| _movable | System.Boolean | Private |
| _childrenByDesign | System.Collections.Generic.List`1<WildSkies.Puzzles.LaserNode> | Public |
| _laserOffsets | System.Collections.Generic.List`1<UnityEngine.Quaternion> | Public |
| _forwardByDesign | UnityEngine.Vector3 | Private |
| _lastPowerTime | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ForwardByDesign | UnityEngine.Vector3 | Public |

## Methods

- **get_ForwardByDesign()**: UnityEngine.Vector3 (Public)
- **Start()**: System.Void (Private)
- **Calibrate()**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FiringLaser()**: System.Void (Public)
- **ReceivePowered()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

