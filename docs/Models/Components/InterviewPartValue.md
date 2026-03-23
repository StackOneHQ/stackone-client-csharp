# InterviewPartValue

The type of the interview.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = InterviewPartValue.Screening;

// Open enum: use .Of() to create instances from custom string values
var custom = InterviewPartValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Screening`     | screening       |
| `Lunch`         | lunch           |
| `OnSite`        | on_site         |
| `Presentation`  | presentation    |
| `Sell`          | sell            |
| `Culture`       | culture         |
| `Informal`      | informal        |
| `Test`          | test            |
| `Phone`         | phone           |
| `Video`         | video           |
| `UnmappedValue` | unmapped_value  |