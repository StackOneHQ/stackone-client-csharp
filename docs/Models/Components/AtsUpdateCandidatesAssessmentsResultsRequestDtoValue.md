# AtsUpdateCandidatesAssessmentsResultsRequestDtoValue

The result of the test.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AtsUpdateCandidatesAssessmentsResultsRequestDtoValue.Initiated;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsUpdateCandidatesAssessmentsResultsRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Initiated`     | initiated       |
| `InProgress`    | in_progress     |
| `Cancelled`     | cancelled       |
| `Completed`     | completed       |
| `Expired`       | expired         |
| `Failed`        | failed          |
| `Passed`        | passed          |
| `UnmappedValue` | unmapped_value  |