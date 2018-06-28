using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging
{
    public class Genetic
    {
        [JsonProperty(PropertyName = "Genetic")]
        public string QGenetic { get; set; }
    }
}
