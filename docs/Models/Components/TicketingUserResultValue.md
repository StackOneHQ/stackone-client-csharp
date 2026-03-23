# TicketingUserResultValue

The type of the user.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = TicketingUserResultValue.Agent;

// Open enum: use .Of() to create instances from custom string values
var custom = TicketingUserResultValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Agent`         | agent           |
| `Contact`       | contact         |
| `Bot`           | bot             |
| `UnmappedValue` | unmapped_value  |