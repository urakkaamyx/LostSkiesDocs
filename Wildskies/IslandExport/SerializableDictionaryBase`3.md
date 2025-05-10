# WildSkies.IslandExport.SerializableDictionaryBase`3

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _keys | TKey[] | Private |
| _values | TValueStorage[] | Private |

## Methods

- **.ctor()**: System.Void (Public)
- **.ctor(System.Collections.Generic.IDictionary`2<TKey,TValue> dict)**: System.Void (Public)
- **.ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)**: System.Void (Protected)
- **SetValue(TValueStorage[] storage, System.Int32 i, TValue value)**: System.Void (Protected)
- **GetValue(TValueStorage[] storage, System.Int32 i)**: TValue (Protected)
- **CopyFrom(System.Collections.Generic.IDictionary`2<TKey,TValue> dict)**: System.Void (Public)
- **OnAfterDeserialize()**: System.Void (Public)
- **OnBeforeSerialize()**: System.Void (Public)

