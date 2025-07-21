# Tickets
(*Ticketing.Tickets*)

## Overview

### Available Operations

* [List](#list) - List Tickets
* [Create](#create) - Create Ticket
* [Get](#get) - Get Ticket
* [Update](#update) - Update Ticket
* [ListAttachments](#listattachments) - List Attachments
* [ListStatuses](#liststatuses) - List Ticket Statuses

## List

Retrieve a paginated list of tickets.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

TicketingListTicketsRequest req = new TicketingListTicketsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,type,ticket_number,title,creator_id,remote_creator_id,reporters,assignees,content,parent_id,remote_parent_id,closed_at,ticket_url,status,priority,tags,collections,organization,created_at,updated_at",
    Filter = new TicketingListTicketsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

TicketingListTicketsResponse? res = await sdk.Ticketing.Tickets.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [TicketingListTicketsRequest](../../Models/Requests/TicketingListTicketsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[TicketingListTicketsResponse](../../Models/Requests/TicketingListTicketsResponse.md)**

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

## Create

Create a new ticket record.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ticketing.Tickets.CreateAsync(
    xAccountId: "<id>",
    ticketingTicketCreateRequestDto: new TicketingTicketCreateRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Title = "System outage in production environment",
        CreatorId = "user-001",
        Reporters = new List<string>() {
            "user-001",
            "user-002",
        },
        Assignees = new List<string>() {
            "user-001",
            "user-002",
        },
        Content = new List<TicketingContent>() {
            new TicketingContent() {
                Plain = "This is some content",
                Html = "<p>This is some content</p>",
            },
        },
        ParentId = "ticket-002",
        Priority = new TicketingTicketCreateRequestDtoPriority() {
            Id = "001",
            Value = TicketingTicketCreateRequestDtoValue.Medium,
            SourceValue = TicketingTicketCreateRequestDtoSourceValueUnion.CreateStr(
                "Normal"
            ),
        },
        Tags = new List<string>() {
            "tag-001",
            "tag-002",
        },
        CollectionIds = new List<string>() {
            "collection-001",
            "collection-002",
        },
        Type = "ticket-type-001",
        OrganizationId = "organization-001",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The account identifier                                                                        |
| `TicketingTicketCreateRequestDto`                                                             | [TicketingTicketCreateRequestDto](../../Models/Components/TicketingTicketCreateRequestDto.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |

### Response

**[TicketingCreateTicketResponse](../../Models/Requests/TicketingCreateTicketResponse.md)**

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

## Get

Retrieve a single ticket by its identifier.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

TicketingGetTicketRequest req = new TicketingGetTicketRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,type,ticket_number,title,creator_id,remote_creator_id,reporters,assignees,content,parent_id,remote_parent_id,closed_at,ticket_url,status,priority,tags,collections,organization,created_at,updated_at",
};

var res = await sdk.Ticketing.Tickets.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [TicketingGetTicketRequest](../../Models/Requests/TicketingGetTicketRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[TicketingGetTicketResponse](../../Models/Requests/TicketingGetTicketResponse.md)**

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

## Update

Update an existing ticket record by its identifier.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ticketing.Tickets.UpdateAsync(
    xAccountId: "<id>",
    id: "<id>",
    ticketingTicketUpdateRequestDto: new TicketingTicketUpdateRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Title = "System outage in production environment",
        Reporters = new List<string>() {
            "user-001",
            "user-002",
        },
        Assignees = new List<string>() {
            "user-001",
            "user-002",
        },
        Content = new List<TicketingContent>() {
            new TicketingContent() {
                Plain = "This is some content",
                Html = "<p>This is some content</p>",
            },
        },
        ParentId = "ticket-002",
        Priority = new TicketingTicketUpdateRequestDtoPriority() {
            Id = "001",
            Value = TicketingTicketUpdateRequestDtoPriorityValue.Medium,
            SourceValue = TicketingTicketUpdateRequestDtoPrioritySourceValueUnion.CreateStr(
                "Normal"
            ),
        },
        Tags = new List<string>() {
            "tag-001",
            "tag-002",
        },
        CollectionIds = new List<string>() {
            "collection-001",
            "collection-002",
        },
        Status = new TicketingTicketUpdateRequestDtoStatus() {
            Id = "001",
            Type = new TicketingTicketUpdateRequestDtoType() {
                Value = TicketingTicketUpdateRequestDtoStatusValue.ToDo,
                SourceValue = TicketingTicketUpdateRequestDtoStatusSourceValueUnion.CreateStr(
                    "New"
                ),
            },
            Name = "Backlog",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The account identifier                                                                        |
| `Id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `TicketingTicketUpdateRequestDto`                                                             | [TicketingTicketUpdateRequestDto](../../Models/Components/TicketingTicketUpdateRequestDto.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |

### Response

**[TicketingUpdateTicketResponse](../../Models/Requests/TicketingUpdateTicketResponse.md)**

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

## ListAttachments

Retrieve a paginated list of attachment details for a ticket.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

TicketingListAttachmentsRequest req = new TicketingListAttachmentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,ticket_id,remote_ticket_id,user_id,remote_user_id,file_name,file_format,file_url,size,created_at,updated_at",
    Filter = new TicketingListAttachmentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

TicketingListAttachmentsResponse? res = await sdk.Ticketing.Tickets.ListAttachmentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [TicketingListAttachmentsRequest](../../Models/Requests/TicketingListAttachmentsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[TicketingListAttachmentsResponse](../../Models/Requests/TicketingListAttachmentsResponse.md)**

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

## ListStatuses

Retrieve a paginated list of statuses for a ticket.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

TicketingListTicketStatusesRequest req = new TicketingListTicketStatusesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Filter = new TicketingListTicketStatusesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

TicketingListTicketStatusesResponse? res = await sdk.Ticketing.Tickets.ListStatusesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [TicketingListTicketStatusesRequest](../../Models/Requests/TicketingListTicketStatusesRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[TicketingListTicketStatusesResponse](../../Models/Requests/TicketingListTicketStatusesResponse.md)**

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