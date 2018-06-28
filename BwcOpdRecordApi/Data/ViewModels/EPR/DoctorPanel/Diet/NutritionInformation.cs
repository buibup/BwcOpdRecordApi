using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet
{
    public class NutritionInformation
    {
        [JsonProperty(PropertyName = "ID")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "QUESDate")]
        public DateTime QUESDate { get; set; }

        [JsonProperty(PropertyName = "QUESTime")]
        public TimeSpan QUESTime { get; set; }

        [JsonProperty(PropertyName = "DietaryPatterns")]
        public List<DietaryPattern> DietaryPatterns { get; set; }

        [JsonProperty(PropertyName = "Behavioral")]
        public Behavioral Behavioral { get; set; }

        [JsonProperty(PropertyName = "QDietHistory")]
        public string QDietHistory { get; set; }

        [JsonProperty(PropertyName = "QDietOrder")]
        public string QDietOrder { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "QUESUserDR")]
        public string QUESUserDR { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "SSUSR_Initials")]
        public string SSUSR_Initials { get; set; }

        [JsonProperty(PropertyName = "SSUSR_Name")]
        public string SSUSR_Name { get; set; }
    }
}
