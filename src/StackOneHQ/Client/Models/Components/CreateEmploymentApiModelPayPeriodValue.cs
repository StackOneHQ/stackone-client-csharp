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
    public class CreateEmploymentApiModelPayPeriodValue : IEquatable<CreateEmploymentApiModelPayPeriodValue>
    {
        public static readonly CreateEmploymentApiModelPayPeriodValue Hour = new CreateEmploymentApiModelPayPeriodValue("hour");
        public static readonly CreateEmploymentApiModelPayPeriodValue Day = new CreateEmploymentApiModelPayPeriodValue("day");
        public static readonly CreateEmploymentApiModelPayPeriodValue Week = new CreateEmploymentApiModelPayPeriodValue("week");
        public static readonly CreateEmploymentApiModelPayPeriodValue EveryTwoWeeks = new CreateEmploymentApiModelPayPeriodValue("every_two_weeks");
        public static readonly CreateEmploymentApiModelPayPeriodValue Month = new CreateEmploymentApiModelPayPeriodValue("month");
        public static readonly CreateEmploymentApiModelPayPeriodValue TwiceAMonth = new CreateEmploymentApiModelPayPeriodValue("twice_a_month");
        public static readonly CreateEmploymentApiModelPayPeriodValue EveryTwoMonths = new CreateEmploymentApiModelPayPeriodValue("every_two_months");
        public static readonly CreateEmploymentApiModelPayPeriodValue Quarter = new CreateEmploymentApiModelPayPeriodValue("quarter");
        public static readonly CreateEmploymentApiModelPayPeriodValue EverySixMonths = new CreateEmploymentApiModelPayPeriodValue("every_six_months");
        public static readonly CreateEmploymentApiModelPayPeriodValue Year = new CreateEmploymentApiModelPayPeriodValue("year");
        public static readonly CreateEmploymentApiModelPayPeriodValue OneOff = new CreateEmploymentApiModelPayPeriodValue("one_off");
        public static readonly CreateEmploymentApiModelPayPeriodValue None = new CreateEmploymentApiModelPayPeriodValue("none");
        public static readonly CreateEmploymentApiModelPayPeriodValue UnmappedValue = new CreateEmploymentApiModelPayPeriodValue("unmapped_value");

        private static readonly Dictionary <string, CreateEmploymentApiModelPayPeriodValue> _knownValues =
            new Dictionary <string, CreateEmploymentApiModelPayPeriodValue> ()
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

        private static readonly ConcurrentDictionary<string, CreateEmploymentApiModelPayPeriodValue> _values =
            new ConcurrentDictionary<string, CreateEmploymentApiModelPayPeriodValue>(_knownValues);

        private CreateEmploymentApiModelPayPeriodValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static CreateEmploymentApiModelPayPeriodValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new CreateEmploymentApiModelPayPeriodValue(value));
        }

        public static implicit operator CreateEmploymentApiModelPayPeriodValue(string value) => Of(value);
        public static implicit operator string(CreateEmploymentApiModelPayPeriodValue createemploymentapimodelpayperiodvalue) => createemploymentapimodelpayperiodvalue.Value;

        public static CreateEmploymentApiModelPayPeriodValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as CreateEmploymentApiModelPayPeriodValue);

        public bool Equals(CreateEmploymentApiModelPayPeriodValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}