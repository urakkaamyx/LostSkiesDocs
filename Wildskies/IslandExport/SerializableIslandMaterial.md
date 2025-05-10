# WildSkies.IslandExport.SerializableIslandMaterial

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| IslandLayerCount | System.Int32 | Public |
| aoIntensity | System.Single | Public |
| baseLayer | WildSkies.IslandExport.IslandMaterialLayer | Public |
| topR | WildSkies.IslandExport.IslandMaterialLayer | Public |
| topG | WildSkies.IslandExport.IslandMaterialLayer | Public |
| topB | WildSkies.IslandExport.IslandMaterialLayer | Public |
| sideR | WildSkies.IslandExport.IslandMaterialLayer | Public |
| sideG | WildSkies.IslandExport.IslandMaterialLayer | Public |
| bottomR | WildSkies.IslandExport.IslandMaterialLayer | Public |
| bottomG | WildSkies.IslandExport.IslandMaterialLayer | Public |
| grass0 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass1 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass2 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass3 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass4 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass5 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass6 | WildSkies.IslandExport.IslandGrassLayer | Public |
| grass7 | WildSkies.IslandExport.IslandGrassLayer | Public |
| subBiomeDefinitions | WildSkies.IslandExport.SubBiomeDefinition[] | Public |
| MaterialLayers | WildSkies.IslandExport.IslandMaterialLayer[] | Public |
| GrassLayers | WildSkies.IslandExport.IslandGrassLayer[] | Public |
| GlobalTextureIndices | System.Int32[] | Public |
| IslandMaterial | UnityEngine.Material | Public |
| HasSetup | System.Boolean | Public |
| _islandSurface | WildSkies.IslandExport.IslandSurface | Private |
| _islandSubBiomeNames | System.String[] | Private |
| _islandSubBiomeIds | System.Int32[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| GetIslandSubBiomeNames | System.String[] | Public |
| GetIslandSubBiomeIds | System.Int32[] | Public |
| GetIslandSubBiomeTypes | WildSkies.IslandExport.SubBiomeType[] | Public |

## Methods

- **.ctor(System.String surfaceString, WildSkies.IslandExport.IslandSurface islandSurface)**: System.Void (Public)
- **.ctor(WildSkies.IslandExport.SerializableIslandMaterial islandMaterial)**: System.Void (Public)
- **SerializeMaterial()**: System.String (Public)
- **HasTexturesLoaded()**: System.Boolean (Public)
- **get_GetIslandSubBiomeNames()**: System.String[] (Public)
- **get_GetIslandSubBiomeIds()**: System.Int32[] (Public)
- **get_GetIslandSubBiomeTypes()**: WildSkies.IslandExport.SubBiomeType[] (Public)
- **GetSubBiomeDefinitionFromLayer(System.Int32 id)**: WildSkies.IslandExport.SubBiomeDefinition (Public)
- **GetSubBiomeDefinitionFromName(System.String subBiomeName)**: WildSkies.IslandExport.SubBiomeDefinition (Public)
- **UpdateSubBiomeDefinition(WildSkies.IslandExport.SubBiomeDefinition newDefinition)**: System.Boolean (Public)
- **GetColors(System.Single saturationScale, System.Single valueScale)**: UnityEngine.Color[] (Public)
- **SaveMaterial()**: System.Void (Public)
- **RevertMaterial(System.Boolean withTextures)**: System.Void (Public)
- **GetLayerSurfaceType(System.Int32 layerId)**: WildSkies.IslandExport.SurfaceType (Public)
- **SetLayers()**: System.Void (Private)
- **GetLayers()**: System.Void (Private)
- **ValidateLayers()**: System.Void (Private)
- **LoadTextures()**: System.Void (Public)
- **LoadTexture(WildSkies.IslandExport.IslandMaterialLayer layer, System.String texture)**: System.Void (Public)
- **ClearTextures()**: System.Void (Public)

