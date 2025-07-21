# Employees
(*Hris.Employees*)

## Overview

### Available Operations

* [ListCustomFieldDefinitions](#listcustomfielddefinitions) - List employee Custom Field Definitions
* [List](#list) - List Employees
* [Create](#create) - Creates an employee
* [Update](#update) - Updates an employee
* [Invite](#invite) - Invite Employee
* [CreateTimeOff](#createtimeoff) - Create Employee Time Off Request
* [BatchUploadDocument](#batchuploaddocument) - Batch Upload Employee Document
* [WorkEligibilityList](#workeligibilitylist) - List Employee Work Eligibility
* [CreateWorkEligibilityRequest](#createworkeligibilityrequest) - Create Employee Work Eligibility Request
* [GetWorkEligibility](#getworkeligibility) - Get Employees Work Eligibility
* [CreateEmployment](#createemployment) - Create Employee Employment
* [GetEmployment](#getemployment) - Get Employee Employment
* [ListTimeOffPolicies](#listtimeoffpolicies) - List Assigned Time Off Policies
* [GetSkill](#getskill) - Get Employee Skill

## ListCustomFieldDefinitions

List employee Custom Field Definitions

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeCustomFieldDefinitionsRequest req = new HrisListEmployeeCustomFieldDefinitionsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,description,type,options",
    Filter = new HrisListEmployeeCustomFieldDefinitionsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListEmployeeCustomFieldDefinitionsResponse? res = await sdk.Hris.Employees.ListCustomFieldDefinitionsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [HrisListEmployeeCustomFieldDefinitionsRequest](../../Models/Requests/HrisListEmployeeCustomFieldDefinitionsRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |

### Response

**[HrisListEmployeeCustomFieldDefinitionsResponse](../../Models/Requests/HrisListEmployeeCustomFieldDefinitionsResponse.md)**

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

## List

List Employees

### Example Usage

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

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [HrisListEmployeesRequest](../../Models/Requests/HrisListEmployeesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[HrisListEmployeesResponse](../../Models/Requests/HrisListEmployeesResponse.md)**

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

Creates an employee

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

var res = await sdk.Hris.Employees.CreateAsync(
    xAccountId: "<id>",
    hrisCreateEmployeeRequestDto: new HrisCreateEmployeeRequestDto() {
        FirstName = "Isaac",
        LastName = "Newton",
        Name = "Isaac Newton",
        DisplayName = "Sir Isaac Newton",
        AvatarUrl = "https://example.com/avatar.png",
        PersonalEmail = "isaac.newton@example.com",
        PersonalPhoneNumber = "+1234567890",
        WorkEmail = "newton@example.com",
        WorkPhoneNumber = "+1234567890",
        JobTitle = "Physicist",
        DepartmentId = "3093",
        TeamId = "2913",
        Department = "Physics",
        ManagerId = "67890",
        Gender = new HrisCreateEmployeeRequestDtoGender() {},
        PreferredLanguage = new HrisCreateEmployeeRequestDtoPreferredLanguage() {
            Value = HrisCreateEmployeeRequestDtoPreferredLanguageValue.Eng,
        },
        Ethnicity = new HrisCreateEmployeeRequestDtoEthnicity() {},
        DateOfBirth = System.DateTime.Parse("1990-01-01T00:00:00.000Z"),
        Birthday = System.DateTime.Parse("2021-01-01T00:00:00Z"),
        MaritalStatus = new HrisCreateEmployeeRequestDtoMaritalStatus() {},
        Avatar = new HrisCreateEmployeeRequestDtoAvatar() {},
        HireDate = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        StartDate = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        EmploymentStatus = new HrisCreateEmployeeRequestDtoEmploymentStatus() {},
        TerminationDate = System.DateTime.Parse("2021-01-01T00:00:00Z"),
        CompanyId = "1234567890",
        Citizenships = new List<CountryCodeEnum>() {
            new CountryCodeEnum() {
                Value = CountryCodeEnumValue.Us,
            },
        },
        Employment = null,
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
        Benefits = new List<CreateHRISBenefit>() {
            new CreateHRISBenefit() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Name = "Health Insurance",
                Provider = "Aetna",
                Description = "Health insurance for employees",
                CreatedAt = System.DateTime.Parse("2021-01-01T00:00:00Z"),
                UpdatedAt = System.DateTime.Parse("2021-01-01T00:00:00Z"),
            },
        },
        EmployeeNumber = "125",
        NationalIdentityNumbers = new List<NationalIdentityNumberApiModel>() {
            new NationalIdentityNumberApiModel() {
                Value = "123456789",
                Type = new NationalIdentityNumberApiModelType() {
                    Value = NationalIdentityNumberApiModelTypeValue.Ssn,
                },
                Country = new NationalIdentityNumberApiModelCountry() {
                    Value = NationalIdentityNumberApiModelCountryValue.Us,
                },
            },
        },
        HomeLocation = new HrisCreateEmployeeRequestDtoHomeLocation() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "Woolsthorpe Manor",
            PhoneNumber = "+44 1476 860 364",
            Street1 = "Water Lane",
            Street2 = "Woolsthorpe by Colsterworth",
            City = "Grantham",
            ZipCode = "NG33 5NR",
            Country = new HrisCreateEmployeeRequestDtoHomeLocationCountry() {
                Value = HrisCreateEmployeeRequestDtoHomeLocationValue.Us,
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
            State = new HrisCreateEmployeeRequestDtoHomeLocationState() {},
        },
        WorkLocation = null,
        CostCenters = new List<CreateCostCenterApiModel>() {
            new CreateCostCenterApiModel() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Name = "R&D",
                DistributionPercentage = 100D,
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

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `HrisCreateEmployeeRequestDto`                                                          | [HrisCreateEmployeeRequestDto](../../Models/Components/HrisCreateEmployeeRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[HrisCreateEmployeeResponse](../../Models/Requests/HrisCreateEmployeeResponse.md)**

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

Updates an employee

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

var res = await sdk.Hris.Employees.UpdateAsync(
    xAccountId: "<id>",
    id: "<id>",
    hrisUpdateEmployeeRequestDto: new HrisUpdateEmployeeRequestDto() {
        FirstName = "Isaac",
        LastName = "Newton",
        Name = "Isaac Newton",
        DisplayName = "Sir Isaac Newton",
        AvatarUrl = "https://example.com/avatar.png",
        PersonalEmail = "isaac.newton@example.com",
        PersonalPhoneNumber = "+1234567890",
        WorkEmail = "newton@example.com",
        WorkPhoneNumber = "+1234567890",
        JobTitle = "Physicist",
        DepartmentId = "3093",
        TeamId = "2913",
        Department = "Physics",
        ManagerId = "67890",
        Gender = new HrisUpdateEmployeeRequestDtoGender() {},
        PreferredLanguage = new HrisUpdateEmployeeRequestDtoPreferredLanguage() {
            Value = HrisUpdateEmployeeRequestDtoPreferredLanguageValue.Eng,
        },
        Ethnicity = new HrisUpdateEmployeeRequestDtoEthnicity() {},
        DateOfBirth = System.DateTime.Parse("1990-01-01T00:00:00.000Z"),
        Birthday = System.DateTime.Parse("2021-01-01T00:00:00Z"),
        MaritalStatus = new HrisUpdateEmployeeRequestDtoMaritalStatus() {},
        Avatar = new HrisUpdateEmployeeRequestDtoAvatar() {},
        HireDate = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        StartDate = System.DateTime.Parse("2021-01-01T00:00:00.000Z"),
        EmploymentStatus = new HrisUpdateEmployeeRequestDtoEmploymentStatus() {},
        TerminationDate = System.DateTime.Parse("2021-01-01T00:00:00Z"),
        CompanyId = "1234567890",
        Citizenships = new List<CountryCodeEnum>() {
            new CountryCodeEnum() {
                Value = CountryCodeEnumValue.Us,
            },
        },
        Employment = null,
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
        Benefits = null,
        EmployeeNumber = "125",
        NationalIdentityNumbers = new List<NationalIdentityNumberApiModel>() {
            new NationalIdentityNumberApiModel() {
                Value = "123456789",
                Type = new NationalIdentityNumberApiModelType() {
                    Value = NationalIdentityNumberApiModelTypeValue.Ssn,
                },
                Country = new NationalIdentityNumberApiModelCountry() {
                    Value = NationalIdentityNumberApiModelCountryValue.Us,
                },
            },
        },
        HomeLocation = new HrisUpdateEmployeeRequestDtoHomeLocation() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "Woolsthorpe Manor",
            PhoneNumber = "+44 1476 860 364",
            Street1 = "Water Lane",
            Street2 = "Woolsthorpe by Colsterworth",
            City = "Grantham",
            ZipCode = "NG33 5NR",
            Country = new HrisUpdateEmployeeRequestDtoHomeLocationCountry() {
                Value = HrisUpdateEmployeeRequestDtoHomeLocationValue.Us,
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
            State = new HrisUpdateEmployeeRequestDtoHomeLocationState() {},
        },
        WorkLocation = new HrisUpdateEmployeeRequestDtoWorkLocation() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "Woolsthorpe Manor",
            PhoneNumber = "+44 1476 860 364",
            Street1 = "Water Lane",
            Street2 = "Woolsthorpe by Colsterworth",
            City = "Grantham",
            ZipCode = "NG33 5NR",
            Country = new HrisUpdateEmployeeRequestDtoWorkLocationCountry() {
                Value = HrisUpdateEmployeeRequestDtoWorkLocationValue.Us,
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
            State = new HrisUpdateEmployeeRequestDtoWorkLocationState() {},
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `Id`                                                                                    | *string*                                                                                | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `HrisUpdateEmployeeRequestDto`                                                          | [HrisUpdateEmployeeRequestDto](../../Models/Components/HrisUpdateEmployeeRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[HrisUpdateEmployeeResponse](../../Models/Requests/HrisUpdateEmployeeResponse.md)**

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

## Invite

Invite Employee

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.Employees.InviteAsync(
    xAccountId: "<id>",
    id: "<id>",
    hrisInviteEmployeeRequestDto: new HrisInviteEmployeeRequestDto() {
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `Id`                                                                                    | *string*                                                                                | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `HrisInviteEmployeeRequestDto`                                                          | [HrisInviteEmployeeRequestDto](../../Models/Components/HrisInviteEmployeeRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[HrisInviteEmployeeResponse](../../Models/Requests/HrisInviteEmployeeResponse.md)**

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

## CreateTimeOff

Create Employee Time Off Request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.Employees.CreateTimeOffAsync(
    xAccountId: "<id>",
    id: "<id>",
    hrisCreateTimeOffRequestDto: new HrisCreateTimeOffRequestDto() {
        ApproverId = "1687-4",
        StartDate = "2021-01-01T01:01:01.000",
        EndDate = "2021-01-01T01:01:01.000",
        StartHalfDay = HrisCreateTimeOffRequestDtoStartHalfDayUnion.CreateBoolean(
            true
        ),
        EndHalfDay = HrisCreateTimeOffRequestDtoEndHalfDayUnion.CreateBoolean(
            true
        ),
        TimeOffPolicyId = "cx280928933",
        Reason = new HrisCreateTimeOffRequestDtoReason() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
        },
        Comment = "Taking a day off for personal reasons",
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `XAccountId`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | The account identifier                                                                |
| `Id`                                                                                  | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `HrisCreateTimeOffRequestDto`                                                         | [HrisCreateTimeOffRequestDto](../../Models/Components/HrisCreateTimeOffRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |

### Response

**[HrisCreateEmployeeTimeOffRequestResponse](../../Models/Requests/HrisCreateEmployeeTimeOffRequestResponse.md)**

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

## BatchUploadDocument

Batch Upload Employee Document

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.Employees.BatchUploadDocumentAsync(
    xAccountId: "<id>",
    id: "<id>",
    hrisBatchDocumentUploadRequestDto: new HrisBatchDocumentUploadRequestDto() {
        Items = new List<HrisDocumentsUploadRequestDto>() {
            new HrisDocumentsUploadRequestDto() {
                Name = "weather-forecast",
                FileFormat = new HrisDocumentsUploadRequestDtoFileFormat() {
                    Value = HrisDocumentsUploadRequestDtoFileFormatValue.Pdf,
                    SourceValue = HrisDocumentsUploadRequestDtoFileFormatSourceValueUnion.CreateStr(
                        "application/pdf"
                    ),
                },
                Content = "VGhpcyBpc24ndCByZWFsbHkgYSBzYW1wbGUgZmlsZSwgYnV0IG5vIG9uZSB3aWxsIGV2ZXIga25vdyE",
                CategoryId = "6530",
                Path = "/path/to/file",
                Confidential = new HrisDocumentsUploadRequestDtoConfidential() {
                    Value = HrisDocumentsUploadRequestDtoConfidentialValue.True,
                    SourceValue = HrisDocumentsUploadRequestDtoConfidentialSourceValueUnion.CreateStr(
                        "public"
                    ),
                },
                Category = new HrisDocumentsUploadRequestDtoCategory() {},
            },
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
| `HrisBatchDocumentUploadRequestDto`                                                               | [HrisBatchDocumentUploadRequestDto](../../Models/Components/HrisBatchDocumentUploadRequestDto.md) | :heavy_check_mark:                                                                                | N/A                                                                                               |

### Response

**[HrisBatchUploadEmployeeDocumentResponse](../../Models/Requests/HrisBatchUploadEmployeeDocumentResponse.md)**

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

## WorkEligibilityList

List Employee Work Eligibility

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeWorkEligibilityRequest req = new HrisListEmployeeWorkEligibilityRequest() {
    Id = "<id>",
    Fields = "id,remote_id,type,sub_type,document,valid_from,valid_to,issued_by,number",
    Filter = new HrisListEmployeeWorkEligibilityFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    XAccountId = "<id>",
};

HrisListEmployeeWorkEligibilityResponse? res = await sdk.Hris.Employees.WorkEligibilityListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisListEmployeeWorkEligibilityRequest](../../Models/Requests/HrisListEmployeeWorkEligibilityRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisListEmployeeWorkEligibilityResponse](../../Models/Requests/HrisListEmployeeWorkEligibilityResponse.md)**

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

## CreateWorkEligibilityRequest

Create Employee Work Eligibility Request

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

var res = await sdk.Hris.Employees.CreateWorkEligibilityRequestAsync(
    id: "<id>",
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
            FileFormat = null,
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
| `XAccountId`                                                                                          | *string*                                                                                              | :heavy_check_mark:                                                                                    | The account identifier                                                                                |
| `HrisCreateWorkEligibilityRequestDto`                                                                 | [HrisCreateWorkEligibilityRequestDto](../../Models/Components/HrisCreateWorkEligibilityRequestDto.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |

### Response

**[HrisCreateEmployeeWorkEligibilityRequestResponse](../../Models/Requests/HrisCreateEmployeeWorkEligibilityRequestResponse.md)**

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

## GetWorkEligibility

Get Employees Work Eligibility

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeesWorkEligibilityRequest req = new HrisGetEmployeesWorkEligibilityRequest() {
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,type,sub_type,document,valid_from,valid_to,issued_by,number",
    XAccountId = "<id>",
};

var res = await sdk.Hris.Employees.GetWorkEligibilityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisGetEmployeesWorkEligibilityRequest](../../Models/Requests/HrisGetEmployeesWorkEligibilityRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisGetEmployeesWorkEligibilityResponse](../../Models/Requests/HrisGetEmployeesWorkEligibilityResponse.md)**

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

## CreateEmployment

Create Employee Employment

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

var res = await sdk.Hris.Employees.CreateEmploymentAsync(
    xAccountId: "<id>",
    id: "<id>",
    hrisCreateEmploymentRequestDto: new HrisCreateEmploymentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        JobTitle = "Software Engineer",
        PayRate = "40.00",
        PayPeriod = new HrisCreateEmploymentRequestDtoPayPeriod() {
            Value = HrisCreateEmploymentRequestDtoPayPeriodValue.Hour,
            SourceValue = HrisCreateEmploymentRequestDtoPayPeriodSourceValueUnion.CreateStr(
                "Hour"
            ),
        },
        PayFrequency = new HrisCreateEmploymentRequestDtoPayFrequency() {
            Value = HrisCreateEmploymentRequestDtoPayFrequencyValue.Hourly,
            SourceValue = HrisCreateEmploymentRequestDtoPayFrequencySourceValueUnion.CreateStr(
                "Hourly"
            ),
        },
        PayCurrency = "USD",
        EffectiveDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        EndDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Grade = new HrisCreateEmploymentRequestDtoGrade() {
            Id = "1687-3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "1687-4",
            Description = "Mid-level employee demonstrating proficiency and autonomy.",
        },
        WorkTime = new HrisCreateEmploymentRequestDtoWorkTime() {
            Duration = "P0Y0M0DT8H0M0S",
            DurationUnit = new HrisCreateEmploymentRequestDtoDurationUnit() {
                Value = HrisCreateEmploymentRequestDtoWorkTimeValue.Month,
            },
        },
        PayrollCode = "PC1",
        JobId = "5290",
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                | *string*                                                                                    | :heavy_check_mark:                                                                          | The account identifier                                                                      |
| `Id`                                                                                        | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `HrisCreateEmploymentRequestDto`                                                            | [HrisCreateEmploymentRequestDto](../../Models/Components/HrisCreateEmploymentRequestDto.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |

### Response

**[HrisCreateEmployeeEmploymentResponse](../../Models/Requests/HrisCreateEmployeeEmploymentResponse.md)**

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

## GetEmployment

Get Employee Employment

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeEmploymentRequest req = new HrisGetEmployeeEmploymentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,job_title,pay_rate,pay_period,pay_frequency,pay_currency,effective_date,end_date,employment_type,employment_contract_type,change_reason,grade,work_time,payroll_code,fte,created_at,updated_at,start_date,active,department,team,cost_center,cost_centers,division,job,type,contract_type,manager",
    Expand = "groups",
};

var res = await sdk.Hris.Employees.GetEmploymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [HrisGetEmployeeEmploymentRequest](../../Models/Requests/HrisGetEmployeeEmploymentRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[HrisGetEmployeeEmploymentResponse](../../Models/Requests/HrisGetEmployeeEmploymentResponse.md)**

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

## ListTimeOffPolicies

List Assigned Time Off Policies

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeTimeOffPoliciesRequest req = new HrisListEmployeeTimeOffPoliciesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,description,type,duration_unit,reasons,updated_at,created_at",
    Filter = new HrisListEmployeeTimeOffPoliciesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListEmployeeTimeOffPoliciesResponse? res = await sdk.Hris.Employees.ListTimeOffPoliciesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisListEmployeeTimeOffPoliciesRequest](../../Models/Requests/HrisListEmployeeTimeOffPoliciesRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisListEmployeeTimeOffPoliciesResponse](../../Models/Requests/HrisListEmployeeTimeOffPoliciesResponse.md)**

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

## GetSkill

Get Employee Skill

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeSkillRequest req = new HrisGetEmployeeSkillRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,name,active,language,maximum_proficiency,minimum_proficiency",
};

var res = await sdk.Hris.Employees.GetSkillAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [HrisGetEmployeeSkillRequest](../../Models/Requests/HrisGetEmployeeSkillRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[HrisGetEmployeeSkillResponse](../../Models/Requests/HrisGetEmployeeSkillResponse.md)**

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