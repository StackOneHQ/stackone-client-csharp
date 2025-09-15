# StackOne.Client


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### List Employees

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeesRequest req = new HrisListEmployeesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,first_name,last_name,name,display_name,gender,ethnicity,date_of_birth,birthday,marital_status,avatar_url,avatar,personal_email,personal_phone_number,work_email,work_phone_number,job_id,remote_job_id,job_title,job_description,department_id,remote_department_id,department,cost_centers,company,manager_id,remote_manager_id,hire_date,start_date,tenure,work_anniversary,employment_type,employment_contract_type,employment_status,termination_date,company_name,company_id,remote_company_id,preferred_language,citizenships,home_location,work_location,employments,custom_fields,created_at,updated_at,benefits,employee_number,national_identity_number,national_identity_numbers,skills",
    Filter = new HrisListEmployeesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Expand = "company,employments,work_location,home_location,groups,skills",
    Include = "avatar_url,avatar,custom_fields,job_description,benefits",
};

HrisListEmployeesResponse? res = await sdk.Hris.Employees.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                      | Type | Scheme     |
| ------------------------- | ---- | ---------- |
| `Username`<br/>`Password` | http | HTTP Basic |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

ConnectSessionCreate req = new ConnectSessionCreate() {
    Categories = new List<ConnectSessionCreateCategory>() {
        ConnectSessionCreateCategory.Ats,
        ConnectSessionCreateCategory.Hris,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Crm,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Marketing,
        ConnectSessionCreateCategory.Lms,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Documents,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Screening,
        ConnectSessionCreateCategory.Messaging,
        ConnectSessionCreateCategory.Accounting,
    },
    OriginOwnerId = "<id>",
    OriginOwnerName = "<value>",
};

var res = await sdk.ConnectSessions.CreateAsync(req);

// handle response
```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient();

var res = await sdk.Mcp.McpGetAsync(
    security: new StackoneMcpGetSecurity() {
        Basic = new SchemeBasic() {
            Username = "",
            Password = "",
        },
    },
    xAccountId: "<id>",
    mcpSessionId: "<id>"
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Pagination [pagination] -->
## Pagination

Some of the endpoints in this SDK support pagination. To use pagination, you make your SDK calls as usual, but the
returned response object will have a `Next` method that can be called to pull down the next group of results. If the
return value of `Next` is `null`, then there are no more pages to be fetched.

Here's an example of one such pagination call:
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListActionsMetaRequest req = new StackoneListActionsMetaRequest() {
    GroupBy = "[\"connector\"]",
    Filter = new StackoneListActionsMetaFilter() {
        Connectors = "connector1,connector2",
        AccountIds = "account1,account2",
        ActionKey = "action1",
    },
    Include = new List<StackoneListActionsMetaInclude>() {
        StackoneListActionsMetaInclude.OperationDetails,
    },
};

StackoneListActionsMetaResponse? res = await sdk.Actions.ListActionsMetaAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```
<!-- End Pagination [pagination] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

ConnectSessionCreate req = new ConnectSessionCreate() {
    Categories = new List<ConnectSessionCreateCategory>() {
        ConnectSessionCreateCategory.Ats,
        ConnectSessionCreateCategory.Hris,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Crm,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Marketing,
        ConnectSessionCreateCategory.Lms,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Documents,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Screening,
        ConnectSessionCreateCategory.Messaging,
        ConnectSessionCreateCategory.Accounting,
    },
    OriginOwnerId = "<id>",
    OriginOwnerName = "<value>",
};

var res = await sdk.ConnectSessions.CreateAsync(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    request: req
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    security: new Security() {
        Username = "",
        Password = "",
    }
);

ConnectSessionCreate req = new ConnectSessionCreate() {
    Categories = new List<ConnectSessionCreateCategory>() {
        ConnectSessionCreateCategory.Ats,
        ConnectSessionCreateCategory.Hris,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Crm,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Marketing,
        ConnectSessionCreateCategory.Lms,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Documents,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Screening,
        ConnectSessionCreateCategory.Messaging,
        ConnectSessionCreateCategory.Accounting,
    },
    OriginOwnerId = "<id>",
    OriginOwnerName = "<value>",
};

