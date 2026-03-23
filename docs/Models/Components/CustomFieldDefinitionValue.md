# CustomFieldDefinitionValue

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CustomFieldDefinitionValue.Date;

// Open enum: use .Of() to create instances from custom string values
var custom = CustomFieldDefinitionValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Date`          | date            |
| `Float`         | float           |
| `Integer`       | integer         |
| `List`          | list            |
| `Checkbox`      | checkbox        |
| `Text`          | text            |
| `Boolean`       | boolean         |
| `SingleSelect`  | single_select   |
| `MultiSelect`   | multi_select    |
| `Url`           | url             |
| `Other`         | other           |
| `UnmappedValue` | unmapped_value  |