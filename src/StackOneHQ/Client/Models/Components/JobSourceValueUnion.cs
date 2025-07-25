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
    

    public class JobSourceValueUnionType
    {
        private JobSourceValueUnionType(string value) { Value = value; }

        public string Value { get; private set; }
        public static JobSourceValueUnionType Str { get { return new JobSourceValueUnionType("str"); } }
        
        public static JobSourceValueUnionType Number { get { return new JobSourceValueUnionType("number"); } }
        
        public static JobSourceValueUnionType Boolean { get { return new JobSourceValueUnionType("boolean"); } }
        
        public static JobSourceValueUnionType JobSourceValue { get { return new JobSourceValueUnionType("Job_source_value"); } }
        
        public static JobSourceValueUnionType ArrayOfAny { get { return new JobSourceValueUnionType("arrayOfAny"); } }
        
        public static JobSourceValueUnionType Null { get { return new JobSourceValueUnionType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(JobSourceValueUnionType v) { return v.Value; }
        public static JobSourceValueUnionType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "number": return Number;
                case "boolean": return Boolean;
                case "Job_source_value": return JobSourceValue;
                case "arrayOfAny": return ArrayOfAny;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for JobSourceValueUnionType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((JobSourceValueUnionType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The source value of the job status.
    /// </summary>
    [JsonConverter(typeof(JobSourceValueUnion.JobSourceValueUnionConverter))]
    public class JobSourceValueUnion {
        public JobSourceValueUnion(JobSourceValueUnionType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public JobSourceValue? JobSourceValue { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<object>? ArrayOfAny { get; set; }

        public JobSourceValueUnionType Type { get; set; }


        public static JobSourceValueUnion CreateStr(string str) {
            JobSourceValueUnionType typ = JobSourceValueUnionType.Str;

            JobSourceValueUnion res = new JobSourceValueUnion(typ);
            res.Str = str;
            return res;
        }

        public static JobSourceValueUnion CreateNumber(double number) {
            JobSourceValueUnionType typ = JobSourceValueUnionType.Number;

            JobSourceValueUnion res = new JobSourceValueUnion(typ);
            res.Number = number;
            return res;
        }

        public static JobSourceValueUnion CreateBoolean(bool boolean) {
            JobSourceValueUnionType typ = JobSourceValueUnionType.Boolean;

            JobSourceValueUnion res = new JobSourceValueUnion(typ);
            res.Boolean = boolean;
            return res;
        }

        public static JobSourceValueUnion CreateJobSourceValue(JobSourceValue jobSourceValue) {
            JobSourceValueUnionType typ = JobSourceValueUnionType.JobSourceValue;

            JobSourceValueUnion res = new JobSourceValueUnion(typ);
            res.JobSourceValue = jobSourceValue;
            return res;
        }

        public static JobSourceValueUnion CreateArrayOfAny(List<object> arrayOfAny) {
            JobSourceValueUnionType typ = JobSourceValueUnionType.ArrayOfAny;

            JobSourceValueUnion res = new JobSourceValueUnion(typ);
            res.ArrayOfAny = arrayOfAny;
            return res;
        }

        public static JobSourceValueUnion CreateNull() {
            JobSourceValueUnionType typ = JobSourceValueUnionType.Null;
            return new JobSourceValueUnion(typ);
        }

        public class JobSourceValueUnionConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(JobSourceValueUnion);

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
                    return new JobSourceValueUnion(JobSourceValueUnionType.JobSourceValue)
                    {
                        JobSourceValue = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<JobSourceValue>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(JobSourceValue), new JobSourceValueUnion(JobSourceValueUnionType.JobSourceValue), "JobSourceValue"));
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
                    return new JobSourceValueUnion(JobSourceValueUnionType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new JobSourceValueUnion(JobSourceValueUnionType.Number)
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
                    return new JobSourceValueUnion(JobSourceValueUnionType.Boolean)
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
                    return new JobSourceValueUnion(JobSourceValueUnionType.ArrayOfAny)
                    {
                        ArrayOfAny = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<object>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<object>), new JobSourceValueUnion(JobSourceValueUnionType.ArrayOfAny), "ArrayOfAny"));
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
                JobSourceValueUnion res = (JobSourceValueUnion)value;
                if (JobSourceValueUnionType.FromString(res.Type).Equals(JobSourceValueUnionType.Null))
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
                if (res.JobSourceValue != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.JobSourceValue));
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