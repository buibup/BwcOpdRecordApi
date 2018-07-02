using Newtonsoft.Json;
using System;

namespace BwcOpdRecordApi.Data.Models.Questionnaires
{
    public class QBWCPEANTI
    {
        public long ID { get; set; }
        public long QUESPAAdmDR { get; set; }
        public long QUESPAPatMasDR { get; set; }
        public DateTime QUESDate { get; set; }
        public TimeSpan QUESTime { get; set; }
        [JsonProperty(PropertyName = "ChiefComplaint")]
        public string QCC { get; set; }
        [JsonProperty(PropertyName = "ChiefComplaintOther")]
        public string QCCText { get; set; }
        [JsonProperty(PropertyName = "PresentIllness")]
        public string QCCOtherText { get; set; }
        [JsonProperty(PropertyName = "UnderlyingDisease")]
        public string QUnderlying { get; set; }
        [JsonProperty(PropertyName = "CurrentMedication")]
        public string QCurrentMed { get; set; }
        [JsonProperty(PropertyName = "Supplementation")]
        public string QSupplementation { get; set; }
        [JsonProperty(PropertyName = "HistoryInvestigation")]
        public string QHistoryInvestigation { get; set; }
        [JsonProperty(PropertyName = "GI")]
        public string QGI { get; set; }
        [JsonProperty(PropertyName = "GIOther")]
        public string QGOText { get; set; }
        [JsonProperty(PropertyName = "Sleep")]
        public string QSleep { get; set; }
        [JsonProperty(PropertyName = "SleepHours")]
        public decimal? QSleepHours { get; set; }
        [JsonProperty(PropertyName = "SleepOther")]
        public string QSleepText { get; set; }
        [JsonProperty(PropertyName = "Skin")]
        public string QSkin { get; set; }
        [JsonProperty(PropertyName = "SkinOther")]
        public string QSkinText { get; set; }
        [JsonProperty(PropertyName = "Memory")]
        public string QMemory { get; set; }
        [JsonProperty(PropertyName = "MemoryOther")]
        public string QMemoryText { get; set; }
        [JsonProperty(PropertyName = "Immune")]
        public string QImmune { get; set; }
        [JsonProperty(PropertyName = "ImmuneOther")]
        public string QImmuneText { get; set; }
        [JsonProperty(PropertyName = "Sexual")]
        public string QSexual { get; set; }
        [JsonProperty(PropertyName = "SexualOther")]
        public string QSexualText { get; set; }
        [JsonProperty(PropertyName = "Exercise")]
        public string QExercise { get; set; }
        [JsonProperty(PropertyName = "Genetic")]
        public string QGenetic { get; set; }
        [JsonProperty(PropertyName = "Father")]
        public string QFamilyFather { get; set; }
        [JsonProperty(PropertyName = "Mother")]
        public string QFamilyMother { get; set; }
        [JsonProperty(PropertyName = "GeneralAppearance")]
        public string QGeneralPE { get; set; }
        [JsonProperty(PropertyName = "GeneralOther")]
        public string QGeneralPEText { get; set; }
        [JsonProperty(PropertyName = "ENT")]
        public string QENTPE { get; set; }
        [JsonProperty(PropertyName = "Pharynx")]
        public string QENTPharynx { get; set; }
        [JsonProperty(PropertyName = "Tonsils")]
        public string QENTTonsils { get; set; }
        [JsonProperty(PropertyName = "NeckNode")]
        public string QENTNeckNode { get; set; }
        [JsonProperty(PropertyName = "NeckNodeOther")]
        public string QENTPEText { get; set; }
        [JsonProperty(PropertyName = "Respiratory")]
        public string QRespiratoryPE { get; set; }
        [JsonProperty(PropertyName = "RespiratoryOther")]
        public string QRespiratoryPEText { get; set; }
        [JsonProperty(PropertyName = "Cardiovascular")]
        public string QCardiovascularPE { get; set; }
        [JsonProperty(PropertyName = "CardiovascularOther")]
        public string QCardiovascularPEText { get; set; }
        [JsonProperty(PropertyName = "Abdomen")]
        public string QAbdomenPE { get; set; }
        [JsonProperty(PropertyName = "AbdomenOther")]
        public string QAbdomenPEText { get; set; }
        [JsonProperty(PropertyName = "PhysicalExam")]
        public string QPEText { get; set; }
        [JsonProperty(PropertyName = "SpecialNote")]
        public string QSpecialNote { get; set; } = "";
        [JsonProperty(PropertyName = "Doctor")]
        public string QDoctor { get; set; }
        [JsonProperty(PropertyName = "LastUpdateUser")]
        public string QUESUserDR { get; set; }
    }
}
