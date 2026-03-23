# JobPostingEmploymentContractTypeValue

The employment contract type.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = JobPostingEmploymentContractTypeValue.FullTime;

// Open enum: use .Of() to create instances from custom string values
var custom = JobPostingEmploymentContractTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `FullTime`      | full_time       |
| `Shifts`        | shifts          |
| `PartTime`      | part_time       |
| `UnmappedValue` | unmapped_value  |