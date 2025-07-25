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
    

    public class InterviewSourceValueUnionType
    {
        private InterviewSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static InterviewSourceValueUnionType Str { get { return new InterviewSourceValueUnionType("str"); } }
        
        public static InterviewSourceValueUnionType Number { get { return new InterviewSourceValueUnionType("number"); } }
        
        public static InterviewSourceValueUnionType Boolean { get { return new InterviewSourceValueUnionType("boolean"); } }
        
        public static InterviewSourceValueUnionType InterviewSourceValue { get { return new InterviewSourceValueUnionType("Interview_source_value"); } }
        
        public static InterviewSourceValueUnionType ArrayOfAny { get { return new InterviewSourceValueUnionType("arrayOfAny"); } }
        
        public static InterviewSourceValueUnionType Null { get { return new InterviewSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(InterviewSourceValueUnionType v) { return v.Value; }
        public static InterviewSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "Interview_source_value": return InterviewSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for InterviewSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((InterviewSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The source value of the interview status.
    /// </summary>
    [JsonConverter(typeof(InterviewSourceValueUnion.InterviewSourceValueUnionConverter))]
    public class InterviewSourceValueUnion {
        public InterviewSourceValueUnion(InterviewSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public InterviewSourceValue? InterviewSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public InterviewSourceValueUnionType Type { get; set; }


        public static InterviewSourceValueUnion CreateStr(string str) {
            InterviewSourceValueUnionType typ = InterviewSourceValueUnionType.Str;

            InterviewSourceValueUnion res = new InterviewSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static InterviewSourceValueUnion CreateNumber(double number) {
            InterviewSourceValueUnionType typ = InterviewSourceValueUnionType.Number;

            InterviewSourceValueUnion res = new InterviewSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static InterviewSourceValueUnion CreateBoolean(bool boolean) {
            InterviewSourceValueUnionType typ = InterviewSourceValueUnionType.Boolean;

            InterviewSourceValueUnion res = new InterviewSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static InterviewSourceValueUnion CreateInterviewSourceValue(InterviewSourceValue interviewSourceValue) {
            InterviewSourceValueUnionType typ = InterviewSourceValueUnionType.InterviewSourceValue;

            InterviewSourceValueUnion res = new InterviewSourceValueUnion(typ);
            res.InterviewSourceValue = interviewSourceValue;
            return res;
        }

        public static InterviewSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            InterviewSourceValueUnionType typ = InterviewSourceValueUnionType.ArrayOfAny;

            InterviewSourceValueUnion res = new InterviewSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static InterviewSourceValueUnion CreateNull() {
            InterviewSourceValueUnionType typ = InterviewSourceValueUnionType.Null;
            return new InterviewSourceValueUnion(typ);
        }

        public class InterviewSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(InterviewSourceValueUnion);

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
                    return new InterviewSourceValueUnion(InterviewSourceValueUnionType.InterviewSourceValue)
                    {
                        InterviewSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<InterviewSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(InterviewSourceValue), new InterviewSourceValueUnion(InterviewSourceValueUnionType.InterviewSourceValue), "InterviewSourceValue"));
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
                    return new InterviewSourceValueUnion(InterviewSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new InterviewSourceValueUnion(InterviewSourceValueUnionType.Number)
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
                    return new InterviewSourceValueUnion(InterviewSourceValueUnionType.Boolean)
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
                    return new InterviewSourceValueUnion(InterviewSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new InterviewSourceValueUnion(InterviewSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                InterviewSourceValueUnion res = (InterviewSourceValueUnion)value;
                if (InterviewSourceValueUnionType.FromString(res.Type).Equals(InterviewSourceValueUnionType.Null))
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
                if (res.InterviewSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.InterviewSourceValue));
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