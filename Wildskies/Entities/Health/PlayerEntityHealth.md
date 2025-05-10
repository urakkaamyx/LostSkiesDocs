# WildSkies.Entities.Health.PlayerEntityHealth

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _buffService | WildSkies.Service.BuffService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _character | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| OnArmorValueUpdated | System.Action`2<System.Single,System.Single> | Private |
| <Invincible>k__BackingField | System.Boolean | Private |
| _lastDamageFrame | System.Collections.Generic.Dictionary`2<WildSkies.Weapon.DamageType,System.Int32> | Private |
| _equippedArmor | System.Collections.Generic.Dictionary`2<EquipmentType,System.Single> | Private |
| _currentArmorValue | System.Single | Private |
| _belowNormalizedHealthToMuffleAudio | System.Single | Private |
| _hurtCameraEfectScale | System.Single | Private |
| _impulseSpringForHurting | Bossa.Cinematika.Impulses.ImpulseSpring | Private |
| _impulseSpringStrength | System.Single | Private |
| _hurtCameraImpulseScale | System.Single | Private |
| _impulseIsImpact | System.Boolean | Private |
| _hurtCameraEffect | HurtCameraEffect | Private |
| _eqCutOffOnLowHealth | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentArmorValue | System.Single | Public |
| Invincible | System.Boolean | Public |

## Methods

- **add_OnArmorValueUpdated(System.Action`2<System.Single,System.Single> value)**: System.Void (Public)
- **remove_OnArmorValueUpdated(System.Action`2<System.Single,System.Single> value)**: System.Void (Public)
- **get_CurrentArmorValue()**: System.Single (Public)
- **get_Invincible()**: System.Boolean (Public)
- **set_Invincible(System.Boolean value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: System.Single (Public)
- **AuthorityDamage(System.Single damage, System.Int32 type, System.Int32 srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint)**: System.Single (Protected)
- **Start()**: System.Void (Private)
- **CameraDamageEffect(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 point, System.Single newNormalizedHealth)**: System.Void (Private)
- **OnAllServicesReady()**: System.Void (Private)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **UpdateCurrentEquipped()**: System.Void (Public)
- **UpdateAccumilatedArmorValue()**: System.Void (Private)
- **OnArmorEquipped(Player.Inventory.IInventoryItem item)**: System.Void (Private)
- **OnArmorRemoved(Player.Inventory.IInventoryItem item)**: System.Void (Private)
- **AdjustCurrentValue(System.Single value)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<Start>b__29_0()**: System.Void (Private)

