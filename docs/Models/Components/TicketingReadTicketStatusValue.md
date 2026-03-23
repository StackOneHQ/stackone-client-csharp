# TicketingReadTicketStatusValue

The type of this status

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TicketingReadTicketStatusValue.ToDo;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketingReadTicketStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `ToDo`          | to-do           |
| `InProgress`    | in-progress     |
| `Closed`        | closed          |
| `UnmappedValue` | unmapped_value  |