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
    /// The type of the benefit
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class CreateHRISBenefitValue : IEquatable<CreateHRISBenefitValue>
    {
        public static readonly CreateHRISBenefitValue RetirementSavings = new CreateHRISBenefitValue("retirement_savings");
        public static readonly CreateHRISBenefitValue HealthSavings = new CreateHRISBenefitValue("health_savings");
        public static readonly CreateHRISBenefitValue Other = new CreateHRISBenefitValue("other");
        public static readonly CreateHRISBenefitValue HealthInsurance = new CreateHRISBenefitValue("health_insurance");
        public static readonly CreateHRISBenefitValue Insurance = new CreateHRISBenefitValue("insurance");
        public static readonly CreateHRISBenefitValue UnmappedValue = new CreateHRISBenefitValue("unmapped_value");

        private static readonly Dictionary <string, CreateHRISBenefitValue> _knownValues =
            new Dictionary <string, CreateHRISBenefitValue> ()
            {
                ["retirement_savings"] = RetirementSavings,
                ["health_savings"] = HealthSavings,
                ["other"] = Other,
                ["health_insurance"] = HealthInsurance,
                ["insurance"] = Insurance,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, CreateHRISBenefitValue> _values =
            new ConcurrentDictionary<string, CreateHRISBenefitValue>(_knownValues);

        private CreateHRISBenefitValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static CreateHRISBenefitValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new CreateHRISBenefitValue(value));
        }

        public static implicit operator CreateHRISBenefitValue(string value) => Of(value);
        public static implicit operator string(CreateHRISBenefitValue createhrisbenefitvalue) => createhrisbenefitvalue.Value;

        public static CreateHRISBenefitValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as CreateHRISBenefitValue);

        public bool Equals(CreateHRISBenefitValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}