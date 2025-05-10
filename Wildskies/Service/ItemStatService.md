# WildSkies.Service.ItemStatService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| <UseTestAssets>k__BackingField | System.Boolean | Private |
| _allItemStatDefinition | System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemStatDefinition> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| UseTestAssets | System.Boolean | Public |
| AddressableLocationKey | System.String | Private |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_UseTestAssets()**: System.Boolean (Public)
- **set_UseTestAssets(System.Boolean value)**: System.Void (Public)
- **get_AddressableLocationKey()**: System.String (Protected)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **FetchAllItemStats()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemStatDefinition> (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **LoadItemStats()**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **OnLoadAddressable(WildSkies.Gameplay.Items.ItemStatDefinition itemStatDefinition)**: System.Void (Private)
- **TryFetchItemStatById(System.String id, WildSkies.Gameplay.Items.ItemStatDefinition& itemStatDefinition)**: System.Boolean (Public)
- **TryFetchItemStatByName(System.String name, WildSkies.Gameplay.Items.ItemStatDefinition& itemStatDefinition)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

