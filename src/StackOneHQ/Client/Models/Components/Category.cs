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
    
    public class Category
    {

        /// <summary>
        /// The ID associated with this category
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
        /// The name associated with this category
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Whether the category is active and therefore available for use
        /// </summary>
        [JsonProperty("active")]
        public CategoryActiveUnion? Active { get; set; } = null;

        /// <summary>
        /// The hierarchal level of the category
        /// </summary>
        [JsonProperty("hierarchy")]
        public CategoryHierarchy? Hierarchy { get; set; } = null;

        /// <summary>
        /// The hierarchal level of the category
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("level")]
        public CategoryLevel? Level { get; set; } = null;

        /// <summary>
        /// The language associated with this category
        /// </summary>
        [JsonProperty("language")]
        public CategoryLanguage? Language { get; set; } = null;
    }
}