# AtsCreateApplicationRequestDtoValue

The status of the application.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AtsCreateApplicationRequestDtoValue.Active;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsCreateApplicationRequestDtoValue.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Active`              | active                |
| `Assessment`          | assessment            |
| `BackgroundCheck`     | background_check      |
| `Converted`           | converted             |
| `DeclinedByCandidate` | declined_by_candidate |
| `Hired`               | hired                 |
| `Interview`           | interview             |
| `Lead`                | lead                  |
| `Offer`               | offer                 |
| `ReferenceCheck`      | reference_check       |
| `Rejected`            | rejected              |
| `Review`              | review                |
| `Screen`              | screen                |
| `New`                 | new                   |
| `Onboarding`          | onboarding            |
| `Created`             | created               |
| `Accepted`            | accepted              |
| `ShortList`           | short_list            |
| `Approved`            | approved              |
| `UnmappedValue`       | unmapped_value        |