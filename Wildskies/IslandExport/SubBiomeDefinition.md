# WildSkies.IslandExport.SubBiomeDefinition

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Name | System.String | Public |
| SubBiomeType | WildSkies.IslandExport.SubBiomeType | Public |
| ParentBiome | WildSkies.IslandExport.Biome | Public |
| SubBiomeRegion | WildSkies.IslandExport.Region | Public |
| SubBiomeAssets | WildSkies.IslandExport.SubBiomeAsset[] | Public |
| UsingDynamicGrass | System.Boolean | Public |
| VspPalettes | WildSkies.IslandExport.VspPalettePairs[] | Public |
| DefaultTexture | System.String | Public |
| DefaultColorIndex | System.Int32 | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| BiomeFreeName | System.String | Public |

## Methods

- **Init(WildSkies.IslandExport.VspPalettePairs packagePair)**: System.Void (Public)
- **Load(WildSkies.IslandExport.SubBiomeDefinition loadedDefinition)**: System.Void (Public)
- **DeepCopy()**: WildSkies.IslandExport.SubBiomeDefinition (Public)
- **UpdateDensityMultiplier(WildSkies.IslandExport.SubBiomeAsset asset)**: System.Void (Public)
- **GetAssetIndexFromName(System.String assetGuid)**: System.Int32 (Public)
- **GetVspPackage(WildSkies.IslandExport.IslandPalette palette)**: System.Collections.Generic.List`1<WildSkies.IslandExport.VspPalettePairs> (Public)
- **get_BiomeFreeName()**: System.String (Public)

