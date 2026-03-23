# HRISDivisionValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HRISDivisionValue.Department;

// Open enum: use .Of() to create instances from custom string values
var custom = HRISDivisionValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Department`    | department      |
| `Company`       | company         |
| `Division`      | division        |
| `Group`         | group           |
| `Project`       | project         |
| `CostCenter`    | cost_center     |
| `Team`          | team            |
| `UnmappedValue` | unmapped_value  |