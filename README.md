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

Documents: The documentation for the StackOne Unified API - DOCUMENTS
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

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/StackOne/Client/StackOne.Client.csproj
```
<!-- End SDK Installation [installation] -->

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

HrisListEmployeesResponse? res = await sdk.Hris.ListEmployeesAsync(req);

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

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Accounts](docs/sdks/accounts/README.md)

* [List](docs/sdks/accounts/README.md#list) - List Accounts
* [Get](docs/sdks/accounts/README.md#get) - Get Account
* [Delete](docs/sdks/accounts/README.md#delete) - Delete Account
* [Update](docs/sdks/accounts/README.md#update) - Update Account
* [GetMeta](docs/sdks/accounts/README.md#getmeta) - Get meta information of the account

### [Ats](docs/sdks/ats/README.md)

* [ListApplications](docs/sdks/ats/README.md#listapplications) - List Applications
* [CreateApplication](docs/sdks/ats/README.md#createapplication) - Create Application
* [GetApplication](docs/sdks/ats/README.md#getapplication) - Get Application
* [UpdateApplication](docs/sdks/ats/README.md#updateapplication) - Update an Application
* [ListApplicationsOffers](docs/sdks/ats/README.md#listapplicationsoffers) - List Application Offers
* [MoveApplication](docs/sdks/ats/README.md#moveapplication) - Move Application
* [RejectApplication](docs/sdks/ats/README.md#rejectapplication) - Reject Application
* [GetApplicationOffer](docs/sdks/ats/README.md#getapplicationoffer) - Get Application Offer
* [ListApplicationScorecards](docs/sdks/ats/README.md#listapplicationscorecards) - List Application Scorecards
* [GetApplicationScorecard](docs/sdks/ats/README.md#getapplicationscorecard) - Get Application Scorecard
* [ListApplicationChanges](docs/sdks/ats/README.md#listapplicationchanges) - List Application Changes
* [ListApplicationNotes](docs/sdks/ats/README.md#listapplicationnotes) - List Application Notes
* [CreateApplicationNote](docs/sdks/ats/README.md#createapplicationnote) - Create Application Note
* [GetApplicationNote](docs/sdks/ats/README.md#getapplicationnote) - Get Application Note
* [UpdateApplicationNote](docs/sdks/ats/README.md#updateapplicationnote) - Update an Application Note
* [ListApplicationsScheduledInterviews](docs/sdks/ats/README.md#listapplicationsscheduledinterviews) - List Applications scheduled interviews
* [GetApplicationScheduledInterview](docs/sdks/ats/README.md#getapplicationscheduledinterview) - Get Applications scheduled interview
* [UploadApplicationDocument](docs/sdks/ats/README.md#uploadapplicationdocument) - Upload Application Document
* [DownloadApplicationDocument](docs/sdks/ats/README.md#downloadapplicationdocument) - Download Application Document
* [ListApplicationDocuments](docs/sdks/ats/README.md#listapplicationdocuments) - List Application Documents
* [GetApplicationDocument](docs/sdks/ats/README.md#getapplicationdocument) - Get Application Document
* [ListCandidates](docs/sdks/ats/README.md#listcandidates) - List Candidates
* [CreateCandidate](docs/sdks/ats/README.md#createcandidate) - Create Candidate
* [GetCandidate](docs/sdks/ats/README.md#getcandidate) - Get Candidate
* [UpdateCandidate](docs/sdks/ats/README.md#updatecandidate) - Update Candidate
* [ListCandidateNotes](docs/sdks/ats/README.md#listcandidatenotes) - List Candidate Notes
* [CreateCandidateNote](docs/sdks/ats/README.md#createcandidatenote) - Create Candidate Note
* [GetCandidateNote](docs/sdks/ats/README.md#getcandidatenote) - Get Candidate Note
* [ListApplicationCustomFieldDefinitions](docs/sdks/ats/README.md#listapplicationcustomfielddefinitions) - List Application Custom Field Definitions
* [GetApplicationCustomFieldDefinition](docs/sdks/ats/README.md#getapplicationcustomfielddefinition) - Get Application Custom Field Definition
* [ListCandidateCustomFieldDefinitions](docs/sdks/ats/README.md#listcandidatecustomfielddefinitions) - List Candidate Custom Field Definitions
* [GetCandidateCustomFieldDefinition](docs/sdks/ats/README.md#getcandidatecustomfielddefinition) - Get Candidate Custom Field Definition
* [ListJobCustomFieldDefinitions](docs/sdks/ats/README.md#listjobcustomfielddefinitions) - List Job Custom Field Definitions
* [GetJobCustomFieldDefinition](docs/sdks/ats/README.md#getjobcustomfielddefinition) - Get Job Custom Field Definition
* [ListDepartments](docs/sdks/ats/README.md#listdepartments) - List Departments
* [GetDepartment](docs/sdks/ats/README.md#getdepartment) - Get Department
* [ListInterviewStages](docs/sdks/ats/README.md#listinterviewstages) - List Interview Stages
* [GetInterviewStage](docs/sdks/ats/README.md#getinterviewstage) - Get Interview Stage
* [ListInterviews](docs/sdks/ats/README.md#listinterviews) - List Interviews
* [GetInterview](docs/sdks/ats/README.md#getinterview) - Get Interview
* [ListJobs](docs/sdks/ats/README.md#listjobs) - List Jobs
* [CreateJob](docs/sdks/ats/README.md#createjob) - Create Job
* [GetJob](docs/sdks/ats/README.md#getjob) - Get Job
* [UpdateJob](docs/sdks/ats/README.md#updatejob) - Update Job
* [ListLists](docs/sdks/ats/README.md#listlists) - Get all Lists
* [GetList](docs/sdks/ats/README.md#getlist) - Get List
* [ListLocations](docs/sdks/ats/README.md#listlocations) - List locations
* [GetLocation](docs/sdks/ats/README.md#getlocation) - Get Location
* [ListRejectedReasons](docs/sdks/ats/README.md#listrejectedreasons) - List Rejected Reasons
* [GetRejectedReason](docs/sdks/ats/README.md#getrejectedreason) - Get Rejected Reason
* [ListUsers](docs/sdks/ats/README.md#listusers) - List Users
* [GetUser](docs/sdks/ats/README.md#getuser) - Get User
* [ListJobPostings](docs/sdks/ats/README.md#listjobpostings) - List Job Postings
* [GetJobPosting](docs/sdks/ats/README.md#getjobposting) - Get Job Posting
* [ListOffers](docs/sdks/ats/README.md#listoffers) - List Offers
* [CreateOffer](docs/sdks/ats/README.md#createoffer) - Creates an offer
* [GetOffer](docs/sdks/ats/README.md#getoffer) - Get Offer
* [ListAssessmentsPackages](docs/sdks/ats/README.md#listassessmentspackages) - List Assessments Packages
* [GetAssessmentsPackage](docs/sdks/ats/README.md#getassessmentspackage) - Get Assessments Package
* [OrderAssessmentsRequest](docs/sdks/ats/README.md#orderassessmentsrequest) - Order Assessments Request
* [UpdateAssessmentsResult](docs/sdks/ats/README.md#updateassessmentsresult) - Update Assessments Result
* [GetAssessmentsResult](docs/sdks/ats/README.md#getassessmentsresult) - Get Assessments Results
* [ListBackgroundCheckPackages](docs/sdks/ats/README.md#listbackgroundcheckpackages) - List Background Check Packages
* [CreateBackgroundCheckPackage](docs/sdks/ats/README.md#createbackgroundcheckpackage) - Create Background Check Package
* [GetBackgroundCheckPackage](docs/sdks/ats/README.md#getbackgroundcheckpackage) - Get Background Check Package
* [DeleteBackgroundCheckPackage](docs/sdks/ats/README.md#deletebackgroundcheckpackage) - Delete Background Check Package
* [UpdateBackgroundCheckPackage](docs/sdks/ats/README.md#updatebackgroundcheckpackage) - Update Background Check Package
* [OrderBackgroundCheckRequest](docs/sdks/ats/README.md#orderbackgroundcheckrequest) - Order Background Check Request
* [UpdateBackgroundCheckResult](docs/sdks/ats/README.md#updatebackgroundcheckresult) - Update Background Check Result
* [GetBackgroundCheckResult](docs/sdks/ats/README.md#getbackgroundcheckresult) - Get Background Check Results
* [ListApplicationDocumentCategories](docs/sdks/ats/README.md#listapplicationdocumentcategories) - List Application Document Categories
* [GetApplicationDocumentCategory](docs/sdks/ats/README.md#getapplicationdocumentcategory) - Get Application Document Category

### [Connectors](docs/sdks/connectors/README.md)

* [ListMeta](docs/sdks/connectors/README.md#listmeta) - List Connectors Meta Information for all providers
* [GetMeta](docs/sdks/connectors/README.md#getmeta) - Get Connector Meta information for the given provider key

### [ConnectSessions](docs/sdks/connectsessions/README.md)

* [Create](docs/sdks/connectsessions/README.md#create) - Create Connect Session
* [Authenticate](docs/sdks/connectsessions/README.md#authenticate) - Authenticate Connect Session

### [Crm](docs/sdks/crm/README.md)

* [ListContacts](docs/sdks/crm/README.md#listcontacts) - List Contacts
* [CreateContact](docs/sdks/crm/README.md#createcontact) - Creates a new Contact
* [GetContact](docs/sdks/crm/README.md#getcontact) - Get Contact
* [UpdateContact](docs/sdks/crm/README.md#updatecontact) - Update Contact (early access)
* [ListAccounts](docs/sdks/crm/README.md#listaccounts) - List Accounts
* [GetAccount](docs/sdks/crm/README.md#getaccount) - Get Account
* [ListLists](docs/sdks/crm/README.md#listlists) - Get all Lists
* [GetList](docs/sdks/crm/README.md#getlist) - Get List
* [ListContactCustomFieldDefinitions](docs/sdks/crm/README.md#listcontactcustomfielddefinitions) - List Contact Custom Field Definitions
* [GetContactCustomFieldDefinition](docs/sdks/crm/README.md#getcontactcustomfielddefinition) - Get Contact Custom Field Definition

### [Documents](docs/sdks/documents/README.md)

* [DownloadFile](docs/sdks/documents/README.md#downloadfile) - Download File
* [UploadFile](docs/sdks/documents/README.md#uploadfile) - Upload File
* [ListFiles](docs/sdks/documents/README.md#listfiles) - List Files
* [GetFile](docs/sdks/documents/README.md#getfile) - Get File
* [ListFolders](docs/sdks/documents/README.md#listfolders) - List Folders
* [GetFolder](docs/sdks/documents/README.md#getfolder) - Get Folder
* [ListDrives](docs/sdks/documents/README.md#listdrives) - List Drives
* [GetDrive](docs/sdks/documents/README.md#getdrive) - Get Drive

### [Hris](docs/sdks/hris/README.md)

* [ListCompanies](docs/sdks/hris/README.md#listcompanies) - List Companies
* [GetCompany](docs/sdks/hris/README.md#getcompany) - Get Company
* [ListEmployeeCustomFieldDefinitions](docs/sdks/hris/README.md#listemployeecustomfielddefinitions) - List employee Custom Field Definitions
* [GetEmployeeCustomFieldDefinition](docs/sdks/hris/README.md#getemployeecustomfielddefinition) - Get employee Custom Field Definition
* [ListEmployees](docs/sdks/hris/README.md#listemployees) - List Employees
* [CreateEmployee](docs/sdks/hris/README.md#createemployee) - Creates an employee
* [GetEmployee](docs/sdks/hris/README.md#getemployee) - Get Employee
* [UpdateEmployee](docs/sdks/hris/README.md#updateemployee) - Updates an employee
* [InviteEmployee](docs/sdks/hris/README.md#inviteemployee) - Invite Employee
* [ListEmployeeTimeOffRequests](docs/sdks/hris/README.md#listemployeetimeoffrequests) - List Employee Time Off Requests
* [CreateEmployeeTimeOffRequest](docs/sdks/hris/README.md#createemployeetimeoffrequest) - Create Employee Time Off Request
* [GetEmployeesTimeOffRequest](docs/sdks/hris/README.md#getemployeestimeoffrequest) - Get Employees Time Off Request
* [CancelEmployeeTimeOffRequest](docs/sdks/hris/README.md#cancelemployeetimeoffrequest) - Cancel Employee Time Off Request
* [UpdateEmployeeTimeOffRequest](docs/sdks/hris/README.md#updateemployeetimeoffrequest) - Update Employee Time Off Request
* [BatchUploadEmployeeDocument](docs/sdks/hris/README.md#batchuploademployeedocument) - Batch Upload Employee Document
* [UploadEmployeeDocument](docs/sdks/hris/README.md#uploademployeedocument) - Upload Employee Document
* [DownloadEmployeeDocument](docs/sdks/hris/README.md#downloademployeedocument) - Download Employee Document
* [ListEmployeeDocuments](docs/sdks/hris/README.md#listemployeedocuments) - List Employee Documents
* [GetEmployeeDocument](docs/sdks/hris/README.md#getemployeedocument) - Get Employee Document
* [ListEmployeeCategories](docs/sdks/hris/README.md#listemployeecategories) - List Employee Document Categories
* [GetEmployeeDocumentCategory](docs/sdks/hris/README.md#getemployeedocumentcategory) - Get Employee Document Category
* [ListEmployeeWorkEligibility](docs/sdks/hris/README.md#listemployeeworkeligibility) - List Employee Work Eligibility
* [CreateEmployeeWorkEligibilityRequest](docs/sdks/hris/README.md#createemployeeworkeligibilityrequest) - Create Employee Work Eligibility Request
* [GetEmployeesWorkEligibility](docs/sdks/hris/README.md#getemployeesworkeligibility) - Get Employees Work Eligibility
* [UpdateEmployeeWorkEligibilityRequest](docs/sdks/hris/README.md#updateemployeeworkeligibilityrequest) - Update Employee Work Eligibility Request
* [ListEmployeeTimeOffBalances](docs/sdks/hris/README.md#listemployeetimeoffbalances) - List Employee Time Off Balances
* [GetEmployeeTimeOffBalance](docs/sdks/hris/README.md#getemployeetimeoffbalance) - Get Employee Time Off Balance
* [ListEmployments](docs/sdks/hris/README.md#listemployments) - List Employments
* [GetEmployment](docs/sdks/hris/README.md#getemployment) - Get Employment
* [ListEmployeeEmployments](docs/sdks/hris/README.md#listemployeeemployments) - List Employee Employments
* [CreateEmployeeEmployment](docs/sdks/hris/README.md#createemployeeemployment) - Create Employee Employment
* [GetEmployeeEmployment](docs/sdks/hris/README.md#getemployeeemployment) - Get Employee Employment
* [UpdateEmployeeEmployment](docs/sdks/hris/README.md#updateemployeeemployment) - Update Employee Employment
* [ListGroups](docs/sdks/hris/README.md#listgroups) - List Groups
* [ListDepartmentGroups](docs/sdks/hris/README.md#listdepartmentgroups) - List Department Groups
* [ListCostCenterGroups](docs/sdks/hris/README.md#listcostcentergroups) - List Cost Center Groups
* [ListTeamGroups](docs/sdks/hris/README.md#listteamgroups) - List Team Groups
* [ListDivisionGroups](docs/sdks/hris/README.md#listdivisiongroups) - List Division Groups
* [ListCompaniesGroups](docs/sdks/hris/README.md#listcompaniesgroups) - List Companies Groups
* [GetGroup](docs/sdks/hris/README.md#getgroup) - Get Group
* [GetDepartmentGroup](docs/sdks/hris/README.md#getdepartmentgroup) - Get Department Group
* [GetCostCenterGroup](docs/sdks/hris/README.md#getcostcentergroup) - Get Cost Center Group
* [GetTeamGroup](docs/sdks/hris/README.md#getteamgroup) - Get Team Group
* [GetDivisionGroup](docs/sdks/hris/README.md#getdivisiongroup) - Get Division Group
* [GetCompanyGroup](docs/sdks/hris/README.md#getcompanygroup) - Get Company Group
* [ListJobs](docs/sdks/hris/README.md#listjobs) - List Jobs
* [GetJob](docs/sdks/hris/README.md#getjob) - Get Job
* [ListLocations](docs/sdks/hris/README.md#listlocations) - List Work Locations
* [GetLocation](docs/sdks/hris/README.md#getlocation) - Get Work Location
* [ListPositions](docs/sdks/hris/README.md#listpositions) - List Positions
* [GetPosition](docs/sdks/hris/README.md#getposition) - Get Position
* [ListTimeEntries](docs/sdks/hris/README.md#listtimeentries) - List Time Entries
* [GetTimeEntries](docs/sdks/hris/README.md#gettimeentries) - Get Time Entry
* [ListTimeOffRequests](docs/sdks/hris/README.md#listtimeoffrequests) - List time off requests
* [GetTimeOffRequest](docs/sdks/hris/README.md#gettimeoffrequest) - Get time off request
* [ListShifts](docs/sdks/hris/README.md#listshifts) - List Shifts
* [GetShift](docs/sdks/hris/README.md#getshift) - Get Shift
* [~~ListTimeOffTypes~~](docs/sdks/hris/README.md#listtimeofftypes) - List time off types :warning: **Deprecated**
* [~~GetTimeOffType~~](docs/sdks/hris/README.md#gettimeofftype) - Get time off type :warning: **Deprecated**
* [ListTimeOffPolicies](docs/sdks/hris/README.md#listtimeoffpolicies) - List Time Off Policies
* [GetTimeOffPolicy](docs/sdks/hris/README.md#gettimeoffpolicy) - Get Time Off Policy
* [ListEmployeeTimeOffPolicies](docs/sdks/hris/README.md#listemployeetimeoffpolicies) - List Assigned Time Off Policies
* [ListBenefits](docs/sdks/hris/README.md#listbenefits) - List benefits
* [GetBenefit](docs/sdks/hris/README.md#getbenefit) - Get Benefit
* [ListEmployeeSkills](docs/sdks/hris/README.md#listemployeeskills) - List Employee Skills
* [CreateEmployeeSkill](docs/sdks/hris/README.md#createemployeeskill) - Create Employee Skill
* [GetEmployeeSkill](docs/sdks/hris/README.md#getemployeeskill) - Get Employee Skill
* [ListEmployeeTasks](docs/sdks/hris/README.md#listemployeetasks) - List Employee Tasks
* [GetEmployeeTask](docs/sdks/hris/README.md#getemployeetask) - Get Employee Task
* [ListTasks](docs/sdks/hris/README.md#listtasks) - List Tasks
* [GetTask](docs/sdks/hris/README.md#gettask) - Get Task

### [Iam](docs/sdks/iam/README.md)

* [ListUsers](docs/sdks/iam/README.md#listusers) - List Users
* [GetUser](docs/sdks/iam/README.md#getuser) - Get User
* [DeleteUser](docs/sdks/iam/README.md#deleteuser) - Delete User
* [UpdateUser](docs/sdks/iam/README.md#updateuser) - Update User
* [ListRoles](docs/sdks/iam/README.md#listroles) - List Roles
* [GetRole](docs/sdks/iam/README.md#getrole) - Get Role
* [ListGroups](docs/sdks/iam/README.md#listgroups) - List Groups
* [GetGroup](docs/sdks/iam/README.md#getgroup) - Get Group
* [ListPolicies](docs/sdks/iam/README.md#listpolicies) - List Policies
* [GetPolicy](docs/sdks/iam/README.md#getpolicy) - Get Policy

### [Lms](docs/sdks/lms/README.md)

* [ListCourses](docs/sdks/lms/README.md#listcourses) - List Courses
* [GetCourse](docs/sdks/lms/README.md#getcourse) - Get Course
* [ListUserAssignments](docs/sdks/lms/README.md#listuserassignments) - List User Assignments
* [CreateUserAssignment](docs/sdks/lms/README.md#createuserassignment) - Create User Assignment
* [GetUserAssignment](docs/sdks/lms/README.md#getuserassignment) - Get User Assignment
* [BatchUpsertContent](docs/sdks/lms/README.md#batchupsertcontent) - Batch Upsert Content
* [ListContent](docs/sdks/lms/README.md#listcontent) - List Content
* [UpsertContent](docs/sdks/lms/README.md#upsertcontent) - Upsert Content
* [GetContent](docs/sdks/lms/README.md#getcontent) - Get Content
* [UpdateContent](docs/sdks/lms/README.md#updatecontent) - Update Content
* [ListUserCompletions](docs/sdks/lms/README.md#listusercompletions) - List User Completions
* [CreateUserCompletion](docs/sdks/lms/README.md#createusercompletion) - Create User Completion
* [GetUserCompletion](docs/sdks/lms/README.md#getusercompletion) - Get User Completion
* [DeleteUserCompletion](docs/sdks/lms/README.md#deleteusercompletion) - Delete User Completion
* [ListCompletions](docs/sdks/lms/README.md#listcompletions) - List Completions
* [GetCompletion](docs/sdks/lms/README.md#getcompletion) - Get Completion
* [GetCategory](docs/sdks/lms/README.md#getcategory) - Get Category
* [ListCategories](docs/sdks/lms/README.md#listcategories) - List Categories
* [ListUsers](docs/sdks/lms/README.md#listusers) - List Users
* [GetUser](docs/sdks/lms/README.md#getuser) - Get User
* [GetSkill](docs/sdks/lms/README.md#getskill) - Get Skill
* [ListSkills](docs/sdks/lms/README.md#listskills) - List Skills
* [ListAssignments](docs/sdks/lms/README.md#listassignments) - List Assignments
* [GetAssignment](docs/sdks/lms/README.md#getassignment) - Get Assignment

### [Marketing](docs/sdks/marketing/README.md)

* [ListEmailTemplates](docs/sdks/marketing/README.md#listemailtemplates) - List Email Templates
* [CreateEmailTemplate](docs/sdks/marketing/README.md#createemailtemplate) - Create Email Templates
* [GetEmailTemplate](docs/sdks/marketing/README.md#getemailtemplate) - Get Email Templates
* [UpdateEmailTemplate](docs/sdks/marketing/README.md#updateemailtemplate) - Update Email Templates
* [ListInAppTemplates](docs/sdks/marketing/README.md#listinapptemplates) - List In-App Templates
* [CreateInAppTemplate](docs/sdks/marketing/README.md#createinapptemplate) - Create In-App Template
* [GetInAppTemplate](docs/sdks/marketing/README.md#getinapptemplate) - Get In-App Template
* [UpdateInAppTemplate](docs/sdks/marketing/README.md#updateinapptemplate) - Update In-App Template
* [ListSmsTemplates](docs/sdks/marketing/README.md#listsmstemplates) - List SMS Templates
* [CreateSmsTemplate](docs/sdks/marketing/README.md#createsmstemplate) - Create SMS Template
* [GetSmsTemplate](docs/sdks/marketing/README.md#getsmstemplate) - Get SMS Template
* [UpdateSmsTemplate](docs/sdks/marketing/README.md#updatesmstemplate) - Update SMS Template
* [~~ListOmniChannelTemplates~~](docs/sdks/marketing/README.md#listomnichanneltemplates) - List Omni-Channel Templates :warning: **Deprecated**
* [~~CreateOmniChannelTemplate~~](docs/sdks/marketing/README.md#createomnichanneltemplate) - Create Omni-Channel Template :warning: **Deprecated**
* [~~GetOmniChannelTemplate~~](docs/sdks/marketing/README.md#getomnichanneltemplate) - Get Omni-Channel Template :warning: **Deprecated**
* [~~UpdateOmniChannelTemplate~~](docs/sdks/marketing/README.md#updateomnichanneltemplate) - Update Omni-Channel Template :warning: **Deprecated**
* [ListPushTemplates](docs/sdks/marketing/README.md#listpushtemplates) - List Push Templates
* [CreatePushTemplate](docs/sdks/marketing/README.md#createpushtemplate) - Create Push Template
* [GetPushTemplate](docs/sdks/marketing/README.md#getpushtemplate) - Get Push Template
* [UpdatePushTemplate](docs/sdks/marketing/README.md#updatepushtemplate) - Update Push Template
* [ListCampaigns](docs/sdks/marketing/README.md#listcampaigns) - List campaigns
* [GetCampaign](docs/sdks/marketing/README.md#getcampaign) - Get campaign
* [ListContentBlocks](docs/sdks/marketing/README.md#listcontentblocks) - List Content Blocks
* [CreateContentBlock](docs/sdks/marketing/README.md#createcontentblock) - Create Content Block
* [GetContentBlock](docs/sdks/marketing/README.md#getcontentblock) - Get Content Blocks
* [UpdateContentBlock](docs/sdks/marketing/README.md#updatecontentblock) - Update Content Block

### [Proxy](docs/sdks/proxy/README.md)

* [Perform](docs/sdks/proxy/README.md#perform) - Proxy Request

### [RequestLogs](docs/sdks/requestlogs/README.md)

* [ListSteps](docs/sdks/requestlogs/README.md#liststeps) - List Step Logs
* [Get](docs/sdks/requestlogs/README.md#get) - Get a Log
* [List](docs/sdks/requestlogs/README.md#list) - List Logs


### [Ticketing](docs/sdks/ticketing/README.md)

* [ListTickets](docs/sdks/ticketing/README.md#listtickets) - List Tickets
* [CreateTicket](docs/sdks/ticketing/README.md#createticket) - Create Ticket
* [GetTicket](docs/sdks/ticketing/README.md#getticket) - Get Ticket
* [UpdateTicket](docs/sdks/ticketing/README.md#updateticket) - Update Ticket
* [ListUsers](docs/sdks/ticketing/README.md#listusers) - List Users
* [GetUser](docs/sdks/ticketing/README.md#getuser) - Get User
* [ListComments](docs/sdks/ticketing/README.md#listcomments) - List Comments
* [GetComment](docs/sdks/ticketing/README.md#getcomment) - Get Comment
* [DownloadTicketingAttachment](docs/sdks/ticketing/README.md#downloadticketingattachment) - Download Attachment
* [ListAttachments](docs/sdks/ticketing/README.md#listattachments) - List Attachments
* [GetAttachment](docs/sdks/ticketing/README.md#getattachment) - Get Attachment
* [ListTicketTypes](docs/sdks/ticketing/README.md#listtickettypes) - List Ticket Types
* [GetTicketType](docs/sdks/ticketing/README.md#gettickettype) - Get Ticket Type
* [ListCollections](docs/sdks/ticketing/README.md#listcollections) - List Collections
* [GetCollection](docs/sdks/ticketing/README.md#getcollection) - Get Collection
* [ListCollectionTicketTypes](docs/sdks/ticketing/README.md#listcollectiontickettypes) - List Collection Ticket Types
* [ListTicketStatuses](docs/sdks/ticketing/README.md#listticketstatuses) - List Ticket Statuses

</details>
<!-- End Available Resources and Operations [operations] -->

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

HrisListCompaniesResponse? res = await sdk.Hris.ListCompaniesAsync(req);

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

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=stack-one-client&utm_campaign=csharp)
