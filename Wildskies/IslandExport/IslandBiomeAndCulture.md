# WildSkies.IslandExport.IslandBiomeAndCulture

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| AllCultures | System.Collections.Generic.HashSet`1<System.String> | Public |
| AllBiomes | System.Collections.Generic.HashSet`1<System.String> | Public |
| AllRegions | System.Collections.Generic.HashSet`1<System.String> | Public |
| AllPalettes | System.Collections.Generic.HashSet`1<System.String> | Public |
| currentBiome | WildSkies.IslandExport.Biome | Public |
| currentCulture | WildSkies.IslandExport.Culture | Public |
| currentRegion | WildSkies.IslandExport.Region | Public |
| currentIslandPalette | WildSkies.IslandExport.IslandPalette | Public |
| OnCultureChanged | System.Action | Public |
| OnBiomeChanged | System.Action | Public |
| OnRegionChange | System.Action | Public |
| OnRegionOrBiomeChange | System.Action | Public |
| OnIslandPaletteChange | System.Action`1<WildSkies.IslandExport.IslandPalette> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| RegionData | WildSkies.IslandExport.RegionData | Public |

## Methods

- **Awake()**: System.Void (Private)
- **get_RegionData()**: WildSkies.IslandExport.RegionData (Public)
- **SetRegion(WildSkies.IslandExport.Region region)**: System.Void (Public)
- **SetCultureRegionAndBiome(WildSkies.IslandExport.Culture culture, WildSkies.IslandExport.Biome biome, WildSkies.IslandExport.Region region, WildSkies.IslandExport.IslandPalette islandPalette)**: System.Void (Public)
- **SetIslandPalette(System.Int32 islandDifficulty)**: System.Void (Public)
- **SetIslandPalette(WildSkies.IslandExport.IslandPalette islandPalette)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

