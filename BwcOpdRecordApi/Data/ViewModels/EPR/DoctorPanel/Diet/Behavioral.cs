using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet
{
    public class Behavioral
    {
        [JsonProperty(PropertyName = "QBehavioralNA")]
        public byte QBehavioralNA { get; set; }

        [JsonProperty(PropertyName = "QVegetableConsumption")]
        public string QVegetableConsumption { get; set; }

        [JsonProperty(PropertyName = "QVegetableFrequency")]
        public string QVegetableFrequency { get; set; }

        [JsonProperty(PropertyName = "QVegetableNote")]
        public string QVegetableNote { get; set; }

        [JsonProperty(PropertyName = "QFruitConsumption")]
        public string QFruitConsumption { get; set; }

        [JsonProperty(PropertyName = "QFruitFrequency")]
        public string QFruitFrequency { get; set; }

        [JsonProperty(PropertyName = "QFruitNote")]
        public string QFruitNote { get; set; }

        [JsonProperty(PropertyName = "QTeaType")]
        public string QTeaType { get; set; }

        [JsonProperty(PropertyName = "QTeaTypeOther")]
        public string QTeaTypeOther { get; set; }

        [JsonProperty(PropertyName = "QTeaConsumption")]
        public string QTeaConsumption { get; set; }

        [JsonProperty(PropertyName = "QTeaFrequency")]
        public string QTeaFrequency { get; set; }

        [JsonProperty(PropertyName = "QTeaNote")]
        public string QTeaNote { get; set; }

        [JsonProperty(PropertyName = "QCoffeeType")]
        public string QCoffeeType { get; set; }

        [JsonProperty(PropertyName = "QCoffeeTpyeOther")]
        public string QCoffeeTpyeOther { get; set; }

        [JsonProperty(PropertyName = "QCoffeeConsumption")]
        public string QCoffeeConsumption { get; set; }

        [JsonProperty(PropertyName = "QCoffeeFrequency")]
        public string QCoffeeFrequency { get; set; }

        [JsonProperty(PropertyName = "QCoffeeNote")]
        public string QCoffeeNote { get; set; }

        [JsonProperty(PropertyName = "QAlcoholType")]
        public string QAlcoholType { get; set; }

        [JsonProperty(PropertyName = "QAlcoholTypeOther")]
        public string QAlcoholTypeOther { get; set; }

        [JsonProperty(PropertyName = "QAlcoholConsumption")]
        public string QAlcoholConsumption { get; set; }

        [JsonProperty(PropertyName = "QAlcoholFrequency")]
        public string QAlcoholFrequency { get; set; }

        [JsonProperty(PropertyName = "QAlcoholNote")]
        public string QAlcoholNote { get; set; }
    }
}
