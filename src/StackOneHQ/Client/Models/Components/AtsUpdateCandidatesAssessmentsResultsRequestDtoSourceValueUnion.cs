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
    

    public class AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType
    {
        private AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType Str { get { return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType("str"); } }
        
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType Number { get { return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType("number"); } }
        
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType Boolean { get { return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType("boolean"); } }
        
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue { get { return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType("AtsUpdateCandidatesAssessmentsResultsRequestDto_source_value"); } }
        
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType ArrayOfAny { get { return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType("arrayOfAny"); } }
        
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType Null { get { return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType v) { return v.Value; }
        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "AtsUpdateCandidatesAssessmentsResultsRequestDto_source_value": return AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The source value of the test result.
    /// </summary>
    [JsonConverter(typeof(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionConverter))]
    public class AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion {
        public AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue? AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType Type { get; set; }


        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion CreateStr(string str) {
            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType typ = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Str;

            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion res = new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion CreateNumber(double number) {
            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType typ = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Number;

            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion res = new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion CreateBoolean(bool boolean) {
            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType typ = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Boolean;

            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion res = new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion CreateAtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue atsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue) {
            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType typ = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue;

            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion res = new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(typ);
            res.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue = atsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue;
            return res;
        }

        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType typ = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.ArrayOfAny;

            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion res = new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion CreateNull() {
            AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType typ = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Null;
            return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(typ);
        }

        public class AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion);

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
                    return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue)
                    {
                        AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue), new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue), "AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue"));
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
                    return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Number)
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
                    return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Boolean)
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
                    return new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion res = (AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion)value;
                if (AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.FromString(res.Type).Equals(AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnionType.Null))
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
                if (res.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValue));
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