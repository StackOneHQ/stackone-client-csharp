# TicketingReadTicketPriorityValue

The priority of the ticket.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TicketingReadTicketPriorityValue.Lowest;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketingReadTicketPriorityValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Lowest`        | lowest          |
| `Low`           | low             |
| `Medium`        | medium          |
| `High`          | high            |
| `Highest`       | highest         |
| `UnmappedValue` | unmapped_value  |