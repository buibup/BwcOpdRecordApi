using Newtonsoft.Json;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging
{
    public class FamilyHistory
    {
        [JsonProperty(PropertyName = "Father")]
        public string QFamilyFather { get; set; }
        [JsonProperty(PropertyName = "Mother")]
        public string QFamilyMother { get; set; }
    }
}
