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
    

    public class HRISDepartmentSourceValueUnionType
    {
        private HRISDepartmentSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static HRISDepartmentSourceValueUnionType Str { get { return new HRISDepartmentSourceValueUnionType("str"); } }
        
        public static HRISDepartmentSourceValueUnionType Number { get { return new HRISDepartmentSourceValueUnionType("number"); } }
        
        public static HRISDepartmentSourceValueUnionType Boolean { get { return new HRISDepartmentSourceValueUnionType("boolean"); } }
        
        public static HRISDepartmentSourceValueUnionType HRISDepartmentSourceValue { get { return new HRISDepartmentSourceValueUnionType("HRISDepartment_source_value"); } }
        
        public static HRISDepartmentSourceValueUnionType ArrayOfAny { get { return new HRISDepartmentSourceValueUnionType("arrayOfAny"); } }
        
        public static HRISDepartmentSourceValueUnionType Null { get { return new HRISDepartmentSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HRISDepartmentSourceValueUnionType v) { return v.Value; }
        public static HRISDepartmentSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "HRISDepartment_source_value": return HRISDepartmentSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HRISDepartmentSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HRISDepartmentSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(HRISDepartmentSourceValueUnion.HRISDepartmentSourceValueUnionConverter))]
    public class HRISDepartmentSourceValueUnion {
        public HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HRISDepartmentSourceValue? HRISDepartmentSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public HRISDepartmentSourceValueUnionType Type { get; set; }


        public static HRISDepartmentSourceValueUnion CreateStr(string str) {
            HRISDepartmentSourceValueUnionType typ = HRISDepartmentSourceValueUnionType.Str;

            HRISDepartmentSourceValueUnion res = new HRISDepartmentSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static HRISDepartmentSourceValueUnion CreateNumber(double number) {
            HRISDepartmentSourceValueUnionType typ = HRISDepartmentSourceValueUnionType.Number;

            HRISDepartmentSourceValueUnion res = new HRISDepartmentSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static HRISDepartmentSourceValueUnion CreateBoolean(bool boolean) {
            HRISDepartmentSourceValueUnionType typ = HRISDepartmentSourceValueUnionType.Boolean;

            HRISDepartmentSourceValueUnion res = new HRISDepartmentSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HRISDepartmentSourceValueUnion CreateHRISDepartmentSourceValue(HRISDepartmentSourceValue hrisDepartmentSourceValue) {
            HRISDepartmentSourceValueUnionType typ = HRISDepartmentSourceValueUnionType.HRISDepartmentSourceValue;

            HRISDepartmentSourceValueUnion res = new HRISDepartmentSourceValueUnion(typ);
            res.HRISDepartmentSourceValue = hrisDepartmentSourceValue;
            return res;
        }

        public static HRISDepartmentSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            HRISDepartmentSourceValueUnionType typ = HRISDepartmentSourceValueUnionType.ArrayOfAny;

            HRISDepartmentSourceValueUnion res = new HRISDepartmentSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static HRISDepartmentSourceValueUnion CreateNull() {
            HRISDepartmentSourceValueUnionType typ = HRISDepartmentSourceValueUnionType.Null;
            return new HRISDepartmentSourceValueUnion(typ);
        }

        public class HRISDepartmentSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HRISDepartmentSourceValueUnion);

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
                    return new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.HRISDepartmentSourceValue)
                    {
                        HRISDepartmentSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HRISDepartmentSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HRISDepartmentSourceValue), new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.HRISDepartmentSourceValue), "HRISDepartmentSourceValue"));
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
                    return new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.Number)
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
                    return new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.Boolean)
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
                    return new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new HRISDepartmentSourceValueUnion(HRISDepartmentSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                HRISDepartmentSourceValueUnion res = (HRISDepartmentSourceValueUnion)value;
                if (HRISDepartmentSourceValueUnionType.FromString(res.Type).Equals(HRISDepartmentSourceValueUnionType.Null))
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
                if (res.HRISDepartmentSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HRISDepartmentSourceValue));
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