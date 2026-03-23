# HRISDepartmentValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HRISDepartmentValue.Department;

// Open enum: use .Of() to create instances from custom string values
var custom = HRISDepartmentValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Department`    | department      |
| `Company`       | company         |
| `Division`      | division        |
| `Group`         | group           |
| `Project`       | project         |
| `Team`          | team            |
| `UnmappedValue` | unmapped_value  |