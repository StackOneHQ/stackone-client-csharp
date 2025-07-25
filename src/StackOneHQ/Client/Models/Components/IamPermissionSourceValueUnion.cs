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
    using Newtonsoft.Json.Linq;
    using StackOneHQ.Client.Models.Components;
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class IamPermissionSourceValueUnionType
    {
        private IamPermissionSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static IamPermissionSourceValueUnionType Str { get { return new IamPermissionSourceValueUnionType("str"); } }
        
        public static IamPermissionSourceValueUnionType Number { get { return new IamPermissionSourceValueUnionType("number"); } }
        
        public static IamPermissionSourceValueUnionType Boolean { get { return new IamPermissionSourceValueUnionType("boolean"); } }
        
        public static IamPermissionSourceValueUnionType IamPermissionSourceValue { get { return new IamPermissionSourceValueUnionType("IamPermission_source_value"); } }
        
        public static IamPermissionSourceValueUnionType ArrayOfAny { get { return new IamPermissionSourceValueUnionType("arrayOfAny"); } }
        
        public static IamPermissionSourceValueUnionType Null { get { return new IamPermissionSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(IamPermissionSourceValueUnionType v) { return v.Value; }
        public static IamPermissionSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "IamPermission_source_value": return IamPermissionSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for IamPermissionSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((IamPermissionSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(IamPermissionSourceValueUnion.IamPermissionSourceValueUnionConverter))]
    public class IamPermissionSourceValueUnion {
        public IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public IamPermissionSourceValue? IamPermissionSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public IamPermissionSourceValueUnionType Type { get; set; }


        public static IamPermissionSourceValueUnion CreateStr(string str) {
            IamPermissionSourceValueUnionType typ = IamPermissionSourceValueUnionType.Str;

            IamPermissionSourceValueUnion res = new IamPermissionSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static IamPermissionSourceValueUnion CreateNumber(double number) {
            IamPermissionSourceValueUnionType typ = IamPermissionSourceValueUnionType.Number;

            IamPermissionSourceValueUnion res = new IamPermissionSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static IamPermissionSourceValueUnion CreateBoolean(bool boolean) {
            IamPermissionSourceValueUnionType typ = IamPermissionSourceValueUnionType.Boolean;

            IamPermissionSourceValueUnion res = new IamPermissionSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static IamPermissionSourceValueUnion CreateIamPermissionSourceValue(IamPermissionSourceValue iamPermissionSourceValue) {
            IamPermissionSourceValueUnionType typ = IamPermissionSourceValueUnionType.IamPermissionSourceValue;

            IamPermissionSourceValueUnion res = new IamPermissionSourceValueUnion(typ);
            res.IamPermissionSourceValue = iamPermissionSourceValue;
            return res;
        }

        public static IamPermissionSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            IamPermissionSourceValueUnionType typ = IamPermissionSourceValueUnionType.ArrayOfAny;

            IamPermissionSourceValueUnion res = new IamPermissionSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static IamPermissionSourceValueUnion CreateNull() {
            IamPermissionSourceValueUnionType typ = IamPermissionSourceValueUnionType.Null;
            return new IamPermissionSourceValueUnion(typ);
        }

        public class IamPermissionSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(IamPermissionSourceValueUnion);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.IamPermissionSourceValue)
                    {
                        IamPermissionSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<IamPermissionSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(IamPermissionSourceValue), new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.IamPermissionSourceValue), "IamPermissionSourceValue"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.Number)
                    {
                        Number = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    var converted = Convert.ToBoolean(json);
                    return new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.Boolean)
                    {
                        Boolean = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                try
                {
                    return new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new IamPermissionSourceValueUnion(IamPermissionSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                IamPermissionSourceValueUnion res = (IamPermissionSourceValueUnion)value;
                if (IamPermissionSourceValueUnionType.FromString(res.Type).Equals(IamPermissionSourceValueUnionType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }
                if (res.IamPermissionSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.IamPermissionSourceValue));
                    return;
                }
                if (res.ArrayOfAny != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfAny));
                    return;
                }

            }

        }

    }
}