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
    using System.Collections.Generic;
    
    public class LmsBatchUpsertContentRequestDto
    {

        /// <summary>
        /// The batch of items to upsert
        /// </summary>
        [JsonProperty("items")]
        public List<LmsUpsertContentRequestDto> Items { get; set; } = default!;
    }
}