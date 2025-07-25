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
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The status of the application.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class AtsUpdateApplicationRequestDtoValue : IEquatable<AtsUpdateApplicationRequestDtoValue>
    {
        public static readonly AtsUpdateApplicationRequestDtoValue Active = new AtsUpdateApplicationRequestDtoValue("active");
        public static readonly AtsUpdateApplicationRequestDtoValue Assessment = new AtsUpdateApplicationRequestDtoValue("assessment");
        public static readonly AtsUpdateApplicationRequestDtoValue BackgroundCheck = new AtsUpdateApplicationRequestDtoValue("background_check");
        public static readonly AtsUpdateApplicationRequestDtoValue Converted = new AtsUpdateApplicationRequestDtoValue("converted");
        public static readonly AtsUpdateApplicationRequestDtoValue DeclinedByCandidate = new AtsUpdateApplicationRequestDtoValue("declined_by_candidate");
        public static readonly AtsUpdateApplicationRequestDtoValue Hired = new AtsUpdateApplicationRequestDtoValue("hired");
        public static readonly AtsUpdateApplicationRequestDtoValue Interview = new AtsUpdateApplicationRequestDtoValue("interview");
        public static readonly AtsUpdateApplicationRequestDtoValue Lead = new AtsUpdateApplicationRequestDtoValue("lead");
        public static readonly AtsUpdateApplicationRequestDtoValue Offer = new AtsUpdateApplicationRequestDtoValue("offer");
        public static readonly AtsUpdateApplicationRequestDtoValue ReferenceCheck = new AtsUpdateApplicationRequestDtoValue("reference_check");
        public static readonly AtsUpdateApplicationRequestDtoValue Rejected = new AtsUpdateApplicationRequestDtoValue("rejected");
        public static readonly AtsUpdateApplicationRequestDtoValue Review = new AtsUpdateApplicationRequestDtoValue("review");
        public static readonly AtsUpdateApplicationRequestDtoValue Screen = new AtsUpdateApplicationRequestDtoValue("screen");
        public static readonly AtsUpdateApplicationRequestDtoValue New = new AtsUpdateApplicationRequestDtoValue("new");
        public static readonly AtsUpdateApplicationRequestDtoValue Onboarding = new AtsUpdateApplicationRequestDtoValue("onboarding");
        public static readonly AtsUpdateApplicationRequestDtoValue Created = new AtsUpdateApplicationRequestDtoValue("created");
        public static readonly AtsUpdateApplicationRequestDtoValue Accepted = new AtsUpdateApplicationRequestDtoValue("accepted");
        public static readonly AtsUpdateApplicationRequestDtoValue ShortList = new AtsUpdateApplicationRequestDtoValue("short_list");
        public static readonly AtsUpdateApplicationRequestDtoValue Approved = new AtsUpdateApplicationRequestDtoValue("approved");
        public static readonly AtsUpdateApplicationRequestDtoValue UnmappedValue = new AtsUpdateApplicationRequestDtoValue("unmapped_value");

        private static readonly Dictionary <string, AtsUpdateApplicationRequestDtoValue> _knownValues =
            new Dictionary <string, AtsUpdateApplicationRequestDtoValue> ()
            {
                ["active"] = Active,
                ["assessment"] = Assessment,
                ["background_check"] = BackgroundCheck,
                ["converted"] = Converted,
                ["declined_by_candidate"] = DeclinedByCandidate,
                ["hired"] = Hired,
                ["interview"] = Interview,
                ["lead"] = Lead,
                ["offer"] = Offer,
                ["reference_check"] = ReferenceCheck,
                ["rejected"] = Rejected,
                ["review"] = Review,
                ["screen"] = Screen,
                ["new"] = New,
                ["onboarding"] = Onboarding,
                ["created"] = Created,
                ["accepted"] = Accepted,
                ["short_list"] = ShortList,
                ["approved"] = Approved,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, AtsUpdateApplicationRequestDtoValue> _values =
            new ConcurrentDictionary<string, AtsUpdateApplicationRequestDtoValue>(_knownValues);

        private AtsUpdateApplicationRequestDtoValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static AtsUpdateApplicationRequestDtoValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new AtsUpdateApplicationRequestDtoValue(value));
        }

        public static implicit operator AtsUpdateApplicationRequestDtoValue(string value) => Of(value);
        public static implicit operator string(AtsUpdateApplicationRequestDtoValue atsupdateapplicationrequestdtovalue) => atsupdateapplicationrequestdtovalue.Value;

        public static AtsUpdateApplicationRequestDtoValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as AtsUpdateApplicationRequestDtoValue);

        public bool Equals(AtsUpdateApplicationRequestDtoValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}