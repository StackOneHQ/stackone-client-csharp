# WorkEligibility
(*Hris.Employees.WorkEligibility*)

## Overview

### Available Operations

* [UpdateRequest](#updaterequest) - Update Employee Work Eligibility Request

## UpdateRequest

Update Employee Work Eligibility Request

### Example Usage

<!-- UsageSnippet language="csharp" operationID="hris_update_employee_work_eligibility_request" method="patch" path="/unified/hris/employees/{id}/work_eligibility/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
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

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |