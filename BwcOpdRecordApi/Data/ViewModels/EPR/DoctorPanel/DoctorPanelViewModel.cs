using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Exercises;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.VitalSignsOPDs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel
{
    public class DoctorPanelViewModel
    {
        [JsonProperty(PropertyName = "VitalSignsOPDs")]
        public List<VitalSignsOPD> VitalSignsOPDs { get; set; } = new List<VitalSignsOPD>();

        [JsonProperty(PropertyName = "PhysicalExams")]
        public PhysicalExam PhysicalExams { get; set; } = new PhysicalExam();

        [JsonProperty(PropertyName = "Diets")]
        public List<NutritionInformation> NutritionInformations { get; set; } = new List<NutritionInformation>();

        [JsonProperty(PropertyName = "Exercises")]
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();

        [JsonProperty(PropertyName = "PlanAndTreatments")]
        public List<PlanAndTreatment> PlanAndTreatments { get; set; } = new List<PlanAndTreatment>();
    }
}
