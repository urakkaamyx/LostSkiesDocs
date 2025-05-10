# WildSkies.Service.AIFeedbackService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _perceptions | System.Collections.Generic.List`1<WildSkies.AI.IAIPerceptionSystem> | Private |
| _activeEngagements | System.Collections.Generic.List`1<WildSkies.AI.IAIPerceptionSystem> | Private |
| _perceptionTransforms | System.Collections.Generic.Dictionary`2<WildSkies.AI.IAIPerceptionSystem,UnityEngine.Transform> | Private |
| _playerEngagementState | PlayerEngagementState | Private |
| _maxEngagementReached | System.Boolean | Private |
| OnDeerAddedToPerception | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| PlayerEngagementState | PlayerEngagementState | Public |
| Perceptions | System.Collections.Generic.List`1<WildSkies.AI.IAIPerceptionSystem> | Public |
| PerceptionTransforms | System.Collections.Generic.Dictionary`2<WildSkies.AI.IAIPerceptionSystem,UnityEngine.Transform> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_PlayerEngagementState()**: PlayerEngagementState (Public)
- **get_Perceptions()**: System.Collections.Generic.List`1<WildSkies.AI.IAIPerceptionSystem> (Public)
- **get_PerceptionTransforms()**: System.Collections.Generic.Dictionary`2<WildSkies.AI.IAIPerceptionSystem,UnityEngine.Transform> (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **AddAIPerception(WildSkies.AI.IAIPerceptionSystem aiPerception, UnityEngine.Transform transform)**: System.Void (Public)
- **RemoveAIPerception(WildSkies.AI.IAIPerceptionSystem aiPerception)**: System.Void (Public)
- **OnPerceptionStateChange(WildSkies.AI.IAIPerceptionSystem perceptionSystem)**: System.Void (Public)
- **UpdateActiveEngagements(WildSkies.AI.IAIPerceptionSystem perceptionSystem)**: System.Void (Private)
- **UpdatePlayerEngagementState(WildSkies.AI.IAIPerceptionSystem perceptionSystem)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

