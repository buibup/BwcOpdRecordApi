using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.GI;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.Heart;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.NEURO;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.Sport;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams
{
    public class PhysicalExamViewModel
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "HN")]
        public string PAPMI_No { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "EpisodeNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "PhysicalExams")]
        public PhysicalExam PhysicalExams { get; set; }
    }

    public class PhysicalExam
    {
        [JsonProperty(PropertyName = "AntiAgings")]
        public List<PhysicalExamAntiAgingViewModel> PhysicalExamAntiAgings { get; set; } = new List<PhysicalExamAntiAgingViewModel>();

        [JsonProperty(PropertyName = "GIs")]
        public List<PhysicalExamGIViewModel> PhysicalExamGIs { get; set; } = new List<PhysicalExamGIViewModel>();

        [JsonProperty(PropertyName = "Hearts")]
        public List<PhysicalExamHeartViewModel> PhysicalExamHearts { get; set; } = new List<PhysicalExamHeartViewModel>();

        [JsonProperty(PropertyName = "NEUROs")]
        public List<PhysicalExamNEUROViewModel> PhysicalExamNEUROs { get; set; } = new List<PhysicalExamNEUROViewModel>();

        [JsonProperty(PropertyName = "Sports")]
        public List<PhysicalExamSportViewModel> PhysicalExamSports { get; set; } = new List<PhysicalExamSportViewModel>();
    }
}
