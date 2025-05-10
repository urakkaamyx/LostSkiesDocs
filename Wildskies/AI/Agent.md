# WildSkies.AI.Agent

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _navAgent | WildSkies.AI.BossaNavAgent | Private |
| _perceptionStateMachine | WildSkies.AI.PerceptionStateMachine | Private |
| _isInitialised | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| PerceptionStateMachine | WildSkies.AI.PerceptionStateMachine | Public |
| NavAgent | WildSkies.AI.BossaNavAgent | Public |

## Methods

- **get_PerceptionStateMachine()**: WildSkies.AI.PerceptionStateMachine (Public)
- **get_NavAgent()**: WildSkies.AI.BossaNavAgent (Public)
- **Init(AIEvents events, Coherence.Toolkit.CoherenceSync coherenceSync, WildSkies.Service.AIGroupService groupService, WildSkies.Entities.IAIGroupMember groupMember, WildSkies.Service.CameraImpulseService cameraImpulseService, WildSkies.Service.FloatingWorldOriginService floatingWorldOriginService)**: System.Void (Public)
- **SetNavActive(System.Boolean enabled)**: System.Void (Public)
- **SetPerceptionActive(System.Boolean enabled)**: System.Void (Public)
- **SetPerceptionEventCallbacks(WildSkies.AI.PerceptionStateMachine/OnStateChange action, System.Boolean addCallback)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

