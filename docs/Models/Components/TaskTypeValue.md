# TaskTypeValue

The unified value for the type of the task. If the provider does not specify this type, the value will be set to UnmappedValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TaskTypeValue.Action;

// Open enum: use .Of() to create instances from custom string values
var custom = TaskTypeValue.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Action`         | action           |
| `Review`         | review           |
| `Acknowledgment` | acknowledgment   |
| `Edit`           | edit             |
| `Approve`        | approve          |
| `UnmappedValue`  | unmapped_value   |