# EmploymentPeriodValue

The unified value for the period.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = EmploymentPeriodValue.Day;

// Open enum: use .Of() to create instances from custom string values
var custom = EmploymentPeriodValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Day`           | day             |
| `Week`          | week            |
| `Month`         | month           |
| `Year`          | year            |
| `UnmappedValue` | unmapped_value  |