# HRISBankDetailsAccountTypeValue

The type of bank account

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HRISBankDetailsAccountTypeValue.Savings;

// Open enum: use .Of() to create instances from custom string values
var custom = HRISBankDetailsAccountTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Savings`       | savings         |
| `Checking`      | checking        |
| `Current`       | current         |
| `Business`      | business        |
| `Personal`      | personal        |
| `Other`         | other           |
| `UnmappedValue` | unmapped_value  |