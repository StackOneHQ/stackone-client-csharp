# EmployeeEmploymentStatusValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = EmployeeEmploymentStatusValue.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = EmployeeEmploymentStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Active`        | active          |
| `Pending`       | pending         |
| `Terminated`    | terminated      |
| `Leave`         | leave           |
| `Inactive`      | inactive        |
| `Unknown`       | unknown         |
| `UnmappedValue` | unmapped_value  |