# ContentBlockTypeValue

The type of the content blocks.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ContentBlockTypeValue.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = ContentBlockTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Text`          | text            |
| `Html`          | html            |
| `Image`         | image           |
| `CodeSnippet`   | code-snippet    |
| `UnmappedValue` | unmapped_value  |