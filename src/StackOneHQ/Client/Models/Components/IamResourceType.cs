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
    
    public class IamResourceType
    {

        /// <summary>
        /// The type of the resource, e.g. user, group, permission, etc.
        /// </summary>
        [JsonProperty("value")]
        public IamResourceValue? Value { get; set; } = null;

        [JsonProperty("source_value")]
        public IamResourceSourceValueUnion? SourceValue { get; set; } = null;
    }
}