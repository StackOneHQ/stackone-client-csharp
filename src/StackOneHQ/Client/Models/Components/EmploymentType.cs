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
    
    /// <summary>
    /// The type of employment
    /// </summary>
    public class EmploymentType
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
        /// The label of the employment type
        /// </summary>
        [JsonProperty("label")]
        public string? Label { get; set; } = null;

        /// <summary>
        /// The type of employment (e.g., contractor, permanent)
        /// </summary>
        [JsonProperty("type")]
        public EmploymentTypeType? Type { get; set; } = null;
    }
}