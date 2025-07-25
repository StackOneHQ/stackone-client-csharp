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
    /// The type of the permission, e.g. read, read_write, delete, etc.
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class IamPermissionValue : IEquatable<IamPermissionValue>
    {
        public static readonly IamPermissionValue Read = new IamPermissionValue("read");
        public static readonly IamPermissionValue ReadWrite = new IamPermissionValue("read_write");
        public static readonly IamPermissionValue Approve = new IamPermissionValue("approve");
        public static readonly IamPermissionValue Delete = new IamPermissionValue("delete");
        public static readonly IamPermissionValue Use = new IamPermissionValue("use");
        public static readonly IamPermissionValue Export = new IamPermissionValue("export");
        public static readonly IamPermissionValue UnmappedValue = new IamPermissionValue("unmapped_value");

        private static readonly Dictionary <string, IamPermissionValue> _knownValues =
            new Dictionary <string, IamPermissionValue> ()
            {
                ["read"] = Read,
                ["read_write"] = ReadWrite,
                ["approve"] = Approve,
                ["delete"] = Delete,
                ["use"] = Use,
                ["export"] = Export,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, IamPermissionValue> _values =
            new ConcurrentDictionary<string, IamPermissionValue>(_knownValues);

        private IamPermissionValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static IamPermissionValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new IamPermissionValue(value));
        }

        public static implicit operator IamPermissionValue(string value) => Of(value);
        public static implicit operator string(IamPermissionValue iampermissionvalue) => iampermissionvalue.Value;

        public static IamPermissionValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as IamPermissionValue);

        public bool Equals(IamPermissionValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}