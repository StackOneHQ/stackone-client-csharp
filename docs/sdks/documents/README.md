# Documents
(*Documents*)

## Overview

### Available Operations

* [ListApplicationCategories](#listapplicationcategories) - List Application Document Categories
* [UploadFile](#uploadfile) - Upload File

## ListApplicationCategories

List Application Document Categories

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListApplicationDocumentCategoriesRequest req = new AtsListApplicationDocumentCategoriesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active",
    Filter = new AtsListApplicationDocumentCategoriesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

AtsListApplicationDocumentCategoriesResponse? res = await sdk.Documents.ListApplicationCategoriesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [AtsListApplicationDocumentCategoriesRequest](../../Models/Requests/AtsListApplicationDocumentCategoriesRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[AtsListApplicationDocumentCategoriesResponse](../../Models/Requests/AtsListApplicationDocumentCategoriesResponse.md)**

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

## UploadFile

Upload File

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Documents.UploadFileAsync(
    xAccountId: "<id>",
    unifiedUploadRequestDto: new UnifiedUploadRequestDto() {
        Name = "weather-forecast",
        FileFormat = new UnifiedUploadRequestDtoFileFormat() {
            Value = UnifiedUploadRequestDtoFileFormatValue.Pdf,
            SourceValue = UnifiedUploadRequestDtoFileFormatSourceValueUnion.CreateStr(
                "application/pdf"
            ),
        },
        Content = "VGhpcyBpc24ndCByZWFsbHkgYSBzYW1wbGUgZmlsZSwgYnV0IG5vIG9uZSB3aWxsIGV2ZXIga25vdyE",
        CategoryId = "6530",
        Path = "/path/to/file",
        Category = new UnifiedUploadRequestDtoCategory() {
            Value = "reports, resumes",
            SourceValue = "550e8400-e29b-41d4-a716-446655440000, CUSTOM_CATEGORY_NAME",
        },
        Confidential = new UnifiedUploadRequestDtoConfidential() {
            Value = UnifiedUploadRequestDtoConfidentialValue.True,
            SourceValue = UnifiedUploadRequestDtoConfidentialSourceValueUnion.CreateStr(
                "public"
            ),
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `XAccountId`                                                                  | *string*                                                                      | :heavy_check_mark:                                                            | The account identifier                                                        |
| `UnifiedUploadRequestDto`                                                     | [UnifiedUploadRequestDto](../../Models/Components/UnifiedUploadRequestDto.md) | :heavy_check_mark:                                                            | N/A                                                                           |
| `XStackoneApiSessionToken`                                                    | *string*                                                                      | :heavy_minus_sign:                                                            | The session token                                                             |

### Response

**[DocumentsUploadFileResponse](../../Models/Requests/DocumentsUploadFileResponse.md)**

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