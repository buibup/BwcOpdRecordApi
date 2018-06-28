using Newtonsoft.Json;
using System;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Exercises
{
    public class Exercise
    {
        [JsonProperty(PropertyName = "ID")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "QUESDate")]
        public DateTime QUESDate { get; set; }

        [JsonProperty(PropertyName = "QUESTime")]
        public TimeSpan QUESTime { get; set; }

        [JsonProperty(PropertyName = "QFrequency")]
        public string QFrequency { get; set; }

        [JsonProperty(PropertyName = "QTypeExercise")]
        public string QTypeExercise { get; set; }

        [JsonProperty(PropertyName = "QListOfExercise")]
        public string QListOfExercise { get; set; }

        [JsonProperty(PropertyName = "QListOfExerciseETC")]
        public string QListOfExerciseETC { get; set; }

        [JsonProperty(PropertyName = "QDuration")]
        public string QDuration { get; set; }

        [JsonProperty(PropertyName = "QAthleticInjuries")]
        public string QAthleticInjuries { get; set; }

        [JsonProperty(PropertyName = "QAthleticInjuriesText")]
        public string QAthleticInjuriesText { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "QUESUserDR")]
        public long QUESUserDR { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "SSUSR_Initials")]
        public string SSUSR_Initials { get; set; }

        [JsonProperty(PropertyName = "SSUSR_Name")]
        public string SSUSR_Name { get; set; }
    }
}
