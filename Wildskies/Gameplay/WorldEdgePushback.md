# WildSkies.Gameplay.WorldEdgePushback

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| NEGATE_VELOCITY_DISTANCE | System.Single | Public |
| PUSHBACK_DISTANCE | System.Single | Public |
| VERTICAL_PUSHBACK | System.Single | Public |
| VERTICAL_NEGATE | System.Single | Private |
| VERTICAL_PUSHBACK_FLOOR | System.Single | Public |
| VERTICAL_NEGATE_FLOOR | System.Single | Private |
| VERTICAL_NEGATE_DISTANCE_FLOOR | System.Single | Private |
| VERTICAL_NEGATE_DISTANCE | System.Single | Public |
| PLAYER_DISTANCE_THRESHOLD | System.Single | Private |
| _outOfBoundsMessage | UnityEngine.Localization.LocalizedString | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| _initialized | System.Boolean | Private |

## Methods

- **Awake()**: System.Void (Protected)
- **FixedUpdate()**: System.Void (Protected)
- **Initialize()**: System.Void (Private)
- **EnforceNegativeBound(System.Single& pos, System.Single& vel, System.Single pushThreshold, System.Single negateThreshold)**: System.Boolean (Private)
- **EnforcePositiveBound(System.Single& pos, System.Single& vel, System.Single pushThreshold, System.Single negateThreshold)**: System.Boolean (Private)
- **DampenIfNeeded(System.Single& vel, System.Single t)**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

