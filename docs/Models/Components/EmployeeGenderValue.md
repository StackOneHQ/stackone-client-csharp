# EmployeeGenderValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = EmployeeGenderValue.Male;

// Open enum: use .Of() to create instances from custom string values
var custom = EmployeeGenderValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Male`          | male            |
| `Female`        | female          |
| `NonBinary`     | non_binary      |
| `Other`         | other           |
| `NotDisclosed`  | not_disclosed   |
| `Diverse`       | diverse         |
| `UnmappedValue` | unmapped_value  |