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

    [JsonConverter(typeof(OpenEnumConverter))]
    public class HrisUpdateEmployeeRequestDtoEmploymentStatusValue : IEquatable<HrisUpdateEmployeeRequestDtoEmploymentStatusValue>
    {
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue Active = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("active");
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue Pending = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("pending");
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue Terminated = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("terminated");
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue Leave = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("leave");
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue Inactive = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("inactive");
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue Unknown = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("unknown");
        public static readonly HrisUpdateEmployeeRequestDtoEmploymentStatusValue UnmappedValue = new HrisUpdateEmployeeRequestDtoEmploymentStatusValue("unmapped_value");

        private static readonly Dictionary <string, HrisUpdateEmployeeRequestDtoEmploymentStatusValue> _knownValues =
            new Dictionary <string, HrisUpdateEmployeeRequestDtoEmploymentStatusValue> ()
            {
                ["active"] = Active,
                ["pending"] = Pending,
                ["terminated"] = Terminated,
                ["leave"] = Leave,
                ["inactive"] = Inactive,
                ["unknown"] = Unknown,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, HrisUpdateEmployeeRequestDtoEmploymentStatusValue> _values =
            new ConcurrentDictionary<string, HrisUpdateEmployeeRequestDtoEmploymentStatusValue>(_knownValues);

        private HrisUpdateEmployeeRequestDtoEmploymentStatusValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static HrisUpdateEmployeeRequestDtoEmploymentStatusValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new HrisUpdateEmployeeRequestDtoEmploymentStatusValue(value));
        }

        public static implicit operator HrisUpdateEmployeeRequestDtoEmploymentStatusValue(string value) => Of(value);
        public static implicit operator string(HrisUpdateEmployeeRequestDtoEmploymentStatusValue hrisupdateemployeerequestdtoemploymentstatusvalue) => hrisupdateemployeerequestdtoemploymentstatusvalue.Value;

        public static HrisUpdateEmployeeRequestDtoEmploymentStatusValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as HrisUpdateEmployeeRequestDtoEmploymentStatusValue);

        public bool Equals(HrisUpdateEmployeeRequestDtoEmploymentStatusValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}