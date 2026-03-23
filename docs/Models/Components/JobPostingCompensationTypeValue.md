# JobPostingCompensationTypeValue

The type of the compensation.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = JobPostingCompensationTypeValue.Salary;

// Open enum: use .Of() to create instances from custom string values
var custom = JobPostingCompensationTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Salary`        | salary          |
| `Hourly`        | hourly          |
| `Commission`    | commission      |
| `Bonus`         | bonus           |
| `Equity`        | equity          |
| `Other`         | other           |
| `UnmappedValue` | unmapped_value  |