# WildSkies.AI.Attacks.StompAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _explosionHandler | ExplosionHandler | Private |
| _data | WildSkies.AI.StompAttackData | Private |
| _agentAnimation | AgentAnimation | Private |
| _navAgent | WildSkies.AI.BossaNavAgent | Private |
| _stompPoint | UnityEngine.Transform | Private |
| _ignoreColliders | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _weakSpots | UnityEngine.Collider[] | Private |
| _vulnerableTimerCancellationToken | System.Threading.CancellationTokenSource | Private |
| _vulnerableTimerTask | Cysharp.Threading.Tasks.UniTask | Private |
| _vulnerableTimer | System.Single | Private |
| _stompAnimationEvent | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **Start()**: System.Void (Protected)
- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Protected)
- **OnFixedUpdate()**: System.Void (Public)
- **OnAnimationEvent(System.String id)**: System.Void (Private)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **OnWindUp()**: System.Void (Private)
- **OnWindUpComplete(UnityEngine.AnimatorStateInfo obj)**: System.Void (Private)
- **OnStart()**: System.Void (Private)
- **OnStartComplete(UnityEngine.AnimatorStateInfo obj)**: System.Void (Private)
- **OnVulnerable()**: System.Void (Private)
- **OnRecover()**: System.Void (Private)
- **OnRecoverComplete(UnityEngine.AnimatorStateInfo obj)**: System.Void (Private)
- **SetWeakspotsEnabled(System.Boolean isEnabled)**: System.Void (Public)
- **VulnerableTimerTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)

