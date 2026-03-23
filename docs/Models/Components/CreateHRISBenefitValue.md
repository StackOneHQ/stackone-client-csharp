# CreateHRISBenefitValue

The type of the benefit

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CreateHRISBenefitValue.RetirementSavings;

// Open enum: use .Of() to create instances from custom string values
var custom = CreateHRISBenefitValue.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `RetirementSavings` | retirement_savings  |
| `HealthSavings`     | health_savings      |
| `Other`             | other               |
| `HealthInsurance`   | health_insurance    |
| `Insurance`         | insurance           |
| `UnmappedValue`     | unmapped_value      |