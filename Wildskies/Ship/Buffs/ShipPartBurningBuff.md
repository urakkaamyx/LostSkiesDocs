# WildSkies.Ship.Buffs.ShipPartBurningBuff

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _burningTimer | System.Single | Private |
| _burningDuration | System.Single | Private |
| _buffData | ShipPartBuffData | Private |
| _shipPart | WildSkies.Ship.ShipPart | Private |
| _forceRemove | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| BuffType | ShipPartBuffs | Public |
| ReadyToRemove | System.Boolean | Public |

## Methods

- **get_BuffType()**: ShipPartBuffs (Public)
- **get_ReadyToRemove()**: System.Boolean (Public)
- **Init(ShipPartBuffData buffData, WildSkies.Ship.ShipPart shipPart)**: System.Void (Public)
- **OnAdd()**: System.Void (Public)
- **OnRemove()**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)
- **OnBuffsChanged(ShipPartBuffs activeBuffs)**: System.Void (Public)
- **CalculateDamage(System.Single percentage, System.Single maxHealth)**: System.Single (Private)
- **.ctor()**: System.Void (Public)

