<!-- Start SDK Example Usage [usage] -->
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
    Fields = "id,remote_id,first_name,last_name,name,display_name,gender,ethnicity,date_of_birth,birthday,marital_status,avatar_url,avatar,personal_email,personal_phone_number,work_email,work_phone_number,job_id,remote_job_id,job_title,job_description,department_id,remote_department_id,department,cost_centers,company,manager_id,remote_manager_id,hire_date,start_date,tenure,work_anniversary,employment_type,employment_contract_type,employment_status,termination_date,company_name,company_id,remote_company_id,preferred_language,citizenships,home_location,work_location,employments,custom_fields,documents,created_at,updated_at,benefits,employee_number,national_identity_number,national_identity_numbers,skills",
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