# HrisShiftResultApprovalStatusValue

The approval status of the shift

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HrisShiftResultApprovalStatusValue.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisShiftResultApprovalStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Pending`       | pending         |
| `Approved`      | approved        |
| `Rejected`      | rejected        |
| `UnmappedValue` | unmapped_value  |