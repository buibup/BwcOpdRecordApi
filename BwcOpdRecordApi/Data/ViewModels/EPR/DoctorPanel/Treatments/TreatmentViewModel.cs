using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments
{
    public class TreatmentViewModel
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "HN")]
        public string PAPMI_No { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "EpisodeNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "PlanAndTreatments")]
        public List<PlanAndTreatment> PlanAndTreatments { get; set; }
    }
}
