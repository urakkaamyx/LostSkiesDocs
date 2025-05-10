# WildSkies.AI.AIStagger

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _rendererController | CraftableRendererController | Private |
| _entityRendererController | EntityRendererController | Private |
| _staggeredPingTick | System.Single | Private |
| _staggerMultiplier | System.Single | Private |
| _currentStagger | System.Int32 | Public |
| _isStunned | System.Boolean | Public |
| _aiConfig | WildSkies.AI.AIConfig | Private |
| _cooldownTimer | System.Single | Private |
| _aiEvents | AIEvents | Private |
| _staggerUpdateTask | Cysharp.Threading.Tasks.UniTask | Private |
| _cooldownToken | System.Threading.CancellationTokenSource | Private |
| _stunnedToken | System.Threading.CancellationTokenSource | Private |
| _staggeredToken | System.Threading.CancellationTokenSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentStagger | System.Int32 | Public |
| IsStunned | System.Boolean | Public |
| IsStaggered | System.Boolean | Public |

## Methods

- **get_CurrentStagger()**: System.Int32 (Public)
- **get_IsStunned()**: System.Boolean (Public)
- **get_IsStaggered()**: System.Boolean (Public)
- **Init(WildSkies.AI.AIConfig aiConfig, AIEvents aiEvents)**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **ApplyStaggerDamage(System.Int32 staggerAmount, WildSkies.AI.AIStagger/StaggerType staggerType)**: System.Void (Public)
- **NetworkApplyStaggerDamage(System.Int32 staggerAmount, System.Int32 staggerType)**: System.Void (Public)
- **ApplyStun(System.Boolean forceStun, System.Boolean isTimed)**: System.Void (Public)
- **ForceEndStun()**: System.Void (Public)
- **OnStunned()**: System.Void (Private)
- **RemoveStaggerDamage(System.Int32 amount)**: System.Void (Public)
- **AdjustStagger(System.Int32 adjustment)**: System.Void (Private)
- **NetworkRemoveStaggerDamage(System.Int32 amount)**: System.Void (Public)
- **ResetStagger()**: System.Void (Public)
- **StaggerPingTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **CooldownStagger()**: Cysharp.Threading.Tasks.UniTask (Private)
- **StunnedTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)

