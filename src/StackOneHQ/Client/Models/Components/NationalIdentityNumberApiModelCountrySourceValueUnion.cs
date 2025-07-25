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
    

    public class NationalIdentityNumberApiModelCountrySourceValueUnionType
    {
        private NationalIdentityNumberApiModelCountrySourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType Str { get { return new NationalIdentityNumberApiModelCountrySourceValueUnionType("str"); } }
        
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType Number { get { return new NationalIdentityNumberApiModelCountrySourceValueUnionType("number"); } }
        
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType Boolean { get { return new NationalIdentityNumberApiModelCountrySourceValueUnionType("boolean"); } }
        
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType NationalIdentityNumberApiModelSourceValueCountry { get { return new NationalIdentityNumberApiModelCountrySourceValueUnionType("NationalIdentityNumberApiModel_source_value_country"); } }
        
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType ArrayOfAny { get { return new NationalIdentityNumberApiModelCountrySourceValueUnionType("arrayOfAny"); } }
        
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType Null { get { return new NationalIdentityNumberApiModelCountrySourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(NationalIdentityNumberApiModelCountrySourceValueUnionType v) { return v.Value; }
        public static NationalIdentityNumberApiModelCountrySourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "NationalIdentityNumberApiModel_source_value_country": return NationalIdentityNumberApiModelSourceValueCountry;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for NationalIdentityNumberApiModelCountrySourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((NationalIdentityNumberApiModelCountrySourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(NationalIdentityNumberApiModelCountrySourceValueUnion.NationalIdentityNumberApiModelCountrySourceValueUnionConverter))]
    public class NationalIdentityNumberApiModelCountrySourceValueUnion {
        public NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public NationalIdentityNumberApiModelSourceValueCountry? NationalIdentityNumberApiModelSourceValueCountry { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public NationalIdentityNumberApiModelCountrySourceValueUnionType Type { get; set; }


        public static NationalIdentityNumberApiModelCountrySourceValueUnion CreateStr(string str) {
            NationalIdentityNumberApiModelCountrySourceValueUnionType typ = NationalIdentityNumberApiModelCountrySourceValueUnionType.Str;

            NationalIdentityNumberApiModelCountrySourceValueUnion res = new NationalIdentityNumberApiModelCountrySourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static NationalIdentityNumberApiModelCountrySourceValueUnion CreateNumber(double number) {
            NationalIdentityNumberApiModelCountrySourceValueUnionType typ = NationalIdentityNumberApiModelCountrySourceValueUnionType.Number;

            NationalIdentityNumberApiModelCountrySourceValueUnion res = new NationalIdentityNumberApiModelCountrySourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static NationalIdentityNumberApiModelCountrySourceValueUnion CreateBoolean(bool boolean) {
            NationalIdentityNumberApiModelCountrySourceValueUnionType typ = NationalIdentityNumberApiModelCountrySourceValueUnionType.Boolean;

            NationalIdentityNumberApiModelCountrySourceValueUnion res = new NationalIdentityNumberApiModelCountrySourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static NationalIdentityNumberApiModelCountrySourceValueUnion CreateNationalIdentityNumberApiModelSourceValueCountry(NationalIdentityNumberApiModelSourceValueCountry nationalIdentityNumberAPIModelSourceValueCountry) {
            NationalIdentityNumberApiModelCountrySourceValueUnionType typ = NationalIdentityNumberApiModelCountrySourceValueUnionType.NationalIdentityNumberApiModelSourceValueCountry;

            NationalIdentityNumberApiModelCountrySourceValueUnion res = new NationalIdentityNumberApiModelCountrySourceValueUnion(typ);
            res.NationalIdentityNumberApiModelSourceValueCountry = nationalIdentityNumberAPIModelSourceValueCountry;
            return res;
        }

        public static NationalIdentityNumberApiModelCountrySourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            NationalIdentityNumberApiModelCountrySourceValueUnionType typ = NationalIdentityNumberApiModelCountrySourceValueUnionType.ArrayOfAny;

            NationalIdentityNumberApiModelCountrySourceValueUnion res = new NationalIdentityNumberApiModelCountrySourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static NationalIdentityNumberApiModelCountrySourceValueUnion CreateNull() {
            NationalIdentityNumberApiModelCountrySourceValueUnionType typ = NationalIdentityNumberApiModelCountrySourceValueUnionType.Null;
            return new NationalIdentityNumberApiModelCountrySourceValueUnion(typ);
        }

        public class NationalIdentityNumberApiModelCountrySourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(NationalIdentityNumberApiModelCountrySourceValueUnion);

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
                    return new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.NationalIdentityNumberApiModelSourceValueCountry)
                    {
                        NationalIdentityNumberApiModelSourceValueCountry = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<NationalIdentityNumberApiModelSourceValueCountry>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(NationalIdentityNumberApiModelSourceValueCountry), new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.NationalIdentityNumberApiModelSourceValueCountry), "NationalIdentityNumberApiModelSourceValueCountry"));
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
                    return new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.Number)
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
                    return new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.Boolean)
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
                    return new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new NationalIdentityNumberApiModelCountrySourceValueUnion(NationalIdentityNumberApiModelCountrySourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                NationalIdentityNumberApiModelCountrySourceValueUnion res = (NationalIdentityNumberApiModelCountrySourceValueUnion)value;
                if (NationalIdentityNumberApiModelCountrySourceValueUnionType.FromString(res.Type).Equals(NationalIdentityNumberApiModelCountrySourceValueUnionType.Null))
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
                if (res.NationalIdentityNumberApiModelSourceValueCountry != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.NationalIdentityNumberApiModelSourceValueCountry));
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