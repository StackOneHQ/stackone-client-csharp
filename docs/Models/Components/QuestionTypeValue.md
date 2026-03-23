# QuestionTypeValue

The type of the questions.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = QuestionTypeValue.ShortText;

// Open enum: use .Of() to create instances from custom string values
var custom = QuestionTypeValue.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `ShortText`      | short_text       |
| `LongText`       | long_text        |
| `Attachment`     | attachment       |
| `MultiSelect`    | multi_select     |
| `SingleSelect`   | single_select    |
| `Boolean`        | boolean          |
| `Number`         | number           |
| `Date`           | date             |
| `Video`          | video            |
| `ReferenceCheck` | reference_check  |
| `Url`            | url              |
| `UnmappedValue`  | unmapped_value   |