# StackOne.Client


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### List Employees

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeesRequest req = new HrisListEmployeesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,first_name,last_name,name,display_name,gender,ethnicity,date_of_birth,birthday,marital_status,avatar_url,avatar,personal_email,personal_phone_number,work_email,work_phone_number,job_id,remote_job_id,job_title,job_description,department_id,remote_department_id,department,cost_centers,company,manager_id,remote_manager_id,hire_date,start_date,tenure,work_anniversary,employment_type,employment_contract_type,employment_status,termination_date,company_name,company_id,remote_company_id,preferred_language,citizenships,home_location,work_location,employments,custom_fields,documents,created_at,updated_at,benefits,employee_number,national_identity_number,national_identity_numbers,skills",
    Filter = new HrisListEmployeesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
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
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
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
<!-- End Authentication [security] -->

<!-- Start Pagination [pagination] -->
## Pagination

Some of the endpoints in this SDK support pagination. To use pagination, you make your SDK calls as usual, but the
returned response object will have a `Next` method that can be called to pull down the next group of results. If the
return value of `Next` is `null`, then there are no more pages to be fetched.

Here's an example of one such pagination call:
```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListCompaniesRequest req = new HrisListCompaniesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,full_name,display_name,created_at,updated_at",
    Filter = new HrisListCompaniesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListCompaniesResponse? res = await sdk.Hris.GetCompaniesAsync(req);

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
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
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
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(
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

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `StackOne.Client.Models.Errors.APIException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CreateAsync` method throws the following exceptions:

| Error Type                                                         | Status Code | Content Type     |
| ------------------------------------------------------------------ | ----------- | ---------------- |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400         | application/json |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401         | application/json |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403         | application/json |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404         | application/json |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408         | application/json |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409         | application/json |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422         | application/json |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429         | application/json |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500         | application/json |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501         | application/json |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502         | application/json |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Errors;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
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
catch (Exception ex)
{
    if (ex is BadRequestResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is UnauthorizedResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is ForbiddenResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is NotFoundResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is RequestTimedOutResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is ConflictResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is UnprocessableEntityResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is TooManyRequestsResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is InternalServerErrorResponse)
    {
        // Handle exception data
        throw;
    }
    else if (ex is NotImplementedResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is BadGatewayResponseException)
    {
        // Handle exception data
        throw;
    }
    else if (ex is StackOne.Client.Models.Errors.APIException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(
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