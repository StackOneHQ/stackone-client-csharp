# CreateEmploymentApiModelPayFrequencyValue

The pay frequency of the job postings.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CreateEmploymentApiModelPayFrequencyValue.Hourly;

// Open enum: use .Of() to create instances from custom string values
var custom = CreateEmploymentApiModelPayFrequencyValue.Of("custom_value");
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Hourly`          | hourly            |
| `Weekly`          | weekly            |
| `BiWeekly`        | bi_weekly         |
| `FourWeekly`      | four_weekly       |
| `SemiMonthly`     | semi_monthly      |
| `Monthly`         | monthly           |
| `BiMonthly`       | bi_monthly        |
| `Quarterly`       | quarterly         |
| `SemiAnnually`    | semi_annually     |
| `Yearly`          | yearly            |
| `ThirteenMonthly` | thirteen_monthly  |
| `ProRata`         | pro_rata          |
| `UnmappedValue`   | unmapped_value    |
| `HalfYearly`      | half_yearly       |
| `Daily`           | daily             |