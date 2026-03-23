# ApplicationAttachmentValue

The content type of the attachment.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ApplicationAttachmentValue.Text;

// Open enum: use .Of() to create instances from custom string values
var custom = ApplicationAttachmentValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Text`          | text            |
| `Pdf`           | pdf             |
| `Video`         | video           |
| `Other`         | other           |
| `UnmappedValue` | unmapped_value  |