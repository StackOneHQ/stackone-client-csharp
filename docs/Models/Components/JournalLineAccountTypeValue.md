# JournalLineAccountTypeValue

Type of account

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = JournalLineAccountTypeValue.Asset;

// Open enum: use .Of() to create instances from custom string values
var custom = JournalLineAccountTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Asset`         | asset           |
| `Liability`     | liability       |
| `Equity`        | equity          |
| `Revenue`       | revenue         |
| `Expense`       | expense         |
| `UnmappedValue` | unmapped_value  |