# JobPostingStatusValue

The status of the job postings.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = JobPostingStatusValue.Live;

// Open enum: use .Of() to create instances from custom string values
var custom = JobPostingStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Live`          | live            |
| `Draft`         | draft           |
| `Pending`       | pending         |
| `Internal`      | internal        |
| `Rejected`      | rejected        |
| `Closed`        | closed          |
| `Archived`      | archived        |
| `UnmappedValue` | unmapped_value  |