# LmsCreateCompletionRequestDtoValue

The StackOne unified result status.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = LmsCreateCompletionRequestDtoValue.Pass;

// Open enum: use .Of() to create instances from custom string values
var custom = LmsCreateCompletionRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Pass`          | Pass            |
| `Fail`          | Fail            |
| `UnmappedValue` | unmapped_value  |