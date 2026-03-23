# RejectedReasonValue

The type of the rejected reason.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = RejectedReasonValue.RejectedByCandidate;

// Open enum: use .Of() to create instances from custom string values
var custom = RejectedReasonValue.Of("custom_value");
```


## Values

| Name                     | Value                    |
| ------------------------ | ------------------------ |
| `RejectedByCandidate`    | rejected_by_candidate    |
| `RejectedByOrganization` | rejected_by_organization |
| `Other`                  | other                    |
| `Unknown`                | unknown                  |
| `UnmappedValue`          | unmapped_value           |