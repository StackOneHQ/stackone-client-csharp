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
    
    public class CreateMessage
    {

        /// <summary>
        /// Unique identifier
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// Stackone enum identifying the type of message associated with the content.
        /// </summary>
        [JsonProperty("message_type")]
        public CreateMessageMessageType? MessageType { get; set; } = null;

        [JsonProperty("message_content")]
        public CreateMessageMessageContent? MessageContent { get; set; } = null;
    }
}