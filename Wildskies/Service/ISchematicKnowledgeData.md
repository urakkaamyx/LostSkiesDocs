# WildSkies.Service.ISchematicKnowledgeData

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| SchematicKnowledgeDictionary | System.Collections.Generic.Dictionary`2<System.String,System.Boolean> | Public |

## Methods

- **get_SchematicKnowledgeDictionary()**: System.Collections.Generic.Dictionary`2<System.String,System.Boolean> (Public)
- **LearnSchematic(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: System.Boolean (Public)
- **UpgradeSchematic(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic, System.Int32 numberOfLevels, System.Int32 extraAddedXp)**: System.Void (Public)
- **SetSchematicLevel(System.String schematic, System.Int32 newLevel, System.Int32 extraAddedXp)**: System.Void (Public)
- **ForgetSchematic(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: System.Boolean (Public)
- **ResetUpgradesForSchematic(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: System.Boolean (Public)
- **GetSchematicsLevel(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: System.Int32 (Public)
- **GetSchematicsLevelById(System.String schematicId)**: System.Int32 (Public)
- **GetAppliedXp(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: System.Int32 (Public)
- **GetAllSchematicsOfTypeAndLearnMethod(WildSkies.Gameplay.Crafting.CraftingMethod type, WildSkies.Gameplay.Crafting.LearnMethod method, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetPendingSchematicsForCraftingMethod(WildSkies.Gameplay.Crafting.CraftingMethod type, System.Collections.Generic.List`1<System.String>& schematics)**: System.Boolean (Public)
- **GetKnownSchematics()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> (Public)
- **GetKnownSchematicsOfCraftingMethod(WildSkies.Gameplay.Crafting.CraftingMethod type, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetKnownSchematicsOfType(WildSkies.Gameplay.Items.SchematicType type, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetKnownSchematicsOfTypeAndLearnMethod(WildSkies.Gameplay.Crafting.CraftingMethod type, WildSkies.Gameplay.Crafting.LearnMethod method, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetUnknownSchematicsOfType(WildSkies.Gameplay.Crafting.CraftingMethod type, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& schematics)**: System.Boolean (Public)
- **GetSchematicById(System.String schematicId)**: WildSkies.Gameplay.Crafting.CraftableItemBlueprint (Public)
- **IsSchematicKnown(System.String schematicId)**: System.Boolean (Public)
- **HasNewSchematics(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& newSchematics)**: System.Boolean (Public)
- **HasNewSchematicsOfType(WildSkies.Gameplay.Crafting.CraftingMethod craftingMethod, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>& newSchematics)**: System.Boolean (Public)
- **LearnCraftingMethodForSchematic(System.String schematicId)**: System.Void (Public)
- **LearnCraftingMethod(WildSkies.Gameplay.Crafting.CraftingMethod method)**: System.Void (Public)
- **IsCraftingMethodKnownForSchematic(WildSkies.Gameplay.Crafting.CraftingMethod method)**: System.Boolean (Public)
- **CacheSchematicThatNeedsCraftingMethod(WildSkies.Gameplay.Crafting.CraftingMethod craftingMethod, System.String schematicId)**: System.Void (Public)

