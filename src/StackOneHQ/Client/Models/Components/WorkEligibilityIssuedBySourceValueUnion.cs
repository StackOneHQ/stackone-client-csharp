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
    

    public class WorkEligibilityIssuedBySourceValueUnionType
    {
        private WorkEligibilityIssuedBySourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static WorkEligibilityIssuedBySourceValueUnionType Str { get { return new WorkEligibilityIssuedBySourceValueUnionType("str"); } }
        
        public static WorkEligibilityIssuedBySourceValueUnionType Number { get { return new WorkEligibilityIssuedBySourceValueUnionType("number"); } }
        
        public static WorkEligibilityIssuedBySourceValueUnionType Boolean { get { return new WorkEligibilityIssuedBySourceValueUnionType("boolean"); } }
        
        public static WorkEligibilityIssuedBySourceValueUnionType WorkEligibilitySourceValueIssuedBy { get { return new WorkEligibilityIssuedBySourceValueUnionType("WorkEligibility_source_value_issued_by"); } }
        
        public static WorkEligibilityIssuedBySourceValueUnionType ArrayOfAny { get { return new WorkEligibilityIssuedBySourceValueUnionType("arrayOfAny"); } }
        
        public static WorkEligibilityIssuedBySourceValueUnionType Null { get { return new WorkEligibilityIssuedBySourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(WorkEligibilityIssuedBySourceValueUnionType v) { return v.Value; }
        public static WorkEligibilityIssuedBySourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "WorkEligibility_source_value_issued_by": return WorkEligibilitySourceValueIssuedBy;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for WorkEligibilityIssuedBySourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((WorkEligibilityIssuedBySourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(WorkEligibilityIssuedBySourceValueUnion.WorkEligibilityIssuedBySourceValueUnionConverter))]
    public class WorkEligibilityIssuedBySourceValueUnion {
        public WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public WorkEligibilitySourceValueIssuedBy? WorkEligibilitySourceValueIssuedBy { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public WorkEligibilityIssuedBySourceValueUnionType Type { get; set; }


        public static WorkEligibilityIssuedBySourceValueUnion CreateStr(string str) {
            WorkEligibilityIssuedBySourceValueUnionType typ = WorkEligibilityIssuedBySourceValueUnionType.Str;

            WorkEligibilityIssuedBySourceValueUnion res = new WorkEligibilityIssuedBySourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static WorkEligibilityIssuedBySourceValueUnion CreateNumber(double number) {
            WorkEligibilityIssuedBySourceValueUnionType typ = WorkEligibilityIssuedBySourceValueUnionType.Number;

            WorkEligibilityIssuedBySourceValueUnion res = new WorkEligibilityIssuedBySourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static WorkEligibilityIssuedBySourceValueUnion CreateBoolean(bool boolean) {
            WorkEligibilityIssuedBySourceValueUnionType typ = WorkEligibilityIssuedBySourceValueUnionType.Boolean;

            WorkEligibilityIssuedBySourceValueUnion res = new WorkEligibilityIssuedBySourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static WorkEligibilityIssuedBySourceValueUnion CreateWorkEligibilitySourceValueIssuedBy(WorkEligibilitySourceValueIssuedBy workEligibilitySourceValueIssuedBy) {
            WorkEligibilityIssuedBySourceValueUnionType typ = WorkEligibilityIssuedBySourceValueUnionType.WorkEligibilitySourceValueIssuedBy;

            WorkEligibilityIssuedBySourceValueUnion res = new WorkEligibilityIssuedBySourceValueUnion(typ);
            res.WorkEligibilitySourceValueIssuedBy = workEligibilitySourceValueIssuedBy;
            return res;
        }

        public static WorkEligibilityIssuedBySourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            WorkEligibilityIssuedBySourceValueUnionType typ = WorkEligibilityIssuedBySourceValueUnionType.ArrayOfAny;

            WorkEligibilityIssuedBySourceValueUnion res = new WorkEligibilityIssuedBySourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static WorkEligibilityIssuedBySourceValueUnion CreateNull() {
            WorkEligibilityIssuedBySourceValueUnionType typ = WorkEligibilityIssuedBySourceValueUnionType.Null;
            return new WorkEligibilityIssuedBySourceValueUnion(typ);
        }

        public class WorkEligibilityIssuedBySourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(WorkEligibilityIssuedBySourceValueUnion);

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
                    return new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.WorkEligibilitySourceValueIssuedBy)
                    {
                        WorkEligibilitySourceValueIssuedBy = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<WorkEligibilitySourceValueIssuedBy>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(WorkEligibilitySourceValueIssuedBy), new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.WorkEligibilitySourceValueIssuedBy), "WorkEligibilitySourceValueIssuedBy"));
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
                    return new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.Number)
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
                    return new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.Boolean)
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
                    return new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new WorkEligibilityIssuedBySourceValueUnion(WorkEligibilityIssuedBySourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                WorkEligibilityIssuedBySourceValueUnion res = (WorkEligibilityIssuedBySourceValueUnion)value;
                if (WorkEligibilityIssuedBySourceValueUnionType.FromString(res.Type).Equals(WorkEligibilityIssuedBySourceValueUnionType.Null))
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
                if (res.WorkEligibilitySourceValueIssuedBy != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.WorkEligibilitySourceValueIssuedBy));
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