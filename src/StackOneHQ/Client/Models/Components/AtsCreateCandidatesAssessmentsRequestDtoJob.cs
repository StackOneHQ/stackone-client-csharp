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
    using System.Collections.Generic;
    
    public class AtsCreateCandidatesAssessmentsRequestDtoJob
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
        /// Title of the job
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// Hiring team for the job.
        /// </summary>
        [JsonProperty("hiring_team")]
        public List<JobHiringTeam>? HiringTeam { get; set; } = null;

        /// <summary>
        /// Value to pass through to the provider
        /// </summary>
        [JsonProperty("passthrough")]
        public Dictionary<string, object>? Passthrough { get; set; } = null;
    }
}