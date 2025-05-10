# WildSkies.ShipParts.ShipWeaponProjectile

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _statsType | WildSkies.ShipParts.ShipWeaponProjectile/StatsType | Private |
| _muzzleFlash | WildSkies.VfxType | Private |
| _audioOnShoot | WildSkies.Audio.AudioType | Private |
| _audioDryFire | WildSkies.Audio.AudioType | Private |
| _audioReload | WildSkies.Audio.AudioType | Private |
| _projectileHitSound | WildSkies.Audio.AudioType | Private |
| _cannonInventory | ObjectInventory | Private |
| _fireAnimationStateName | System.String | Private |
| _damage | System.Single | Private |
| _damageType | WildSkies.Weapon.DamageType | Private |
| _collisionLayerMask | UnityEngine.LayerMask | Private |
| _explosionRadius | System.Single | Private |
| _explosionDamageAtCenter | System.Single | Private |
| _explosionDamageAtEdge | System.Single | Private |
| _maxDistance | System.Single | Private |
| _dropAmount | System.Single | Private |
| _dropStartDistance | System.Single | Private |
| _delayBetweenShots | System.Single | Private |
| _shotSpeed | System.Single | Private |
| _shotImpulseSpringSettings | Bossa.Cinematika.Impulses.ImpulseSpring | Private |
| _shotImpulseStrength | System.Single | Private |
| _rumbleDecay | System.Single | Private |
| _rumbleMagnitude | System.Single | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |
| _projectileService | WildSkies.Service.ProjectileService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _projectileLocator | UnityEngine.Transform | Private |
| _lastFireTime | System.Single | Private |
| _ammoItem | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _constantlyUpdateStats | System.Boolean | Private |

## Methods

- **UpdateStats()**: System.Void (Protected)
- **FirePressed()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **FireHeld()**: System.Void (Public)
- **SetupReferences(ShipPartSubComponent[] shipParts)**: System.Void (Public)
- **CheckAmmo()**: System.Boolean (Private)
- **FireProjectile()**: System.Void (Public)
- **OnProjectileHit(UnityEngine.RaycastHit hit)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

