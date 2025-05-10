# WildSkies.Ship.Buffs.ShipPartBuffReceiver

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _buffData | ShipPartBuffData | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _buffService | WildSkies.Service.BuffService | Private |
| _buffs | System.Collections.Generic.Dictionary`2<ShipPartBuffs,WildSkies.Ship.Buffs.ShipPartBuff> | Private |
| _activeBuffs | ShipPartBuffs | Private |
| _updateIsRunning | System.Boolean | Private |
| _shipPart | WildSkies.Ship.ShipPart | Private |
| _updateCancellationToken | System.Threading.CancellationTokenSource | Private |

## Methods

- **Init(WildSkies.Ship.ShipPart shipPart)**: System.Void (Public)
- **SetCoherenceSync(Coherence.Toolkit.CoherenceSync coherenceSync)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **TryAddBuff(BuffDefinitionBase buffDefinitionBase, WildSkies.BuffSystem.ActiveBuff& activeBuff)**: System.Boolean (Public)
- **OverrideBuffCountdown(BuffDefinitionBase buff, System.Single deductionPerSecond)**: System.Void (Public)
- **AddBuff(ShipPartBuffs buff)**: System.Void (Public)
- **RemoveBuff(ShipPartBuffs buff)**: System.Void (Public)
- **EndUpdateTask()**: System.Void (Private)
- **UpdateTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnUpdateBuffs()**: System.Void (Public)
- **IsActiveBuff(ShipPartBuffs buff)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

