# WorkEligibility
(*Hris.Employees.WorkEligibility*)

## Overview

### Available Operations

* [UpdateRequest](#updaterequest) - Update Employee Work Eligibility Request

## UpdateRequest

Update Employee Work Eligibility Request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.Employees.WorkEligibility.UpdateRequestAsync(
    id: "<id>",
    subResourceId: "<id>",
    xAccountId: "<id>",
    hrisCreateWorkEligibilityRequestDto: new HrisCreateWorkEligibilityRequestDto() {
        Document = new HrisCreateWorkEligibilityRequestDtoDocument() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "My Document",
            Path = "/path/to/file",
            Category = new HrisCreateWorkEligibilityRequestDtoCategory() {},
            CategoryId = "6530",
            CreatedAt = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
            UpdatedAt = System.DateTime.Parse("2021-01-02T01:01:01.000Z"),
            RemoteUrl = "https://example.com/file.pdf",
            FileFormat = new HrisCreateWorkEligibilityRequestDtoFileFormat() {
                Value = HrisCreateWorkEligibilityRequestDtoDocumentValue.Pdf,
                SourceValue = HrisCreateWorkEligibilityRequestDtoFileFormatSourceValueUnion.CreateStr(
                    "application/pdf"
                ),
            },
        },
        IssuedBy = new HrisCreateWorkEligibilityRequestDtoIssuedBy() {
            Value = HrisCreateWorkEligibilityRequestDtoIssuedByValue.Us,
        },
        Number = "1234567890",
        SubType = "H1B",
        Type = new HrisCreateWorkEligibilityRequestDtoType() {},
        ValidFrom = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        ValidTo = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `SubResourceId`                                                                                       | *string*                                                                                              | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `XAccountId`                                                                                          | *string*                                                                                              | :heavy_check_mark:                                                                                    | The account identifier                                                                                |
| `HrisCreateWorkEligibilityRequestDto`                                                                 | [HrisCreateWorkEligibilityRequestDto](../../Models/Components/HrisCreateWorkEligibilityRequestDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |

### Response

**[HrisUpdateEmployeeWorkEligibilityRequestResponse](../../Models/Requests/HrisUpdateEmployeeWorkEligibilityRequestResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |