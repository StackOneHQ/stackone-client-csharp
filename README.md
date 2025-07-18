# StackOne.Client

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *StackOne.Client* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=stack-one-client&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<br /><br />
> [!IMPORTANT]
> This SDK is not yet ready for production use. To complete setup please follow the steps outlined in your [workspace](https://app.speakeasy.com/org/stackone/stackone). Delete this section before > publishing to a package manager.

<!-- Start Summary [summary] -->
## Summary

StackOne: The documentation for the StackOne API
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [StackOne.Client](#stackoneclient)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/StackOne/Client/StackOne.Client.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

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

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Accounts](docs/sdks/accounts/README.md)

* [List](docs/sdks/accounts/README.md#list) - List Accounts
* [Get](docs/sdks/accounts/README.md#get) - Get Account
* [Update](docs/sdks/accounts/README.md#update) - Update Account
* [Delete](docs/sdks/accounts/README.md#delete) - Delete Account
* [GetMeta](docs/sdks/accounts/README.md#getmeta) - Get meta information of the account

### [Connectors](docs/sdks/connectors/README.md)

* [ListMeta](docs/sdks/connectors/README.md#listmeta) - List Connectors Meta Information for all providers
* [GetMeta](docs/sdks/connectors/README.md#getmeta) - Get Connector Meta information for the given provider key

### [ConnectSessions](docs/sdks/connectsessions/README.md)

* [Create](docs/sdks/connectsessions/README.md#create) - Create Connect Session
* [Authenticate](docs/sdks/connectsessions/README.md#authenticate) - Authenticate Connect Session

### [Proxy](docs/sdks/proxy/README.md)

* [Perform](docs/sdks/proxy/README.md#perform) - Proxy Request

### [RequestLogs](docs/sdks/requestlogs/README.md)

* [ListSteps](docs/sdks/requestlogs/README.md#liststeps) - List Step Logs
* [Get](docs/sdks/requestlogs/README.md#get) - Get a Log
* [List](docs/sdks/requestlogs/README.md#list) - List Logs


</details>
<!-- End Available Resources and Operations [operations] -->

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

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=stack-one-client&utm_campaign=csharp)
