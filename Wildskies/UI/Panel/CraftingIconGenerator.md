# Wildskies.UI.Panel.CraftingIconGenerator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _lightingVolumes | UnityEngine.GameObject | Private |
| _iconRenderCamera | UnityEngine.Camera | Private |
| _layerToUseForIcons | UnityEngine.LayerMask | Private |
| _keyLight | UnityEngine.Light | Private |
| _iconRenderTexture | UnityEngine.RenderTexture | Private |
| _framingScale | System.Single | Private |
| _targetPositionOffset | UnityEngine.Vector3 | Private |
| _curRenderToCamera | UnityEngine.Coroutine | Private |
| _renderingLayerMasks | System.Collections.Generic.List`1<System.UInt32> | Private |
| _iconRenderers | System.Collections.Generic.List`1<UnityEngine.Renderer> | Private |

## Methods

- **FrameObjectWithCamera(UnityEngine.GameObject iconTargetObject, WildSkies.Gameplay.Items.ItemIconViewpoint iconViewpoint)**: System.Void (Public)
- **RenderToCamera(UnityEngine.GameObject iconTargetObject, WildSkies.Gameplay.Items.ItemIconViewpoint iconViewpoint)**: System.Collections.IEnumerator (Private)
- **GetObjectRotation(WildSkies.Gameplay.Items.ItemIconViewpoint iconViewpoint)**: UnityEngine.Quaternion (Private)
- **GetCameraRotation(WildSkies.Gameplay.Items.ItemIconViewpoint iconViewpoint)**: UnityEngine.Quaternion (Private)
- **.ctor()**: System.Void (Public)

