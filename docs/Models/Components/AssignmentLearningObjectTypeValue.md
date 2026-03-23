# AssignmentLearningObjectTypeValue

The StackOne unified learning object type.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AssignmentLearningObjectTypeValue.Content;

// Open enum: use .Of() to create instances from custom string values
var custom = AssignmentLearningObjectTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Content`       | content         |
| `Course`        | course          |
| `Collection`    | collection      |
| `UnmappedValue` | unmapped_value  |