# WildSkies.AI.HoverBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _target | UnityEngine.Transform | Private |
| _heightOffset | System.Single | Private |
| _hoverDistance | System.Single | Private |
| _hoverLocation | UnityEngine.Vector3 | Private |
| _strafeSpeed | System.Single | Private |
| _hoverTurnSpeed | System.Single | Private |
| _behaviourEnded | System.Boolean | Private |
| _endWhenReachedTarget | System.Boolean | Private |
| _offset | UnityEngine.Vector3 | Private |
| _distanceAllowance | System.Single | Private |
| _onComplete | System.Action | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **.ctor(WildSkies.AI.BossaNavAgent agent, AIEvents events)**: System.Void (Public)
- **get_Type()**: MovementBehaviourTypes (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **SetHoverValues(UnityEngine.Transform target, System.Single heightOffset, System.Single hoverDistance, System.Single strafeSpeed, System.Action onComplete, UnityEngine.Vector3 offset, System.Boolean endWhenReachedTarget)**: System.Void (Public)
- **Destination()**: UnityEngine.Vector3 (Private)

