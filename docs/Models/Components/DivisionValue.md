# DivisionValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = DivisionValue.Workspace;

// Open enum: use .Of() to create instances from custom string values
var custom = DivisionValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Workspace`     | workspace       |
| `Team`          | team            |
| `Department`    | department      |
| `Group`         | group           |
| `Organization`  | organization    |
| `UnmappedValue` | unmapped_value  |
| `CostCenter`    | cost_center     |