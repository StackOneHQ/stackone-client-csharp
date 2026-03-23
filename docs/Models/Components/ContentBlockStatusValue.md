# ContentBlockStatusValue

The Status of the content blocks.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ContentBlockStatusValue.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = ContentBlockStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Live`          | live            |
| `Archived`      | archived        |
| `UnmappedValue` | unmapped_value  |