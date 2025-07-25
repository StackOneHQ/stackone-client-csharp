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
    

    public class HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType
    {
        private HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType Str { get { return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType("str"); } }
        
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType Number { get { return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType("number"); } }
        
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType Boolean { get { return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType("boolean"); } }
        
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType HrisCreateWorkEligibilityRequestDtoSourceValueCategory { get { return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType("HrisCreateWorkEligibilityRequestDto_source_value_category"); } }
        
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType ArrayOfAny { get { return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType("arrayOfAny"); } }
        
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType Null { get { return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType v) { return v.Value; }
        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "HrisCreateWorkEligibilityRequestDto_source_value_category": return HrisCreateWorkEligibilityRequestDtoSourceValueCategory;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion.HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionConverter))]
    public class HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion {
        public HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HrisCreateWorkEligibilityRequestDtoSourceValueCategory? HrisCreateWorkEligibilityRequestDtoSourceValueCategory { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType Type { get; set; }


        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion CreateStr(string str) {
            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType typ = HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Str;

            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion res = new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion CreateNumber(double number) {
            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType typ = HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Number;

            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion res = new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion CreateBoolean(bool boolean) {
            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType typ = HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Boolean;

            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion res = new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion CreateHrisCreateWorkEligibilityRequestDtoSourceValueCategory(HrisCreateWorkEligibilityRequestDtoSourceValueCategory hrisCreateWorkEligibilityRequestDtoSourceValueCategory) {
            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType typ = HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.HrisCreateWorkEligibilityRequestDtoSourceValueCategory;

            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion res = new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(typ);
            res.HrisCreateWorkEligibilityRequestDtoSourceValueCategory = hrisCreateWorkEligibilityRequestDtoSourceValueCategory;
            return res;
        }

        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType typ = HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.ArrayOfAny;

            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion res = new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion CreateNull() {
            HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType typ = HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Null;
            return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(typ);
        }

        public class HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion);

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
                    return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.HrisCreateWorkEligibilityRequestDtoSourceValueCategory)
                    {
                        HrisCreateWorkEligibilityRequestDtoSourceValueCategory = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HrisCreateWorkEligibilityRequestDtoSourceValueCategory>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HrisCreateWorkEligibilityRequestDtoSourceValueCategory), new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.HrisCreateWorkEligibilityRequestDtoSourceValueCategory), "HrisCreateWorkEligibilityRequestDtoSourceValueCategory"));
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
                    return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Number)
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
                    return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Boolean)
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
                    return new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion res = (HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnion)value;
                if (HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.FromString(res.Type).Equals(HrisCreateWorkEligibilityRequestDtoCategorySourceValueUnionType.Null))
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
                if (res.HrisCreateWorkEligibilityRequestDtoSourceValueCategory != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HrisCreateWorkEligibilityRequestDtoSourceValueCategory));
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