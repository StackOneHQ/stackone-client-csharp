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
    

    public class UnifiedUploadRequestDtoConfidentialSourceValueUnionType
    {
        private UnifiedUploadRequestDtoConfidentialSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType Str { get { return new UnifiedUploadRequestDtoConfidentialSourceValueUnionType("str"); } }
        
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType Number { get { return new UnifiedUploadRequestDtoConfidentialSourceValueUnionType("number"); } }
        
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType Boolean { get { return new UnifiedUploadRequestDtoConfidentialSourceValueUnionType("boolean"); } }
        
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType UnifiedUploadRequestDtoSourceValueConfidential { get { return new UnifiedUploadRequestDtoConfidentialSourceValueUnionType("UnifiedUploadRequestDto_source_value_confidential"); } }
        
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType ArrayOfAny { get { return new UnifiedUploadRequestDtoConfidentialSourceValueUnionType("arrayOfAny"); } }
        
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType Null { get { return new UnifiedUploadRequestDtoConfidentialSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(UnifiedUploadRequestDtoConfidentialSourceValueUnionType v) { return v.Value; }
        public static UnifiedUploadRequestDtoConfidentialSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "UnifiedUploadRequestDto_source_value_confidential": return UnifiedUploadRequestDtoSourceValueConfidential;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for UnifiedUploadRequestDtoConfidentialSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((UnifiedUploadRequestDtoConfidentialSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(UnifiedUploadRequestDtoConfidentialSourceValueUnion.UnifiedUploadRequestDtoConfidentialSourceValueUnionConverter))]
    public class UnifiedUploadRequestDtoConfidentialSourceValueUnion {
        public UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public UnifiedUploadRequestDtoSourceValueConfidential? UnifiedUploadRequestDtoSourceValueConfidential { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public UnifiedUploadRequestDtoConfidentialSourceValueUnionType Type { get; set; }


        public static UnifiedUploadRequestDtoConfidentialSourceValueUnion CreateStr(string str) {
            UnifiedUploadRequestDtoConfidentialSourceValueUnionType typ = UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Str;

            UnifiedUploadRequestDtoConfidentialSourceValueUnion res = new UnifiedUploadRequestDtoConfidentialSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static UnifiedUploadRequestDtoConfidentialSourceValueUnion CreateNumber(double number) {
            UnifiedUploadRequestDtoConfidentialSourceValueUnionType typ = UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Number;

            UnifiedUploadRequestDtoConfidentialSourceValueUnion res = new UnifiedUploadRequestDtoConfidentialSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static UnifiedUploadRequestDtoConfidentialSourceValueUnion CreateBoolean(bool boolean) {
            UnifiedUploadRequestDtoConfidentialSourceValueUnionType typ = UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Boolean;

            UnifiedUploadRequestDtoConfidentialSourceValueUnion res = new UnifiedUploadRequestDtoConfidentialSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static UnifiedUploadRequestDtoConfidentialSourceValueUnion CreateUnifiedUploadRequestDtoSourceValueConfidential(UnifiedUploadRequestDtoSourceValueConfidential unifiedUploadRequestDtoSourceValueConfidential) {
            UnifiedUploadRequestDtoConfidentialSourceValueUnionType typ = UnifiedUploadRequestDtoConfidentialSourceValueUnionType.UnifiedUploadRequestDtoSourceValueConfidential;

            UnifiedUploadRequestDtoConfidentialSourceValueUnion res = new UnifiedUploadRequestDtoConfidentialSourceValueUnion(typ);
            res.UnifiedUploadRequestDtoSourceValueConfidential = unifiedUploadRequestDtoSourceValueConfidential;
            return res;
        }

        public static UnifiedUploadRequestDtoConfidentialSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            UnifiedUploadRequestDtoConfidentialSourceValueUnionType typ = UnifiedUploadRequestDtoConfidentialSourceValueUnionType.ArrayOfAny;

            UnifiedUploadRequestDtoConfidentialSourceValueUnion res = new UnifiedUploadRequestDtoConfidentialSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static UnifiedUploadRequestDtoConfidentialSourceValueUnion CreateNull() {
            UnifiedUploadRequestDtoConfidentialSourceValueUnionType typ = UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Null;
            return new UnifiedUploadRequestDtoConfidentialSourceValueUnion(typ);
        }

        public class UnifiedUploadRequestDtoConfidentialSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(UnifiedUploadRequestDtoConfidentialSourceValueUnion);

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
                    return new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.UnifiedUploadRequestDtoSourceValueConfidential)
                    {
                        UnifiedUploadRequestDtoSourceValueConfidential = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<UnifiedUploadRequestDtoSourceValueConfidential>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(UnifiedUploadRequestDtoSourceValueConfidential), new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.UnifiedUploadRequestDtoSourceValueConfidential), "UnifiedUploadRequestDtoSourceValueConfidential"));
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
                    return new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Number)
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
                    return new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Boolean)
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
                    return new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new UnifiedUploadRequestDtoConfidentialSourceValueUnion(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                UnifiedUploadRequestDtoConfidentialSourceValueUnion res = (UnifiedUploadRequestDtoConfidentialSourceValueUnion)value;
                if (UnifiedUploadRequestDtoConfidentialSourceValueUnionType.FromString(res.Type).Equals(UnifiedUploadRequestDtoConfidentialSourceValueUnionType.Null))
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
                if (res.UnifiedUploadRequestDtoSourceValueConfidential != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.UnifiedUploadRequestDtoSourceValueConfidential));
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