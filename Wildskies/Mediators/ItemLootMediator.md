# WildSkies.Mediators.ItemLootMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _lootDropService | WildSkies.Service.LootDropService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |

## Methods

- **Initialise(WildSkies.Service.IItemService itemService, WildSkies.Service.LootDropService lootDropService, WildSkies.Service.WildSkiesInstantiationService instantiationService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **InstantiationRequested(WildSkies.Gameplay.Items.ItemDefinition itemDefinition, WildSkies.Service.LootDropService/SpawnItemStruct spawnItemStruct)**: System.Void (Private)
- **ItemCreated(UnityEngine.GameObject obj)**: System.Void (Private)
- **ItemRequested(WildSkies.Service.LootDropService/SpawnItemStruct spawnItemStruct)**: System.Void (Private)
- **GetRandomCustomColorScheme(WildSkies.Gameplay.Items.CustomColorScheme[] customColorSchemes)**: WildSkies.Gameplay.Items.ColorDataInfo (Private)
- **NewColorDataInfo(WildSkies.Gameplay.Items.CustomColorScheme customColorScheme)**: WildSkies.Gameplay.Items.ColorDataInfo (Private)
- **GetShaderProperty(System.String[] shaderProperty, System.Int32 idx)**: System.String (Private)
- **.ctor()**: System.Void (Public)

