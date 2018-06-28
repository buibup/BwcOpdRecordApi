using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging
{
    public class History
    {
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
        public decimal QSleepHours { get; set; }
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
    }
}
