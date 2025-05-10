# WildSkies.Enemies.AwarenessStateFactory

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _megaLogic | WildSkies.Enemies.MegaLogic | Private |
| _skyBossLogic | WildSkies.Enemies.SkyBoss | Private |
| _bossTransform | UnityEngine.Transform | Private |
| _data | WildSkies.Enemies.AwarenessUtilityData | Private |
| _debugTarget | UnityEngine.Transform | Private |
| _shipTarget | WildSkies.Enemies.ShipTarget | Private |

## Methods

- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **SetTarget(WildSkies.Gameplay.ShipBuilding.ConstructedShipController target)**: System.Void (Public)
- **ClearTarget()**: System.Void (Private)
- **Awake()**: System.Void (Private)
- **BuildAwarenessState(WildSkies.Enemies.EAwarenessState state)**: WildSkies.Enemies.AwarenessState (Public)
- **BuildLosingGroundState()**: WildSkies.Enemies.AwarenessState (Private)
- **BuildRelaxedState()**: WildSkies.Enemies.AwarenessState (Private)
- **BuildSideOnState()**: WildSkies.Enemies.AwarenessState (Private)
- **BuildTurnedAwayState()**: WildSkies.Enemies.AwarenessState (Private)
- **BuildBeingChasedState()**: WildSkies.Enemies.AwarenessState (Private)
- **.ctor()**: System.Void (Public)

