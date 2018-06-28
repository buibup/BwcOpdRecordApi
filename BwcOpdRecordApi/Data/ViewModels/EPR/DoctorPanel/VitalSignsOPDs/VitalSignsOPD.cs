using Newtonsoft.Json;
using System;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.VitalSignsOPDs
{
    public class VitalSignsOPD
    {
        [JsonProperty(PropertyName = "ObsDate")]
        public DateTime? OBS_Date { get; set; }

        [JsonProperty(PropertyName = "ObsTime")]
        public TimeSpan? OBS_Time { get; set; }

        [JsonProperty(PropertyName = "Weight")]
        public string Weight { get; set; }

        [JsonProperty(PropertyName = "Height")]
        public string Height { get; set; }

        [JsonProperty(PropertyName = "Temperature")]
        public string Temperature { get; set; }

        [JsonProperty(PropertyName = "Systolic")]
        public string Systolic { get; set; }

        [JsonProperty(PropertyName = "Diastolic")]
        public string Diastolic { get; set; }

        [JsonProperty(PropertyName = "Pulse")]
        public string Pulse { get; set; }

        [JsonProperty(PropertyName = "Respirations")]
        public string Respirations { get; set; }

        [JsonProperty(PropertyName = "BMI")]
        public string BMI { get; set; }

        [JsonProperty(PropertyName = "OxygenSaturation")]
        public string OxygenSaturation { get; set; }

        [JsonIgnore]
        public string EWSTotal { get; set; }
    }
}
