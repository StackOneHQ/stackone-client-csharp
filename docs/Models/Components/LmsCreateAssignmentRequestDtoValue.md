# LmsCreateAssignmentRequestDtoValue

The StackOne unified assignment status.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = LmsCreateAssignmentRequestDtoValue.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = LmsCreateAssignmentRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Pending`       | pending         |
| `InProgress`    | in_progress     |
| `Completed`     | completed       |
| `UnmappedValue` | unmapped_value  |