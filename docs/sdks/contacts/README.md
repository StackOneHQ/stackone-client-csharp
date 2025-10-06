# Contacts
(*Crm.Contacts*)

## Overview

### Available Operations

* [List](#list) - List Contacts
* [Create](#create) - Create Contact

## List

List Contacts

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm_list_contacts" method="get" path="/unified/crm/contacts" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

CrmListContactsRequest req = new CrmListContactsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,first_name,last_name,company_name,emails,phone_numbers,deal_ids,remote_deal_ids,account_ids,remote_account_ids,custom_fields,created_at,updated_at,unified_custom_fields",
    Filter = new CrmListContactsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Include = "custom_fields",
};

CrmListContactsResponse? res = await sdk.Crm.Contacts.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CrmListContactsRequest](../../Models/Requests/CrmListContactsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[CrmListContactsResponse](../../Models/Requests/CrmListContactsResponse.md)**

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

## Create

Create Contact

### Example Usage

<!-- UsageSnippet language="csharp" operationID="crm_create_contact" method="post" path="/unified/crm/contacts" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Crm.Contacts.CreateAsync(
    xAccountId: "<id>",
    crmCreateContactRequestDto: new CrmCreateContactRequestDto() {
        FirstName = "Steve",
        LastName = "Wozniak",
        CompanyName = "Apple Inc.",
        Emails = new List<string>() {
            "steve@apple.com",
        },
        PhoneNumbers = new List<string>() {
            "123-456-7890",
        },
        DealIds = new List<string>() {
            "deal-001",
            "deal-002",
        },
        AccountIds = new List<string>() {
            "account-123",
            "account-456",
        },
        CustomFields = new List<CustomFields>() {
            new CustomFields() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Name = "Training Completion Status",
                Value = CustomFieldsValueUnion.CreateStr(
                    "Completed"
                ),
                ValueId = "value_456",
                RemoteValueId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
            },
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `XAccountId`                                                                        | *string*                                                                            | :heavy_check_mark:                                                                  | The account identifier                                                              |
| `CrmCreateContactRequestDto`                                                        | [CrmCreateContactRequestDto](../../Models/Components/CrmCreateContactRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |

### Response

**[CrmCreateContactResponse](../../Models/Requests/CrmCreateContactResponse.md)**

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