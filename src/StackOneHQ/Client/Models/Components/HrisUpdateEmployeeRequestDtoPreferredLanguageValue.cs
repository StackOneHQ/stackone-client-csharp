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
    using StackOneHQ.Client.Utils;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The ISO639-2 Code of the language
    /// </summary>
    [JsonConverter(typeof(OpenEnumConverter))]
    public class HrisUpdateEmployeeRequestDtoPreferredLanguageValue : IEquatable<HrisUpdateEmployeeRequestDtoPreferredLanguageValue>
    {
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Aar = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("aar");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Afr = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("afr");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Amh = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("amh");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ara = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ara");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Aym = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("aym");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Aze = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("aze");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Bel = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("bel");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Bul = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("bul");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Bis = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("bis");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ben = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ben");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Bos = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("bos");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Byn = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("byn");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Cat = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("cat");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Cha = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("cha");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ces = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ces");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Dan = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("dan");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Deu = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("deu");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Div = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("div");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Dzo = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("dzo");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ell = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ell");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Eng = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("eng");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Spa = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("spa");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Est = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("est");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Fas = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("fas");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Fan = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("fan");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ful = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ful");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Fin = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("fin");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Fij = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("fij");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Fao = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("fao");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Fra = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("fra");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Gle = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("gle");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Grn = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("grn");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Guj = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("guj");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Glv = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("glv");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Heb = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("heb");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Hin = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("hin");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Hrv = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("hrv");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Hat = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("hat");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Hun = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("hun");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Hye = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("hye");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ind = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ind");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Isl = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("isl");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ita = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ita");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Jpn = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("jpn");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kat = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kat");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kon = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kon");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kaz = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kaz");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kal = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kal");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Khm = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("khm");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kor = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kor");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kur = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kur");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kir = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kir");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Lat = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("lat");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ltz = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ltz");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Lin = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("lin");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Lao = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("lao");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Lit = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("lit");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Lub = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("lub");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Lav = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("lav");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mlg = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mlg");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mah = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mah");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mri = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mri");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mkd = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mkd");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mon = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mon");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mar = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mar");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Msa = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("msa");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mlt = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mlt");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Mya = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("mya");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nob = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nob");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nep = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nep");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nld = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nld");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nno = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nno");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nor = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nor");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nbl = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nbl");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Nya = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("nya");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Pan = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("pan");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Pol = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("pol");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Pus = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("pus");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Por = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("por");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Que = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("que");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Rar = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("rar");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Roh = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("roh");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Rup = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("rup");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ron = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ron");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Rus = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("rus");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Kin = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("kin");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Sme = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("sme");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Sag = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("sag");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Sin = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("sin");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Slk = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("slk");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Slv = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("slv");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Smo = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("smo");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Sna = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("sna");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Som = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("som");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Sqi = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("sqi");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Srp = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("srp");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ssw = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ssw");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Swe = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("swe");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Swa = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("swa");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tam = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tam");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tel = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tel");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tgk = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tgk");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tha = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tha");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tir = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tir");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tig = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tig");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tuk = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tuk");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tsn = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tsn");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ton = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ton");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tur = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tur");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Tso = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("tso");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ukr = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ukr");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Urd = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("urd");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Uzb = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("uzb");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Ven = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("ven");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Vie = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("vie");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Xho = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("xho");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Zho = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("zho");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue Zul = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("zul");
        public static readonly HrisUpdateEmployeeRequestDtoPreferredLanguageValue UnmappedValue = new HrisUpdateEmployeeRequestDtoPreferredLanguageValue("unmapped_value");

        private static readonly Dictionary <string, HrisUpdateEmployeeRequestDtoPreferredLanguageValue> _knownValues =
            new Dictionary <string, HrisUpdateEmployeeRequestDtoPreferredLanguageValue> ()
            {
                ["aar"] = Aar,
                ["afr"] = Afr,
                ["amh"] = Amh,
                ["ara"] = Ara,
                ["aym"] = Aym,
                ["aze"] = Aze,
                ["bel"] = Bel,
                ["bul"] = Bul,
                ["bis"] = Bis,
                ["ben"] = Ben,
                ["bos"] = Bos,
                ["byn"] = Byn,
                ["cat"] = Cat,
                ["cha"] = Cha,
                ["ces"] = Ces,
                ["dan"] = Dan,
                ["deu"] = Deu,
                ["div"] = Div,
                ["dzo"] = Dzo,
                ["ell"] = Ell,
                ["eng"] = Eng,
                ["spa"] = Spa,
                ["est"] = Est,
                ["fas"] = Fas,
                ["fan"] = Fan,
                ["ful"] = Ful,
                ["fin"] = Fin,
                ["fij"] = Fij,
                ["fao"] = Fao,
                ["fra"] = Fra,
                ["gle"] = Gle,
                ["grn"] = Grn,
                ["guj"] = Guj,
                ["glv"] = Glv,
                ["heb"] = Heb,
                ["hin"] = Hin,
                ["hrv"] = Hrv,
                ["hat"] = Hat,
                ["hun"] = Hun,
                ["hye"] = Hye,
                ["ind"] = Ind,
                ["isl"] = Isl,
                ["ita"] = Ita,
                ["jpn"] = Jpn,
                ["kat"] = Kat,
                ["kon"] = Kon,
                ["kaz"] = Kaz,
                ["kal"] = Kal,
                ["khm"] = Khm,
                ["kor"] = Kor,
                ["kur"] = Kur,
                ["kir"] = Kir,
                ["lat"] = Lat,
                ["ltz"] = Ltz,
                ["lin"] = Lin,
                ["lao"] = Lao,
                ["lit"] = Lit,
                ["lub"] = Lub,
                ["lav"] = Lav,
                ["mlg"] = Mlg,
                ["mah"] = Mah,
                ["mri"] = Mri,
                ["mkd"] = Mkd,
                ["mon"] = Mon,
                ["mar"] = Mar,
                ["msa"] = Msa,
                ["mlt"] = Mlt,
                ["mya"] = Mya,
                ["nob"] = Nob,
                ["nep"] = Nep,
                ["nld"] = Nld,
                ["nno"] = Nno,
                ["nor"] = Nor,
                ["nbl"] = Nbl,
                ["nya"] = Nya,
                ["pan"] = Pan,
                ["pol"] = Pol,
                ["pus"] = Pus,
                ["por"] = Por,
                ["que"] = Que,
                ["rar"] = Rar,
                ["roh"] = Roh,
                ["rup"] = Rup,
                ["ron"] = Ron,
                ["rus"] = Rus,
                ["kin"] = Kin,
                ["sme"] = Sme,
                ["sag"] = Sag,
                ["sin"] = Sin,
                ["slk"] = Slk,
                ["slv"] = Slv,
                ["smo"] = Smo,
                ["sna"] = Sna,
                ["som"] = Som,
                ["sqi"] = Sqi,
                ["srp"] = Srp,
                ["ssw"] = Ssw,
                ["swe"] = Swe,
                ["swa"] = Swa,
                ["tam"] = Tam,
                ["tel"] = Tel,
                ["tgk"] = Tgk,
                ["tha"] = Tha,
                ["tir"] = Tir,
                ["tig"] = Tig,
                ["tuk"] = Tuk,
                ["tsn"] = Tsn,
                ["ton"] = Ton,
                ["tur"] = Tur,
                ["tso"] = Tso,
                ["ukr"] = Ukr,
                ["urd"] = Urd,
                ["uzb"] = Uzb,
                ["ven"] = Ven,
                ["vie"] = Vie,
                ["xho"] = Xho,
                ["zho"] = Zho,
                ["zul"] = Zul,
                ["unmapped_value"] = UnmappedValue
            };

        private static readonly ConcurrentDictionary<string, HrisUpdateEmployeeRequestDtoPreferredLanguageValue> _values =
            new ConcurrentDictionary<string, HrisUpdateEmployeeRequestDtoPreferredLanguageValue>(_knownValues);

        private HrisUpdateEmployeeRequestDtoPreferredLanguageValue(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        public string Value { get; }

        public static HrisUpdateEmployeeRequestDtoPreferredLanguageValue Of(string value)
        {
            return _values.GetOrAdd(value, _ => new HrisUpdateEmployeeRequestDtoPreferredLanguageValue(value));
        }

        public static implicit operator HrisUpdateEmployeeRequestDtoPreferredLanguageValue(string value) => Of(value);
        public static implicit operator string(HrisUpdateEmployeeRequestDtoPreferredLanguageValue hrisupdateemployeerequestdtopreferredlanguagevalue) => hrisupdateemployeerequestdtopreferredlanguagevalue.Value;

        public static HrisUpdateEmployeeRequestDtoPreferredLanguageValue[] Values()
        {
            return _values.Values.ToArray();
        }

        public override string ToString() => Value.ToString();

        public bool IsKnown()
        {
            return _knownValues.ContainsKey(Value);
        }

        public override bool Equals(object? obj) => Equals(obj as HrisUpdateEmployeeRequestDtoPreferredLanguageValue);

        public bool Equals(HrisUpdateEmployeeRequestDtoPreferredLanguageValue? other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }

}