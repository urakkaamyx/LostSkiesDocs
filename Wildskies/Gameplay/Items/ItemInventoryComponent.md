# WildSkies.Gameplay.Items.ItemInventoryComponent

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ClassItemType | WildSkies.Gameplay.Items.ItemTypes | Public |
| ShapeSprite | UnityEngine.Sprite | Public |
| _shapeArray | System.Boolean[,] | Private |
| _shapeRelativePositions | System.Collections.Generic.List`1<UnityEngine.Vector2Int> | Private |
| MaxStackSize | System.Int32 | Public |
| ShapeType | Player.Inventory.ShapeType | Public |
| AttachmentPositionsList | System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemInventoryComponent/AttachmentPosition> | Public |
| OnSpriteChanged | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ItemType | WildSkies.Gameplay.Items.ItemTypes | Public |
| IsStackable | System.Boolean | Public |
| ShapeRelativePositions | System.Collections.Generic.List`1<UnityEngine.Vector2Int> | Public |
| ShapeArray | System.Boolean[,] | Public |

## Methods

- **get_ItemType()**: WildSkies.Gameplay.Items.ItemTypes (Public)
- **get_IsStackable()**: System.Boolean (Public)
- **get_ShapeRelativePositions()**: System.Collections.Generic.List`1<UnityEngine.Vector2Int> (Public)
- **CalculateShapeRelativeRotatedPositions()**: System.Collections.Generic.List`1<UnityEngine.Vector2Int> (Public)
- **GetRotatedShape()**: Player.Inventory.ShapeType (Public)
- **GetRotateDirection()**: System.Int32 (Public)
- **CanBeRotated()**: System.Boolean (Public)
- **get_ShapeArray()**: System.Boolean[,] (Public)
- **OnSpriteChangedCallback()**: System.Void (Public)
- **Initialize()**: System.Void (Public)
- **UpdateShapeTemplate()**: System.Void (Public)
- **GetAttachment(UnityEngine.Vector2Int position)**: WildSkies.Gameplay.Items.ItemInventoryComponent/ItemAttachmentType (Public)
- **AddItemSlot(UnityEngine.Vector2Int gridPosition)**: System.Void (Public)
- **TrimPositions()**: System.Void (Private)
- **OffsetPositions(UnityEngine.Vector2Int offset)**: System.Void (Private)
- **RemoveItemSlot(UnityEngine.Vector2Int gridPosition)**: System.Void (Public)
- **ResetShape()**: System.Void (Public)
- **UpdateShapeRelativeList()**: System.Void (Public)
- **UpdateShapeRelativeList(System.Boolean[,] shapeList)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

