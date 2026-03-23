# ApplicationChangesValue

The type of change that occurred to the application

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ApplicationChangesValue.ApplicationStatus;

// Open enum: use .Of() to create instances from custom string values
var custom = ApplicationChangesValue.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `ApplicationStatus` | application_status  |
| `InterviewStage`    | interview_stage     |
| `RejectedReasons`   | rejected_reasons    |
| `UnmappedValue`     | unmapped_value      |