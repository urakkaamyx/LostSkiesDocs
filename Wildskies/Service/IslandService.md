# WildSkies.Service.IslandService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _islandControllers | System.Collections.Generic.List`1<World.IslandController> | Private |
| _authoredIslands | System.Collections.Generic.Dictionary`2<System.String,System.String> | Private |
| _firstIslandLoaded | System.Boolean | Private |
| SpawnDelayAfterFirstIslandLoad | System.Int32 | Private |
| <IslandAuthorityRequested>k__BackingField | System.Action`2<System.String,System.String> | Private |
| <IslandAuthorityReleased>k__BackingField | System.Action`2<System.String,System.String> | Private |
| <IslandAuthorityGranted>k__BackingField | System.Action`2<System.String,System.String> | Private |
| <IslandAbandoned>k__BackingField | System.Action`1<System.String> | Private |
| <RegisteredIsland>k__BackingField | System.Action | Private |
| <UnregisteredIsland>k__BackingField | System.Action | Private |
| StarterIslandNameContains | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
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

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
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
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RegisterIsland(World.IslandController islandController)**: System.Void (Public)
- **UnregisterIsland(World.IslandController islandController)**: System.Void (Public)
- **GetClosestIsland(UnityEngine.Vector3 from)**: World.IslandController (Public)
- **GetAllIslandsCenter()**: UnityEngine.Vector3 (Public)
- **GetAllIslandsRadius(System.Single addition)**: System.Single (Public)
- **OwnerProcessIslandAuthorityRequest(System.String islandAuthorityId, System.String islandName, System.String ownIslandAuthorityId)**: System.Void (Public)
- **OwnerProcessIslandAuthorityRelease(System.String islandAuthorityId, System.String islandName, System.String ownIslandAuthorityId)**: System.Void (Public)
- **ClientProcessIslandAuthorityResponse(System.Collections.Generic.Dictionary`2<System.String,System.String> newlyReceivedAuthoredIslands, System.String ownIslandAuthorityId)**: System.Void (Public)
- **RequestAuthority(System.String islandAuthorityId, System.String islandName)**: System.Void (Public)
- **ReleaseAuthority(System.String islandAuthorityId, System.String islandName)**: System.Void (Public)
- **ClientHasAuthorityOverIsland(System.String islandAuthorityId, System.String islandName)**: System.Boolean (Public)
- **SetFirstIslandLoaded(System.Boolean loaded)**: System.Void (Public)
- **CheckPositionIsOnIsland(UnityEngine.Vector3 position)**: System.Boolean (Public)
- **CheckTransformIsOnIsland(UnityEngine.Transform transform)**: System.Boolean (Public)
- **FindStarterIslandController()**: System.ValueTuple`2<World.IslandController,System.Int32> (Public)
- **.ctor()**: System.Void (Public)

