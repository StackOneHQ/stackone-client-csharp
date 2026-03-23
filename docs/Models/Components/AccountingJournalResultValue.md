# AccountingJournalResultValue

The journal status

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AccountingJournalResultValue.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountingJournalResultValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Posted`        | posted          |
| `Void`          | void            |
| `UnmappedValue` | unmapped_value  |