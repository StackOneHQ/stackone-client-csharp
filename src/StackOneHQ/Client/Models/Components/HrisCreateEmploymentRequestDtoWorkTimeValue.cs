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
    /// The unified value for the period.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class HrisCreateEmploymentRequestDtoWorkTimeValue : IEquatable<HrisCreateEmploymentRequestDtoWorkTimeValue>
    {
        public static readonly HrisCreateEmploymentRequestDtoWorkTimeValue Day = new HrisCreateEmploymentRequestDtoWorkTimeValue("day");
        public static readonly HrisCreateEmploymentRequestDtoWorkTimeValue Week = new HrisCreateEmploymentRequestDtoWorkTimeValue("week");
        public static readonly HrisCreateEmploymentRequestDtoWorkTimeValue Month = new HrisCreateEmploymentRequestDtoWorkTimeValue("month");
        public static readonly HrisCreateEmploymentRequestDtoWorkTimeValue Year = new HrisCreateEmploymentRequestDtoWorkTimeValue("year");
        public static readonly HrisCreateEmploymentRequestDtoWorkTimeValue UnmappedValue = new HrisCreateEmploymentRequestDtoWorkTimeValue("unmapped_value");

        private static readonly Dictionary <string, HrisCreateEmploymentRequestDtoWorkTimeValue> _knownValues =
            new Dictionary <string, HrisCreateEmploymentRequestDtoWorkTimeValue> ()
            {
                ["day"] = Day,
                ["week"] = Week,
                ["month"] = Month,
                ["year"] = Year,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, HrisCreateEmploymentRequestDtoWorkTimeValue> _values =
            new ConcurrentDictionary<string, HrisCreateEmploymentRequestDtoWorkTimeValue>(_knownValues);

        private HrisCreateEmploymentRequestDtoWorkTimeValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static HrisCreateEmploymentRequestDtoWorkTimeValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new HrisCreateEmploymentRequestDtoWorkTimeValue(value));
        }

        public static implicit operator HrisCreateEmploymentRequestDtoWorkTimeValue(string value) => Of(value);
        public static implicit operator string(HrisCreateEmploymentRequestDtoWorkTimeValue hriscreateemploymentrequestdtoworktimevalue) => hriscreateemploymentrequestdtoworktimevalue.Value;

        public static HrisCreateEmploymentRequestDtoWorkTimeValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as HrisCreateEmploymentRequestDtoWorkTimeValue);

        public bool Equals(HrisCreateEmploymentRequestDtoWorkTimeValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}