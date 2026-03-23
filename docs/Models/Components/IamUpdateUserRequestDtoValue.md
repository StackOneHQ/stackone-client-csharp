# IamUpdateUserRequestDtoValue

The status of the user, e.g. whether the user is enabled, has been disabled (eg. by an admin), or is pending (ie: awaiting approval by the user or an admin).

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = IamUpdateUserRequestDtoValue.Enabled;

// Open enum: use .Of() to create instances from custom string values
var custom = IamUpdateUserRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Enabled`       | enabled         |
| `Disabled`      | disabled        |
| `Pending`       | pending         |
| `UnmappedValue` | unmapped_value  |