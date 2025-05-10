# WildSkies.Service.LocalisationService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| OnLocaleSet | System.Action`1<WildSkies.Service.SupportedLocales> | Public |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _localeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.Service.SupportedLocales,WildSkies.Service.LocalisationService/LocaleData> | Private |
| _cachedInputActions | System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Localization.LocalizedString> | Private |
| _datapadDictionary | System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Localization.LocalizedString> | Private |
| _datapadTable | UnityEngine.Localization.Tables.StringTable | Private |
| _localisedFontSelector | WildSkies.Service.LocalisedFontSelector | Private |
| HudTableRef | System.String | Private |
| LocalisedFontTableRef | System.String | Private |
| InputKeyPrefix | System.String | Private |
| OutfitRegularKey | System.String | Private |
| OutfitRegularNoShadowKey | System.String | Private |
| OutfitMediumKey | System.String | Private |
| OutfitMediumNoShadowKey | System.String | Private |
| OutfitBoldKey | System.String | Private |
| OutfitBoldNoShadowKey | System.String | Private |
| _codeInitialisedStringDictionary | System.Collections.Generic.Dictionary`2<LocalisedStringID,UnityEngine.Localization.LocalizedString> | Private |
| _resourceTypeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.Items.ResourceType,UnityEngine.Localization.LocalizedString> | Private |
| _buffTypeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.BuffSystem.BuffType,UnityEngine.Localization.LocalizedString> | Private |
| _ancestryNameDictionary | System.Collections.Generic.Dictionary`2<AncestryType,UnityEngine.Localization.LocalizedString> | Private |
| _shipPartNameDictionary | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.HullObjectType,UnityEngine.Localization.LocalizedString> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **LoadLocalisation()**: System.Threading.Tasks.Task (Private)
- **LoadLocalisedFontAssets()**: System.Threading.Tasks.Task (Private)
- **GetLocalizedAssetFromTable(UnityEngine.Localization.Tables.AssetTable table, System.String fontKey)**: UnityEngine.Localization.LocalizedAsset`1<TMPro.TMP_FontAsset> (Private)
- **PopulateLocaleDictionary()**: System.Void (Private)
- **PopulateDatapadDictionary()**: System.Threading.Tasks.Task (Private)
- **InitialiseTextAssets()**: System.Void (Public)
- **SetLocale(WildSkies.Service.SupportedLocales supportedLocales)**: System.Void (Public)
- **GetCurrentLocale()**: WildSkies.Service.SupportedLocales (Public)
- **GetCurrentLocaleName()**: System.String (Public)
- **GetSupportedLocales()**: System.Collections.Generic.List`1<UnityEngine.Localization.Locale> (Public)
- **GetLocalisedString(LocalisedStringID stringId)**: System.String (Public)
- **GetLocalisedStringWithArguments(LocalisedStringID stringId, System.Object[] arguments)**: System.String (Public)
- **TryGetDatapadEntry(System.String value, UnityEngine.Localization.LocalizedString& localizedStringObject)**: System.Boolean (Public)
- **GetLocalisedResourceType(WildSkies.Gameplay.Items.ResourceType resourceType)**: UnityEngine.Localization.LocalizedString (Public)
- **GetLocalisedBuffType(WildSkies.BuffSystem.BuffType buffType)**: UnityEngine.Localization.LocalizedString (Public)
- **GetLocalisedAncestryString(AncestryType ancestryType)**: System.String (Public)
- **GetLocalisedShipPartTypeString(WildSkies.Gameplay.ShipBuilding.HullObjectType shipPartType)**: System.String (Public)
- **GetLocalizedStringObjectFromId(LocalisedStringID stringId)**: UnityEngine.Localization.LocalizedString (Public)
- **GetLocalisedInputAction(System.String actionName)**: System.String (Public)
- **GetLocaleDictionary()**: System.Collections.Generic.Dictionary`2<WildSkies.Service.SupportedLocales,WildSkies.Service.LocalisationService/LocaleData> (Public)
- **GetSanitisedKey(System.String value)**: System.String (Private)
- **ClearSavedLocale()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

