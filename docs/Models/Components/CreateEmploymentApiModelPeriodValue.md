# CreateEmploymentApiModelPeriodValue

The unified value for the period.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CreateEmploymentApiModelPeriodValue.Day;

// Open enum: use .Of() to create instances from custom string values
var custom = CreateEmploymentApiModelPeriodValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Day`           | day             |
| `Week`          | week            |
| `Month`         | month           |
| `Year`          | year            |
| `UnmappedValue` | unmapped_value  |