var res = await sdk.ConnectSessions.CreateAsync(req);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`StackOneError`](./src/StackOneHQ/Client/Models/Errors/StackOneError.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `Request`     | *HttpRequestMessage*  | HTTP request object   |
| `Response`    | *HttpResponseMessage* | HTTP response object  |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Errors;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

try
{
    ConnectSessionCreate req = new ConnectSessionCreate() {
        Categories = new List<ConnectSessionCreateCategory>() {
            ConnectSessionCreateCategory.Ats,
            ConnectSessionCreateCategory.Hris,
            ConnectSessionCreateCategory.Ticketing,
            ConnectSessionCreateCategory.Crm,
            ConnectSessionCreateCategory.Iam,
            ConnectSessionCreateCategory.Marketing,
            ConnectSessionCreateCategory.Lms,
            ConnectSessionCreateCategory.Iam,
            ConnectSessionCreateCategory.Documents,
            ConnectSessionCreateCategory.Ticketing,
            ConnectSessionCreateCategory.Screening,
            ConnectSessionCreateCategory.Messaging,
            ConnectSessionCreateCategory.Accounting,
        },
        OriginOwnerId = "<id>",
        OriginOwnerName = "<value>",
    };

    var res = await sdk.ConnectSessions.CreateAsync(req);

    // handle response
}
catch (StackOneError ex)  // all SDK exceptions inherit from StackOneError
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpRequestMessage request = ex.Request;
    HttpResponseMessage response = ex.Response;
    var statusCode = (int)response.StatusCode;
    var responseBody = ex.Body;

    if (ex is BadRequestResponseException) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        BadRequestResponseExceptionPayload payload = ex.Payload;
        double StatusCode = payload.StatusCode;
        string Message = payload.Message;
        // ...
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exceptions:**
* [`StackOneError`](./src/StackOneHQ/Client/Models/Errors/StackOneError.cs): The base class for HTTP error responses.
  * [`BadRequestResponseException`](./src/StackOneHQ/Client/Models/Errors/BadRequestResponseException.cs): Invalid request. Status code `400`.
  * [`UnauthorizedResponseException`](./src/StackOneHQ/Client/Models/Errors/UnauthorizedResponseException.cs): Unauthorized access. Status code `401`.
  * [`ForbiddenResponseException`](./src/StackOneHQ/Client/Models/Errors/ForbiddenResponseException.cs): Forbidden. Status code `403`.
  * [`NotFoundResponseException`](./src/StackOneHQ/Client/Models/Errors/NotFoundResponseException.cs): Resource not found. Status code `404`.
  * [`RequestTimedOutResponseException`](./src/StackOneHQ/Client/Models/Errors/RequestTimedOutResponseException.cs): The request has timed out. Status code `408`.
  * [`ConflictResponseException`](./src/StackOneHQ/Client/Models/Errors/ConflictResponseException.cs): Conflict with current state. Status code `409`.
  * [`UnprocessableEntityResponseException`](./src/StackOneHQ/Client/Models/Errors/UnprocessableEntityResponseException.cs): Validation error. Status code `422`.
  * [`TooManyRequestsResponseException`](./src/StackOneHQ/Client/Models/Errors/TooManyRequestsResponseException.cs): Too many requests. Status code `429`.
  * [`InternalServerErrorResponse`](./src/StackOneHQ/Client/Models/Errors/InternalServerErrorResponse.cs): Server error while executing the request. Status code `500`.
  * [`NotImplementedResponseException`](./src/StackOneHQ/Client/Models/Errors/NotImplementedResponseException.cs): This functionality is not implemented. Status code `501`.
  * [`BadGatewayResponseException`](./src/StackOneHQ/Client/Models/Errors/BadGatewayResponseException.cs): Bad gateway error. Status code `502`.
  * [`PreconditionFailedResponseException`](./src/StackOneHQ/Client/Models/Errors/PreconditionFailedResponseException.cs): Precondition failed: linked account belongs to a disabled integration. Status code `412`. *

<details><summary>Less common exceptions (2)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`StackOneError`](./src/StackOneHQ/Client/Models/Errors/StackOneError.cs):
  * [`ResponseValidationError`](./src/StackOneHQ/Client/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(
    serverUrl: "https://api.stackone.com",
    security: new Security() {
        Username = "",
        Password = "",
    }
);

ConnectSessionCreate req = new ConnectSessionCreate() {
    Categories = new List<ConnectSessionCreateCategory>() {
        ConnectSessionCreateCategory.Ats,
        ConnectSessionCreateCategory.Hris,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Crm,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Marketing,
        ConnectSessionCreateCategory.Lms,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Documents,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Screening,
        ConnectSessionCreateCategory.Messaging,
        ConnectSessionCreateCategory.Accounting,
    },
    OriginOwnerId = "<id>",
    OriginOwnerName = "<value>",
};

var res = await sdk.ConnectSessions.CreateAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->