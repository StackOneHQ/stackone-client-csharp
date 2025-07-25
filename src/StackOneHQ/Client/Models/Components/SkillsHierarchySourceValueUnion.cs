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
    

    public class SkillsHierarchySourceValueUnionType
    {
        private SkillsHierarchySourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static SkillsHierarchySourceValueUnionType Str { get { return new SkillsHierarchySourceValueUnionType("str"); } }
        
        public static SkillsHierarchySourceValueUnionType Number { get { return new SkillsHierarchySourceValueUnionType("number"); } }
        
        public static SkillsHierarchySourceValueUnionType Boolean { get { return new SkillsHierarchySourceValueUnionType("boolean"); } }
        
        public static SkillsHierarchySourceValueUnionType SkillsSourceValueHierarchy { get { return new SkillsHierarchySourceValueUnionType("Skills_source_value_hierarchy"); } }
        
        public static SkillsHierarchySourceValueUnionType ArrayOfAny { get { return new SkillsHierarchySourceValueUnionType("arrayOfAny"); } }
        
        public static SkillsHierarchySourceValueUnionType Null { get { return new SkillsHierarchySourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(SkillsHierarchySourceValueUnionType v) { return v.Value; }
        public static SkillsHierarchySourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "Skills_source_value_hierarchy": return SkillsSourceValueHierarchy;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for SkillsHierarchySourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((SkillsHierarchySourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(SkillsHierarchySourceValueUnion.SkillsHierarchySourceValueUnionConverter))]
    public class SkillsHierarchySourceValueUnion {
        public SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SkillsSourceValueHierarchy? SkillsSourceValueHierarchy { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public SkillsHierarchySourceValueUnionType Type { get; set; }


        public static SkillsHierarchySourceValueUnion CreateStr(string str) {
            SkillsHierarchySourceValueUnionType typ = SkillsHierarchySourceValueUnionType.Str;

            SkillsHierarchySourceValueUnion res = new SkillsHierarchySourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static SkillsHierarchySourceValueUnion CreateNumber(double number) {
            SkillsHierarchySourceValueUnionType typ = SkillsHierarchySourceValueUnionType.Number;

            SkillsHierarchySourceValueUnion res = new SkillsHierarchySourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static SkillsHierarchySourceValueUnion CreateBoolean(bool boolean) {
            SkillsHierarchySourceValueUnionType typ = SkillsHierarchySourceValueUnionType.Boolean;

            SkillsHierarchySourceValueUnion res = new SkillsHierarchySourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static SkillsHierarchySourceValueUnion CreateSkillsSourceValueHierarchy(SkillsSourceValueHierarchy skillsSourceValueHierarchy) {
            SkillsHierarchySourceValueUnionType typ = SkillsHierarchySourceValueUnionType.SkillsSourceValueHierarchy;

            SkillsHierarchySourceValueUnion res = new SkillsHierarchySourceValueUnion(typ);
            res.SkillsSourceValueHierarchy = skillsSourceValueHierarchy;
            return res;
        }

        public static SkillsHierarchySourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            SkillsHierarchySourceValueUnionType typ = SkillsHierarchySourceValueUnionType.ArrayOfAny;

            SkillsHierarchySourceValueUnion res = new SkillsHierarchySourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static SkillsHierarchySourceValueUnion CreateNull() {
            SkillsHierarchySourceValueUnionType typ = SkillsHierarchySourceValueUnionType.Null;
            return new SkillsHierarchySourceValueUnion(typ);
        }

        public class SkillsHierarchySourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(SkillsHierarchySourceValueUnion);

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
                    return new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.SkillsSourceValueHierarchy)
                    {
                        SkillsSourceValueHierarchy = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SkillsSourceValueHierarchy>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SkillsSourceValueHierarchy), new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.SkillsSourceValueHierarchy), "SkillsSourceValueHierarchy"));
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
                    return new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.Number)
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
                    return new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.Boolean)
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
                    return new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new SkillsHierarchySourceValueUnion(SkillsHierarchySourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                SkillsHierarchySourceValueUnion res = (SkillsHierarchySourceValueUnion)value;
                if (SkillsHierarchySourceValueUnionType.FromString(res.Type).Equals(SkillsHierarchySourceValueUnionType.Null))
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
                if (res.SkillsSourceValueHierarchy != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SkillsSourceValueHierarchy));
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