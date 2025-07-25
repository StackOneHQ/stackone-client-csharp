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
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    
    /// <summary>
    /// Stackone enum identifying the type of message associated with the content.
    /// </summary>
    public class CreateMessageMessageType
    {

        /// <summary>
        /// The unified message type.
        /// </summary>
        [JsonProperty("value")]
        public CreateMessageValue? Value { get; set; } = null;

        /// <summary>
        /// The original value from the provider used to derive the unified message type.
        /// </summary>
        [JsonProperty("source_value")]
        public CreateMessageSourceValueUnion? SourceValue { get; set; } = null;
    }
}