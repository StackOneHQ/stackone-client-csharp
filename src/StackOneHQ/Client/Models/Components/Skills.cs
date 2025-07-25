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
    
    public class Skills
    {

        /// <summary>
        /// The ID associated with this skill
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// Provider&apos;s unique identifier
        /// </summary>
        [JsonProperty("remote_id")]
        public string? RemoteId { get; set; } = null;

        /// <summary>
        /// The name associated with this skill
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Whether the skill is active and therefore available for use
        /// </summary>
        [JsonProperty("active")]
        public SkillsActiveUnion? Active { get; set; } = null;

        /// <summary>
        /// The hierarchal level of the skill
        /// </summary>
        [JsonProperty("hierarchy")]
        public SkillsHierarchy? Hierarchy { get; set; } = null;

        /// <summary>
        /// The language associated with this skill
        /// </summary>
        [JsonProperty("language")]
        public SkillsLanguage? Language { get; set; } = null;

        /// <summary>
        /// The hierarchal level of the skill
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("level")]
        public SkillsLevel? Level { get; set; } = null;
    }
}