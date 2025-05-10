# WildSkies.Gameplay.Building.ComponentData

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ComponentID | System.String | Public |
| ResourceIDs | System.Collections.Generic.List`1<System.String> | Public |
| IsMainComponent | System.Boolean | Public |

## Methods

- **.ctor()**: System.Void (Public)
- **.ctor(System.String componentID, System.Collections.Generic.List`1<System.String> resourceIDs, System.Boolean isMainComponent)**: System.Void (Public)
- **Clone()**: WildSkies.Gameplay.Building.ComponentData (Public)
- **Matches(WildSkies.Gameplay.Building.ComponentData cmpComponentData)**: System.Boolean (Public)
- **Serialize(System.IO.BinaryWriter writer)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader)**: WildSkies.Gameplay.Building.ComponentData (Public)

