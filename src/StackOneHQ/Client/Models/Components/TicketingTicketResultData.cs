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
    
    public class TicketingTicketResultData
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
        /// The title or subject of the ticket
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The creator of the ticket
        /// </summary>
        [JsonProperty("creator_id")]
        public string? CreatorId { get; set; } = null;

        /// <summary>
        /// Users who reported the ticket
        /// </summary>
        [JsonProperty("reporters")]
        public List<string>? Reporters { get; set; } = null;

        /// <summary>
        /// Agents assigned to the ticket
        /// </summary>
        [JsonProperty("assignees")]
        public List<string>? Assignees { get; set; } = null;

        /// <summary>
        /// Array of content associated with the ticket
        /// </summary>
        [JsonProperty("content")]
        public List<TicketingContent>? Content { get; set; } = null;

        /// <summary>
        /// ID of the parent ticket if this is a sub-ticket
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; } = null;

        /// <summary>
        /// Priority of the ticket
        /// </summary>
        [JsonProperty("priority")]
        public TicketingTicketResultPriority? Priority { get; set; } = null;

        /// <summary>
        /// The tags of the ticket
        /// </summary>
        [JsonProperty("tags")]
        public List<string>? Tags { get; set; } = null;

        /// <summary>
        /// Collections the ticket belongs to
        /// </summary>
        [JsonProperty("collections")]
        public List<TicketingCollection>? Collections { get; set; } = null;

        /// <summary>
        /// The unique ticket number or reference ID
        /// </summary>
        [JsonProperty("ticket_number")]
        public string? TicketNumber { get; set; } = null;

        /// <summary>
        /// The type of the ticket
        /// </summary>
        [JsonProperty("type")]
        public TicketingTicketResultType? Type { get; set; } = null;

        /// <summary>
        /// The date the ticket was closed
        /// </summary>
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; } = null;

        /// <summary>
        /// URL to view the ticket in the source system
        /// </summary>
        [JsonProperty("ticket_url")]
        public string? TicketUrl { get; set; } = null;

        /// <summary>
        /// Current status of the ticket
        /// </summary>
        [JsonProperty("status")]
        public TicketingTicketResultStatus? Status { get; set; } = null;

        /// <summary>
        /// Organization associated with the ticket
        /// </summary>
        [JsonProperty("organization")]
        public TicketingTicketResultOrganization? Organization { get; set; } = null;

        /// <summary>
        /// The timestamp when the record was created
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; } = null;

        /// <summary>
        /// The timestamp when the record was last updated
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;
    }
}