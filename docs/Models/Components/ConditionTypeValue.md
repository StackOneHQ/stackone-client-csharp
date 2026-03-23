# ConditionTypeValue

The type of the question's condition

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ConditionTypeValue.EqualsTo;

// Open enum: use .Of() to create instances from custom string values
var custom = ConditionTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `EqualsTo`      | equals_to       |
| `Contains`      | contains        |
| `UnmappedValue` | unmapped_value  |