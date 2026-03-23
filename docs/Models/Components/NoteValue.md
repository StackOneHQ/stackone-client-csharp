# NoteValue

The visibility of the notes.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = NoteValue.Private;

// Open enum: use .Of() to create instances from custom string values
var custom = NoteValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Private`       | private         |
| `Public`        | public          |
| `UnmappedValue` | unmapped_value  |