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
    

    public class HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType
    {
        private HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType Str { get { return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType("str"); } }
        
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType Number { get { return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType("number"); } }
        
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType Boolean { get { return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType("boolean"); } }
        
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType { get { return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType("HrisCreateEmployeeRequestDto_source_value_employment_contract_type"); } }
        
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType ArrayOfAny { get { return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType("arrayOfAny"); } }
        
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType Null { get { return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType v) { return v.Value; }
        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "HrisCreateEmployeeRequestDto_source_value_employment_contract_type": return HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion.HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionConverter))]
    public class HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion {
        public HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType? HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType Type { get; set; }


        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion CreateStr(string str) {
            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType typ = HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Str;

            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion res = new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion CreateNumber(double number) {
            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType typ = HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Number;

            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion res = new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion CreateBoolean(bool boolean) {
            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType typ = HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Boolean;

            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion res = new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion CreateHrisCreateEmployeeRequestDtoSourceValueEmploymentContractType(HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType hrisCreateEmployeeRequestDtoSourceValueEmploymentContractType) {
            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType typ = HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType;

            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion res = new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(typ);
            res.HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType = hrisCreateEmployeeRequestDtoSourceValueEmploymentContractType;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType typ = HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.ArrayOfAny;

            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion res = new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion CreateNull() {
            HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType typ = HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Null;
            return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(typ);
        }

        public class HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion);

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
                    return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType)
                    {
                        HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType), new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType), "HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType"));
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
                    return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Number)
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
                    return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Boolean)
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
                    return new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion res = (HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnion)value;
                if (HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.FromString(res.Type).Equals(HrisCreateEmployeeRequestDtoEmploymentContractTypeSourceValueUnionType.Null))
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
                if (res.HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HrisCreateEmployeeRequestDtoSourceValueEmploymentContractType));
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