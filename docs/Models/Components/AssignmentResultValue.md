# AssignmentResultValue

The StackOne unified result status.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AssignmentResultValue.Pass;

// Open enum: use .Of() to create instances from custom string values
var custom = AssignmentResultValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Pass`          | Pass            |
| `Fail`          | Fail            |
| `UnmappedValue` | unmapped_value  |