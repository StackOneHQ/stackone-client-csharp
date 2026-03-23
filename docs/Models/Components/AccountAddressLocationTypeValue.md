# AccountAddressLocationTypeValue

The type of the location.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AccountAddressLocationTypeValue.Home;

// Open enum: use .Of() to create instances from custom string values
var custom = AccountAddressLocationTypeValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Home`          | home            |
| `Work`          | work            |
| `UnmappedValue` | unmapped_value  |