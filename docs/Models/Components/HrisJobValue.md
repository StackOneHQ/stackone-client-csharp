# HrisJobValue

The status of the job.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HrisJobValue.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisJobValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Pending`       | pending         |
| `Archived`      | archived        |
| `Closed`        | closed          |
| `Open`          | open            |
| `Deleted`       | deleted         |
| `UnmappedValue` | unmapped_value  |