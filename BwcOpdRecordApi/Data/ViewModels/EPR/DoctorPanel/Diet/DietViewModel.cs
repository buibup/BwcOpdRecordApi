using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet
{
    public class DietViewModel
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "HN")]
        public string PAPMI_No { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "EpisodeNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "NutritionInformations")]
        public List<NutritionInformation> NutritionInformations { get; set; }
    }
}
