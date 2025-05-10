# WildSkies.BuffSystem.Food.Stomach

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _foodSlots | WildSkies.BuffSystem.Food.ActiveFoodBuff[] | Private |
| _currentBuffsAux | System.Collections.Generic.List`1<BuffEffect> | Private |
| _currentActiveBuffsAux | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> | Private |
| _buffsToRemove | System.Collections.Generic.List`1<WildSkies.BuffSystem.Food.ActiveFoodBuff> | Private |
| _currentBuffCount | System.Int32 | Private |
| _currentActiveTickBuffs | System.Collections.Generic.List`1<WildSkies.BuffSystem.TickBuffEffect> | Private |
| FoodConsumed | System.Action`2<WildSkies.Gameplay.Items.ItemDefinition,WildSkies.BuffSystem.Food.FoodConsumptionResult> | Public |
| OnBuffAdded | System.Action`1<WildSkies.BuffSystem.ActiveBuff> | Public |
| OnBuffRemoved | System.Action`1<WildSkies.BuffSystem.ActiveBuff> | Public |
| OnBuffsChanged | System.Action | Public |
| OnTickBuffRemoved | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| HasAnyBuffs | System.Boolean | Public |

## Methods

- **RemoveAllFoodBuffs()**: System.Void (Public)
- **get_HasAnyBuffs()**: System.Boolean (Public)
- **GetActiveBuffEffects()**: BuffEffect[] (Public)
- **GetActiveBuffs()**: System.Collections.Generic.IReadOnlyCollection`1<WildSkies.BuffSystem.ActiveBuff> (Public)
- **RemoveBuff(BuffDefinitionBase buff)**: System.Void (Public)
- **ConsumeFood(WildSkies.Gameplay.Items.ItemDefinition itemDefinition)**: WildSkies.BuffSystem.Food.FoodConsumptionResult (Public)
- **CreateNewBuff(WildSkies.BuffSystem.Food.FoodData food)**: System.Void (Private)
- **AddBuffAtIndex(WildSkies.BuffSystem.Food.FoodData foodData, System.Int32 index)**: System.Void (Private)
- **AddBuff(BuffDefinitionBase buff)**: WildSkies.BuffSystem.ActiveBuff (Public)
- **InitialiseTickBuff(WildSkies.BuffSystem.TickBuffEffect tickBuff)**: System.Void (Private)
- **OverwriteExistingBuff(WildSkies.BuffSystem.Food.FoodData food)**: System.Void (Private)
- **ReplaceBuff(WildSkies.BuffSystem.Food.FoodData foodData)**: System.Void (Private)
- **OnUpdate()**: System.Void (Public)
- **CountDownBuffs()**: System.Void (Private)
- **DiminishBuffValue(WildSkies.BuffSystem.Food.ActiveFoodBuff food)**: System.Void (Private)
- **IsFull()**: System.Boolean (Private)
- **IsInStomach(WildSkies.BuffSystem.Food.FoodData food, System.Boolean& isExpiring)**: System.Boolean (Private)
- **GetDecayThreshold(WildSkies.BuffSystem.Food.ActiveFoodBuff foodBuff)**: System.Single (Private)
- **IsDecaying(WildSkies.BuffSystem.Food.ActiveFoodBuff buff)**: System.Boolean (Public)
- **IsAnyFoodDecaying()**: System.Boolean (Public)
- **GetActiveFoodBuffs()**: WildSkies.BuffSystem.Food.ActiveFoodBuff[] (Public)
- **GetFoodEatenCount()**: System.Int32 (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

