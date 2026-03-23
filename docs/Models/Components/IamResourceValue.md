# IamResourceValue

The type of the resource, e.g. user, group, permission, etc.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = IamResourceValue.Project;

// Open enum: use .Of() to create instances from custom string values
var custom = IamResourceValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Project`       | project         |
| `File`          | file            |
| `Folder`        | folder          |
| `Product`       | product         |
| `Property`      | property        |
| `User`          | user            |
| `UnmappedValue` | unmapped_value  |