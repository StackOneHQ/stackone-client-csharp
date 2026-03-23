# PositionValue

The status of the position.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = PositionValue.Open;

// Open enum: use .Of() to create instances from custom string values
var custom = PositionValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Open`          | open            |
| `Draft`         | draft           |
| `Closed`        | closed          |
| `Paused`        | paused          |
| `UnmappedValue` | unmapped_value  |