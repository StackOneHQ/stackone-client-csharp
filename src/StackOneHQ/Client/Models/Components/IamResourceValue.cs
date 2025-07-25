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
    /// The type of the resource, e.g. user, group, permission, etc.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class IamResourceValue : IEquatable<IamResourceValue>
    {
        public static readonly IamResourceValue Project = new IamResourceValue("project");
        public static readonly IamResourceValue File = new IamResourceValue("file");
        public static readonly IamResourceValue Folder = new IamResourceValue("folder");
        public static readonly IamResourceValue Product = new IamResourceValue("product");
        public static readonly IamResourceValue Property = new IamResourceValue("property");
        public static readonly IamResourceValue User = new IamResourceValue("user");
        public static readonly IamResourceValue UnmappedValue = new IamResourceValue("unmapped_value");

        private static readonly Dictionary <string, IamResourceValue> _knownValues =
            new Dictionary <string, IamResourceValue> ()
            {
                ["project"] = Project,
                ["file"] = File,
                ["folder"] = Folder,
                ["product"] = Product,
                ["property"] = Property,
                ["user"] = User,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, IamResourceValue> _values =
            new ConcurrentDictionary<string, IamResourceValue>(_knownValues);

        private IamResourceValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static IamResourceValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new IamResourceValue(value));
        }

        public static implicit operator IamResourceValue(string value) => Of(value);
        public static implicit operator string(IamResourceValue iamresourcevalue) => iamresourcevalue.Value;

        public static IamResourceValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as IamResourceValue);

        public bool Equals(IamResourceValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}