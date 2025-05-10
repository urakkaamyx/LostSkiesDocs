# WildSkies.BuffSystem.HeatSource

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _buffToApply | BuffDefinitionBase | Private |
| _buffsToCounteract | BuffDefinitionBase[] | Private |
| _temperatureAtCentre | System.Single | Private |
| _maxRange | System.Single | Private |
| _minRange | System.Single | Private |
| _maxRangeCollider | UnityEngine.SphereCollider | Private |
| _minRangeCollider | UnityEngine.SphereCollider | Private |
| _buffService | WildSkies.Service.BuffService | Private |
| _entitiesInRange | System.Collections.Generic.List`1<WildSkies.BuffSystem.EntityInRange> | Private |
| _entitiesToRemove | System.Collections.Generic.List`1<WildSkies.BuffSystem.EntityInRange> | Private |
| TemperatureToApplicationRateConversionValue | System.Single | Private |

## Methods

- **Update()**: System.Void (Public)
- **OnTriggerEnter(UnityEngine.Collider other)**: System.Void (Public)
- **AddEntityInRange(WildSkies.BuffSystem.EntityInRange newEntityInRange)**: System.Void (Private)
- **OnTriggerExit(UnityEngine.Collider other)**: System.Void (Private)
- **HitIsPlayer(UnityEngine.Transform other, WildSkies.Player.LocalPlayer& localPlayer)**: System.Boolean (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **OnValidate()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

