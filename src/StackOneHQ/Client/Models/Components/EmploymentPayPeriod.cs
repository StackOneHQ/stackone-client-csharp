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
    /// The pay period
    /// </summary>
    public class EmploymentPayPeriod
    {

        /// <summary>
        /// The pay period of the job postings.
        /// </summary>
        [JsonProperty("value")]
        public EmploymentPayPeriodValue? Value { get; set; } = null;

        /// <summary>
        /// The source value of the pay period.
        /// </summary>
        [JsonProperty("source_value")]
        public EmploymentPayPeriodSourceValueUnion? SourceValue { get; set; } = null;
    }
}