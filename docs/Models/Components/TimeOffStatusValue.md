# TimeOffStatusValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TimeOffStatusValue.Approved;

// Open enum: use .Of() to create instances from custom string values
var custom = TimeOffStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Approved`      | approved        |
| `Cancelled`     | cancelled       |
| `Rejected`      | rejected        |
| `Pending`       | pending         |
| `Deleted`       | deleted         |
| `Draft`         | draft           |
| `UnmappedValue` | unmapped_value  |