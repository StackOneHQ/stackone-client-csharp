# FieldType

The type of the field

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = FieldType.ShortText;

// Open enum: use .Of() to create instances from custom string values
var custom = FieldType.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `ShortText`     | short_text      |
| `LongText`      | long_text       |
| `MultiSelect`   | multi_select    |
| `SingleSelect`  | single_select   |
| `Boolean`       | boolean         |
| `Number`        | number          |
| `Date`          | date            |
| `Phone`         | phone           |
| `Email`         | email           |
| `Score`         | score           |
| `Location`      | location        |
| `UnmappedValue` | unmapped_value  |