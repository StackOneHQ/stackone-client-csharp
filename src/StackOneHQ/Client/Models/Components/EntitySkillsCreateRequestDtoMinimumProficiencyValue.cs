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
    public class EntitySkillsCreateRequestDtoMinimumProficiencyValue : IEquatable<EntitySkillsCreateRequestDtoMinimumProficiencyValue>
    {
        public static readonly EntitySkillsCreateRequestDtoMinimumProficiencyValue One = new EntitySkillsCreateRequestDtoMinimumProficiencyValue("1");
        public static readonly EntitySkillsCreateRequestDtoMinimumProficiencyValue Two = new EntitySkillsCreateRequestDtoMinimumProficiencyValue("2");
        public static readonly EntitySkillsCreateRequestDtoMinimumProficiencyValue Three = new EntitySkillsCreateRequestDtoMinimumProficiencyValue("3");
        public static readonly EntitySkillsCreateRequestDtoMinimumProficiencyValue Four = new EntitySkillsCreateRequestDtoMinimumProficiencyValue("4");
        public static readonly EntitySkillsCreateRequestDtoMinimumProficiencyValue Five = new EntitySkillsCreateRequestDtoMinimumProficiencyValue("5");
        public static readonly EntitySkillsCreateRequestDtoMinimumProficiencyValue UnmappedValue = new EntitySkillsCreateRequestDtoMinimumProficiencyValue("unmapped_value");

        private static readonly Dictionary <string, EntitySkillsCreateRequestDtoMinimumProficiencyValue> _knownValues =
            new Dictionary <string, EntitySkillsCreateRequestDtoMinimumProficiencyValue> ()
            {
                ["1"] = One,
                ["2"] = Two,
                ["3"] = Three,
                ["4"] = Four,
                ["5"] = Five,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, EntitySkillsCreateRequestDtoMinimumProficiencyValue> _values =
            new ConcurrentDictionary<string, EntitySkillsCreateRequestDtoMinimumProficiencyValue>(_knownValues);

        private EntitySkillsCreateRequestDtoMinimumProficiencyValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static EntitySkillsCreateRequestDtoMinimumProficiencyValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new EntitySkillsCreateRequestDtoMinimumProficiencyValue(value));
        }

        public static implicit operator EntitySkillsCreateRequestDtoMinimumProficiencyValue(string value) => Of(value);
        public static implicit operator string(EntitySkillsCreateRequestDtoMinimumProficiencyValue entityskillscreaterequestdtominimumproficiencyvalue) => entityskillscreaterequestdtominimumproficiencyvalue.Value;

        public static EntitySkillsCreateRequestDtoMinimumProficiencyValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as EntitySkillsCreateRequestDtoMinimumProficiencyValue);

        public bool Equals(EntitySkillsCreateRequestDtoMinimumProficiencyValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}