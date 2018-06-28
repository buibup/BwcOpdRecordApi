using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging
{
    public class SpecialNote
    {
        [JsonProperty(PropertyName = "SpecialNote")]
        public string QSpecialNote { get; set; }
    }
}
