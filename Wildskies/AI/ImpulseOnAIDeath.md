# WildSkies.AI.ImpulseOnAIDeath

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _aiEntity | WildSkies.Entities.AIEntity | Private |
| _doAOEDamage | System.Boolean | Private |
| _aoeRadius | System.Single | Private |
| aoeDamageAtCenter | System.Single | Private |
| _aoeDamageAtEdge | System.Single | Private |
| _doCameraImpulse | System.Boolean | Private |
| _cameraImpulseSpringData | Bossa.Cinematika.Impulses.ImpulseSpring | Private |
| _cameraImpulseSpringStrength | System.Single | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| _uiService | UISystem.IUIService | Private |
| _localDamageables | Entities.Weapons.IDamageable[] | Private |

## Methods

- **Start()**: System.Void (Private)
- **OnEntityDeath(Bossa.Core.Entity.Entity entity, UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

