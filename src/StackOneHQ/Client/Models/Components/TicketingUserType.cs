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
    
    public class TicketingUserType
    {

        /// <summary>
        /// The type of the user.
        /// </summary>
        [JsonProperty("value")]
        public TicketingUserValue? Value { get; set; } = null;

        /// <summary>
        /// The source value of the user type.
        /// </summary>
        [JsonProperty("source_value")]
        public TicketingUserSourceValueUnion? SourceValue { get; set; } = null;
    }
}