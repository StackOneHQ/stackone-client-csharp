# LmsUpsertContentRequestDtoValue

The content type for write operations. Provide one of the listed enum values. If omitted or set to "unmapped_value", the source_value will be sent to the provider instead.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = LmsUpsertContentRequestDtoValue.Video;

// Open enum: use .Of() to create instances from custom string values
var custom = LmsUpsertContentRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Video`         | video           |
| `Quiz`          | quiz            |
| `Document`      | document        |
| `Audio`         | audio           |
| `Article`       | article         |
| `Book`          | book            |
| `Event`         | event           |
| `Course`        | course          |
| `Collection`    | collection      |
| `Interactive`   | interactive     |
| `UnmappedValue` | unmapped_value  |