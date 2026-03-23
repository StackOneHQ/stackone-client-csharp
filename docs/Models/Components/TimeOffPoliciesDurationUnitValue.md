# TimeOffPoliciesDurationUnitValue

The unified value for the duration unit. If the provider does not specify this unit, the value will be set to unknown

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TimeOffPoliciesDurationUnitValue.Minutes;

// Open enum: use .Of() to create instances from custom string values
var custom = TimeOffPoliciesDurationUnitValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Minutes`       | minutes         |
| `Hours`         | hours           |
| `Days`          | days            |
| `Weeks`         | weeks           |
| `Months`        | months          |
| `Years`         | years           |
| `Unknown`       | unknown         |
| `UnmappedValue` | unmapped_value  |