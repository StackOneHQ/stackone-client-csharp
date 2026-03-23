# LinkedAccountStatus

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = LinkedAccountStatus.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = LinkedAccountStatus.Of("custom_value");
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Active`    | active      |
| `Inactive`  | inactive    |
| `Suspended` | suspended   |
| `Archived`  | archived    |
| `Expired`   | expired     |
| `Error`     | error       |