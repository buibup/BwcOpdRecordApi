using Newtonsoft.Json;
using System;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging
{
    public class PhysicalExamAntiAgingViewModel
    {
        [JsonProperty(PropertyName = "ID")]
        public long ID { get; set; }
        [JsonIgnore]
        [JsonProperty(PropertyName = "QUESPAAdmDR")]
        public long QUESPAAdmDR { get; set; }
        [JsonIgnore]
        [JsonProperty(PropertyName = "QUESPAPatMasDR")]
        public long QUESPAPatMasDR { get; set; }
        [JsonProperty(PropertyName = "QUESDate")]
        public DateTime QUESDate { get; set; }
        [JsonProperty(PropertyName = "QUESTime")]
        public TimeSpan QUESTime { get; set; }
        [JsonProperty(PropertyName = "History")]
        public History History { get; set; }
        [JsonProperty(PropertyName = "Genetic")]
        public Genetic Genetic { get; set; }
        [JsonProperty(PropertyName = "FamilyHistory")]
        public FamilyHistory FamilyHistory { get; set; }
        [JsonProperty(PropertyName = "PhysicalExamination")]
        public PhysicalExamination PhysicalExamination { get; set; }
        [JsonProperty(PropertyName = "SpecialNote")]
        public SpecialNote SpecialNote { get; set; }
        [JsonProperty(PropertyName = "Doctor")]
        public string QDoctor { get; set; }
        [JsonProperty(PropertyName = "LastUpdateUser")]
        public string QUESUserDR { get; set; }
    }
}
