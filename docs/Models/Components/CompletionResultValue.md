# CompletionResultValue

The StackOne unified result status.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CompletionResultValue.Pass;

// Open enum: use .Of() to create instances from custom string values
var custom = CompletionResultValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Pass`          | Pass            |
| `Fail`          | Fail            |
| `UnmappedValue` | unmapped_value  |