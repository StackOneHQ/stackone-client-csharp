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
    

    public class CompletionLearningObjectTypeSourceValueUnionType
    {
        private CompletionLearningObjectTypeSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CompletionLearningObjectTypeSourceValueUnionType Str { get { return new CompletionLearningObjectTypeSourceValueUnionType("str"); } }
        
        public static CompletionLearningObjectTypeSourceValueUnionType Number { get { return new CompletionLearningObjectTypeSourceValueUnionType("number"); } }
        
        public static CompletionLearningObjectTypeSourceValueUnionType Boolean { get { return new CompletionLearningObjectTypeSourceValueUnionType("boolean"); } }
        
        public static CompletionLearningObjectTypeSourceValueUnionType CompletionSourceValueLearningObjectType { get { return new CompletionLearningObjectTypeSourceValueUnionType("Completion_source_value_learning_object_type"); } }
        
        public static CompletionLearningObjectTypeSourceValueUnionType ArrayOfAny { get { return new CompletionLearningObjectTypeSourceValueUnionType("arrayOfAny"); } }
        
        public static CompletionLearningObjectTypeSourceValueUnionType Null { get { return new CompletionLearningObjectTypeSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CompletionLearningObjectTypeSourceValueUnionType v) { return v.Value; }
        public static CompletionLearningObjectTypeSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "Completion_source_value_learning_object_type": return CompletionSourceValueLearningObjectType;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CompletionLearningObjectTypeSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CompletionLearningObjectTypeSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(CompletionLearningObjectTypeSourceValueUnion.CompletionLearningObjectTypeSourceValueUnionConverter))]
    public class CompletionLearningObjectTypeSourceValueUnion {
        public CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CompletionSourceValueLearningObjectType? CompletionSourceValueLearningObjectType { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public CompletionLearningObjectTypeSourceValueUnionType Type { get; set; }


        public static CompletionLearningObjectTypeSourceValueUnion CreateStr(string str) {
            CompletionLearningObjectTypeSourceValueUnionType typ = CompletionLearningObjectTypeSourceValueUnionType.Str;

            CompletionLearningObjectTypeSourceValueUnion res = new CompletionLearningObjectTypeSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static CompletionLearningObjectTypeSourceValueUnion CreateNumber(double number) {
            CompletionLearningObjectTypeSourceValueUnionType typ = CompletionLearningObjectTypeSourceValueUnionType.Number;

            CompletionLearningObjectTypeSourceValueUnion res = new CompletionLearningObjectTypeSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static CompletionLearningObjectTypeSourceValueUnion CreateBoolean(bool boolean) {
            CompletionLearningObjectTypeSourceValueUnionType typ = CompletionLearningObjectTypeSourceValueUnionType.Boolean;

            CompletionLearningObjectTypeSourceValueUnion res = new CompletionLearningObjectTypeSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static CompletionLearningObjectTypeSourceValueUnion CreateCompletionSourceValueLearningObjectType(CompletionSourceValueLearningObjectType completionSourceValueLearningObjectType) {
            CompletionLearningObjectTypeSourceValueUnionType typ = CompletionLearningObjectTypeSourceValueUnionType.CompletionSourceValueLearningObjectType;

            CompletionLearningObjectTypeSourceValueUnion res = new CompletionLearningObjectTypeSourceValueUnion(typ);
            res.CompletionSourceValueLearningObjectType = completionSourceValueLearningObjectType;
            return res;
        }

        public static CompletionLearningObjectTypeSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            CompletionLearningObjectTypeSourceValueUnionType typ = CompletionLearningObjectTypeSourceValueUnionType.ArrayOfAny;

            CompletionLearningObjectTypeSourceValueUnion res = new CompletionLearningObjectTypeSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static CompletionLearningObjectTypeSourceValueUnion CreateNull() {
            CompletionLearningObjectTypeSourceValueUnionType typ = CompletionLearningObjectTypeSourceValueUnionType.Null;
            return new CompletionLearningObjectTypeSourceValueUnion(typ);
        }

        public class CompletionLearningObjectTypeSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CompletionLearningObjectTypeSourceValueUnion);

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
                    return new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.CompletionSourceValueLearningObjectType)
                    {
                        CompletionSourceValueLearningObjectType = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CompletionSourceValueLearningObjectType>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CompletionSourceValueLearningObjectType), new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.CompletionSourceValueLearningObjectType), "CompletionSourceValueLearningObjectType"));
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
                    return new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.Number)
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
                    return new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.Boolean)
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
                    return new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new CompletionLearningObjectTypeSourceValueUnion(CompletionLearningObjectTypeSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                CompletionLearningObjectTypeSourceValueUnion res = (CompletionLearningObjectTypeSourceValueUnion)value;
                if (CompletionLearningObjectTypeSourceValueUnionType.FromString(res.Type).Equals(CompletionLearningObjectTypeSourceValueUnionType.Null))
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
                if (res.CompletionSourceValueLearningObjectType != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CompletionSourceValueLearningObjectType));
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