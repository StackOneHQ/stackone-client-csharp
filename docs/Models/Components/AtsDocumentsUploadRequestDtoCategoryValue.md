# AtsDocumentsUploadRequestDtoCategoryValue

The category name to associate with the file

## Example Usage

```csharp
using StackOneHQ.Client.Models.Components;

var value = AtsDocumentsUploadRequestDtoCategoryValue.Resume;

// Open enum: use .Of() to create instances from custom string values
var custom = AtsDocumentsUploadRequestDtoCategoryValue.Of("custom_value");
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `Resume`              | resume                |
| `Avatar`              | avatar                |
| `CoverLetter`         | cover_letter          |
| `ProfilePicture`      | profile_picture       |
| `Policy`              | policy                |
| `Passport`            | passport              |
| `Assessment`          | assessment            |
| `InterviewAttachment` | interview_attachment  |
| `TakeHomeTest`        | take_home_test        |
| `OfferLetter`         | offer_letter          |
| `SignedOfferLetter`   | signed_offer_letter   |
| `NationalId`          | national_id           |
| `OfferPacket`         | offer_packet          |
| `Other`               | other                 |
| `UnmappedValue`       | unmapped_value        |