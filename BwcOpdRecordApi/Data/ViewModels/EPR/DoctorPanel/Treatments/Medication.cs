using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments
{
    public class Medication
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "ID")]
        public string ID { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "QUESParRefDR")]
        public long QUESParRefDR { get; set; }

        [JsonProperty(PropertyName = "ARCIM_Desc")]
        public string ARCIM_Desc { get; set; }

        [JsonProperty(PropertyName = "QDose")]
        public string QDose { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "Childsub")]
        public string childsub { get; set; }
    }
}
