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
    
    public class EntitySkillsCreateRequestDto
    {

        /// <summary>
        /// The ID associated with this skill
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        /// <summary>
        /// The name associated with this skill
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// The proficiency level of the skill
        /// </summary>
        [JsonProperty("maximum_proficiency")]
        public EntitySkillsCreateRequestDtoMaximumProficiency? MaximumProficiency { get; set; } = null;

        /// <summary>
        /// The proficiency level of the skill
        /// </summary>
        [JsonProperty("minimum_proficiency")]
        public EntitySkillsCreateRequestDtoMinimumProficiency? MinimumProficiency { get; set; } = null;
    }
}