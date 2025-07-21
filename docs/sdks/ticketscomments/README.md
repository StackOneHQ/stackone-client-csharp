# TicketsComments
(*Ticketing.Tickets.Comments*)

## Overview

### Available Operations

* [List](#list) - List Comments

## List

Retrieve a paginated list of comments for a ticket.

### Example Usage

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

TicketingListCommentsRequest req = new TicketingListCommentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,ticket_id,remote_ticket_id,content,user_id,remote_user_id,internal,created_at,updated_at",
    Filter = new TicketingListCommentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

TicketingListCommentsResponse? res = await sdk.Ticketing.Tickets.Comments.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [TicketingListCommentsRequest](../../Models/Requests/TicketingListCommentsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[TicketingListCommentsResponse](../../Models/Requests/TicketingListCommentsResponse.md)**

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