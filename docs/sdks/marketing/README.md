# Marketing
(*Marketing*)

## Overview

### Available Operations

* [TemplatesListEmail](#templateslistemail) - List Email Templates
* [CreateEmailTemplate](#createemailtemplate) - Create Email Templates
* [GetEmailTemplate](#getemailtemplate) - Get Email Templates
* [UpdateEmailTemplate](#updateemailtemplate) - Update Email Templates
* [TemplatesListInApp](#templateslistinapp) - List In-App Templates
* [CreateInAppTemplate](#createinapptemplate) - Create In-App Template
* [ListSmsTemplates](#listsmstemplates) - List SMS Templates
* [CreateSmsTemplate](#createsmstemplate) - Create SMS Template
* [UpdateSmsTemplate](#updatesmstemplate) - Update SMS Template
* [~~ListOmniChannelTemplates~~](#listomnichanneltemplates) - List Omni-Channel Templates :warning: **Deprecated**
* [~~GetOmniChannelTemplate~~](#getomnichanneltemplate) - Get Omni-Channel Template :warning: **Deprecated**
* [~~UpdateOmniChannelTemplate~~](#updateomnichanneltemplate) - Update Omni-Channel Template :warning: **Deprecated**
* [TemplatesListPush](#templateslistpush) - List Push Templates
* [UpdatePushTemplate](#updatepushtemplate) - Update Push Template
* [ListContentBlocks](#listcontentblocks) - List Content Blocks
* [CreateContentBlock](#createcontentblock) - Create Content Block
* [GetContentBlock](#getcontentblock) - Get Content Blocks

## TemplatesListEmail

List Email Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_list_email_templates" method="get" path="/unified/marketing/templates/email" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingListEmailTemplatesRequest req = new MarketingListEmailTemplatesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
    Filter = new MarketingListEmailTemplatesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

MarketingListEmailTemplatesResponse? res = await sdk.Marketing.TemplatesListEmailAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [MarketingListEmailTemplatesRequest](../../Models/Requests/MarketingListEmailTemplatesRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[MarketingListEmailTemplatesResponse](../../Models/Requests/MarketingListEmailTemplatesResponse.md)**

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

## CreateEmailTemplate

Create Email Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_create_email_template" method="post" path="/unified/marketing/templates/email" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.CreateEmailTemplateAsync(
    xAccountId: "<id>",
    marketingCreateEmailTemplateRequestDto: new MarketingCreateEmailTemplateRequestDto() {
        Messages = new List<EmailMessages>() {
            new EmailMessages() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = null,
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

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                | *string*                                                                                                    | :heavy_check_mark:                                                                                          | The account identifier                                                                                      |
| `MarketingCreateEmailTemplateRequestDto`                                                                    | [MarketingCreateEmailTemplateRequestDto](../../Models/Components/MarketingCreateEmailTemplateRequestDto.md) | :heavy_check_mark:                                                                                          | N/A                                                                                                         |

### Response

**[MarketingCreateEmailTemplateResponse](../../Models/Requests/MarketingCreateEmailTemplateResponse.md)**

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

## GetEmailTemplate

Get Email Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_get_email_template" method="get" path="/unified/marketing/templates/email/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingGetEmailTemplateRequest req = new MarketingGetEmailTemplateRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
};

var res = await sdk.Marketing.GetEmailTemplateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [MarketingGetEmailTemplateRequest](../../Models/Requests/MarketingGetEmailTemplateRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[MarketingGetEmailTemplateResponse](../../Models/Requests/MarketingGetEmailTemplateResponse.md)**

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

## UpdateEmailTemplate

Update Email Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_update_email_template" method="patch" path="/unified/marketing/templates/email/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.UpdateEmailTemplateAsync(
    xAccountId: "<id>",
    id: "<id>",
    marketingCreateEmailTemplateRequestDto: new MarketingCreateEmailTemplateRequestDto() {
        Messages = new List<EmailMessages>() {
            new EmailMessages() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = new EmailMessagesMessageType() {
                    Value = EmailMessagesValue.Email,
                    SourceValue = EmailMessagesSourceValueUnion.CreateStr(
                        "Email"
                    ),
                },
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

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                | *string*                                                                                                    | :heavy_check_mark:                                                                                          | The account identifier                                                                                      |
| `Id`                                                                                                        | *string*                                                                                                    | :heavy_check_mark:                                                                                          | N/A                                                                                                         |
| `MarketingCreateEmailTemplateRequestDto`                                                                    | [MarketingCreateEmailTemplateRequestDto](../../Models/Components/MarketingCreateEmailTemplateRequestDto.md) | :heavy_check_mark:                                                                                          | N/A                                                                                                         |

### Response

**[MarketingUpdateEmailTemplateResponse](../../Models/Requests/MarketingUpdateEmailTemplateResponse.md)**

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

## TemplatesListInApp

List In-App Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_list_in_app_templates" method="get" path="/unified/marketing/templates/in_app" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingListInAppTemplatesRequest req = new MarketingListInAppTemplatesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
    Filter = null,
};

MarketingListInAppTemplatesResponse? res = await sdk.Marketing.TemplatesListInAppAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [MarketingListInAppTemplatesRequest](../../Models/Requests/MarketingListInAppTemplatesRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[MarketingListInAppTemplatesResponse](../../Models/Requests/MarketingListInAppTemplatesResponse.md)**

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

## CreateInAppTemplate

Create In-App Template

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_create_in_app_template" method="post" path="/unified/marketing/templates/in_app" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.CreateInAppTemplateAsync(
    xAccountId: "<id>",
    marketingCreateInAppTemplateRequestDto: new MarketingCreateInAppTemplateRequestDto() {
        Messages = new List<InAppMessages>() {
            new InAppMessages() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = new InAppMessagesMessageType() {
                    Value = InAppMessagesValue.Email,
                    SourceValue = InAppMessagesSourceValueUnion.CreateStr(
                        "Email"
                    ),
                },
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

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                | *string*                                                                                                    | :heavy_check_mark:                                                                                          | The account identifier                                                                                      |
| `MarketingCreateInAppTemplateRequestDto`                                                                    | [MarketingCreateInAppTemplateRequestDto](../../Models/Components/MarketingCreateInAppTemplateRequestDto.md) | :heavy_check_mark:                                                                                          | N/A                                                                                                         |

### Response

**[MarketingCreateInAppTemplateResponse](../../Models/Requests/MarketingCreateInAppTemplateResponse.md)**

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

## ListSmsTemplates

List SMS Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_list_sms_templates" method="get" path="/unified/marketing/templates/sms" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingListSmsTemplatesRequest req = new MarketingListSmsTemplatesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
    Filter = new MarketingListSmsTemplatesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

MarketingListSmsTemplatesResponse? res = await sdk.Marketing.ListSmsTemplatesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [MarketingListSmsTemplatesRequest](../../Models/Requests/MarketingListSmsTemplatesRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[MarketingListSmsTemplatesResponse](../../Models/Requests/MarketingListSmsTemplatesResponse.md)**

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

## CreateSmsTemplate

Create SMS Template

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_create_sms_template" method="post" path="/unified/marketing/templates/sms" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.CreateSmsTemplateAsync(
    xAccountId: "<id>",
    marketingCreateSmsTemplateRequestDto: new MarketingCreateSmsTemplateRequestDto() {
        Messages = new List<SmsMessages>() {
            new SmsMessages() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = new SmsMessagesMessageType() {
                    Value = SmsMessagesValue.Email,
                    SourceValue = SmsMessagesSourceValueUnion.CreateStr(
                        "Email"
                    ),
                },
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

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                            | *string*                                                                                                | :heavy_check_mark:                                                                                      | The account identifier                                                                                  |
| `MarketingCreateSmsTemplateRequestDto`                                                                  | [MarketingCreateSmsTemplateRequestDto](../../Models/Components/MarketingCreateSmsTemplateRequestDto.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |

### Response

**[MarketingCreateSmsTemplateResponse](../../Models/Requests/MarketingCreateSmsTemplateResponse.md)**

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

## UpdateSmsTemplate

Update SMS Template

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_update_sms_template" method="patch" path="/unified/marketing/templates/sms/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.UpdateSmsTemplateAsync(
    xAccountId: "<id>",
    id: "<id>",
    marketingCreateSmsTemplateRequestDto: new MarketingCreateSmsTemplateRequestDto() {
        Messages = new List<SmsMessages>() {
            new SmsMessages() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = new SmsMessagesMessageType() {
                    Value = SmsMessagesValue.Email,
                    SourceValue = SmsMessagesSourceValueUnion.CreateStr(
                        "Email"
                    ),
                },
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

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                            | *string*                                                                                                | :heavy_check_mark:                                                                                      | The account identifier                                                                                  |
| `Id`                                                                                                    | *string*                                                                                                | :heavy_check_mark:                                                                                      | N/A                                                                                                     |
| `MarketingCreateSmsTemplateRequestDto`                                                                  | [MarketingCreateSmsTemplateRequestDto](../../Models/Components/MarketingCreateSmsTemplateRequestDto.md) | :heavy_check_mark:                                                                                      | N/A                                                                                                     |

### Response

**[MarketingUpdateSmsTemplateResponse](../../Models/Requests/MarketingUpdateSmsTemplateResponse.md)**

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

## ~~ListOmniChannelTemplates~~

List Omni-Channel Templates

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_list_omni_channel_templates" method="get" path="/unified/marketing/templates/omni_channel" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingListOmniChannelTemplatesRequest req = new MarketingListOmniChannelTemplatesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
    Filter = new MarketingListOmniChannelTemplatesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

MarketingListOmniChannelTemplatesResponse? res = await sdk.Marketing.ListOmniChannelTemplatesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [MarketingListOmniChannelTemplatesRequest](../../Models/Requests/MarketingListOmniChannelTemplatesRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[MarketingListOmniChannelTemplatesResponse](../../Models/Requests/MarketingListOmniChannelTemplatesResponse.md)**

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

## ~~GetOmniChannelTemplate~~

Get Omni-Channel Template

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_get_omni_channel_template" method="get" path="/unified/marketing/templates/omni_channel/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingGetOmniChannelTemplateRequest req = new MarketingGetOmniChannelTemplateRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
};

var res = await sdk.Marketing.GetOmniChannelTemplateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [MarketingGetOmniChannelTemplateRequest](../../Models/Requests/MarketingGetOmniChannelTemplateRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[MarketingGetOmniChannelTemplateResponse](../../Models/Requests/MarketingGetOmniChannelTemplateResponse.md)**

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

## ~~UpdateOmniChannelTemplate~~

Update Omni-Channel Template

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_update_omni_channel_template" method="patch" path="/unified/marketing/templates/omni_channel/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.UpdateOmniChannelTemplateAsync(
    xAccountId: "<id>",
    id: "<id>",
    marketingCreateTemplateRequestDto: new MarketingCreateTemplateRequestDto() {
        Messages = new List<CreateMessage>() {
            new CreateMessage() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = new CreateMessageMessageType() {
                    Value = CreateMessageValue.Email,
                    SourceValue = CreateMessageSourceValueUnion.CreateStr(
                        "Email"
                    ),
                },
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

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                      | *string*                                                                                          | :heavy_check_mark:                                                                                | The account identifier                                                                            |
| `Id`                                                                                              | *string*                                                                                          | :heavy_check_mark:                                                                                | N/A                                                                                               |
| `MarketingCreateTemplateRequestDto`                                                               | [MarketingCreateTemplateRequestDto](../../Models/Components/MarketingCreateTemplateRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |

### Response

**[MarketingUpdateOmniChannelTemplateResponse](../../Models/Requests/MarketingUpdateOmniChannelTemplateResponse.md)**

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

## TemplatesListPush

List Push Templates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_list_push_templates" method="get" path="/unified/marketing/templates/push" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingListPushTemplatesRequest req = new MarketingListPushTemplatesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,messages,created_at,updated_at,tags",
    Filter = new MarketingListPushTemplatesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

MarketingListPushTemplatesResponse? res = await sdk.Marketing.TemplatesListPushAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [MarketingListPushTemplatesRequest](../../Models/Requests/MarketingListPushTemplatesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[MarketingListPushTemplatesResponse](../../Models/Requests/MarketingListPushTemplatesResponse.md)**

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

## UpdatePushTemplate

Update Push Template

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_update_push_template" method="patch" path="/unified/marketing/templates/push/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.UpdatePushTemplateAsync(
    xAccountId: "<id>",
    id: "<id>",
    marketingCreatePushTemplateRequestDto: new MarketingCreatePushTemplateRequestDto() {
        Messages = new List<PushMessages>() {
            new PushMessages() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                MessageType = new PushMessagesMessageType() {
                    Value = PushMessagesValue.Email,
                    SourceValue = PushMessagesSourceValueUnion.CreateStr(
                        "Email"
                    ),
                },
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

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                              | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The account identifier                                                                                    |
| `Id`                                                                                                      | *string*                                                                                                  | :heavy_check_mark:                                                                                        | N/A                                                                                                       |
| `MarketingCreatePushTemplateRequestDto`                                                                   | [MarketingCreatePushTemplateRequestDto](../../Models/Components/MarketingCreatePushTemplateRequestDto.md) | :heavy_check_mark:                                                                                        | N/A                                                                                                       |

### Response

**[MarketingUpdatePushTemplateResponse](../../Models/Requests/MarketingUpdatePushTemplateResponse.md)**

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

## ListContentBlocks

List Content Blocks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_list_content_blocks" method="get" path="/unified/marketing/content_blocks" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingListContentBlocksRequest req = new MarketingListContentBlocksRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,content,status,tags,created_at,updated_at",
    Filter = new MarketingListContentBlocksFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

MarketingListContentBlocksResponse? res = await sdk.Marketing.ListContentBlocksAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [MarketingListContentBlocksRequest](../../Models/Requests/MarketingListContentBlocksRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[MarketingListContentBlocksResponse](../../Models/Requests/MarketingListContentBlocksResponse.md)**

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

## CreateContentBlock

Create Content Block

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_create_content_block" method="post" path="/unified/marketing/content_blocks" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Marketing.CreateContentBlockAsync(
    xAccountId: "<id>",
    marketingCreateContentBlocksRequestDto: new MarketingCreateContentBlocksRequestDto() {
        Type = new MarketingCreateContentBlocksRequestDtoType() {
            Value = MarketingCreateContentBlocksRequestDtoValue.Html,
            SourceValue = MarketingCreateContentBlocksRequestDtoSourceValueUnion.CreateStr(
                "text"
            ),
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                | *string*                                                                                                    | :heavy_check_mark:                                                                                          | The account identifier                                                                                      |
| `MarketingCreateContentBlocksRequestDto`                                                                    | [MarketingCreateContentBlocksRequestDto](../../Models/Components/MarketingCreateContentBlocksRequestDto.md) | :heavy_check_mark:                                                                                          | N/A                                                                                                         |

### Response

**[MarketingCreateContentBlockResponse](../../Models/Requests/MarketingCreateContentBlockResponse.md)**

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

## GetContentBlock

Get Content Blocks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="marketing_get_content_block" method="get" path="/unified/marketing/content_blocks/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

MarketingGetContentBlockRequest req = new MarketingGetContentBlockRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,content,status,tags,created_at,updated_at",
};

var res = await sdk.Marketing.GetContentBlockAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [MarketingGetContentBlockRequest](../../Models/Requests/MarketingGetContentBlockRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[MarketingGetContentBlockResponse](../../Models/Requests/MarketingGetContentBlockResponse.md)**

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