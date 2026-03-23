# OverallRecommendation

The overall recommendation

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = OverallRecommendation.StrongYes;

// Open enum: use .Of() to create instances from custom string values
var custom = OverallRecommendation.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `StrongYes`     | strong_yes      |
| `Yes`           | yes             |
| `No`            | no              |
| `StrongNo`      | strong_no       |
| `NoDecision`    | no_decision     |
| `UnmappedValue` | unmapped_value  |