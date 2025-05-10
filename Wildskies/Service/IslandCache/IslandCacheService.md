# WildSkies.Service.IslandCache.IslandCacheService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localCache | WildSkies.Service.IslandCache.ILocalIslandCache | Private |
| _remoteSource | WildSkies.Service.IslandCache.IRemoteIslandSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **GetIsland(WildSkies.Service.IslandCache.CachedIslandId id)**: WildSkies.Service.IslandCache.CachedIsland (Public)
- **Terminate()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

