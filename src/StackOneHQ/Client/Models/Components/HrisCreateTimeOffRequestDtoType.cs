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
    /// The type of the time off request
    /// </summary>
    [Obsolete("This will be removed in a future release, please migrate away from it as soon as possible")]
    public class HrisCreateTimeOffRequestDtoType
    {

        [JsonProperty("value")]
        public HrisCreateTimeOffRequestDtoTypeValue? Value { get; set; } = null;

        [JsonProperty("source_value")]
        public HrisCreateTimeOffRequestDtoTypeSourceValueUnion? SourceValue { get; set; } = null;
    }
}