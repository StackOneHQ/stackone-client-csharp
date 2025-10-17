# StackOne.Client

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *StackOne.Client* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=stack-one-client&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>

<!-- Start Summary [summary] -->
## Summary

Accounting: The documentation for the StackOne Unified API - ACCOUNTING
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [StackOne.Client](#stackoneclient)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Pagination](#pagination)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package StackOneHQ.Client
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/StackOneHQ/Client/StackOneHQ.Client.csproj
```
<!-- End SDK Installation [installation] -->

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
    Fields = "id,remote_id,title,first_name,last_name,name,display_name,gender,ethnicity,date_of_birth,birthday,marital_status,avatar_url,avatar,personal_email,personal_phone_number,work_email,work_phone_number,job_id,remote_job_id,job_title,job_description,department_id,remote_department_id,department,cost_centers,company,manager_id,remote_manager_id,hire_date,start_date,tenure,work_anniversary,employment_type,employment_contract_type,employment_status,termination_date,company_name,company_id,remote_company_id,preferred_language,citizenships,home_location,work_location,employments,custom_fields,created_at,updated_at,benefits,employee_number,national_identity_number,national_identity_numbers,skills,unified_custom_fields",
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

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Accounting](docs/sdks/accounting/README.md)

* [ListCompanies](docs/sdks/accounting/README.md#listcompanies) - List Companies
* [GetCompany](docs/sdks/accounting/README.md#getcompany) - Get Company
* [ListCompanyAccounts](docs/sdks/accounting/README.md#listcompanyaccounts) - List Accounts
* [GetCompanyAccount](docs/sdks/accounting/README.md#getcompanyaccount) - Get Account
* [ListCompanyTaxRates](docs/sdks/accounting/README.md#listcompanytaxrates) - List Tax Rates
* [GetCompanyTaxRate](docs/sdks/accounting/README.md#getcompanytaxrate) - Get Tax Rate
* [BatchCreateCompanyJournals](docs/sdks/accounting/README.md#batchcreatecompanyjournals) - Batch Create Journals
* [ListCompanyJournals](docs/sdks/accounting/README.md#listcompanyjournals) - List Journals
* [CreateCompanyJournal](docs/sdks/accounting/README.md#createcompanyjournal) - Create Journal
* [GetCompanyJournal](docs/sdks/accounting/README.md#getcompanyjournal) - Get Journal

### [Accounts](docs/sdks/accounts/README.md)

* [List](docs/sdks/accounts/README.md#list) - List Accounts
* [Get](docs/sdks/accounts/README.md#get) - Get Account
* [Delete](docs/sdks/accounts/README.md#delete) - Delete Account
* [Update](docs/sdks/accounts/README.md#update) - Update Account
* [GetMeta](docs/sdks/accounts/README.md#getmeta) - Get Account Meta Information

### [Actions](docs/sdks/actions/README.md)

* [ListActionsMeta](docs/sdks/actions/README.md#listactionsmeta) - List all actions metadata
* [RpcAction](docs/sdks/actions/README.md#rpcaction) - Make an RPC call to an action

### [Applications](docs/sdks/applications/README.md)

* [GetScorecard](docs/sdks/applications/README.md#getscorecard) - Get Application Scorecard

### [Ats](docs/sdks/ats/README.md)

* [ListApplications](docs/sdks/ats/README.md#listapplications) - List Applications
* [Get](docs/sdks/ats/README.md#get) - Get Application
* [GetApplicationChanges](docs/sdks/ats/README.md#getapplicationchanges) - List Application Changes
* [ListApplicationNotes](docs/sdks/ats/README.md#listapplicationnotes) - List Application Notes
* [CreateApplicationNote](docs/sdks/ats/README.md#createapplicationnote) - Create Application Note
* [GetNote](docs/sdks/ats/README.md#getnote) - Get Application Note
* [UpdateNote](docs/sdks/ats/README.md#updatenote) - Update Application Note
* [DocumentsUpload](docs/sdks/ats/README.md#documentsupload) - Upload Application Document
* [GetDocument](docs/sdks/ats/README.md#getdocument) - Get Application Document
* [ListCandidates](docs/sdks/ats/README.md#listcandidates) - List Candidates
* [UpdateCandidate](docs/sdks/ats/README.md#updatecandidate) - Update Candidate
* [CreateNote](docs/sdks/ats/README.md#createnote) - Create Candidate Note
* [GetCandidateNote](docs/sdks/ats/README.md#getcandidatenote) - Get Candidate Note
* [ListJobCustomFieldDefinitions](docs/sdks/ats/README.md#listjobcustomfielddefinitions) - List Job Custom Field Definitions
* [GetDepartments](docs/sdks/ats/README.md#getdepartments) - List Departments
* [ListApplicationStages](docs/sdks/ats/README.md#listapplicationstages) - List Application Stages
* [GetApplicationStage](docs/sdks/ats/README.md#getapplicationstage) - Get Application Stage
* [ListJobs](docs/sdks/ats/README.md#listjobs) - List Jobs
* [CreateJob](docs/sdks/ats/README.md#createjob) - Create Job
* [ListJobApplicationStages](docs/sdks/ats/README.md#listjobapplicationstages) - List Job Application Stages
* [UpdateJob](docs/sdks/ats/README.md#updatejob) - Update Job
* [GetJobApplicationStage](docs/sdks/ats/README.md#getjobapplicationstage) - Get Job Application Stage
* [GetUser](docs/sdks/ats/README.md#getuser) - Get User
* [ListJobPostings](docs/sdks/ats/README.md#listjobpostings) - List Job Postings
* [OrderAssessments](docs/sdks/ats/README.md#orderassessments) - Order Assessments Request
* [AssessmentsUpdateResult](docs/sdks/ats/README.md#assessmentsupdateresult) - Update Assessments Result
* [UpdateBackgroundCheckPackage](docs/sdks/ats/README.md#updatebackgroundcheckpackage) - Update Background Check Package
* [OrderBackgroundCheck](docs/sdks/ats/README.md#orderbackgroundcheck) - Order Background Check Request
* [UpdateBackgroundCheckResult](docs/sdks/ats/README.md#updatebackgroundcheckresult) - Update Background Check Result

#### [Ats.Applications](docs/sdks/atsapplications/README.md)

* [Create](docs/sdks/atsapplications/README.md#create) - Create Application
* [Update](docs/sdks/atsapplications/README.md#update) - Update Application
* [ListOffers](docs/sdks/atsapplications/README.md#listoffers) - List Application Offers
* [Move](docs/sdks/atsapplications/README.md#move) - Move Application
* [Reject](docs/sdks/atsapplications/README.md#reject) - Reject Application
* [GetOffer](docs/sdks/atsapplications/README.md#getoffer) - Get Application Offer
* [ScorecardsList](docs/sdks/atsapplications/README.md#scorecardslist) - List Application Scorecards
* [ListScheduledInterviews](docs/sdks/atsapplications/README.md#listscheduledinterviews) - List Applications scheduled interviews
* [GetScheduledInterview](docs/sdks/atsapplications/README.md#getscheduledinterview) - Get Applications scheduled interview
* [DownloadDocument](docs/sdks/atsapplications/README.md#downloaddocument) - Download Application Document
* [ListCustomFieldDefinitions](docs/sdks/atsapplications/README.md#listcustomfielddefinitions) - List Application Custom Field Definitions
* [GetCustomFieldDefinition](docs/sdks/atsapplications/README.md#getcustomfielddefinition) - Get Application Custom Field Definition

#### [Ats.Applications.Documents](docs/sdks/applicationsdocuments/README.md)

* [List](docs/sdks/applicationsdocuments/README.md#list) - List Application Documents

#### [Ats.Assessments](docs/sdks/assessments/README.md)

* [PackagesList](docs/sdks/assessments/README.md#packageslist) - List Assessments Packages

#### [Ats.Assessments.Packages](docs/sdks/assessmentspackages/README.md)

* [Get](docs/sdks/assessmentspackages/README.md#get) - Get Assessments Package

#### [Ats.BackgroundChecks](docs/sdks/atsbackgroundchecks/README.md)

* [PackagesList](docs/sdks/atsbackgroundchecks/README.md#packageslist) - List Background Check Packages
* [CreatePackage](docs/sdks/atsbackgroundchecks/README.md#createpackage) - Create Background Check Package

#### [Ats.BackgroundChecks.Packages](docs/sdks/backgroundcheckspackages/README.md)

* [Get](docs/sdks/backgroundcheckspackages/README.md#get) - Get Background Check Package

#### [Ats.Candidates](docs/sdks/candidates/README.md)

* [Create](docs/sdks/candidates/README.md#create) - Create Candidate
* [Get](docs/sdks/candidates/README.md#get) - Get Candidate

#### [Ats.Candidates.CustomFieldDefinitions](docs/sdks/candidatescustomfielddefinitions/README.md)

* [Get](docs/sdks/candidatescustomfielddefinitions/README.md#get) - Get Candidate Custom Field Definition

#### [Ats.Candidates.Notes](docs/sdks/notes/README.md)

* [List](docs/sdks/notes/README.md#list) - List Candidate Notes

#### [Ats.CustomFieldDefinitions](docs/sdks/atscustomfielddefinitions/README.md)

* [ListCandidates](docs/sdks/atscustomfielddefinitions/README.md#listcandidates) - List Candidate Custom Field Definitions
* [GetJob](docs/sdks/atscustomfielddefinitions/README.md#getjob) - Get Job Custom Field Definition

#### [Ats.Departments](docs/sdks/atsdepartments/README.md)

* [Get](docs/sdks/atsdepartments/README.md#get) - Get Department

#### [Ats.Documents.ApplicationCategories](docs/sdks/applicationcategories/README.md)

* [Get](docs/sdks/applicationcategories/README.md#get) - Get Application Document Category

#### [Ats.Interviews](docs/sdks/atsinterviews/README.md)

* [List](docs/sdks/atsinterviews/README.md#list) - List Interviews

#### [~~Ats.InterviewStages~~](docs/sdks/interviewstages/README.md)

* [~~List~~](docs/sdks/interviewstages/README.md#list) - List Interview Stages :warning: **Deprecated**
* [~~Get~~](docs/sdks/interviewstages/README.md#get) - Get Interview Stage :warning: **Deprecated**

#### [Ats.JobPostings](docs/sdks/jobpostings/README.md)

* [Get](docs/sdks/jobpostings/README.md#get) - Get Job Posting

#### [Ats.Jobs](docs/sdks/atsjobs/README.md)

* [Get](docs/sdks/atsjobs/README.md#get) - Get Job

#### [Ats.Lists](docs/sdks/atslists/README.md)

* [List](docs/sdks/atslists/README.md#list) - Get all Lists
* [Get](docs/sdks/atslists/README.md#get) - Get List

#### [Ats.Locations](docs/sdks/atslocations/README.md)

* [List](docs/sdks/atslocations/README.md#list) - List locations
* [Get](docs/sdks/atslocations/README.md#get) - Get Location

#### [Ats.Offers](docs/sdks/offers/README.md)

* [List](docs/sdks/offers/README.md#list) - List Offers
* [Create](docs/sdks/offers/README.md#create) - Create Offer
* [Get](docs/sdks/offers/README.md#get) - Get Offer

#### [Ats.RejectedReasons](docs/sdks/rejectedreasons/README.md)

* [List](docs/sdks/rejectedreasons/README.md#list) - List Rejected Reasons
* [Get](docs/sdks/rejectedreasons/README.md#get) - Get Rejected Reason

#### [Ats.Users](docs/sdks/atsusers/README.md)

* [List](docs/sdks/atsusers/README.md#list) - List Users

### [BackgroundChecks](docs/sdks/backgroundchecks/README.md)

* [DeletePackage](docs/sdks/backgroundchecks/README.md#deletepackage) - Delete Background Check Package

### [Connectors](docs/sdks/connectors/README.md)

* [ListMeta](docs/sdks/connectors/README.md#listmeta) - List Connector Meta Information
* [GetMeta](docs/sdks/connectors/README.md#getmeta) - Get Connector Meta Information

### [ConnectSessions](docs/sdks/connectsessions/README.md)

* [Create](docs/sdks/connectsessions/README.md#create) - Create Connect Session
* [Authenticate](docs/sdks/connectsessions/README.md#authenticate) - Authenticate Connect Session

### [Courses](docs/sdks/courses/README.md)

* [List](docs/sdks/courses/README.md#list) - List Courses

### [Crm](docs/sdks/crm/README.md)

* [GetContact](docs/sdks/crm/README.md#getcontact) - Get Contact
* [UpdateContact](docs/sdks/crm/README.md#updatecontact) - Update Contact (early access)
* [ListAccounts](docs/sdks/crm/README.md#listaccounts) - List Accounts
* [GetAccount](docs/sdks/crm/README.md#getaccount) - Get Account

#### [Crm.Contacts](docs/sdks/contacts/README.md)

* [List](docs/sdks/contacts/README.md#list) - List Contacts
* [Create](docs/sdks/contacts/README.md#create) - Create Contact

#### [Crm.CustomFieldDefinitions.Contacts](docs/sdks/customfielddefinitionscontacts/README.md)

* [List](docs/sdks/customfielddefinitionscontacts/README.md#list) - List Contact Custom Field Definitions
* [Get](docs/sdks/customfielddefinitionscontacts/README.md#get) - Get Contact Custom Field Definition

#### [Crm.Lists](docs/sdks/crmlists/README.md)

* [List](docs/sdks/crmlists/README.md#list) - Get all Lists
* [Get](docs/sdks/crmlists/README.md#get) - Get List

### [Documents](docs/sdks/documents/README.md)

* [ListApplicationCategories](docs/sdks/documents/README.md#listapplicationcategories) - List Application Document Categories
* [UploadFile](docs/sdks/documents/README.md#uploadfile) - Upload File

#### [Documents.Drives](docs/sdks/documentsdrives/README.md)

* [List](docs/sdks/documentsdrives/README.md#list) - List Drives

#### [Documents.Files](docs/sdks/files/README.md)

* [Download](docs/sdks/files/README.md#download) - Download File
* [List](docs/sdks/files/README.md#list) - List Files
* [Get](docs/sdks/files/README.md#get) - Get File

#### [Documents.Folders](docs/sdks/folders/README.md)

* [List](docs/sdks/folders/README.md#list) - List Folders
* [Get](docs/sdks/folders/README.md#get) - Get Folder

### [Drives](docs/sdks/drives/README.md)

* [Get](docs/sdks/drives/README.md#get) - Get Drive

### [Hris](docs/sdks/hris/README.md)

* [GetCompanies](docs/sdks/hris/README.md#getcompanies) - List Companies
* [GetCompany](docs/sdks/hris/README.md#getcompany) - Get Company
* [GetEmployeeCustomFieldDefinition](docs/sdks/hris/README.md#getemployeecustomfielddefinition) - Get employee Custom Field Definition
* [GetEmployee](docs/sdks/hris/README.md#getemployee) - Get Employee
* [ListEmployeeShifts](docs/sdks/hris/README.md#listemployeeshifts) - List Employee Shifts
* [GetEmployeeShift](docs/sdks/hris/README.md#getemployeeshift) - Get Employee Shift
* [ListEmployeeTimeOffRequests](docs/sdks/hris/README.md#listemployeetimeoffrequests) - List Employee Time Off Requests
* [GetEmployeeTimeOffRequest](docs/sdks/hris/README.md#getemployeetimeoffrequest) - Get Employees Time Off Request
* [CancelEmployeeTimeOff](docs/sdks/hris/README.md#cancelemployeetimeoff) - Cancel Employee Time Off Request
* [UpdateEmployeeTimeOffRequest](docs/sdks/hris/README.md#updateemployeetimeoffrequest) - Update Employee Time Off Request
* [UploadEmployeeDocument](docs/sdks/hris/README.md#uploademployeedocument) - Upload Employee Document
* [ListEmployeeDocuments](docs/sdks/hris/README.md#listemployeedocuments) - List Employee Documents
* [GetEmployeeDocument](docs/sdks/hris/README.md#getemployeedocument) - Get Employee Document
* [ListEmployeeTimeOffBalances](docs/sdks/hris/README.md#listemployeetimeoffbalances) - List Employee Time Off Balances
* [GetEmployeeTimeOffBalance](docs/sdks/hris/README.md#getemployeetimeoffbalance) - Get Employee Time Off Balance
* [GetEmployment](docs/sdks/hris/README.md#getemployment) - Get Employment
* [GetGroup](docs/sdks/hris/README.md#getgroup) - Get Group
* [GetTeamGroup](docs/sdks/hris/README.md#getteamgroup) - Get Team Group
* [GetLocation](docs/sdks/hris/README.md#getlocation) - Get Work Location
* [ListPositions](docs/sdks/hris/README.md#listpositions) - List Positions
* [GetPosition](docs/sdks/hris/README.md#getposition) - Get Position
* [ListTimeEntries](docs/sdks/hris/README.md#listtimeentries) - List Time Entries
* [GetTimeEntry](docs/sdks/hris/README.md#gettimeentry) - Get Time Entry
* [GetTimeOffRequest](docs/sdks/hris/README.md#gettimeoffrequest) - Get time off request
* [ListShifts](docs/sdks/hris/README.md#listshifts) - List Shifts
* [~~ListTimeOffTypes~~](docs/sdks/hris/README.md#listtimeofftypes) - List time off types :warning: **Deprecated**
* [ListTimeOffPolicies](docs/sdks/hris/README.md#listtimeoffpolicies) - List Time Off Policies
* [GetTimeOffPolicy](docs/sdks/hris/README.md#gettimeoffpolicy) - Get Time Off Policy
* [ListBenefits](docs/sdks/hris/README.md#listbenefits) - List benefits
* [CreateEmployeeSkill](docs/sdks/hris/README.md#createemployeeskill) - Create Employee Skill
* [GetEmployeeTask](docs/sdks/hris/README.md#getemployeetask) - Get Employee Task
* [GetTask](docs/sdks/hris/README.md#gettask) - Get Task

#### [Hris.Benefits](docs/sdks/benefits/README.md)

* [Get](docs/sdks/benefits/README.md#get) - Get Benefit

#### [Hris.Companies](docs/sdks/companies/README.md)

* [Get](docs/sdks/companies/README.md#get) - Get Company Group

#### [Hris.Departments](docs/sdks/hrisdepartments/README.md)

* [Get](docs/sdks/hrisdepartments/README.md#get) - Get Department Group

#### [Hris.Documents.EmployeeCategories](docs/sdks/employeecategories/README.md)

* [List](docs/sdks/employeecategories/README.md#list) - List Employee Document Categories
* [Get](docs/sdks/employeecategories/README.md#get) - Get Employee Document Category

#### [Hris.Employees](docs/sdks/employees/README.md)

* [ListCustomFieldDefinitions](docs/sdks/employees/README.md#listcustomfielddefinitions) - List employee Custom Field Definitions
* [List](docs/sdks/employees/README.md#list) - List Employees
* [Create](docs/sdks/employees/README.md#create) - Create Employee
* [Update](docs/sdks/employees/README.md#update) - Update Employee
* [Invite](docs/sdks/employees/README.md#invite) - Invite Employee
* [CreateTimeOff](docs/sdks/employees/README.md#createtimeoff) - Create Employee Time Off Request
* [BatchUploadDocument](docs/sdks/employees/README.md#batchuploaddocument) - Batch Upload Employee Document
* [WorkEligibilityList](docs/sdks/employees/README.md#workeligibilitylist) - List Employee Work Eligibility
* [CreateWorkEligibilityRequest](docs/sdks/employees/README.md#createworkeligibilityrequest) - Create Employee Work Eligibility Request
* [GetWorkEligibility](docs/sdks/employees/README.md#getworkeligibility) - Get Employees Work Eligibility
* [CreateEmployment](docs/sdks/employees/README.md#createemployment) - Create Employee Employment
* [GetEmployment](docs/sdks/employees/README.md#getemployment) - Get Employee Employment
* [ListTimeOffPolicies](docs/sdks/employees/README.md#listtimeoffpolicies) - List Assigned Time Off Policies
* [GetSkill](docs/sdks/employees/README.md#getskill) - Get Employee Skill

#### [Hris.Employees.Documents](docs/sdks/employeesdocuments/README.md)

* [Download](docs/sdks/employeesdocuments/README.md#download) - Download Employee Document

#### [Hris.Employees.Employments](docs/sdks/employeesemployments/README.md)

* [List](docs/sdks/employeesemployments/README.md#list) - List Employee Employments
* [Update](docs/sdks/employeesemployments/README.md#update) - Update Employee Employment

#### [Hris.Employees.Skills](docs/sdks/employeesskills/README.md)

* [List](docs/sdks/employeesskills/README.md#list) - List Employee Skills

#### [Hris.Employees.Tasks](docs/sdks/employeestasks/README.md)

* [List](docs/sdks/employeestasks/README.md#list) - List Employee Tasks
* [Complete](docs/sdks/employeestasks/README.md#complete) - Update Employee Task

#### [Hris.Employees.WorkEligibility](docs/sdks/workeligibility/README.md)

* [UpdateRequest](docs/sdks/workeligibility/README.md#updaterequest) - Update Employee Work Eligibility Request

#### [Hris.Employments](docs/sdks/employments/README.md)

* [List](docs/sdks/employments/README.md#list) - List Employments

#### [Hris.Groups](docs/sdks/hrisgroups/README.md)

* [List](docs/sdks/hrisgroups/README.md#list) - List Groups
* [ListDepartments](docs/sdks/hrisgroups/README.md#listdepartments) - List Department Groups
* [ListCostCenters](docs/sdks/hrisgroups/README.md#listcostcenters) - List Cost Center Groups
* [ListTeams](docs/sdks/hrisgroups/README.md#listteams) - List Team Groups
* [ListDivisions](docs/sdks/hrisgroups/README.md#listdivisions) - List Division Groups

#### [Hris.Groups.Companies](docs/sdks/groupscompanies/README.md)

* [List](docs/sdks/groupscompanies/README.md#list) - List Companies Groups

#### [Hris.Groups.CostCenters](docs/sdks/costcenters/README.md)

* [Get](docs/sdks/costcenters/README.md#get) - Get Cost Center Group

#### [Hris.Groups.Divisions](docs/sdks/divisions/README.md)

* [Get](docs/sdks/divisions/README.md#get) - Get Division Group

#### [Hris.Jobs](docs/sdks/hrisjobs/README.md)

* [List](docs/sdks/hrisjobs/README.md#list) - List Jobs
* [Get](docs/sdks/hrisjobs/README.md#get) - Get Job

#### [Hris.Locations](docs/sdks/hrislocations/README.md)

* [List](docs/sdks/hrislocations/README.md#list) - List Work Locations

#### [Hris.Shifts](docs/sdks/shifts/README.md)

* [Get](docs/sdks/shifts/README.md#get) - Get Shift

#### [Hris.Tasks](docs/sdks/tasks/README.md)

* [List](docs/sdks/tasks/README.md#list) - List Tasks

#### [Hris.TimeOff](docs/sdks/timeoff/README.md)

* [List](docs/sdks/timeoff/README.md#list) - List time off requests

#### [~~Hris.TimeOffTypes~~](docs/sdks/timeofftypes/README.md)

* [~~Get~~](docs/sdks/timeofftypes/README.md#get) - Get time off type :warning: **Deprecated**

### [Iam](docs/sdks/iam/README.md)

* [DeleteUser](docs/sdks/iam/README.md#deleteuser) - Delete User
* [ListRoles](docs/sdks/iam/README.md#listroles) - List Roles
* [GetRole](docs/sdks/iam/README.md#getrole) - Get Role
* [GetGroup](docs/sdks/iam/README.md#getgroup) - Get Group
* [ListPolicies](docs/sdks/iam/README.md#listpolicies) - List Policies

#### [Iam.Groups](docs/sdks/iamgroups/README.md)

* [List](docs/sdks/iamgroups/README.md#list) - List Groups

#### [Iam.Policies](docs/sdks/policies/README.md)

* [Get](docs/sdks/policies/README.md#get) - Get Policy

#### [Iam.Users](docs/sdks/iamusers/README.md)

* [List](docs/sdks/iamusers/README.md#list) - List Users
* [Get](docs/sdks/iamusers/README.md#get) - Get User
* [Update](docs/sdks/iamusers/README.md#update) - Update User

### [Interviews](docs/sdks/interviews/README.md)

* [Get](docs/sdks/interviews/README.md#get) - Get Interview

### [Lms](docs/sdks/lms/README.md)

* [GetCourse](docs/sdks/lms/README.md#getcourse) - Get Course
* [ListUserAssignments](docs/sdks/lms/README.md#listuserassignments) - List User Assignments
* [BatchUpsertContent](docs/sdks/lms/README.md#batchupsertcontent) - Batch Upsert Content
* [ListContent](docs/sdks/lms/README.md#listcontent) - List Content
* [CreateUserCompletion](docs/sdks/lms/README.md#createusercompletion) - Create User Completion
* [GetUserCompletion](docs/sdks/lms/README.md#getusercompletion) - Get User Completion
* [DeleteUserCompletion](docs/sdks/lms/README.md#deleteusercompletion) - Delete User Completion
* [GetCategory](docs/sdks/lms/README.md#getcategory) - Get Category
* [ListUsers](docs/sdks/lms/README.md#listusers) - List Users
* [GetUser](docs/sdks/lms/README.md#getuser) - Get User
* [ListSkills](docs/sdks/lms/README.md#listskills) - List Skills

#### [Lms.Assignments](docs/sdks/assignments/README.md)

* [Create](docs/sdks/assignments/README.md#create) - Create User Assignment
* [List](docs/sdks/assignments/README.md#list) - List Assignments
* [Get](docs/sdks/assignments/README.md#get) - Get Assignment

#### [Lms.Categories](docs/sdks/categories/README.md)

* [List](docs/sdks/categories/README.md#list) - List Categories

#### [Lms.Completions](docs/sdks/completions/README.md)

* [List](docs/sdks/completions/README.md#list) - List Completions
* [Get](docs/sdks/completions/README.md#get) - Get Completion

#### [Lms.Content](docs/sdks/content/README.md)

* [Upsert](docs/sdks/content/README.md#upsert) - Upsert Content
* [Get](docs/sdks/content/README.md#get) - Get Content
* [Update](docs/sdks/content/README.md#update) - Update Content

#### [Lms.Skills](docs/sdks/lmsskills/README.md)

* [Get](docs/sdks/lmsskills/README.md#get) - Get Skill

#### [Lms.Users](docs/sdks/lmsusers/README.md)

* [ListCompletions](docs/sdks/lmsusers/README.md#listcompletions) - List User Completions

#### [Lms.UsersAssignments](docs/sdks/usersassignments/README.md)

* [Get](docs/sdks/usersassignments/README.md#get) - Get User Assignment

### [Marketing](docs/sdks/marketing/README.md)

* [TemplatesListEmail](docs/sdks/marketing/README.md#templateslistemail) - List Email Templates
* [CreateEmailTemplate](docs/sdks/marketing/README.md#createemailtemplate) - Create Email Templates
* [GetEmailTemplate](docs/sdks/marketing/README.md#getemailtemplate) - Get Email Templates
* [UpdateEmailTemplate](docs/sdks/marketing/README.md#updateemailtemplate) - Update Email Templates
* [TemplatesListInApp](docs/sdks/marketing/README.md#templateslistinapp) - List In-App Templates
* [CreateInAppTemplate](docs/sdks/marketing/README.md#createinapptemplate) - Create In-App Template
* [ListSmsTemplates](docs/sdks/marketing/README.md#listsmstemplates) - List SMS Templates
* [CreateSmsTemplate](docs/sdks/marketing/README.md#createsmstemplate) - Create SMS Template
* [UpdateSmsTemplate](docs/sdks/marketing/README.md#updatesmstemplate) - Update SMS Template
* [~~ListOmniChannelTemplates~~](docs/sdks/marketing/README.md#listomnichanneltemplates) - List Omni-Channel Templates :warning: **Deprecated**
* [~~GetOmniChannelTemplate~~](docs/sdks/marketing/README.md#getomnichanneltemplate) - Get Omni-Channel Template :warning: **Deprecated**
* [~~UpdateOmniChannelTemplate~~](docs/sdks/marketing/README.md#updateomnichanneltemplate) - Update Omni-Channel Template :warning: **Deprecated**
* [TemplatesListPush](docs/sdks/marketing/README.md#templateslistpush) - List Push Templates
* [UpdatePushTemplate](docs/sdks/marketing/README.md#updatepushtemplate) - Update Push Template
* [ListContentBlocks](docs/sdks/marketing/README.md#listcontentblocks) - List Content Blocks
* [CreateContentBlock](docs/sdks/marketing/README.md#createcontentblock) - Create Content Block
* [GetContentBlock](docs/sdks/marketing/README.md#getcontentblock) - Get Content Blocks

#### [Marketing.Campaigns](docs/sdks/campaigns/README.md)

* [List](docs/sdks/campaigns/README.md#list) - List campaigns
* [Get](docs/sdks/campaigns/README.md#get) - Get campaign

#### [Marketing.ContentBlocks](docs/sdks/contentblocks/README.md)

* [Update](docs/sdks/contentblocks/README.md#update) - Update Content Block

#### [Marketing.Templates](docs/sdks/templates/README.md)

* [~~CreateOmniChannel~~](docs/sdks/templates/README.md#createomnichannel) - Create Omni-Channel Template :warning: **Deprecated**
* [CreatePush](docs/sdks/templates/README.md#createpush) - Create Push Template
* [GetPush](docs/sdks/templates/README.md#getpush) - Get Push Template

#### [Marketing.Templates.InApp](docs/sdks/inapp/README.md)

* [Get](docs/sdks/inapp/README.md#get) - Get In-App Template
* [Update](docs/sdks/inapp/README.md#update) - Update In-App Template

#### [Marketing.Templates.Sms](docs/sdks/sms/README.md)

* [Get](docs/sdks/sms/README.md#get) - Get SMS Template

### [Mcp](docs/sdks/mcp/README.md)

* [McpGet](docs/sdks/mcp/README.md#mcpget) - Open MCP SSE stream
* [McpPost](docs/sdks/mcp/README.md#mcppost) - Send MCP JSON-RPC message
* [McpDelete](docs/sdks/mcp/README.md#mcpdelete) - Delete MCP session

### [Messaging](docs/sdks/messaging/README.md)

* [ListConversations](docs/sdks/messaging/README.md#listconversations) - List Conversations
* [CreateConversation](docs/sdks/messaging/README.md#createconversation) - Create Conversation
* [GetConversation](docs/sdks/messaging/README.md#getconversation) - Get Conversation
* [DownloadMessagingAttachment](docs/sdks/messaging/README.md#downloadmessagingattachment) - Download Attachment
* [ListAttachments](docs/sdks/messaging/README.md#listattachments) - List Attachments
* [GetAttachment](docs/sdks/messaging/README.md#getattachment) - Get Attachment
* [ListUsers](docs/sdks/messaging/README.md#listusers) - List Users
* [GetUser](docs/sdks/messaging/README.md#getuser) - Get User
* [ListConversationMessages](docs/sdks/messaging/README.md#listconversationmessages) - List Conversation Messages
* [GetMessage](docs/sdks/messaging/README.md#getmessage) - Get Message
* [SendMessage](docs/sdks/messaging/README.md#sendmessage) - Send Message

### [Proxy](docs/sdks/proxy/README.md)

* [Perform](docs/sdks/proxy/README.md#perform) - Proxy Request

### [RequestLogs](docs/sdks/requestlogs/README.md)

* [ListSteps](docs/sdks/requestlogs/README.md#liststeps) - List Step Logs
* [Get](docs/sdks/requestlogs/README.md#get) - Get Log
* [List](docs/sdks/requestlogs/README.md#list) - List Logs
* [ListPlatformLogs](docs/sdks/requestlogs/README.md#listplatformlogs) - List Platform Logs

### [Ticketing](docs/sdks/ticketing/README.md)

* [GetUser](docs/sdks/ticketing/README.md#getuser) - Get User
* [DownloadAttachment](docs/sdks/ticketing/README.md#downloadattachment) - Download Attachment
* [ListTicketTypes](docs/sdks/ticketing/README.md#listtickettypes) - List Ticket Types
* [GetTicketType](docs/sdks/ticketing/README.md#gettickettype) - Get Ticket Type
* [ListProjects](docs/sdks/ticketing/README.md#listprojects) - List Projects
* [GetProject](docs/sdks/ticketing/README.md#getproject) - Get Project
* [ListProjectComponents](docs/sdks/ticketing/README.md#listprojectcomponents) - List Project Components
* [GetProjectComponent](docs/sdks/ticketing/README.md#getprojectcomponent) - Get Project Component
* [ListProjectTicketTypes](docs/sdks/ticketing/README.md#listprojecttickettypes) - List Project Ticket Types

#### [Ticketing.Comments](docs/sdks/comments/README.md)

* [Get](docs/sdks/comments/README.md#get) - Get Comment

#### [Ticketing.Tickets](docs/sdks/tickets/README.md)

* [List](docs/sdks/tickets/README.md#list) - List Tickets
* [Create](docs/sdks/tickets/README.md#create) - Create Ticket
* [Get](docs/sdks/tickets/README.md#get) - Get Ticket
* [Update](docs/sdks/tickets/README.md#update) - Update Ticket
* [ListAttachments](docs/sdks/tickets/README.md#listattachments) - List Attachments
* [ListStatuses](docs/sdks/tickets/README.md#liststatuses) - List Ticket Statuses

#### [Ticketing.Tickets.Attachments](docs/sdks/attachments/README.md)

* [Get](docs/sdks/attachments/README.md#get) - Get Attachment

#### [Ticketing.Tickets.Comments](docs/sdks/ticketscomments/README.md)

* [List](docs/sdks/ticketscomments/README.md#list) - List Comments

#### [Ticketing.Users](docs/sdks/ticketingusers/README.md)

* [List](docs/sdks/ticketingusers/README.md#list) - List Users

</details>
<!-- End Available Resources and Operations [operations] -->

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

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=stack-one-client&utm_campaign=csharp)
