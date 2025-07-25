//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace StackOneHQ.Client
{
    using StackOneHQ.Client.Hooks;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using StackOneHQ.Client.Utils.Retries;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public struct SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.stackone.com",
        };

        public ISpeakeasyHttpClient Client;
        public string ServerUrl;
        public int ServerIndex;
        public string UserAgent;
        public Func<StackOneHQ.Client.Models.Components.Security>? SecuritySource;
        public SDKHooks Hooks;
        public RetryConfig? RetryConfig;

        /// <summary>
        /// Initializes a new instance of the SDKConfig struct with default values.
        /// </summary>
        public SDKConfig(ISpeakeasyHttpClient? client = null)
        {
            Client = client ?? new SpeakeasyHttpClient();
            ServerUrl = "";
            ServerIndex = 0;
            UserAgent = "speakeasy-sdk/csharp 0.2.6 2.658.3 1.0.0 StackOneHQ.Client";
            SecuritySource = null;
            Hooks = new SDKHooks();
            RetryConfig = null;
        }

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }
    }
}