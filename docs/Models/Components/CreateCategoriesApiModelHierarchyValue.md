# CreateCategoriesApiModelHierarchyValue

The unified category level. For write operations: provide one of the listed enum values, or omit/set to "unmapped_value" to use source_value instead.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CreateCategoriesApiModelHierarchyValue.Primary;

// Open enum: use .Of() to create instances from custom string values
var custom = CreateCategoriesApiModelHierarchyValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Primary`       | primary         |
| `Secondary`     | secondary       |
| `Tertiary`      | tertiary        |
| `UnmappedValue` | unmapped_value  |