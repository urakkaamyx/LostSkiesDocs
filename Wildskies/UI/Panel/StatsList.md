# Wildskies.UI.Panel.StatsList

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _listEntryPoolSansBar | ObjectPool | Private |
| _listEntryPoolWithBar | ObjectPool | Private |
| _listContainer | UnityEngine.RectTransform | Private |
| _sectionName | TMPro.TextMeshProUGUI | Private |
| _statsString | UnityEngine.Localization.LocalizedString | Private |
| _createdItemStatsString | UnityEngine.Localization.LocalizedString | Private |
| _weightString | UnityEngine.Localization.LocalizedString | Private |
| _armourString | UnityEngine.Localization.LocalizedString | Private |
| _hardnessString | UnityEngine.Localization.LocalizedString | Private |
| _durabilityString | UnityEngine.Localization.LocalizedString | Private |
| _windResistanceString | UnityEngine.Localization.LocalizedString | Private |
| _stressResistanceString | UnityEngine.Localization.LocalizedString | Private |
| _heatResistanceString | UnityEngine.Localization.LocalizedString | Private |
| _electricalConductivityString | UnityEngine.Localization.LocalizedString | Private |
| _resilienceString | UnityEngine.Localization.LocalizedString | Private |
| _powerString | UnityEngine.Localization.LocalizedString | Private |
| _accelerationString | UnityEngine.Localization.LocalizedString | Private |
| _fuelEfficiencyString | UnityEngine.Localization.LocalizedString | Private |
| _rateOfFireString | UnityEngine.Localization.LocalizedString | Private |
| _magazineSizeString | UnityEngine.Localization.LocalizedString | Private |
| _reloadSpeedString | UnityEngine.Localization.LocalizedString | Private |
| _pitchSpeedString | UnityEngine.Localization.LocalizedString | Private |
| _turnSpeedString | UnityEngine.Localization.LocalizedString | Private |
| _pivotSpeedString | UnityEngine.Localization.LocalizedString | Private |
| _airResistanceString | UnityEngine.Localization.LocalizedString | Private |
| _handlingString | UnityEngine.Localization.LocalizedString | Private |
| _windPerformanceString | UnityEngine.Localization.LocalizedString | Private |
| _rudderStrengthString | UnityEngine.Localization.LocalizedString | Private |
| _wingResponseString | UnityEngine.Localization.LocalizedString | Private |
| _wingStrengthString | UnityEngine.Localization.LocalizedString | Private |
| _coreWeightString | UnityEngine.Localization.LocalizedString | Private |
| _coreEnergyString | UnityEngine.Localization.LocalizedString | Private |
| _coreEnergyCostString | UnityEngine.Localization.LocalizedString | Private |
| _aerodynamicsString | UnityEngine.Localization.LocalizedString | Private |
| _liftString | UnityEngine.Localization.LocalizedString | Private |
| _sailPowerString | UnityEngine.Localization.LocalizedString | Private |
| _pitchMotionRangeString | UnityEngine.Localization.LocalizedString | Private |
| _yawMotionRangeString | UnityEngine.Localization.LocalizedString | Private |
| _mobilityString | UnityEngine.Localization.LocalizedString | Private |
| _kgString | UnityEngine.Localization.LocalizedString | Private |
| _currentListEntriesWithBar | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _currentListEntriesSansBar | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _tempListEntriesWithBar | System.Collections.Generic.List`1<ItemStat> | Private |
| _tempListEntriesSansBar | System.Collections.Generic.List`1<ItemStat> | Private |

## Methods

- **Awake()**: System.Void (Private)
- **InitialiseItemStats(ItemStats itemStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> additionalMaterialStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> levelUpMaterialStats, System.Boolean isOutputItemForSchematic)**: System.Void (Public)
- **InitialiseWeaponStats(System.Collections.Generic.List`1<System.ValueTuple`4<UnityEngine.Localization.LocalizedString,System.String,System.Single,System.Single>> weaponStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> levelUpStats, System.Boolean isOutputItemForSchematic)**: System.Void (Public)
- **Show()**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **Refresh(ItemStats newStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> additionalMaterialStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> levelUpStats)**: System.Void (Private)
- **Refresh(System.Collections.Generic.List`1<System.ValueTuple`4<UnityEngine.Localization.LocalizedString,System.String,System.Single,System.Single>> weaponStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> additionalMaterialStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> levelUpStats)**: System.Void (Private)
- **CreateListFromVariables(T itemStats, ItemStats itemStatsBase, System.Collections.Generic.Dictionary`2<System.String,System.Single> additionalMaterialStats, System.Collections.Generic.Dictionary`2<System.String,System.Single> levelUpMaterialStats)**: System.Void (Private)
- **CreateListEntry(ItemStat stat, System.Boolean useBar)**: System.Void (Private)
- **ClearList()**: System.Void (Private)
- **GetStatNameFromField(System.String fieldName)**: UnityEngine.Localization.LocalizedString (Private)
- **GetStatSuffixFromField(System.String fieldName)**: UnityEngine.Localization.LocalizedString (Private)
- **.ctor()**: System.Void (Public)

