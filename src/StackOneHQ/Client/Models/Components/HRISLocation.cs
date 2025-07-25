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
    
    public class HRISLocation
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
        /// The employee ID
        /// </summary>
        [JsonProperty("employee_id")]
        public string? EmployeeId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier of the employee
        /// </summary>
        [JsonProperty("remote_employee_id")]
        public string? RemoteEmployeeId { get; set; } = null;

        /// <summary>
        /// The name of the location
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The phone number of the location
        /// </summary>
        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; } = null;

        /// <summary>
        /// The first line of the address
        /// </summary>
        [JsonProperty("street_1")]
        public string? Street1 { get; set; } = null;

        /// <summary>
        /// The second line of the address
        /// </summary>
        [JsonProperty("street_2")]
        public string? Street2 { get; set; } = null;

        /// <summary>
        /// The city where the location is situated
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; } = null;

        /// <summary>
        /// The state where the location is situated
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; } = null;

        /// <summary>
        /// The ZIP code/Postal code of the location
        /// </summary>
        [JsonProperty("zip_code")]
        public string? ZipCode { get; set; } = null;

        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("country")]
        public HRISLocationCountry? Country { get; set; } = null;

        /// <summary>
        /// The location type
        /// </summary>
        [JsonProperty("location_type")]
        public HRISLocationLocationType? LocationType { get; set; } = null;

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