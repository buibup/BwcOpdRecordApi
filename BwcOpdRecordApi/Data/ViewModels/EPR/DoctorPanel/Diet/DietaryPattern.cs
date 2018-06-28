using Newtonsoft.Json;
using System;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet
{
    public class DietaryPattern
    {
        [JsonProperty(PropertyName = "QTime")]
        public TimeSpan QTime { get; set; }

        [JsonProperty(PropertyName = "QMeal")]
        public string QMeal { get; set; }

        [JsonProperty(PropertyName = "QFoodBeverage")]
        public string QFoodBeverage { get; set; }

        [JsonProperty(PropertyName = "Childsub")]
        public string Childsub { get; set; }
    }
}
