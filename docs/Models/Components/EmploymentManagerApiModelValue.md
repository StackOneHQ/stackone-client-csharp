# EmploymentManagerApiModelValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = EmploymentManagerApiModelValue.Admin;

// Open enum: use .Of() to create instances from custom string values
var custom = EmploymentManagerApiModelValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Admin`         | admin           |
| `Viewer`        | viewer          |
| `Editor`        | editor          |
| `Basic`         | basic           |
| `Guest`         | guest           |
| `Unassigned`    | unassigned      |
| `Restricted`    | restricted      |
| `UnmappedValue` | unmapped_value  |