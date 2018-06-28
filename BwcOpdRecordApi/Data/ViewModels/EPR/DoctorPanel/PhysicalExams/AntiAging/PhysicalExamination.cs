using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging
{
    public class PhysicalExamination
    {
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
    }
}
