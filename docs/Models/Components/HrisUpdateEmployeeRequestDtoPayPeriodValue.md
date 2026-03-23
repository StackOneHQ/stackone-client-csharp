# HrisUpdateEmployeeRequestDtoPayPeriodValue

The pay period of the job postings.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = HrisUpdateEmployeeRequestDtoPayPeriodValue.Hour;

// Open enum: use .Of() to create instances from custom string values
var custom = HrisUpdateEmployeeRequestDtoPayPeriodValue.Of("custom_value");
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Hour`           | hour             |
| `Day`            | day              |
| `Week`           | week             |
| `EveryTwoWeeks`  | every_two_weeks  |
| `Month`          | month            |
| `TwiceAMonth`    | twice_a_month    |
| `EveryTwoMonths` | every_two_months |
| `Quarter`        | quarter          |
| `EverySixMonths` | every_six_months |
| `Year`           | year             |
| `OneOff`         | one_off          |
| `None`           | none             |
| `UnmappedValue`  | unmapped_value   |