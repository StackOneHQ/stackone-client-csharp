# ContentValue

The StackOne unified content type.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ContentValue.Video;

// Open enum: use .Of() to create instances from custom string values
var custom = ContentValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Video`         | video           |
| `Quiz`          | quiz            |
| `Document`      | document        |
| `Audio`         | audio           |
| `Article`       | article         |
| `UnmappedValue` | unmapped_value  |