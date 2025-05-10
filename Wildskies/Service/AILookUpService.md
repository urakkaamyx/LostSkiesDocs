# WildSkies.Service.AILookUpService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| AddressableLocationKey | System.String | Private |
| _assets | System.Collections.Generic.Dictionary`2<System.UInt32,UnityEngine.GameObject> | Private |
| _configs | System.Collections.Generic.List`1<WildSkies.AI.AIConfig> | Private |
| _multiRegionReference | System.Collections.Generic.Dictionary`2<System.UInt32,System.Collections.Generic.Dictionary`2<WildSkies.AI.AIRegionVariant,System.UInt32>> | Private |
| _assetReferences | WildSkies.Service.Instantiation.AssetsLookupModel | Private |
| _stringBuilder | System.Text.StringBuilder | Private |
| _groupDefinitions | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.AI.AIGroupDefinition> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **.ctor(WildSkies.Service.Instantiation.AssetsLookupModel assetReferences)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **OnLoadAddressable(WildSkies.Gameplay.AI.AIGroupDefinition groupDefinition)**: System.Void (Private)
- **AddAssetLookup(WildSkies.AI.AIVariantDataContainer variantDataContainer, System.Int32 index)**: System.Void (Private)
- **TryGetAIGroupDefinitionByName(System.String name, WildSkies.Gameplay.AI.AIGroupDefinition& groupDefinition)**: System.Boolean (Public)
- **TryGetAIPrefab(WildSkies.AI.AIVariantDataContainer variantDataContainer, UnityEngine.GameObject& prefab)**: System.Boolean (Public)
- **TryGetAIIDByReadableName(System.String name, System.UInt32& id)**: System.Boolean (Public)
- **GetReadableNames()**: System.String[] (Public)
- **TryGetAIPrefab(System.UInt32 id, UnityEngine.GameObject& prefab)**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)

