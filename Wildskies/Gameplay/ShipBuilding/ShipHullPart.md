# WildSkies.Gameplay.ShipBuilding.ShipHullPart

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _meshRenderer | UnityEngine.MeshRenderer | Public |
| _defaultMaterial | UnityEngine.Material | Protected |
| _hoverMaterial | UnityEngine.Material | Protected |
| _selectedMaterial | UnityEngine.Material | Protected |
| _mirroredMaterial | UnityEngine.Material | Protected |
| _solidMaterial | UnityEngine.Material | Protected |
| _hologramMaterial | UnityEngine.Material | Protected |
| _craftableRendererController | CraftableRendererController | Protected |
| _mirroring | System.Boolean | Private |
| _hovering | System.Boolean | Private |
| _selected | System.Boolean | Private |
| _isCrafted | System.Boolean | Private |
| _isDocked | System.Boolean | Private |
| _isBeingEdited | System.Boolean | Private |
| _selectionState | WildSkies.Gameplay.ShipBuilding.ShipHullPart/SelectionState | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsSelected | System.Boolean | Public |
| IsCrafted | System.Boolean | Public |
| IsDocked | System.Boolean | Private |
| IsBeingEdited | System.Boolean | Private |

## Methods

- **get_IsSelected()**: System.Boolean (Public)
- **get_IsCrafted()**: System.Boolean (Public)
- **set_IsCrafted(System.Boolean value)**: System.Void (Private)
- **get_IsDocked()**: System.Boolean (Protected)
- **set_IsDocked(System.Boolean value)**: System.Void (Private)
- **get_IsBeingEdited()**: System.Boolean (Protected)
- **set_IsBeingEdited(System.Boolean value)**: System.Void (Private)
- **Hover()**: System.Void (Public)
- **Mirrored()**: System.Void (Public)
- **Select()**: System.Void (Public)
- **DoUpdate()**: System.Void (Public)
- **ResetValues()**: System.Void (Public)
- **GetVerts()**: WildSkies.Gameplay.ShipBuilding.HullVertex[] (Public)
- **GetVertPositions()**: System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> (Public)
- **ApplyVertPositions(System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ShipVertexPositionData> positions)**: System.Void (Public)
- **GetPartPlacementCategory()**: WildSkies.ShipParts.ShipPartPlacementCategories (Public)
- **MirroredStateUpdate()**: System.Void (Protected)
- **DefaultStateUpdate()**: System.Void (Protected)
- **HoverStateUpdate()**: System.Void (Protected)
- **SelectedStateUpdate()**: System.Void (Protected)
- **SwitchToDefaultState()**: System.Void (Public)
- **SwitchToMirroredState()**: System.Void (Protected)
- **SwitchToHoverState()**: System.Void (Protected)
- **SwitchToSelectedState()**: System.Void (Protected)
- **EnterDefaultState()**: System.Void (Protected)
- **EnterMirroredState()**: System.Void (Protected)
- **EnterHoverState()**: System.Void (Protected)
- **EnterSelectedState()**: System.Void (Protected)
- **SetSolidStates(System.Boolean isDocked)**: System.Void (Public)
- **SetSolidStates(System.Boolean isCrafted, System.Boolean isDocked, System.Boolean isBeingEdited)**: System.Void (Public)
- **SetColliderSolidState()**: System.Void (Protected)
- **SetMaterialSolidState()**: System.Void (Protected)
- **SetShipPartShadowState(System.Boolean shadowsOn)**: System.Void (Protected)
- **DestroyObject()**: System.Void (Public)
- **.ctor()**: System.Void (Protected)

