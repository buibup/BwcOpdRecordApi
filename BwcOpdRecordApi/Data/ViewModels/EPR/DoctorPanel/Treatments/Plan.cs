using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments
{
    public class Plan
    {
        [JsonProperty(PropertyName = "QDiet")]
        public string QDiet { get; set; }

        [JsonProperty(PropertyName = "QDietText")]
        public string QDietText { get; set; }

        [JsonProperty(PropertyName = "QExercise")]
        public string QExercise { get; set; }

        [JsonProperty(PropertyName = "QExerciseText")]
        public string QExerciseText { get; set; }

        [JsonProperty(PropertyName = "QSleepText")]
        public string QSleepText { get; set; }

        [JsonProperty(PropertyName = "QPlanText")]
        public string QPlanText { get; set; }
    }
}
