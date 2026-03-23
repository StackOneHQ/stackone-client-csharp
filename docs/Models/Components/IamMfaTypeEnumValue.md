# IamMfaTypeEnumValue

The unified value for the type of multi-factor authentication. If the provider does not send back a type but does specify that MFA is set-up for this user, the value will be set to 'unknown'.'

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = IamMfaTypeEnumValue.Sms;

// Open enum: use .Of() to create instances from custom string values
var custom = IamMfaTypeEnumValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Sms`           | sms             |
| `Email`         | email           |
| `Push`          | push            |
| `Totp`          | totp            |
| `PhoneCall`     | phone_call      |
| `Question`      | question        |
| `SoftwareToken` | software_token  |
| `HardwareToken` | hardware_token  |
| `Web`           | web             |
| `Unknown`       | unknown         |
| `UnmappedValue` | unmapped_value  |