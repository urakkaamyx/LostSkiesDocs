# WildSkies.WorldItems.WeatherWall

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _windwallService | WildSkies.Service.WindwallService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _windwallData | WindwallData | Private |
| _windwallInterior | UnityEngine.GameObject | Private |
| _splinePoints | System.Collections.Generic.List`1<UnityEngine.Vector3> | Private |
| _useWindwallInterior | System.Boolean | Private |
| _wallInterior | UnityEngine.BoxCollider | Private |
| _isMainWall | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| _wallWidth | System.Single | Private |
| _wallHeight | System.Single | Private |

## Methods

- **get__wallWidth()**: System.Single (Private)
- **get__wallHeight()**: System.Single (Private)
- **Start()**: System.Void (Public)
- **CalculateWall(System.Int32 wallId)**: System.Void (Public)
- **AddSection(System.Int32 id, UnityEngine.Vector3 pointA, UnityEngine.Vector3 pointB)**: System.Void (Private)
- **OnDestroy()**: System.Void (Public)
- **UpdateWallInterior(UnityEngine.Vector3 pointA, UnityEngine.Vector3 pointB, System.Single height, System.Single depth)**: System.Void (Public)
- **GetCrossOfTwoPoints(UnityEngine.Vector3 a, UnityEngine.Vector3 b)**: UnityEngine.Vector3 (Private)
- **OnFloatingWorldOriginShifted(UnityEngine.Vector3 shift)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

