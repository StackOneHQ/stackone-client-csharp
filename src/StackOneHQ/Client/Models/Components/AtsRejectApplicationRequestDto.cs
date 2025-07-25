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
    using StackOneHQ.Client.Utils;
    using System.Collections.Generic;
    
    public class AtsRejectApplicationRequestDto
    {

        /// <summary>
        /// Value to pass through to the provider
        /// </summary>
        [JsonProperty("passthrough")]
        public Dictionary<string, object>? Passthrough { get; set; } = null;

        /// <summary>
        /// Unique identifier of the rejection reason
        /// </summary>
        [JsonProperty("rejected_reason_id")]
        public string? RejectedReasonId { get; set; } = null;
    }
}