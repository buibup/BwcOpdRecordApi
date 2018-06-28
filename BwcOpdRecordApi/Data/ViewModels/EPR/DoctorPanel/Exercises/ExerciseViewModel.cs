using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Exercises
{
    public class ExerciseViewModel
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "HN")]
        public string PAPMI_No { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "EpisodeNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "Exercises")]
        public List<Exercise> Exercises { get; set; }
    }
}
