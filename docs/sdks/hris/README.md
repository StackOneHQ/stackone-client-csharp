# Hris
(*Hris*)

## Overview

### Available Operations

* [ListCompanies](#listcompanies) - List Companies
* [GetCompany](#getcompany) - Get Company
* [ListEmployeeCustomFieldDefinitions](#listemployeecustomfielddefinitions) - List employee Custom Field Definitions
* [GetEmployeeCustomFieldDefinition](#getemployeecustomfielddefinition) - Get employee Custom Field Definition
* [ListEmployees](#listemployees) - List Employees
* [CreateEmployee](#createemployee) - Creates an employee
* [GetEmployee](#getemployee) - Get Employee
* [UpdateEmployee](#updateemployee) - Updates an employee
* [InviteEmployee](#inviteemployee) - Invite Employee
* [ListEmployeeTimeOffRequests](#listemployeetimeoffrequests) - List Employee Time Off Requests
* [CreateEmployeeTimeOffRequest](#createemployeetimeoffrequest) - Create Employee Time Off Request
* [GetEmployeesTimeOffRequest](#getemployeestimeoffrequest) - Get Employees Time Off Request
* [CancelEmployeeTimeOffRequest](#cancelemployeetimeoffrequest) - Cancel Employee Time Off Request
* [UpdateEmployeeTimeOffRequest](#updateemployeetimeoffrequest) - Update Employee Time Off Request
* [BatchUploadEmployeeDocument](#batchuploademployeedocument) - Batch Upload Employee Document
* [UploadEmployeeDocument](#uploademployeedocument) - Upload Employee Document
* [DownloadEmployeeDocument](#downloademployeedocument) - Download Employee Document
* [ListEmployeeDocuments](#listemployeedocuments) - List Employee Documents
* [GetEmployeeDocument](#getemployeedocument) - Get Employee Document
* [ListEmployeeCategories](#listemployeecategories) - List Employee Document Categories
* [GetEmployeeDocumentCategory](#getemployeedocumentcategory) - Get Employee Document Category
* [ListEmployeeWorkEligibility](#listemployeeworkeligibility) - List Employee Work Eligibility
* [CreateEmployeeWorkEligibilityRequest](#createemployeeworkeligibilityrequest) - Create Employee Work Eligibility Request
* [GetEmployeesWorkEligibility](#getemployeesworkeligibility) - Get Employees Work Eligibility
* [UpdateEmployeeWorkEligibilityRequest](#updateemployeeworkeligibilityrequest) - Update Employee Work Eligibility Request
* [ListEmployeeTimeOffBalances](#listemployeetimeoffbalances) - List Employee Time Off Balances
* [GetEmployeeTimeOffBalance](#getemployeetimeoffbalance) - Get Employee Time Off Balance
* [ListEmployments](#listemployments) - List Employments
* [GetEmployment](#getemployment) - Get Employment
* [ListEmployeeEmployments](#listemployeeemployments) - List Employee Employments
* [CreateEmployeeEmployment](#createemployeeemployment) - Create Employee Employment
* [GetEmployeeEmployment](#getemployeeemployment) - Get Employee Employment
* [UpdateEmployeeEmployment](#updateemployeeemployment) - Update Employee Employment
* [ListGroups](#listgroups) - List Groups
* [ListDepartmentGroups](#listdepartmentgroups) - List Department Groups
* [ListCostCenterGroups](#listcostcentergroups) - List Cost Center Groups
* [ListTeamGroups](#listteamgroups) - List Team Groups
* [ListDivisionGroups](#listdivisiongroups) - List Division Groups
* [ListCompaniesGroups](#listcompaniesgroups) - List Companies Groups
* [GetGroup](#getgroup) - Get Group
* [GetDepartmentGroup](#getdepartmentgroup) - Get Department Group
* [GetCostCenterGroup](#getcostcentergroup) - Get Cost Center Group
* [GetTeamGroup](#getteamgroup) - Get Team Group
* [GetDivisionGroup](#getdivisiongroup) - Get Division Group
* [GetCompanyGroup](#getcompanygroup) - Get Company Group
* [ListJobs](#listjobs) - List Jobs
* [GetJob](#getjob) - Get Job
* [ListLocations](#listlocations) - List Work Locations
* [GetLocation](#getlocation) - Get Work Location
* [ListPositions](#listpositions) - List Positions
* [GetPosition](#getposition) - Get Position
* [ListTimeEntries](#listtimeentries) - List Time Entries
* [GetTimeEntries](#gettimeentries) - Get Time Entry
* [ListTimeOffRequests](#listtimeoffrequests) - List time off requests
* [GetTimeOffRequest](#gettimeoffrequest) - Get time off request
* [ListShifts](#listshifts) - List Shifts
* [GetShift](#getshift) - Get Shift
* [~~ListTimeOffTypes~~](#listtimeofftypes) - List time off types :warning: **Deprecated**
* [~~GetTimeOffType~~](#gettimeofftype) - Get time off type :warning: **Deprecated**
* [ListTimeOffPolicies](#listtimeoffpolicies) - List Time Off Policies
* [GetTimeOffPolicy](#gettimeoffpolicy) - Get Time Off Policy
* [ListEmployeeTimeOffPolicies](#listemployeetimeoffpolicies) - List Assigned Time Off Policies
* [ListBenefits](#listbenefits) - List benefits
* [GetBenefit](#getbenefit) - Get Benefit
* [ListEmployeeSkills](#listemployeeskills) - List Employee Skills
* [CreateEmployeeSkill](#createemployeeskill) - Create Employee Skill
* [GetEmployeeSkill](#getemployeeskill) - Get Employee Skill
* [ListEmployeeTasks](#listemployeetasks) - List Employee Tasks
* [GetEmployeeTask](#getemployeetask) - Get Employee Task
* [ListTasks](#listtasks) - List Tasks
* [GetTask](#gettask) - Get Task

## ListCompanies

List Companies

### Example Usage

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

HrisListCompaniesResponse? res = await sdk.Hris.ListCompaniesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [HrisListCompaniesRequest](../../Models/Requests/HrisListCompaniesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[HrisListCompaniesResponse](../../Models/Requests/HrisListCompaniesResponse.md)**

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

## GetCompany

Get Company

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetCompanyRequest req = new HrisGetCompanyRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,full_name,display_name,created_at,updated_at",
};

var res = await sdk.Hris.GetCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [HrisGetCompanyRequest](../../Models/Requests/HrisGetCompanyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[HrisGetCompanyResponse](../../Models/Requests/HrisGetCompanyResponse.md)**

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

## ListEmployeeCustomFieldDefinitions

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

HrisListEmployeeCustomFieldDefinitionsResponse? res = await sdk.Hris.ListEmployeeCustomFieldDefinitionsAsync(req);

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

## GetEmployeeCustomFieldDefinition

Get employee Custom Field Definition

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeCustomFieldDefinitionRequest req = new HrisGetEmployeeCustomFieldDefinitionRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,description,type,options",
    Filter = new HrisGetEmployeeCustomFieldDefinitionFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

var res = await sdk.Hris.GetEmployeeCustomFieldDefinitionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [HrisGetEmployeeCustomFieldDefinitionRequest](../../Models/Requests/HrisGetEmployeeCustomFieldDefinitionRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[HrisGetEmployeeCustomFieldDefinitionResponse](../../Models/Requests/HrisGetEmployeeCustomFieldDefinitionResponse.md)**

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

## ListEmployees

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

HrisListEmployeesResponse? res = await sdk.Hris.ListEmployeesAsync(req);

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

## CreateEmployee

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

var res = await sdk.Hris.CreateEmployeeAsync(
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

## GetEmployee

Get Employee

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeRequest req = new HrisGetEmployeeRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,first_name,last_name,name,display_name,gender,ethnicity,date_of_birth,birthday,marital_status,avatar_url,avatar,personal_email,personal_phone_number,work_email,work_phone_number,job_id,remote_job_id,job_title,job_description,department_id,remote_department_id,department,cost_centers,company,manager_id,remote_manager_id,hire_date,start_date,tenure,work_anniversary,employment_type,employment_contract_type,employment_status,termination_date,company_name,company_id,remote_company_id,preferred_language,citizenships,home_location,work_location,employments,custom_fields,documents,created_at,updated_at,benefits,employee_number,national_identity_number,national_identity_numbers,skills",
    Expand = "company,employments,work_location,home_location,groups,skills",
    Include = "avatar_url,avatar,custom_fields,job_description,benefits",
};

var res = await sdk.Hris.GetEmployeeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [HrisGetEmployeeRequest](../../Models/Requests/HrisGetEmployeeRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[HrisGetEmployeeResponse](../../Models/Requests/HrisGetEmployeeResponse.md)**

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

## UpdateEmployee

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

var res = await sdk.Hris.UpdateEmployeeAsync(
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

## InviteEmployee

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

var res = await sdk.Hris.InviteEmployeeAsync(
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

## ListEmployeeTimeOffRequests

List Employee Time Off Requests

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeTimeOffRequestsRequest req = new HrisListEmployeeTimeOffRequestsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,approver_id,remote_approver_id,status,type,start_date,end_date,start_half_day,end_half_day,time_off_policy_id,remote_time_off_policy_id,reason,comment,duration,created_at,updated_at,policy",
    Filter = new HrisListEmployeeTimeOffRequestsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "policy",
};

HrisListEmployeeTimeOffRequestsResponse? res = await sdk.Hris.ListEmployeeTimeOffRequestsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisListEmployeeTimeOffRequestsRequest](../../Models/Requests/HrisListEmployeeTimeOffRequestsRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisListEmployeeTimeOffRequestsResponse](../../Models/Requests/HrisListEmployeeTimeOffRequestsResponse.md)**

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

## CreateEmployeeTimeOffRequest

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

var res = await sdk.Hris.CreateEmployeeTimeOffRequestAsync(
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

## GetEmployeesTimeOffRequest

Get Employees Time Off Request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeesTimeOffRequestRequest req = new HrisGetEmployeesTimeOffRequestRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,approver_id,remote_approver_id,status,type,start_date,end_date,start_half_day,end_half_day,time_off_policy_id,remote_time_off_policy_id,reason,comment,duration,created_at,updated_at,policy",
    Expand = "policy",
};

var res = await sdk.Hris.GetEmployeesTimeOffRequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [HrisGetEmployeesTimeOffRequestRequest](../../Models/Requests/HrisGetEmployeesTimeOffRequestRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[HrisGetEmployeesTimeOffRequestResponse](../../Models/Requests/HrisGetEmployeesTimeOffRequestResponse.md)**

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

## CancelEmployeeTimeOffRequest

Cancel Employee Time Off Request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.CancelEmployeeTimeOffRequestAsync(
    xAccountId: "<id>",
    id: "<id>",
    subResourceId: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `XAccountId`           | *string*               | :heavy_check_mark:     | The account identifier |
| `Id`                   | *string*               | :heavy_check_mark:     | N/A                    |
| `SubResourceId`        | *string*               | :heavy_check_mark:     | N/A                    |

### Response

**[HrisCancelEmployeeTimeOffRequestResponse](../../Models/Requests/HrisCancelEmployeeTimeOffRequestResponse.md)**

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

## UpdateEmployeeTimeOffRequest

Update Employee Time Off Request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.UpdateEmployeeTimeOffRequestAsync(
    xAccountId: "<id>",
    id: "<id>",
    subResourceId: "<id>",
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
| `SubResourceId`                                                                       | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `HrisCreateTimeOffRequestDto`                                                         | [HrisCreateTimeOffRequestDto](../../Models/Components/HrisCreateTimeOffRequestDto.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |

### Response

**[HrisUpdateEmployeeTimeOffRequestResponse](../../Models/Requests/HrisUpdateEmployeeTimeOffRequestResponse.md)**

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

## BatchUploadEmployeeDocument

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

var res = await sdk.Hris.BatchUploadEmployeeDocumentAsync(
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

## UploadEmployeeDocument

Upload Employee Document

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.UploadEmployeeDocumentAsync(
    xAccountId: "<id>",
    id: "<id>",
    hrisDocumentsUploadRequestDto: new HrisDocumentsUploadRequestDto() {
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
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `XAccountId`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The account identifier                                                                    |
| `Id`                                                                                      | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `HrisDocumentsUploadRequestDto`                                                           | [HrisDocumentsUploadRequestDto](../../Models/Components/HrisDocumentsUploadRequestDto.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |

### Response

**[HrisUploadEmployeeDocumentResponse](../../Models/Requests/HrisUploadEmployeeDocumentResponse.md)**

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

## DownloadEmployeeDocument

Download Employee Document

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisDownloadEmployeeDocumentRequest req = new HrisDownloadEmployeeDocumentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Format = "base64",
    ExportFormat = "text/plain",
};

var res = await sdk.Hris.DownloadEmployeeDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [HrisDownloadEmployeeDocumentRequest](../../Models/Requests/HrisDownloadEmployeeDocumentRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[HrisDownloadEmployeeDocumentResponse](../../Models/Requests/HrisDownloadEmployeeDocumentResponse.md)**

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

## ListEmployeeDocuments

List Employee Documents

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeDocumentsRequest req = new HrisListEmployeeDocumentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,path,type,category,category_id,remote_category_id,contents,created_at,updated_at,remote_url,file_format",
    Filter = new HrisListEmployeeDocumentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListEmployeeDocumentsResponse? res = await sdk.Hris.ListEmployeeDocumentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [HrisListEmployeeDocumentsRequest](../../Models/Requests/HrisListEmployeeDocumentsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[HrisListEmployeeDocumentsResponse](../../Models/Requests/HrisListEmployeeDocumentsResponse.md)**

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

## GetEmployeeDocument

Get Employee Document

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeDocumentRequest req = new HrisGetEmployeeDocumentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,name,path,type,category,category_id,remote_category_id,contents,created_at,updated_at,remote_url,file_format",
};

var res = await sdk.Hris.GetEmployeeDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisGetEmployeeDocumentRequest](../../Models/Requests/HrisGetEmployeeDocumentRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisGetEmployeeDocumentResponse](../../Models/Requests/HrisGetEmployeeDocumentResponse.md)**

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

## ListEmployeeCategories

List Employee Document Categories

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeCategoriesRequest req = new HrisListEmployeeCategoriesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active",
    Filter = new HrisListEmployeeCategoriesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListEmployeeCategoriesResponse? res = await sdk.Hris.ListEmployeeCategoriesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [HrisListEmployeeCategoriesRequest](../../Models/Requests/HrisListEmployeeCategoriesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[HrisListEmployeeCategoriesResponse](../../Models/Requests/HrisListEmployeeCategoriesResponse.md)**

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

## GetEmployeeDocumentCategory

Get Employee Document Category

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeDocumentCategoryRequest req = new HrisGetEmployeeDocumentCategoryRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active",
};

var res = await sdk.Hris.GetEmployeeDocumentCategoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisGetEmployeeDocumentCategoryRequest](../../Models/Requests/HrisGetEmployeeDocumentCategoryRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisGetEmployeeDocumentCategoryResponse](../../Models/Requests/HrisGetEmployeeDocumentCategoryResponse.md)**

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

## ListEmployeeWorkEligibility

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

HrisListEmployeeWorkEligibilityResponse? res = await sdk.Hris.ListEmployeeWorkEligibilityAsync(req);

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

## CreateEmployeeWorkEligibilityRequest

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

var res = await sdk.Hris.CreateEmployeeWorkEligibilityRequestAsync(
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

## GetEmployeesWorkEligibility

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

var res = await sdk.Hris.GetEmployeesWorkEligibilityAsync(req);

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

## UpdateEmployeeWorkEligibilityRequest

Update Employee Work Eligibility Request

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

var res = await sdk.Hris.UpdateEmployeeWorkEligibilityRequestAsync(
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

## ListEmployeeTimeOffBalances

List Employee Time Off Balances

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeTimeOffBalancesRequest req = new HrisListEmployeeTimeOffBalancesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,policy_id,remote_policy_id,policy,current_balance,initial_balance,balance_unit,balance_start_date,balance_expiry_date,updated_at",
    Filter = new HrisListEmployeeTimeOffBalancesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "policy",
};

HrisListEmployeeTimeOffBalancesResponse? res = await sdk.Hris.ListEmployeeTimeOffBalancesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisListEmployeeTimeOffBalancesRequest](../../Models/Requests/HrisListEmployeeTimeOffBalancesRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisListEmployeeTimeOffBalancesResponse](../../Models/Requests/HrisListEmployeeTimeOffBalancesResponse.md)**

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

## GetEmployeeTimeOffBalance

Get Employee Time Off Balance

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeTimeOffBalanceRequest req = new HrisGetEmployeeTimeOffBalanceRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,policy_id,remote_policy_id,policy,current_balance,initial_balance,balance_unit,balance_start_date,balance_expiry_date,updated_at",
    Expand = "policy",
};

var res = await sdk.Hris.GetEmployeeTimeOffBalanceAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [HrisGetEmployeeTimeOffBalanceRequest](../../Models/Requests/HrisGetEmployeeTimeOffBalanceRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[HrisGetEmployeeTimeOffBalanceResponse](../../Models/Requests/HrisGetEmployeeTimeOffBalanceResponse.md)**

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

## ListEmployments

List Employments

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmploymentsRequest req = new HrisListEmploymentsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,job_title,pay_rate,pay_period,pay_frequency,pay_currency,effective_date,end_date,employment_type,employment_contract_type,change_reason,grade,work_time,payroll_code,fte,created_at,updated_at,start_date,active,department,team,cost_center,cost_centers,division,job,type,contract_type,manager",
    Filter = new HrisListEmploymentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "groups",
};

HrisListEmploymentsResponse? res = await sdk.Hris.ListEmploymentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisListEmploymentsRequest](../../Models/Requests/HrisListEmploymentsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisListEmploymentsResponse](../../Models/Requests/HrisListEmploymentsResponse.md)**

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

Get Employment

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmploymentRequest req = new HrisGetEmploymentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,job_title,pay_rate,pay_period,pay_frequency,pay_currency,effective_date,end_date,employment_type,employment_contract_type,change_reason,grade,work_time,payroll_code,fte,created_at,updated_at,start_date,active,department,team,cost_center,cost_centers,division,job,type,contract_type,manager",
    Expand = "groups",
};

var res = await sdk.Hris.GetEmploymentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [HrisGetEmploymentRequest](../../Models/Requests/HrisGetEmploymentRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[HrisGetEmploymentResponse](../../Models/Requests/HrisGetEmploymentResponse.md)**

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

## ListEmployeeEmployments

List Employee Employments

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeEmploymentsRequest req = new HrisListEmployeeEmploymentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,job_title,pay_rate,pay_period,pay_frequency,pay_currency,effective_date,end_date,employment_type,employment_contract_type,change_reason,grade,work_time,payroll_code,fte,created_at,updated_at,start_date,active,department,team,cost_center,cost_centers,division,job,type,contract_type,manager",
    Filter = new HrisListEmployeeEmploymentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "groups",
};

HrisListEmployeeEmploymentsResponse? res = await sdk.Hris.ListEmployeeEmploymentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [HrisListEmployeeEmploymentsRequest](../../Models/Requests/HrisListEmployeeEmploymentsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[HrisListEmployeeEmploymentsResponse](../../Models/Requests/HrisListEmployeeEmploymentsResponse.md)**

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

## CreateEmployeeEmployment

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

var res = await sdk.Hris.CreateEmployeeEmploymentAsync(
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

## GetEmployeeEmployment

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

var res = await sdk.Hris.GetEmployeeEmploymentAsync(req);

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

## UpdateEmployeeEmployment

Update Employee Employment

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

var res = await sdk.Hris.UpdateEmployeeEmploymentAsync(
    xAccountId: "<id>",
    id: "<id>",
    subResourceId: "<id>",
    hrisUpdateEmploymentRequestDto: new HrisUpdateEmploymentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        JobTitle = "Software Engineer",
        PayRate = "40.00",
        PayPeriod = new HrisUpdateEmploymentRequestDtoPayPeriod() {
            Value = HrisUpdateEmploymentRequestDtoPayPeriodValue.Hour,
            SourceValue = HrisUpdateEmploymentRequestDtoPayPeriodSourceValueUnion.CreateStr(
                "Hour"
            ),
        },
        PayFrequency = new HrisUpdateEmploymentRequestDtoPayFrequency() {
            Value = HrisUpdateEmploymentRequestDtoPayFrequencyValue.Hourly,
            SourceValue = HrisUpdateEmploymentRequestDtoPayFrequencySourceValueUnion.CreateStr(
                "Hourly"
            ),
        },
        PayCurrency = "USD",
        EffectiveDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        EndDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Grade = new HrisUpdateEmploymentRequestDtoGrade() {
            Id = "1687-3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "1687-4",
            Description = "Mid-level employee demonstrating proficiency and autonomy.",
        },
        WorkTime = new HrisUpdateEmploymentRequestDtoWorkTime() {
            Duration = "P0Y0M0DT8H0M0S",
            DurationUnit = new HrisUpdateEmploymentRequestDtoDurationUnit() {
                Value = HrisUpdateEmploymentRequestDtoWorkTimeValue.Month,
            },
        },
        PayrollCode = "PC1",
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
| `SubResourceId`                                                                             | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `HrisUpdateEmploymentRequestDto`                                                            | [HrisUpdateEmploymentRequestDto](../../Models/Components/HrisUpdateEmploymentRequestDto.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |

### Response

**[HrisUpdateEmployeeEmploymentResponse](../../Models/Requests/HrisUpdateEmployeeEmploymentResponse.md)**

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

## ListGroups

List Groups

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListGroupsRequest req = new HrisListGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
    Filter = new HrisListGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListGroupsResponse? res = await sdk.Hris.ListGroupsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [HrisListGroupsRequest](../../Models/Requests/HrisListGroupsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[HrisListGroupsResponse](../../Models/Requests/HrisListGroupsResponse.md)**

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

## ListDepartmentGroups

List Department Groups

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListDepartmentGroupsRequest req = new HrisListDepartmentGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
    Filter = new HrisListDepartmentGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListDepartmentGroupsResponse? res = await sdk.Hris.ListDepartmentGroupsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [HrisListDepartmentGroupsRequest](../../Models/Requests/HrisListDepartmentGroupsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[HrisListDepartmentGroupsResponse](../../Models/Requests/HrisListDepartmentGroupsResponse.md)**

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

## ListCostCenterGroups

List Cost Center Groups

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListCostCenterGroupsRequest req = new HrisListCostCenterGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,distribution_percentage,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
    Filter = new HrisListCostCenterGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListCostCenterGroupsResponse? res = await sdk.Hris.ListCostCenterGroupsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [HrisListCostCenterGroupsRequest](../../Models/Requests/HrisListCostCenterGroupsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[HrisListCostCenterGroupsResponse](../../Models/Requests/HrisListCostCenterGroupsResponse.md)**

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

## ListTeamGroups

List Team Groups

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListTeamGroupsRequest req = new HrisListTeamGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids",
    Filter = new HrisListTeamGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListTeamGroupsResponse? res = await sdk.Hris.ListTeamGroupsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [HrisListTeamGroupsRequest](../../Models/Requests/HrisListTeamGroupsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[HrisListTeamGroupsResponse](../../Models/Requests/HrisListTeamGroupsResponse.md)**

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

## ListDivisionGroups

List Division Groups

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListDivisionGroupsRequest req = new HrisListDivisionGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
    Filter = new HrisListDivisionGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListDivisionGroupsResponse? res = await sdk.Hris.ListDivisionGroupsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [HrisListDivisionGroupsRequest](../../Models/Requests/HrisListDivisionGroupsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[HrisListDivisionGroupsResponse](../../Models/Requests/HrisListDivisionGroupsResponse.md)**

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

## ListCompaniesGroups

List Companies Groups

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListCompaniesGroupsRequest req = new HrisListCompaniesGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,full_name,display_name,created_at,updated_at",
    Filter = new HrisListCompaniesGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListCompaniesGroupsResponse? res = await sdk.Hris.ListCompaniesGroupsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisListCompaniesGroupsRequest](../../Models/Requests/HrisListCompaniesGroupsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisListCompaniesGroupsResponse](../../Models/Requests/HrisListCompaniesGroupsResponse.md)**

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

## GetGroup

Get Group

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetGroupRequest req = new HrisGetGroupRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
};

var res = await sdk.Hris.GetGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [HrisGetGroupRequest](../../Models/Requests/HrisGetGroupRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[HrisGetGroupResponse](../../Models/Requests/HrisGetGroupResponse.md)**

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

## GetDepartmentGroup

Get Department Group

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetDepartmentGroupRequest req = new HrisGetDepartmentGroupRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
};

var res = await sdk.Hris.GetDepartmentGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [HrisGetDepartmentGroupRequest](../../Models/Requests/HrisGetDepartmentGroupRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[HrisGetDepartmentGroupResponse](../../Models/Requests/HrisGetDepartmentGroupResponse.md)**

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

## GetCostCenterGroup

Get Cost Center Group

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetCostCenterGroupRequest req = new HrisGetCostCenterGroupRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,distribution_percentage,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
};

var res = await sdk.Hris.GetCostCenterGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [HrisGetCostCenterGroupRequest](../../Models/Requests/HrisGetCostCenterGroupRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[HrisGetCostCenterGroupResponse](../../Models/Requests/HrisGetCostCenterGroupResponse.md)**

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

## GetTeamGroup

Get Team Group

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetTeamGroupRequest req = new HrisGetTeamGroupRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids",
};

var res = await sdk.Hris.GetTeamGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisGetTeamGroupRequest](../../Models/Requests/HrisGetTeamGroupRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisGetTeamGroupResponse](../../Models/Requests/HrisGetTeamGroupResponse.md)**

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

## GetDivisionGroup

Get Division Group

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetDivisionGroupRequest req = new HrisGetDivisionGroupRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
};

var res = await sdk.Hris.GetDivisionGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [HrisGetDivisionGroupRequest](../../Models/Requests/HrisGetDivisionGroupRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[HrisGetDivisionGroupResponse](../../Models/Requests/HrisGetDivisionGroupResponse.md)**

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

## GetCompanyGroup

Get Company Group

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetCompanyGroupRequest req = new HrisGetCompanyGroupRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,full_name,display_name,created_at,updated_at",
};

var res = await sdk.Hris.GetCompanyGroupAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisGetCompanyGroupRequest](../../Models/Requests/HrisGetCompanyGroupRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisGetCompanyGroupResponse](../../Models/Requests/HrisGetCompanyGroupResponse.md)**

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

## ListJobs

List Jobs

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListJobsRequest req = new HrisListJobsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
    Filter = new HrisListJobsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListJobsResponse? res = await sdk.Hris.ListJobsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [HrisListJobsRequest](../../Models/Requests/HrisListJobsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[HrisListJobsResponse](../../Models/Requests/HrisListJobsResponse.md)**

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

## GetJob

Get Job

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetJobRequest req = new HrisGetJobRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,type,parent_ids,remote_parent_ids,owner_ids,remote_owner_ids,company_id,remote_company_id",
};

var res = await sdk.Hris.GetJobAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [HrisGetJobRequest](../../Models/Requests/HrisGetJobRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[HrisGetJobResponse](../../Models/Requests/HrisGetJobResponse.md)**

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

## ListLocations

List Work Locations

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListLocationsRequest req = new HrisListLocationsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,phone_number,street_1,street_2,city,state,zip_code,country,location_type,created_at,updated_at",
    Filter = new HrisListLocationsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListLocationsResponse? res = await sdk.Hris.ListLocationsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [HrisListLocationsRequest](../../Models/Requests/HrisListLocationsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[HrisListLocationsResponse](../../Models/Requests/HrisListLocationsResponse.md)**

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

## GetLocation

Get Work Location

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetLocationRequest req = new HrisGetLocationRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,phone_number,street_1,street_2,city,state,zip_code,country,location_type,created_at,updated_at",
};

var res = await sdk.Hris.GetLocationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [HrisGetLocationRequest](../../Models/Requests/HrisGetLocationRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[HrisGetLocationResponse](../../Models/Requests/HrisGetLocationResponse.md)**

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

## ListPositions

List Positions

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListPositionsRequest req = new HrisListPositionsRequest() {
    XAccountId = "<id>",
    Filter = new HrisListPositionsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Status = HrisListPositionsStatus.Open,
};

HrisListPositionsResponse? res = await sdk.Hris.ListPositionsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [HrisListPositionsRequest](../../Models/Requests/HrisListPositionsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[HrisListPositionsResponse](../../Models/Requests/HrisListPositionsResponse.md)**

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

## GetPosition

Get Position

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetPositionRequest req = new HrisGetPositionRequest() {
    XAccountId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.GetPositionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [HrisGetPositionRequest](../../Models/Requests/HrisGetPositionRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[HrisGetPositionResponse](../../Models/Requests/HrisGetPositionResponse.md)**

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

## ListTimeEntries

List Time Entries

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListTimeEntriesRequest req = new HrisListTimeEntriesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,start_time,end_time,hours_worked,break_duration,labor_type,location,status,created_at,updated_at",
    Filter = new HrisListTimeEntriesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
        StartTime = "2020-01-01T00:00:00.000Z",
        EndTime = "2020-01-01T00:00:00.000Z",
    },
};

HrisListTimeEntriesResponse? res = await sdk.Hris.ListTimeEntriesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisListTimeEntriesRequest](../../Models/Requests/HrisListTimeEntriesRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisListTimeEntriesResponse](../../Models/Requests/HrisListTimeEntriesResponse.md)**

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

## GetTimeEntries

Get Time Entry

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetTimeEntriesRequest req = new HrisGetTimeEntriesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,start_time,end_time,hours_worked,break_duration,labor_type,location,status,created_at,updated_at",
};

var res = await sdk.Hris.GetTimeEntriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [HrisGetTimeEntriesRequest](../../Models/Requests/HrisGetTimeEntriesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[HrisGetTimeEntriesResponse](../../Models/Requests/HrisGetTimeEntriesResponse.md)**

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

## ListTimeOffRequests

List time off requests

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListTimeOffRequestsRequest req = new HrisListTimeOffRequestsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,approver_id,remote_approver_id,status,type,start_date,end_date,start_half_day,end_half_day,time_off_policy_id,remote_time_off_policy_id,reason,comment,duration,created_at,updated_at,policy",
    Filter = null,
    Expand = "policy",
};

HrisListTimeOffRequestsResponse? res = await sdk.Hris.ListTimeOffRequestsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisListTimeOffRequestsRequest](../../Models/Requests/HrisListTimeOffRequestsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisListTimeOffRequestsResponse](../../Models/Requests/HrisListTimeOffRequestsResponse.md)**

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

## GetTimeOffRequest

Get time off request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetTimeOffRequestRequest req = new HrisGetTimeOffRequestRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,approver_id,remote_approver_id,status,type,start_date,end_date,start_half_day,end_half_day,time_off_policy_id,remote_time_off_policy_id,reason,comment,duration,created_at,updated_at,policy",
    Expand = "policy",
};

var res = await sdk.Hris.GetTimeOffRequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [HrisGetTimeOffRequestRequest](../../Models/Requests/HrisGetTimeOffRequestRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[HrisGetTimeOffRequestResponse](../../Models/Requests/HrisGetTimeOffRequestResponse.md)**

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

## ListShifts

List Shifts

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListShiftsRequest req = new HrisListShiftsRequest() {
    XAccountId = "<id>",
    Filter = new HrisListShiftsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListShiftsResponse? res = await sdk.Hris.ListShiftsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [HrisListShiftsRequest](../../Models/Requests/HrisListShiftsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[HrisListShiftsResponse](../../Models/Requests/HrisListShiftsResponse.md)**

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

## GetShift

Get Shift

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetShiftRequest req = new HrisGetShiftRequest() {
    XAccountId = "<id>",
    Id = "<id>",
};

var res = await sdk.Hris.GetShiftAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [HrisGetShiftRequest](../../Models/Requests/HrisGetShiftRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[HrisGetShiftResponse](../../Models/Requests/HrisGetShiftResponse.md)**

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

## ~~ListTimeOffTypes~~

List time off types

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListTimeOffTypesRequest req = new HrisListTimeOffTypesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active",
    Filter = new HrisListTimeOffTypesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListTimeOffTypesResponse? res = await sdk.Hris.ListTimeOffTypesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [HrisListTimeOffTypesRequest](../../Models/Requests/HrisListTimeOffTypesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[HrisListTimeOffTypesResponse](../../Models/Requests/HrisListTimeOffTypesResponse.md)**

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

## ~~GetTimeOffType~~

Get time off type

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetTimeOffTypeRequest req = new HrisGetTimeOffTypeRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active",
};

var res = await sdk.Hris.GetTimeOffTypeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [HrisGetTimeOffTypeRequest](../../Models/Requests/HrisGetTimeOffTypeRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[HrisGetTimeOffTypeResponse](../../Models/Requests/HrisGetTimeOffTypeResponse.md)**

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

List Time Off Policies

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListTimeOffPoliciesRequest req = new HrisListTimeOffPoliciesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,description,type,duration_unit,reasons,updated_at,created_at",
    Filter = new HrisListTimeOffPoliciesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListTimeOffPoliciesResponse? res = await sdk.Hris.ListTimeOffPoliciesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisListTimeOffPoliciesRequest](../../Models/Requests/HrisListTimeOffPoliciesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisListTimeOffPoliciesResponse](../../Models/Requests/HrisListTimeOffPoliciesResponse.md)**

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

## GetTimeOffPolicy

Get Time Off Policy

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetTimeOffPolicyRequest req = new HrisGetTimeOffPolicyRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,description,type,duration_unit,reasons,updated_at,created_at",
};

var res = await sdk.Hris.GetTimeOffPolicyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [HrisGetTimeOffPolicyRequest](../../Models/Requests/HrisGetTimeOffPolicyRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[HrisGetTimeOffPolicyResponse](../../Models/Requests/HrisGetTimeOffPolicyResponse.md)**

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

## ListEmployeeTimeOffPolicies

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

HrisListEmployeeTimeOffPoliciesResponse? res = await sdk.Hris.ListEmployeeTimeOffPoliciesAsync(req);

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

## ListBenefits

List benefits

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListBenefitsRequest req = new HrisListBenefitsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,benefit_type,provider,description,created_at,updated_at",
    Filter = new HrisListBenefitsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListBenefitsResponse? res = await sdk.Hris.ListBenefitsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [HrisListBenefitsRequest](../../Models/Requests/HrisListBenefitsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[HrisListBenefitsResponse](../../Models/Requests/HrisListBenefitsResponse.md)**

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

## GetBenefit

Get Benefit

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetBenefitRequest req = new HrisGetBenefitRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,benefit_type,provider,description,created_at,updated_at",
};

var res = await sdk.Hris.GetBenefitAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [HrisGetBenefitRequest](../../Models/Requests/HrisGetBenefitRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[HrisGetBenefitResponse](../../Models/Requests/HrisGetBenefitResponse.md)**

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

## ListEmployeeSkills

List Employee Skills

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeSkillsRequest req = new HrisListEmployeeSkillsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active,language,maximum_proficiency,minimum_proficiency",
    Filter = new HrisListEmployeeSkillsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListEmployeeSkillsResponse? res = await sdk.Hris.ListEmployeeSkillsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [HrisListEmployeeSkillsRequest](../../Models/Requests/HrisListEmployeeSkillsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[HrisListEmployeeSkillsResponse](../../Models/Requests/HrisListEmployeeSkillsResponse.md)**

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

## CreateEmployeeSkill

Create Employee Skill

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.CreateEmployeeSkillAsync(
    xAccountId: "<id>",
    id: "<id>",
    entitySkillsCreateRequestDto: new EntitySkillsCreateRequestDto() {
        Id = "16873-IT345",
        Name = "Information-Technology",
        MaximumProficiency = new EntitySkillsCreateRequestDtoMaximumProficiency() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "Expert",
        },
        MinimumProficiency = null,
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `Id`                                                                                    | *string*                                                                                | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `EntitySkillsCreateRequestDto`                                                          | [EntitySkillsCreateRequestDto](../../Models/Components/EntitySkillsCreateRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[HrisCreateEmployeeSkillResponse](../../Models/Requests/HrisCreateEmployeeSkillResponse.md)**

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

## GetEmployeeSkill

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

var res = await sdk.Hris.GetEmployeeSkillAsync(req);

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

## ListEmployeeTasks

List Employee Tasks

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeTasksRequest req = new HrisListEmployeeTasksRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,description,type,status,due_date,completion_date,assigned_by_employee_id,remote_assigned_by_employee_id,assigned_by_employee_name,link_to_task,extracted_links,next_task_id,remote_next_task_id,parent_process_name,comments,attachments,created_at,updated_at",
    Filter = new HrisListEmployeeTasksFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "attachments",
};

HrisListEmployeeTasksResponse? res = await sdk.Hris.ListEmployeeTasksAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [HrisListEmployeeTasksRequest](../../Models/Requests/HrisListEmployeeTasksRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[HrisListEmployeeTasksResponse](../../Models/Requests/HrisListEmployeeTasksResponse.md)**

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

## GetEmployeeTask

Get Employee Task

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeTaskRequest req = new HrisGetEmployeeTaskRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,description,type,status,due_date,completion_date,assigned_by_employee_id,remote_assigned_by_employee_id,assigned_by_employee_name,link_to_task,extracted_links,next_task_id,remote_next_task_id,parent_process_name,comments,attachments,created_at,updated_at",
    Expand = "attachments",
};

var res = await sdk.Hris.GetEmployeeTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisGetEmployeeTaskRequest](../../Models/Requests/HrisGetEmployeeTaskRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisGetEmployeeTaskResponse](../../Models/Requests/HrisGetEmployeeTaskResponse.md)**

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

## ListTasks

List Tasks

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListTasksRequest req = new HrisListTasksRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,description,type,status,due_date,completion_date,assigned_by_employee_id,remote_assigned_by_employee_id,assigned_by_employee_name,link_to_task,extracted_links,next_task_id,remote_next_task_id,parent_process_name,comments,attachments,created_at,updated_at",
    Filter = new HrisListTasksFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "attachments",
};

HrisListTasksResponse? res = await sdk.Hris.ListTasksAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [HrisListTasksRequest](../../Models/Requests/HrisListTasksRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[HrisListTasksResponse](../../Models/Requests/HrisListTasksResponse.md)**

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

## GetTask

Get Task

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetTaskRequest req = new HrisGetTaskRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,description,type,status,due_date,completion_date,assigned_by_employee_id,remote_assigned_by_employee_id,assigned_by_employee_name,link_to_task,extracted_links,next_task_id,remote_next_task_id,parent_process_name,comments,attachments,created_at,updated_at",
    Expand = "attachments",
};

var res = await sdk.Hris.GetTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [HrisGetTaskRequest](../../Models/Requests/HrisGetTaskRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[HrisGetTaskResponse](../../Models/Requests/HrisGetTaskResponse.md)**

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