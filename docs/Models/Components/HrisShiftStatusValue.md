# HrisShiftStatusValue

The status of the shift

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HrisShiftStatusValue.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisShiftStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Published`     | published       |
| `Confirmed`     | confirmed       |
| `Cancelled`     | cancelled       |
| `UnmappedValue` | unmapped_value  |