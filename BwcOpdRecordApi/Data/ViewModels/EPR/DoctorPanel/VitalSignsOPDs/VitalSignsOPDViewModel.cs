using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.VitalSignsOPDs
{
    public class VitalSignsOPDViewModel
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "HN")]
        public string PAPMI_No { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "EpisodeNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "VitalSignsOPDs")]
        public List<VitalSignsOPD> VitalSignsOPDs { get; set; }
    }
}
