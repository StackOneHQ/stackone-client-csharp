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
    /// The type of the employment.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class HrisCreateEmploymentRequestDtoEmploymentTypeValue : IEquatable<HrisCreateEmploymentRequestDtoEmploymentTypeValue>
    {
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Contractor = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("contractor");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Intern = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("intern");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Permanent = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("permanent");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Apprentice = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("apprentice");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Freelance = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("freelance");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Terminated = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("terminated");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Temporary = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("temporary");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Seasonal = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("seasonal");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Volunteer = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("volunteer");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Probation = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("probation");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Internal = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("internal");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue External = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("external");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Expatriate = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("expatriate");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue EmployerOfRecord = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("employer_of_record");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Casual = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("casual");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue Programme = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("Programme");
        public static readonly HrisCreateEmploymentRequestDtoEmploymentTypeValue UnmappedValue = new HrisCreateEmploymentRequestDtoEmploymentTypeValue("unmapped_value");

        private static readonly Dictionary <string, HrisCreateEmploymentRequestDtoEmploymentTypeValue> _knownValues =
            new Dictionary <string, HrisCreateEmploymentRequestDtoEmploymentTypeValue> ()
            {
                ["contractor"] = Contractor,
                ["intern"] = Intern,
                ["permanent"] = Permanent,
                ["apprentice"] = Apprentice,
                ["freelance"] = Freelance,
                ["terminated"] = Terminated,
                ["temporary"] = Temporary,
                ["seasonal"] = Seasonal,
                ["volunteer"] = Volunteer,
                ["probation"] = Probation,
                ["internal"] = Internal,
                ["external"] = External,
                ["expatriate"] = Expatriate,
                ["employer_of_record"] = EmployerOfRecord,
                ["casual"] = Casual,
                ["Programme"] = Programme,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, HrisCreateEmploymentRequestDtoEmploymentTypeValue> _values =
            new ConcurrentDictionary<string, HrisCreateEmploymentRequestDtoEmploymentTypeValue>(_knownValues);

        private HrisCreateEmploymentRequestDtoEmploymentTypeValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static HrisCreateEmploymentRequestDtoEmploymentTypeValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new HrisCreateEmploymentRequestDtoEmploymentTypeValue(value));
        }

        public static implicit operator HrisCreateEmploymentRequestDtoEmploymentTypeValue(string value) => Of(value);
        public static implicit operator string(HrisCreateEmploymentRequestDtoEmploymentTypeValue hriscreateemploymentrequestdtoemploymenttypevalue) => hriscreateemploymentrequestdtoemploymenttypevalue.Value;

        public static HrisCreateEmploymentRequestDtoEmploymentTypeValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as HrisCreateEmploymentRequestDtoEmploymentTypeValue);

        public bool Equals(HrisCreateEmploymentRequestDtoEmploymentTypeValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}