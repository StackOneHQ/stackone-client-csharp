# CampaignStatusValue

The Status of the campaign.

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = CampaignStatusValue.Draft;

// Open enum: use .Of() to create instances from custom string values
var custom = CampaignStatusValue.Of("custom_value");
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Draft`         | draft           |
| `Archived`      | archived        |
| `Live`          | live            |
| `UnmappedValue` | unmapped_value  |