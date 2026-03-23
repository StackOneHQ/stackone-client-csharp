# ListValue

The type of the list.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ListValue.Candidates;

// Open enum: use .Of() to create instances from custom string values
var custom = ListValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Candidates`    | candidates      |
| `Contacts`      | contacts        |
| `Companies`     | companies       |
| `UnmappedValue` | unmapped_value  |