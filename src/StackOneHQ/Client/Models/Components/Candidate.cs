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
    
    public class Candidate
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
        /// Candidate name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Candidate first name
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// Candidate last name
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// Candidate email
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; } = null;

        /// <summary>
        /// List of candidate emails
        /// </summary>
        [JsonProperty("emails")]
        public List<CandidateEmail>? Emails { get; set; } = null;

        /// <summary>
        /// List of candidate social links
        /// </summary>
        [JsonProperty("social_links")]
        public List<SocialLink>? SocialLinks { get; set; } = null;

        /// <summary>
        /// Candidate phone number
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("phone")]
        public string? Phone { get; set; } = null;

        /// <summary>
        /// List of candidate phone numbers including the type of the number when available
        /// </summary>
        [JsonProperty("phone_numbers")]
        public List<PhoneNumber>? PhoneNumbers { get; set; } = null;

        /// <summary>
        /// Candidate company
        /// </summary>
        [JsonProperty("company")]
        public string? Company { get; set; } = null;

        /// <summary>
        /// Candidate title
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// List of candidate application IDs
        /// </summary>
        [JsonProperty("application_ids")]
        public List<string>? ApplicationIds { get; set; } = null;

        /// <summary>
        /// Provider&apos;s list of candidate application IDs
        /// </summary>
        [JsonProperty("remote_application_ids")]
        public List<string>? RemoteApplicationIds { get; set; } = null;

        /// <summary>
        /// Candidate hired date
        /// </summary>
        [JsonProperty("hired_at")]
        public DateTime? HiredAt { get; set; } = null;

        /// <summary>
        /// Candidate country
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; } = null;

        /// <summary>
        /// The candidate custom fields
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<CustomFields>? CustomFields { get; set; } = null;

        /// <summary>
        /// Candidate created date
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// Candidate updated date
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;
    }
}