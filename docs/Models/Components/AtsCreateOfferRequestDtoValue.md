# AtsCreateOfferRequestDtoValue

The status of the offer.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AtsCreateOfferRequestDtoValue.Pending;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsCreateOfferRequestDtoValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Pending`       | pending         |
| `Retracted`     | retracted       |
| `Accepted`      | accepted        |
| `Rejected`      | rejected        |
| `Created`       | created         |
| `Approved`      | approved        |
| `NotApproved`   | not_approved    |
| `UnmappedValue` | unmapped_value  |