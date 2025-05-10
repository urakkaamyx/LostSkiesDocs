# WildSkies.AI.AIVFXHandler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _config | WildSkies.AI.AIVFXConfig | Private |
| _attackHandler | WildSkies.AI.Attacks.AIAttackHandler | Private |
| _movementVFX | WildSkies.AI.AIMovementVFX | Private |
| _vfxPositions | WildSkies.AI.AIVFXHandler/VFXPosition[] | Private |
| _loopingVFX | WildSkies.AI.AIVFXHandler/LoopingVFX[] | Private |
| <CurrentElementLODLevel>k__BackingField | System.Int32 | Private |
| _events | AIEvents | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _vfxDictionary | System.Collections.Generic.Dictionary`2<WildSkies.AI.AIVFXType,WildSkies.AI.AIVFXConfig/AIVFX> | Private |
| _movementVFXDictionary | System.Collections.Generic.Dictionary`2<MovementBehaviourTypes,WildSkies.AI.AIVFXConfig/AIVFX> | Private |
| _meleeAttackStateDictionary | System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttack/AttackState,WildSkies.AI.AIVFXType> | Private |
| _shootAttackStateDictionary | System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttack/AttackState,WildSkies.AI.AIVFXType> | Private |
| _loopingVFXDictionary | System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.AI.AIVFXHandler/LoopingVFX> | Private |
| _positionDictionary | System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Transform> | Private |
| _activeAttackVFXType | WildSkies.AI.AIVFXType | Private |
| _normalizedHealthToDisplayLowHealthVfx | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentElementLODLevel | System.Int32 | Public |

## Methods

- **get_CurrentElementLODLevel()**: System.Int32 (Public)
- **set_CurrentElementLODLevel(System.Int32 value)**: System.Void (Private)
- **Init(WildSkies.Service.NetworkFxService networkFxService, AIEvents events)**: System.Void (Public)
- **RegisterEvents()**: System.Void (Private)
- **OnEntityDamaged(System.Single damage, WildSkies.Weapon.DamageType damageType, UnityEngine.Vector3 damagePoint, System.Single newNormalizedHealth)**: System.Void (Private)
- **OnAttackInterrupted(WildSkies.AI.Attacks.AIAttackType obj)**: System.Void (Private)
- **OnStunned()**: System.Void (Private)
- **OnEndStunned()**: System.Void (Private)
- **OnEntityDeath(Bossa.Core.Entity.Entity entity, UnityEngine.Vector3 forceOfDeath)**: System.Void (Private)
- **OnAttackAiming(WildSkies.AI.Attacks.AIAttackType attackType, System.Boolean isAiming)**: System.Void (Private)
- **OnMovementBehaviourEntered(MovementBehaviourTypes movementBehaviourType)**: System.Void (Private)
- **OnMovementBehaviourExited(MovementBehaviourTypes movementBehaviourType)**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnAttackStateChanged(WildSkies.AI.Attacks.AIAttackType attackType, WildSkies.AI.Attacks.AIAttack/AttackState attackState)**: System.Void (Private)
- **OnAttackHitPlayer(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Void (Private)
- **OnAttackMissed(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Void (Private)
- **OnAttacked(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Void (Private)
- **SetLoopingVFX(WildSkies.VfxType type, System.Boolean play)**: System.Void (Private)
- **NetworkAttackStateChanged(System.Int32 attackType, System.Int32 attackState)**: System.Void (Public)
- **NetworkOnAttackPlayer(System.Int32 attackType)**: System.Void (Public)
- **NetworkOnAttackMissed(System.Int32 attackType)**: System.Void (Public)
- **NetworkOnAttacked(System.Int32 attackType)**: System.Void (Public)
- **NetworkSetLoopingVFX(System.Int32 type, System.Boolean play)**: System.Void (Public)
- **GetPosition(WildSkies.AI.AIVFXType vfxType, UnityEngine.Transform& parent)**: System.Void (Private)
- **ToggleLoopingVFX(System.Boolean on)**: System.Void (Private)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

