# WildSkies.IslandExport.IslandSurface

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| IslandReferenceMaterial | UnityEngine.Material | Public |
| IslandTextureData | WildSkies.IslandExport.IslandTextureData | Public |
| VSBiomeControl | WildSkies.IslandExport.TerrainLayerVSBiomeControl | Public |
| IslandPaletteControl | WildSkies.IslandExport.IslandPaletteControl | Public |
| IslandBiomeAndCulture | WildSkies.IslandExport.IslandBiomeAndCulture | Public |
| IslandShader | UnityEngine.Shader | Public |
| IslandMaterial | UnityEngine.Material | Public |
| _useGlobalTextureArrays | System.Boolean | Protected |
| _islandMaterialData | WildSkies.IslandExport.SerializableIslandMaterial | Private |
| QualityChangeQueue | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.IslandSurface,System.Int32> | Public |
| _processedThisFrame | System.Int32 | Private |
| _isDirty | System.Boolean | Private |
| _useTextures | System.Boolean | Private |
| _useTriPlanarTextures | System.Boolean | Private |
| _individualTextureScaling | System.Boolean | Private |
| _useLayerBlending | System.Boolean | Private |
| _debugSampleCount | System.Boolean | Private |
| <IsCurrentIsland>k__BackingField | System.Boolean | Private |
| AOIntensityID | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsCurrentIsland | System.Boolean | Public |
| UseTextures | System.Boolean | Public |
| UseTriPlanarTextures | System.Boolean | Public |
| IndividualTextureScaling | System.Boolean | Public |
| UseLayerBlending | System.Boolean | Public |
| DebugSampleCount | System.Boolean | Public |
| IslandMaterialData | WildSkies.IslandExport.SerializableIslandMaterial | Public |
| UseGlobalTextureArrays | System.Boolean | Public |

## Methods

- **get_IsCurrentIsland()**: System.Boolean (Public)
- **set_IsCurrentIsland(System.Boolean value)**: System.Void (Public)
- **get_UseTextures()**: System.Boolean (Public)
- **set_UseTextures(System.Boolean value)**: System.Void (Public)
- **get_UseTriPlanarTextures()**: System.Boolean (Public)
- **set_UseTriPlanarTextures(System.Boolean value)**: System.Void (Public)
- **get_IndividualTextureScaling()**: System.Boolean (Public)
- **set_IndividualTextureScaling(System.Boolean value)**: System.Void (Public)
- **get_UseLayerBlending()**: System.Boolean (Public)
- **set_UseLayerBlending(System.Boolean value)**: System.Void (Public)
- **get_DebugSampleCount()**: System.Boolean (Public)
- **set_DebugSampleCount(System.Boolean value)**: System.Void (Public)
- **get_IslandMaterialData()**: WildSkies.IslandExport.SerializableIslandMaterial (Public)
- **get_UseGlobalTextureArrays()**: System.Boolean (Public)
- **set_UseGlobalTextureArrays(System.Boolean value)**: System.Void (Public)
- **InitializeIslandSurfaceFromPath(System.String islandPath, UnityEngine.Material islandMaterial)**: System.Void (Public)
- **ReInitSurface(System.Int32 version)**: System.Void (Public)
- **SetMaterialData(WildSkies.IslandExport.SerializableIslandMaterial islandMaterialData)**: System.Void (Public)
- **SetTerrainQuality(System.Int32 terrainQuality)**: System.Void (Public)
- **SetIslandMaterialLodSettings(System.Boolean useTextures, System.Boolean useTriPlanar, System.Boolean useIndividualScaling, System.Boolean doLayerBlending)**: System.Void (Public)
- **InitMaterial()**: System.Void (Public)
- **ApplyIslandPalette(WildSkies.IslandExport.IslandPalette palette)**: System.Void (Public)
- **ValidateSurfaceType(WildSkies.IslandExport.SerializableIslandMaterial materialData)**: System.Void (Public)
- **GetTextureMeta(System.String tex)**: WildSkies.IslandExport.TextureMetaData (Public)
- **GetIslandRockColor(WildSkies.IslandExport.IslandPalette palette)**: UnityEngine.Color (Public)
- **ApplyToMaterial(System.Boolean textureLayersDirty)**: System.Void (Public)
- **SaveMaterial()**: System.Void (Public)
- **RevertMaterial(System.Boolean withTextures)**: System.Void (Public)
- **UpdateGrassGlobalBuffer(System.Boolean textureLayersDirty)**: System.Void (Public)
- **DeAllocateCpuHeightmaps()**: System.Void (Public)
- **OnEnable()**: System.Void (Protected)
- **Update()**: System.Void (Protected)
- **Init(System.Boolean isCurrentIsland)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

