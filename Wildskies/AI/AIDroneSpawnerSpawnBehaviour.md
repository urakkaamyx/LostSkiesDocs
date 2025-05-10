# WildSkies.AI.AIDroneSpawnerSpawnBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _flyingAgent | WildSkies.AI.BossaFlyingAgent | Private |
| _droneEntity | WildSkies.Entities.AIEntity | Private |
| _timeOut | System.Int32 | Private |
| _xSpawnOffsetRange | UnityEngine.Vector2 | Private |
| _ySpawnOffsetRange | UnityEngine.Vector2 | Private |
| _zSpawnOffsetRange | UnityEngine.Vector2 | Private |
| _hasCrafted | System.Boolean | Private |
| _craftableRendererController | CraftableRendererController | Private |
| _timeoutTokenSource | System.Threading.CancellationTokenSource | Private |

## Methods

- **StartBehaviour()**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **StartMovementBehaviour()**: System.Void (Private)
- **ForceEnd()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **WaitAndEndBehaviour(System.Int32 seconds)**: Cysharp.Threading.Tasks.UniTask (Private)
- **GetSpawnOffsetPositionWithinRange()**: UnityEngine.Vector3 (Private)
- **EndBehaviour(MovementBehaviourTypes obj)**: System.Void (Private)
- **EndBehaviour()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

