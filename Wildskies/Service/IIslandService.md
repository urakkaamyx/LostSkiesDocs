# WildSkies.Service.IIslandService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| Islands | System.Collections.Generic.List`1<World.IslandController> | Public |
| AuthoredIslands | System.Collections.Generic.Dictionary`2<System.String,System.String> | Public |
| FirstIslandLoaded | System.Boolean | Public |
| SpawnDelay | System.Int32 | Public |
| IslandAuthorityRequested | System.Action`2<System.String,System.String> | Public |
| IslandAuthorityReleased | System.Action`2<System.String,System.String> | Public |
| IslandAuthorityGranted | System.Action`2<System.String,System.String> | Public |
| IslandAbandoned | System.Action`1<System.String> | Public |
| RegisteredIsland | System.Action | Public |
| UnregisteredIsland | System.Action | Public |

## Methods

- **get_Islands()**: System.Collections.Generic.List`1<World.IslandController> (Public)
- **get_AuthoredIslands()**: System.Collections.Generic.Dictionary`2<System.String,System.String> (Public)
- **get_FirstIslandLoaded()**: System.Boolean (Public)
- **get_SpawnDelay()**: System.Int32 (Public)
- **get_IslandAuthorityRequested()**: System.Action`2<System.String,System.String> (Public)
- **set_IslandAuthorityRequested(System.Action`2<System.String,System.String> value)**: System.Void (Public)
- **get_IslandAuthorityReleased()**: System.Action`2<System.String,System.String> (Public)
- **set_IslandAuthorityReleased(System.Action`2<System.String,System.String> value)**: System.Void (Public)
- **get_IslandAuthorityGranted()**: System.Action`2<System.String,System.String> (Public)
- **set_IslandAuthorityGranted(System.Action`2<System.String,System.String> value)**: System.Void (Public)
- **get_IslandAbandoned()**: System.Action`1<System.String> (Public)
- **set_IslandAbandoned(System.Action`1<System.String> value)**: System.Void (Public)
- **get_RegisteredIsland()**: System.Action (Public)
- **set_RegisteredIsland(System.Action value)**: System.Void (Public)
- **get_UnregisteredIsland()**: System.Action (Public)
- **set_UnregisteredIsland(System.Action value)**: System.Void (Public)
- **RegisterIsland(World.IslandController islandController)**: System.Void (Public)
- **UnregisterIsland(World.IslandController islandController)**: System.Void (Public)
- **OwnerProcessIslandAuthorityRequest(System.String islandAuthorityId, System.String islandName, System.String ownIslandAuthorityId)**: System.Void (Public)
- **OwnerProcessIslandAuthorityRelease(System.String islandAuthorityId, System.String islandName, System.String ownIslandAuthorityId)**: System.Void (Public)
- **ClientProcessIslandAuthorityResponse(System.Collections.Generic.Dictionary`2<System.String,System.String> newlyReceivedAuthoredIslands, System.String ownIslandAuthorityId)**: System.Void (Public)
- **RequestAuthority(System.String islandAuthorityId, System.String islandName)**: System.Void (Public)
- **ReleaseAuthority(System.String islandAuthorityId, System.String islandName)**: System.Void (Public)
- **ClientHasAuthorityOverIsland(System.String islandAuthorityId, System.String islandName)**: System.Boolean (Public)
- **GetAllIslandsCenter()**: UnityEngine.Vector3 (Public)
- **GetClosestIsland(UnityEngine.Vector3 from)**: World.IslandController (Public)
- **GetAllIslandsRadius(System.Single addition)**: System.Single (Public)
- **SetFirstIslandLoaded(System.Boolean loaded)**: System.Void (Public)
- **FindStarterIslandController()**: System.ValueTuple`2<World.IslandController,System.Int32> (Public)
- **CheckPositionIsOnIsland(UnityEngine.Vector3 position)**: System.Boolean (Public)
- **CheckTransformIsOnIsland(UnityEngine.Transform transform)**: System.Boolean (Public)

