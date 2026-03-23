# JobPostingContentSectionValue

The type of the description.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = JobPostingContentSectionValue.Responsibilities;

// Open enum: use .Of() to create instances from custom string values
var custom = JobPostingContentSectionValue.Of("custom_value");
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `Responsibilities` | responsibilities   |
| `Skills`           | skills             |
| `Benefits`         | benefits           |
| `CompanyOverview`  | company_overview   |
| `Description`      | description        |
| `Other`            | other              |
| `UnmappedValue`    | unmapped_value     |