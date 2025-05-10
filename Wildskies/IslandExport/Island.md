# WildSkies.IslandExport.Island

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _materials | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedMaterialRef> | Private |
| _objects | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedObjectRef> | Private |
| _instanceMetaData | WildSkies.IslandExport.IslandInstanceMetaData | Private |
| _navMeshes | WildSkies.IslandExport.IntNavMeshDictionary | Private |
| _navAreaLUT | WildSkies.IslandExport.SubBiomeTypeIntDictionary | Private |
| _navAreaReverseLUT | WildSkies.IslandExport.IntSubBiomeTypeDictionary | Private |
| _BVHs | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedBVHRef> | Private |
| _subBiomes | System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData> | Private |
| _spawnPoints | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedIslandSpawnPoint> | Private |
| _bounds | UnityEngine.Bounds | Private |
| _vegetationStorage | AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationStoragePackage | Private |
| _numLodLevels | System.Int32 | Private |
| _objectsParentName | System.String | Private |
| _terrainLODGroup | UnityEngine.LODGroup | Private |
| _runtimeIslandSurface | WildSkies.IslandExport.RuntimeIslandSurface | Private |
| _biomeAndCulture | WildSkies.IslandExport.IslandBiomeAndCulture | Private |
| _usingPartialStreaming | System.Boolean | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _cameraInBounds | System.Boolean | Private |
| _vegetationStudioManager | AwesomeTechnologies.VegetationStudio.VegetationStudioManager | Private |
| _terrainLayerVSBiomeControl | WildSkies.IslandExport.TerrainLayerVSBiomeControl | Private |
| <LodBiasChanged>k__BackingField | System.Boolean | Private |
| _meshTerrainBVH | WildSkies.IslandExport.ContainerBVH`1<AwesomeTechnologies.MeshTerrains.MeshTerrain> | Private |
| <IslandActivated>k__BackingField | System.Boolean | Private |
| <DamageTypeOverrides>k__BackingField | WildSkies.Weapon.DamageTypeOverrides | Private |
| <ActivePartial>k__BackingField | UnityEngine.GameObject | Private |
| <ActiveObjectsSubSystem>k__BackingField | UnityEngine.Transform | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| UsingPartialStreaming | System.Boolean | Public |
| LodBiasChanged | System.Boolean | Public |
| Materials | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedMaterialRef> | Public |
| Objects | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedObjectRef> | Public |
| SpawnPoints | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedIslandSpawnPoint> | Public |
| BiomeAndCulture | WildSkies.IslandExport.IslandBiomeAndCulture | Public |
| InstanceMetaData | WildSkies.IslandExport.IslandInstanceMetaData | Public |
| NavMeshes | WildSkies.IslandExport.IntNavMeshDictionary | Public |
| NavAreaLUT | WildSkies.IslandExport.SubBiomeTypeIntDictionary | Public |
| NavAreaReverseLUT | WildSkies.IslandExport.IntSubBiomeTypeDictionary | Public |
| BVHs | System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedBVHRef> | Public |
| SubBiomes | System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData> | Public |
| Bounds | UnityEngine.Bounds | Public |
| NumLodLevels | System.Int32 | Public |
| VegetationStorage | AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationStoragePackage | Public |
| ObjectsParentName | System.String | Public |
| TerrainLODGroup | UnityEngine.LODGroup | Public |
| IslandSurface | WildSkies.IslandExport.RuntimeIslandSurface | Public |
| IslandActivated | System.Boolean | Public |
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |
| ActivePartial | UnityEngine.GameObject | Public |
| ActiveObjectsSubSystem | UnityEngine.Transform | Public |

## Methods

- **get_UsingPartialStreaming()**: System.Boolean (Public)
- **get_LodBiasChanged()**: System.Boolean (Public)
- **set_LodBiasChanged(System.Boolean value)**: System.Void (Public)
- **get_Materials()**: System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedMaterialRef> (Public)
- **set_Materials(System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedMaterialRef> value)**: System.Void (Public)
- **get_Objects()**: System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedObjectRef> (Public)
- **set_Objects(System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedObjectRef> value)**: System.Void (Public)
- **get_SpawnPoints()**: System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedIslandSpawnPoint> (Public)
- **set_SpawnPoints(System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedIslandSpawnPoint> value)**: System.Void (Public)
- **get_BiomeAndCulture()**: WildSkies.IslandExport.IslandBiomeAndCulture (Public)
- **set_BiomeAndCulture(WildSkies.IslandExport.IslandBiomeAndCulture value)**: System.Void (Public)
- **get_InstanceMetaData()**: WildSkies.IslandExport.IslandInstanceMetaData (Public)
- **set_InstanceMetaData(WildSkies.IslandExport.IslandInstanceMetaData value)**: System.Void (Public)
- **get_NavMeshes()**: WildSkies.IslandExport.IntNavMeshDictionary (Public)
- **set_NavMeshes(WildSkies.IslandExport.IntNavMeshDictionary value)**: System.Void (Public)
- **get_NavAreaLUT()**: WildSkies.IslandExport.SubBiomeTypeIntDictionary (Public)
- **set_NavAreaLUT(WildSkies.IslandExport.SubBiomeTypeIntDictionary value)**: System.Void (Public)
- **get_NavAreaReverseLUT()**: WildSkies.IslandExport.IntSubBiomeTypeDictionary (Public)
- **set_NavAreaReverseLUT(WildSkies.IslandExport.IntSubBiomeTypeDictionary value)**: System.Void (Public)
- **get_BVHs()**: System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedBVHRef> (Public)
- **set_BVHs(System.Collections.Generic.List`1<WildSkies.IslandExport.ExportedBVHRef> value)**: System.Void (Public)
- **get_SubBiomes()**: System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData> (Public)
- **set_SubBiomes(System.Collections.Generic.List`1<WildSkies.IslandExport.SubBiomeSurfaceData> value)**: System.Void (Public)
- **get_Bounds()**: UnityEngine.Bounds (Public)
- **set_Bounds(UnityEngine.Bounds value)**: System.Void (Public)
- **get_NumLodLevels()**: System.Int32 (Public)
- **set_NumLodLevels(System.Int32 value)**: System.Void (Public)
- **get_VegetationStorage()**: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationStoragePackage (Public)
- **set_VegetationStorage(AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationStoragePackage value)**: System.Void (Public)
- **get_ObjectsParentName()**: System.String (Public)
- **set_ObjectsParentName(System.String value)**: System.Void (Public)
- **get_TerrainLODGroup()**: UnityEngine.LODGroup (Public)
- **set_TerrainLODGroup(UnityEngine.LODGroup value)**: System.Void (Public)
- **get_IslandSurface()**: WildSkies.IslandExport.RuntimeIslandSurface (Public)
- **set_IslandSurface(WildSkies.IslandExport.RuntimeIslandSurface value)**: System.Void (Public)
- **get_IslandActivated()**: System.Boolean (Public)
- **set_IslandActivated(System.Boolean value)**: System.Void (Public)
- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **get_ActivePartial()**: UnityEngine.GameObject (Public)
- **set_ActivePartial(UnityEngine.GameObject value)**: System.Void (Public)
- **get_ActiveObjectsSubSystem()**: UnityEngine.Transform (Public)
- **set_ActiveObjectsSubSystem(UnityEngine.Transform value)**: System.Void (Public)
- **DebugCopyIslandPartialData(WildSkies.IslandExport.StreamedIslandData islandPartial)**: System.Void (Public)
- **SubBiomeScatteringTest()**: System.Void (Public)
- **GenerateSubBiomeDebugMeshes()**: System.Void (Public)
- **GetNearestSubBiomeFromGameCamera()**: System.Void (Public)
- **FireTestRaysFromGameCamera()**: System.Void (Public)
- **GetNearestSubBiome(UnityEngine.Vector3 worldPos, System.String agentTypeName, System.Single searchRadius)**: WildSkies.IslandExport.SubBiomeType (Public)
- **GetNearestSubBiome(UnityEngine.Vector3 worldPos, System.Int32 agentTypeID, System.Single searchRadius)**: WildSkies.IslandExport.SubBiomeType (Public)
- **TerrainRaycast(UnityEngine.Ray ray, AwesomeTechnologies.Utility.BVHTree.HitInfo& terrainHitInfo)**: System.Boolean (Public)
- **TerrainRaycast(UnityEngine.Ray ray, AwesomeTechnologies.Utility.BVHTree.HitInfo& terrainHitInfo, WildSkies.IslandExport.SurfaceType& hitSurfaceType)**: System.Boolean (Public)
- **TerrainRaycast(UnityEngine.Ray ray, System.Boolean calculateHitSurfaceType, AwesomeTechnologies.Utility.BVHTree.HitInfo& terrainHitInfo, WildSkies.IslandExport.SurfaceType& hitSurfaceType, AwesomeTechnologies.MeshTerrains.MeshTerrain& hitMeshTerrain)**: System.Boolean (Public)
- **ActivateVegetationAndBVH()**: System.Void (Public)
- **DeactivateIslandVegetation()**: System.Void (Public)
- **GetNavMeshAreaExclusionMask(WildSkies.IslandExport.SubBiomeType[] excludedSubBiomes)**: System.Int32 (Public)
- **GetNavMeshAreaMask(WildSkies.IslandExport.SubBiomeType[] subBiomes)**: System.Int32 (Public)
- **GetSubBiomeSurfaceData(WildSkies.IslandExport.SubBiomeType searchType)**: WildSkies.IslandExport.SubBiomeSurfaceData (Public)
- **GetSubBiomeSurfaceData(WildSkies.IslandExport.SubBiomeType searchType, System.String agentTypeName)**: WildSkies.IslandExport.SubBiomeSurfaceData (Public)
- **GetSubBiomeSurfaceData(WildSkies.IslandExport.SubBiomeType searchType, System.Int32 agentTypeID)**: WildSkies.IslandExport.SubBiomeSurfaceData (Public)
- **Update()**: System.Void (Private)
- **SetTerrainLodState(System.Boolean lod0Forced)**: System.Void (Private)
- **OnDrawGizmosSelected()**: System.Void (Private)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **.ctor()**: System.Void (Public)

