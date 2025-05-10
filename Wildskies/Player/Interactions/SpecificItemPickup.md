# WildSkies.Player.Interactions.SpecificItemPickup

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _itemService | WildSkies.Service.IItemService | Protected |
| _uiservice | UISystem.IUIService | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _revealOnEntityDeathUid | System.String | Private |
| _idForItem | System.String | Private |
| _idForSchematicCheck | System.String | Private |
| _idForCompendiumCheck | System.String | Private |
| _amount | System.Int32 | Private |
| _visuals | UnityEngine.GameObject | Private |
| _notificationArgumentsAux | System.Object[] | Private |
| _itemDefinition | WildSkies.Gameplay.Items.ItemDefinition | Private |
| _interactablePickUpAudioType | WildSkies.Audio.AudioType | Private |
| _lootVfx | WildSkies.PoolableVfx | Private |
| _targetEntityDeathReveal | WildSkies.Entities.Health.EntityHealth | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| InteractionId | System.String | Public |
| Rarity | WildSkies.Gameplay.Items.InventoryRarityType | Public |

## Methods

- **get_InteractionId()**: System.String (Public)
- **get_Rarity()**: WildSkies.Gameplay.Items.InventoryRarityType (Public)
- **Start()**: System.Void (Private)
- **CompendiumUnlocked()**: System.Void (Private)
- **SchematicLearnt(System.String id, System.Boolean learnt)**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **CheckIfShouldBeVisible()**: System.Void (Private)
- **Interact(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Public)
- **Dispose()**: System.Void (Private)
- **CanInteract()**: System.Boolean (Public)
- **BindToTargetEntityDeath()**: System.Boolean (Private)
- **OnEntityDamaged()**: System.Void (Private)
- **SetLootVfx(WildSkies.PoolableVfx vfx)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<CheckIfShouldBeVisible>b__25_0()**: System.Boolean (Private)

