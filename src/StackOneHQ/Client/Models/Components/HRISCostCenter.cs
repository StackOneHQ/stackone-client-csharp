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
    
    public class HRISCostCenter
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
        /// The name of the group
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The list of parent group ids of the given group
        /// </summary>
        [JsonProperty("parent_ids")]
        public List<string>? ParentIds { get; set; } = null;

        /// <summary>
        /// Provider&apos;s list of parent group remote ids of the given group
        /// </summary>
        [JsonProperty("remote_parent_ids")]
        public List<string>? RemoteParentIds { get; set; } = null;

        /// <summary>
        /// The list of group owner ids of the given group
        /// </summary>
        [JsonProperty("owner_ids")]
        public List<string>? OwnerIds { get; set; } = null;

        /// <summary>
        /// The list of remote group owner ids of the given group
        /// </summary>
        [JsonProperty("remote_owner_ids")]
        public List<string>? RemoteOwnerIds { get; set; } = null;

        /// <summary>
        /// The id of the company that the group belongs to
        /// </summary>
        [JsonProperty("company_id")]
        public string? CompanyId { get; set; } = null;

        /// <summary>
        /// Provider&apos;s id of the company that the group belongs to
        /// </summary>
        [JsonProperty("remote_company_id")]
        public string? RemoteCompanyId { get; set; } = null;

        /// <summary>
        /// The distribution percentage for cost_center
        /// </summary>
        [JsonProperty("distribution_percentage")]
        public double? DistributionPercentage { get; set; } = null;

        /// <summary>
        /// The type of the group
        /// </summary>
        [JsonProperty("type")]
        public HRISCostCenterType? Type { get; set; } = null;
    }
}