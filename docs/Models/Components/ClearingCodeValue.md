# ClearingCodeValue

The type of clearing code

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = ClearingCodeValue.SortCode;

// Open enum: use .Of() to create instances from custom string values
var custom = ClearingCodeValue.Of("custom_value");
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `SortCode`                 | sort_code                  |
| `BuildingSocietyReference` | building_society_reference |
| `AbaRouting`               | aba_routing                |
| `ChipsParticipantId`       | chips_participant_id       |
| `TransitNumber`            | transit_number             |
| `InstitutionNumber`        | institution_number         |
| `BsbCode`                  | bsb_code                   |
| `IfscCode`                 | ifsc_code                  |
| `MicrCode`                 | micr_code                  |
| `Clabe`                    | clabe                      |
| `CnapsCode`                | cnaps_code                 |
| `ChBankClearingCode`       | ch_bank_clearing_code      |
| `ChSicCode`                | ch_sic_code                |
| `ZenginCode`               | zengin_code                |
| `NzClearingCode`           | nz_clearing_code           |
| `HkBankCode`               | hk_bank_code               |
| `Blz`                      | blz                        |
| `AtBankleitzahl`           | at_bankleitzahl            |
| `Nuban`                    | nuban                      |
| `SeBankgiroCode`           | se_bankgiro_code           |
| `UnmappedValue`            | unmapped_value             |