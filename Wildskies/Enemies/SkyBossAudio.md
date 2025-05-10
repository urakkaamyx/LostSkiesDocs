# WildSkies.Enemies.SkyBossAudio

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _skyBoss | WildSkies.Enemies.SkyBoss | Private |
| _skyBossAnimationEvent | SkyBossAnimationEvent | Private |
| _skyBossAttackHandler | WildSkies.AI.Attacks.SkyBossAttackHandler | Private |
| _skyBossAudioConfig | WildSkies.Enemies.SkyBossAudioConfig | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _skyBossHealth | SkyBossHealth | Private |
| _hasInitialized | System.Boolean | Private |
| _stateAudioMap | System.Collections.Generic.Dictionary`2<WildSkies.Enemies.SkyBoss/State,WildSkies.Enemies.SkyBossAudio/HeraldStateAudio> | Private |
| _attackAudioMap | System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttackType,System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttack/AttackState,WildSkies.Enemies.SkyBossAudio/HeraldAttackState>> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| HasInitialized | System.Boolean | Public |

## Methods

- **get_HasInitialized()**: System.Boolean (Public)
- **SetSkyBossAnimationEvent(SkyBossAnimationEvent skyBossAnimationEvent)**: System.Void (Public)
- **Initialize()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **OnAttackStateChanged(WildSkies.AI.Attacks.AIAttackType attackType, WildSkies.AI.Attacks.AIAttack/AttackState attackState)**: System.Void (Private)
- **OnShipEnteredRange(WildSkies.Gameplay.ShipBuilding.ConstructedShipController obj)**: System.Void (Private)
- **OnShipLeftRange()**: System.Void (Private)
- **OnDamaged()**: System.Void (Private)
- **OnLostSection()**: System.Void (Private)
- **OnMoveUp()**: System.Void (Private)
- **OnMoveDown()**: System.Void (Private)
- **OnStateChanged(WildSkies.Enemies.SkyBoss/State state)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

