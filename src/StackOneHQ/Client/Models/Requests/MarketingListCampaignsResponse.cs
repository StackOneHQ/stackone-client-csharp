//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace StackOneHQ.Client.Models.Requests
{
    using Newtonsoft.Json;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public class MarketingListCampaignsResponse
    {
        public Func<Task<MarketingListCampaignsResponse?>>? Next {get;set;}

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// The list of campaigns was retrieved.
        /// </summary>
        public CampaignsPaginated? CampaignsPaginated { get; set; }

        public Dictionary<string, List<string>> Headers { get; set; } = default!;
    }
}