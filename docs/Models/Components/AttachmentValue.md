# AttachmentValue

The content type of the attachment.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AttachmentValue.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = AttachmentValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Text`          | text            |
| `Pdf`           | pdf             |
| `Video`         | video           |
| `Other`         | other           |
| `UnmappedValue` | unmapped_value  |