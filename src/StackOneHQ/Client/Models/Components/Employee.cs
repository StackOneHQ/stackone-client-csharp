//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace StackOneHQ.Client.Models.Components
{
    using Newtonsoft.Json;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Generic;
    
    public class Employee
    {

        /// <summary>
        /// Unique identifier
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier
        /// </summary>
        [JsonProperty("remote_id")]
        public string? RemoteId { get; set; } = null;

        /// <summary>
        /// Custom Unified Fields configured in your StackOne project
        /// </summary>
        [JsonProperty("unified_custom_fields")]
        public Dictionary<string, object>? UnifiedCustomFields { get; set; } = null;

        /// <summary>
        /// The employee first name
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The employee last name
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// The employee name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The employee display name
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; } = null;

        /// <summary>
        /// The employee avatar Url
        /// </summary>
        [JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; } = null;

        /// <summary>
        /// The employee personal email
        /// </summary>
        [JsonProperty("personal_email")]
        public string? PersonalEmail { get; set; } = null;

        /// <summary>
        /// The employee personal phone number
        /// </summary>
        [JsonProperty("personal_phone_number")]
        public string? PersonalPhoneNumber { get; set; } = null;

        /// <summary>
        /// The employee work email
        /// </summary>
        [JsonProperty("work_email")]
        public string? WorkEmail { get; set; } = null;

        /// <summary>
        /// The employee work phone number
        /// </summary>
        [JsonProperty("work_phone_number")]
        public string? WorkPhoneNumber { get; set; } = null;

        /// <summary>
        /// The employee job id
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("job_id")]
        public string? JobId { get; set; } = null;

        /// <summary>
        /// The employee job title
        /// </summary>
        [JsonProperty("job_title")]
        public string? JobTitle { get; set; } = null;

        /// <summary>
        /// The employee job description
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("job_description")]
        public JobDescription? JobDescription { get; set; } = null;

        /// <summary>
        /// The employee department id
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; } = null;

        /// <summary>
        /// The employee department
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("department")]
        public string? Department { get; set; } = null;

        /// <summary>
        /// The employee groups
        /// </summary>
        [JsonProperty("groups")]
        public List<HRISGroup>? Groups { get; set; } = null;

        /// <summary>
        /// The employee cost centers
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("cost_centers")]
        public List<Models.Components.CostCenters>? CostCenters { get; set; } = null;

        /// <summary>
        /// The employee manager ID
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("manager_id")]
        public string? ManagerId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the manager
        /// </summary>
        [JsonProperty("remote_manager_id")]
        public string? RemoteManagerId { get; set; } = null;

        /// <summary>
        /// The employee gender
        /// </summary>
        [JsonProperty("gender")]
        public EmployeeGender? Gender { get; set; } = null;

        /// <summary>
        /// The employee preferred language
        /// </summary>
        [JsonProperty("preferred_language")]
        public EmployeePreferredLanguage? PreferredLanguage { get; set; } = null;

        /// <summary>
        /// The employee ethnicity
        /// </summary>
        [JsonProperty("ethnicity")]
        public EmployeeEthnicity? Ethnicity { get; set; } = null;

        /// <summary>
        /// The employee date_of_birth
        /// </summary>
        [JsonProperty("date_of_birth")]
        public DateTime? DateOfBirth { get; set; } = null;

        /// <summary>
        /// The employee birthday
        /// </summary>
        [JsonProperty("birthday")]
        public DateTime? Birthday { get; set; } = null;

        /// <summary>
        /// The employee marital status
        /// </summary>
        [JsonProperty("marital_status")]
        public EmployeeMaritalStatus? MaritalStatus { get; set; } = null;

        /// <summary>
        /// The employee avatar
        /// </summary>
        [JsonProperty("avatar")]
        public EmployeeAvatar? Avatar { get; set; } = null;

        /// <summary>
        /// The employee hire date
        /// </summary>
        [JsonProperty("hire_date")]
        public DateTime? HireDate { get; set; } = null;

        /// <summary>
        /// The employee start date
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; } = null;

        /// <summary>
        /// The employee tenure
        /// </summary>
        [JsonProperty("tenure")]
        public double? Tenure { get; set; } = null;

        /// <summary>
        /// The employee work anniversary
        /// </summary>
        [JsonProperty("work_anniversary")]
        public DateTime? WorkAnniversary { get; set; } = null;

        /// <summary>
        /// The employee employment type
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("employment_type")]
        public EmployeeEmploymentType? EmploymentType { get; set; } = null;

        /// <summary>
        /// The employment work schedule type (e.g., full-time, part-time)
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("employment_contract_type")]
        public EmployeeEmploymentContractType? EmploymentContractType { get; set; } = null;

        /// <summary>
        /// The employee employment status
        /// </summary>
        [JsonProperty("employment_status")]
        public EmployeeEmploymentStatus? EmploymentStatus { get; set; } = null;

        /// <summary>
        /// The employee termination date
        /// </summary>
        [JsonProperty("termination_date")]
        public DateTime? TerminationDate { get; set; } = null;

        /// <summary>
        /// The employee company name
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; } = null;

        /// <summary>
        /// The employee company id
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// The citizenships of the Employee
        /// </summary>
        [JsonProperty("citizenships")]
        public List<CountryCodeEnum>? Citizenships { get; set; } = null;

        /// <summary>
        /// The employee home location
        /// </summary>
        [JsonProperty("home_location")]
        public EmployeeHomeLocation? HomeLocation { get; set; } = null;

        /// <summary>
        /// The employee work location
        /// </summary>
        [JsonProperty("work_location")]
        public EmployeeWorkLocation? WorkLocation { get; set; } = null;

        /// <summary>
        /// The employee company
        /// </summary>
        [JsonProperty("company")]
        public EmployeeCompany? Company { get; set; } = null;

        /// <summary>
        /// The employee employments
        /// </summary>
        [JsonProperty("employments")]
        public List<Employment>? Employments { get; set; } = null;

        /// <summary>
        /// The employee custom fields
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<CustomFields>? CustomFields { get; set; } = null;

        /// <summary>
        /// Current benefits of the employee
        /// </summary>
        [JsonProperty("benefits")]
        public List<HRISBenefit>? Benefits { get; set; } = null;

        /// <summary>
        /// The assigned employee number
        /// </summary>
        [JsonProperty("employee_number")]
        public string? EmployeeNumber { get; set; } = null;

        /// <summary>
        /// The national identity number
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("national_identity_number")]
        public EmployeeNationalIdentityNumber? NationalIdentityNumber { get; set; } = null;

        /// <summary>
        /// The national identity numbers
        /// </summary>
        [JsonProperty("national_identity_numbers")]
        public List<NationalIdentityNumberApiModel>? NationalIdentityNumbers { get; set; } = null;

        /// <summary>
        /// The employee skills
        /// </summary>
        [JsonProperty("skills")]
        public List<EntitySkills>? Skills { get; set; } = null;

        /// <summary>
        /// The created_at date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// The updated_at date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;
    }
}