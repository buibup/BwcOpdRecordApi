using Newtonsoft.Json;
using System;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments
{
    public class PlanAndTreatment
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "ID")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "QUESDate")]
        public DateTime QUESDate { get; set; }

        [JsonProperty(PropertyName = "QUESTime")]
        public TimeSpan QUESTime { get; set; }

        [JsonProperty(PropertyName = "Plan")]
        public Plan Plan { get; set; }

        [JsonProperty(PropertyName = "Treatment")]
        public Treatment Treatment { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "Treatment")]
        public long QUESUserDR { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "SSUSR_Initials")]
        public string SSUSR_Initials { get; set; }

        [JsonProperty(PropertyName = "SSUSR_Name")]
        public string SSUSR_Name { get; set; }
    }
}
