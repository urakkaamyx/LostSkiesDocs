# WildSkies.AI.AIIdleBehaviourHandler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _behaviours | WildSkies.AI.IdleBehaviourType[] | Private |
| _animation | AgentAnimation | Private |
| _navAgent | WildSkies.AI.BossaNavAgent | Private |
| _behaviourMap | System.Collections.Generic.Dictionary`2<WildSkies.AI.IdleBehaviourType,WildSkies.AI.IdleBehaviour> | Private |
| _activeBehaviour | WildSkies.AI.IdleBehaviour | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ActiveBehaviour | WildSkies.AI.IdleBehaviour | Public |

## Methods

- **get_ActiveBehaviour()**: WildSkies.AI.IdleBehaviour (Public)
- **Init(AIEvents events)**: System.Void (Public)
- **TrySetBehaviour(WildSkies.AI.IdleBehaviourType type)**: System.Boolean (Public)
- **ClearIdleBehaviour(System.Boolean exitEarly)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

