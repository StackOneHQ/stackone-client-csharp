# UpdateTaskRequestDtoValue

The unified value for the status of the task. If the provider does not specify this status, the value will be set to UnmappedValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = UpdateTaskRequestDtoValue.Open;

// Open enum: use .Of() to create instances from custom string values
var custom = UpdateTaskRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Open`          | open            |
| `InProgress`    | in_progress     |
| `Blocked`       | blocked         |
| `Completed`     | completed       |
| `Cancelled`     | cancelled       |
| `UnmappedValue` | unmapped_value  |