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
    public class CreateCategoriesApiModelHierarchyValue : IEquatable<CreateCategoriesApiModelHierarchyValue>
    {
        public static readonly CreateCategoriesApiModelHierarchyValue Primary = new CreateCategoriesApiModelHierarchyValue("primary");
        public static readonly CreateCategoriesApiModelHierarchyValue Secondary = new CreateCategoriesApiModelHierarchyValue("secondary");
        public static readonly CreateCategoriesApiModelHierarchyValue Tertiary = new CreateCategoriesApiModelHierarchyValue("tertiary");
        public static readonly CreateCategoriesApiModelHierarchyValue UnmappedValue = new CreateCategoriesApiModelHierarchyValue("unmapped_value");

        private static readonly Dictionary <string, CreateCategoriesApiModelHierarchyValue> _knownValues =
            new Dictionary <string, CreateCategoriesApiModelHierarchyValue> ()
            {
                ["primary"] = Primary,
                ["secondary"] = Secondary,
                ["tertiary"] = Tertiary,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, CreateCategoriesApiModelHierarchyValue> _values =
            new ConcurrentDictionary<string, CreateCategoriesApiModelHierarchyValue>(_knownValues);

        private CreateCategoriesApiModelHierarchyValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static CreateCategoriesApiModelHierarchyValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new CreateCategoriesApiModelHierarchyValue(value));
        }

        public static implicit operator CreateCategoriesApiModelHierarchyValue(string value) => Of(value);
        public static implicit operator string(CreateCategoriesApiModelHierarchyValue createcategoriesapimodelhierarchyvalue) => createcategoriesapimodelhierarchyvalue.Value;

        public static CreateCategoriesApiModelHierarchyValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as CreateCategoriesApiModelHierarchyValue);

        public bool Equals(CreateCategoriesApiModelHierarchyValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}