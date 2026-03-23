# WorkEligibilityTypeValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = WorkEligibilityTypeValue.Visa;

// Open enum: use .Of() to create instances from custom string values
var custom = WorkEligibilityTypeValue.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `Visa`             | visa               |
| `Passport`         | passport           |
| `DriverLicense`    | driver_license     |
| `BirthCertificate` | birth_certificate  |
| `Other`            | other              |
| `UnmappedValue`    | unmapped_value     |