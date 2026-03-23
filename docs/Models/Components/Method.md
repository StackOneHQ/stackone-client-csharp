# Method

The method of the request

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = Method.Get;

// Open enum: use .Of() to create instances from custom string values
var custom = Method.Of("custom_value");
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Get`    | get      |
| `Post`   | post     |
| `Put`    | put      |
| `Delete` | delete   |
| `Patch`  | patch    |