# ScheduleTypeValue

The schedule type of the campaign.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ScheduleTypeValue.Immediate;

// Open enum: use .Of() to create instances from custom string values
var custom = ScheduleTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Immediate`     | immediate       |
| `Scheduled`     | scheduled       |
| `Recurring`     | recurring       |
| `Custom`        | custom          |
| `Triggered`     | triggered       |
| `UnmappedValue` | unmapped_value  |