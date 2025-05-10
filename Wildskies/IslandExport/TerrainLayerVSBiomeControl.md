# WildSkies.IslandExport.TerrainLayerVSBiomeControl

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _biomeAndCulture | WildSkies.IslandExport.IslandBiomeAndCulture | Private |
| _subBiomeDefinitions | WildSkies.IslandExport.SubBiomeDefinition[] | Protected |
| _dynamicVegetationShaders | UnityEngine.Shader[] | Private |
| _island | WildSkies.IslandExport.Island | Private |
| _eventsRegistered | System.Boolean | Private |
| _showSubBiomeDefinitions | System.Boolean | Protected |
| FilteredSubBiomes | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.SubBiomeDefinition,System.Collections.Generic.List`1<WildSkies.IslandExport.VspPalettePairs>> | Public |
| _packageDirty | System.Boolean | Private |
| _grassBufferData | WildSkies.IslandExport.IslandGrassBuffer[] | Private |
| _serializableIslandMaterial | WildSkies.IslandExport.SerializableIslandMaterial | Private |
| <GrassBuffer>k__BackingField | UnityEngine.ComputeBuffer | Private |
| _subBiomeIdChanged | System.Collections.Generic.List`1<System.String> | Private |
| _vegiMaterialMap | System.Collections.Generic.Dictionary`2<UnityEngine.Shader,System.Collections.Generic.List`1<UnityEngine.Material>> | Private |
| GrassLayerBufferId | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IslandSurface | WildSkies.IslandExport.Island | Public |
| BiomeAndCulture | WildSkies.IslandExport.IslandBiomeAndCulture | Public |
| VegetationSystem | AwesomeTechnologies.VegetationSystem.VegetationSystemPro | Public |
| GrassBuffer | UnityEngine.ComputeBuffer | Private |

## Methods

- **set_IslandSurface(WildSkies.IslandExport.Island value)**: System.Void (Public)
- **get_BiomeAndCulture()**: WildSkies.IslandExport.IslandBiomeAndCulture (Public)
- **set_BiomeAndCulture(WildSkies.IslandExport.IslandBiomeAndCulture value)**: System.Void (Public)
- **get_VegetationSystem()**: AwesomeTechnologies.VegetationSystem.VegetationSystemPro (Public)
- **get_GrassBuffer()**: UnityEngine.ComputeBuffer (Private)
- **set_GrassBuffer(UnityEngine.ComputeBuffer value)**: System.Void (Private)
- **Init()**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **TearDown()**: System.Void (Private)
- **LoadSubBiomeSaveData(WildSkies.IslandExport.SubBiomeDefinition[] savedBiomeDefinitions)**: WildSkies.IslandExport.SubBiomeDefinition[] (Public)
- **Setup(System.String[] subBiomes, WildSkies.IslandExport.IslandGrassBuffer[] bufferData, WildSkies.IslandExport.SerializableIslandMaterial islandMaterialData, WildSkies.IslandExport.IslandTextureData textureArrays, System.Boolean textureLayersDirty)**: System.Void (Public)
- **UpdateCachedVegiMaterials(WildSkies.IslandExport.IslandTextureData textureArrays)**: System.Void (Public)
- **SetGrassGlobalBuffer()**: System.Void (Public)
- **UpdateVspCache(System.String assetGuid)**: System.Void (Public)
- **SyncSubBiomePackages()**: System.Void (Public)
- **GetDefaultSubBiomeIndex(System.String subBiomeName)**: System.Int32 (Public)
- **InitializeSubBiomes(System.Boolean force)**: System.Boolean (Protected)
- **FilterSubBiomePackages()**: System.Void (Private)
- **IslandPaletteChanged(WildSkies.IslandExport.IslandPalette palette)**: System.Void (Private)
- **RegionOrBiomeChanged()**: System.Void (Private)
- **UpdateSubBiomes(System.String[] islandMaterialSubBiomes)**: System.Void (Private)
- **CacheVegiMaterials()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

