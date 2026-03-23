# TicketingTicketUpdateRequestDtoStatusValue

The type of this status

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TicketingTicketUpdateRequestDtoStatusValue.ToDo;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketingTicketUpdateRequestDtoStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `ToDo`          | to-do           |
| `InProgress`    | in-progress     |
| `Closed`        | closed          |
| `UnmappedValue` | unmapped_value  |