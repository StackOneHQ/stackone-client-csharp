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
    using System;
    
    public enum ConnectSessionTokenAuthLinkCategory
    {
        [JsonProperty("ats")]
        Ats,
        [JsonProperty("hris")]
        Hris,
        [JsonProperty("hris-legacy")]
        HrisLegacy,
        [JsonProperty("crm")]
        Crm,
        [JsonProperty("iam")]
        Iam,
        [JsonProperty("marketing")]
        Marketing,
        [JsonProperty("lms")]
        Lms,
        [JsonProperty("stackone")]
        Stackone,
        [JsonProperty("documents")]
        Documents,
        [JsonProperty("ticketing")]
        Ticketing,
        [JsonProperty("screening")]
        Screening,
        [JsonProperty("messaging")]
        Messaging,
        [JsonProperty("accounting")]
        Accounting,
    }

    public static class ConnectSessionTokenAuthLinkCategoryExtension
    {
        public static string Value(this ConnectSessionTokenAuthLinkCategory value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ConnectSessionTokenAuthLinkCategory ToEnum(this string value)
        {
            foreach(var field in typeof(ConnectSessionTokenAuthLinkCategory).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ConnectSessionTokenAuthLinkCategory)
                    {
                        return (ConnectSessionTokenAuthLinkCategory)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ConnectSessionTokenAuthLinkCategory");
        }
    }

}