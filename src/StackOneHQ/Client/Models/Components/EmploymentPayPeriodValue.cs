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
    /// The pay period of the job postings.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class EmploymentPayPeriodValue : IEquatable<EmploymentPayPeriodValue>
    {
        public static readonly EmploymentPayPeriodValue Hour = new EmploymentPayPeriodValue("hour");
        public static readonly EmploymentPayPeriodValue Day = new EmploymentPayPeriodValue("day");
        public static readonly EmploymentPayPeriodValue Week = new EmploymentPayPeriodValue("week");
        public static readonly EmploymentPayPeriodValue EveryTwoWeeks = new EmploymentPayPeriodValue("every_two_weeks");
        public static readonly EmploymentPayPeriodValue Month = new EmploymentPayPeriodValue("month");
        public static readonly EmploymentPayPeriodValue TwiceAMonth = new EmploymentPayPeriodValue("twice_a_month");
        public static readonly EmploymentPayPeriodValue EveryTwoMonths = new EmploymentPayPeriodValue("every_two_months");
        public static readonly EmploymentPayPeriodValue Quarter = new EmploymentPayPeriodValue("quarter");
        public static readonly EmploymentPayPeriodValue EverySixMonths = new EmploymentPayPeriodValue("every_six_months");
        public static readonly EmploymentPayPeriodValue Year = new EmploymentPayPeriodValue("year");
        public static readonly EmploymentPayPeriodValue OneOff = new EmploymentPayPeriodValue("one_off");
        public static readonly EmploymentPayPeriodValue None = new EmploymentPayPeriodValue("none");
        public static readonly EmploymentPayPeriodValue UnmappedValue = new EmploymentPayPeriodValue("unmapped_value");

        private static readonly Dictionary <string, EmploymentPayPeriodValue> _knownValues =
            new Dictionary <string, EmploymentPayPeriodValue> ()
            {
                ["hour"] = Hour,
                ["day"] = Day,
                ["week"] = Week,
                ["every_two_weeks"] = EveryTwoWeeks,
                ["month"] = Month,
                ["twice_a_month"] = TwiceAMonth,
                ["every_two_months"] = EveryTwoMonths,
                ["quarter"] = Quarter,
                ["every_six_months"] = EverySixMonths,
                ["year"] = Year,
                ["one_off"] = OneOff,
                ["none"] = None,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, EmploymentPayPeriodValue> _values =
            new ConcurrentDictionary<string, EmploymentPayPeriodValue>(_knownValues);

        private EmploymentPayPeriodValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static EmploymentPayPeriodValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new EmploymentPayPeriodValue(value));
        }

        public static implicit operator EmploymentPayPeriodValue(string value) => Of(value);
        public static implicit operator string(EmploymentPayPeriodValue employmentpayperiodvalue) => employmentpayperiodvalue.Value;

        public static EmploymentPayPeriodValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as EmploymentPayPeriodValue);

        public bool Equals(EmploymentPayPeriodValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}