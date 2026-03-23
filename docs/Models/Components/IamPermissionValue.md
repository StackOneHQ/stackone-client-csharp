# IamPermissionValue

The type of the permission, e.g. read, read_write, delete, etc.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = IamPermissionValue.Read;

// Open enum: use .Of() to create instances from custom string values
var custom = IamPermissionValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Read`          | read            |
| `ReadWrite`     | read_write      |
| `Approve`       | approve         |
| `Delete`        | delete          |
| `Use`           | use             |
| `Export`        | export          |
| `UnmappedValue` | unmapped_value  |