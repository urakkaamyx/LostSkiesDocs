# WildSkies.AI.DeployBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _animation | AgentAnimation | Private |
| _openState | System.String | Private |
| _closeState | System.String | Private |
| _damageComponent | WildSkies.Entities.Health.EntityHealthDamageComponent | Private |
| OnComplete | System.Action | Public |
| OnDeploy | System.Action`1<System.Boolean> | Public |
| DeployState | System.Int32 | Public |
| WeakspotMultiplier | System.Single | Public |
| _defaultWeakspotMultiplier | System.Single | Private |
| _noDamageMultiplier | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentState | WildSkies.AI.DeployBehaviour/EDeployState | Public |

## Methods

- **get_CurrentState()**: WildSkies.AI.DeployBehaviour/EDeployState (Public)
- **Start()**: System.Void (Private)
- **Deploy()**: System.Void (Public)
- **Undeploy()**: System.Void (Public)
- **OnAtRest()**: System.Void (Private)
- **UpdateWeakspotMultiplier(System.Single prev, System.Single cur)**: System.Void (Public)
- **SetWeakspotMultiplier(System.Single multiplier)**: System.Void (Private)
- **OnCompleteDeployAnimation(UnityEngine.AnimatorStateInfo stateInfo)**: System.Void (Private)
- **OnCompleteUndeployAnimation(UnityEngine.AnimatorStateInfo stateInfo)**: System.Void (Private)
- **OnDeath()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

