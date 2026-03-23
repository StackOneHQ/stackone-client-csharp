# AtsCreateJobRequestDtoValue

The status of the job.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AtsCreateJobRequestDtoValue.Published;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsCreateJobRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Published`     | published       |
| `Draft`         | draft           |
| `Pending`       | pending         |
| `Internal`      | internal        |
| `Archived`      | archived        |
| `Closed`        | closed          |
| `Open`          | open            |
| `Deleted`       | deleted         |
| `OnHold`        | on_hold         |
| `UnmappedValue` | unmapped_value  |