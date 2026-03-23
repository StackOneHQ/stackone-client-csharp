# ScheduledInterviewValue

The status of the interview.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ScheduledInterviewValue.Unscheduled;

// Open enum: use .Of() to create instances from custom string values
var custom = ScheduledInterviewValue.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Unscheduled`     | unscheduled       |
| `Scheduled`       | scheduled         |
| `Completed`       | completed         |
| `Cancelled`       | cancelled         |
| `PendingFeedback` | pending_feedback  |
| `UnmappedValue`   | unmapped_value    |