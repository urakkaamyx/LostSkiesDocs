# WildSkies.Service.CharacterCustomisationService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _eyeMaterials | System.Collections.Generic.List`1<UnityEngine.Material> | Private |
| _hairShavedMaps | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Private |
| _facialHairShavedMaps | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Private |
| _facePaintTextures | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| EyeMaterials | System.Collections.Generic.List`1<UnityEngine.Material> | Public |
| HairShavedMaps | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Public |
| FacialHairShavedMaps | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Public |
| FacePaintTextures | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_EyeMaterials()**: System.Collections.Generic.List`1<UnityEngine.Material> (Public)
- **get_HairShavedMaps()**: System.Collections.Generic.List`1<UnityEngine.Texture2D> (Public)
- **get_FacialHairShavedMaps()**: System.Collections.Generic.List`1<UnityEngine.Texture2D> (Public)
- **get_FacePaintTextures()**: System.Collections.Generic.List`1<UnityEngine.Texture2D> (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **GetEyeMaterialIndex(System.String eyeMaterialId)**: System.Int32 (Public)
- **GetHairShavedMapIndex(System.String hairShavedMapId)**: System.Int32 (Public)
- **GetFacialHairShavedMapIndex(System.String facialHairShavedMapId)**: System.Int32 (Public)
- **GetFacePaintTextureIndex(System.String facePaintTextureId)**: System.Int32 (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadEyeMaterials()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadHairShavedMaps()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadFacialHairShavedMaps()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadFacePaintTextures()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnEyeMaterialDataLoaded(UnityEngine.Material eyeMaterial)**: System.Void (Private)
- **OnHairShavedMapDataLoaded(UnityEngine.Texture2D hairShavedMap)**: System.Void (Private)
- **OnFacialHairShavedMapDataLoaded(UnityEngine.Texture2D facialHairShavedMap)**: System.Void (Private)
- **OnFacePaintTextureDataLoaded(UnityEngine.Texture2D facePaintTexture)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

