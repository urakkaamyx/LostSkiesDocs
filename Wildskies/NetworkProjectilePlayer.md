# WildSkies.NetworkProjectilePlayer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _projectileService | WildSkies.Service.ProjectileService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |

## Methods

- **Awake()**: System.Void (Protected)
- **SendInitProjectileCommand(WildSkies.Service.ProjectileType projectileType, WildSkies.Service.ProjectileService/ProjectileData data, System.Int32 seed)**: System.Void (Public)
- **InitProjectileCommand(System.Int32 projectileType, UnityEngine.Vector3 start, UnityEngine.Vector3 direction, System.Int32 layerMask, System.Single speed, System.Single maxDistance, System.Single dropAmount, System.Single dropStartDistance, System.Int32 seed)**: System.Void (Public)
- **SendStopProjectileCommand(System.Int32 syncId)**: System.Void (Public)
- **StopProjectileCommand(System.Int32 syncId)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

