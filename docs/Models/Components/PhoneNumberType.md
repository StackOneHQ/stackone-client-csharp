# PhoneNumberType

Type of phone number

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = PhoneNumberType.Personal;

// Open enum: use .Of() to create instances from custom string values
var custom = PhoneNumberType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Personal`      | personal        |
| `Work`          | work            |
| `Mobile`        | mobile          |
| `Home`          | home            |
| `Unknown`       | unknown         |
| `Other`         | other           |
| `UnmappedValue` | unmapped_value  |