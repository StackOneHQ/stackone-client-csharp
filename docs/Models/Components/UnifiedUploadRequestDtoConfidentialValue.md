# UnifiedUploadRequestDtoConfidentialValue

Whether the file is confidential or not

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = UnifiedUploadRequestDtoConfidentialValue.True;

// Open enum: use .Of() to create instances from custom string values
var custom = UnifiedUploadRequestDtoConfidentialValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `True`          | true            |
| `False`         | false           |
| `UnmappedValue` | unmapped_value  |