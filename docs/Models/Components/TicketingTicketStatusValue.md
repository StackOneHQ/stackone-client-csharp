# TicketingTicketStatusValue

The type of this status

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TicketingTicketStatusValue.ToDo;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketingTicketStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `ToDo`          | to-do           |
| `InProgress`    | in-progress     |
| `Closed`        | closed          |
| `UnmappedValue` | unmapped_value  |