using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.PatientAdmission
{
    public class PatientInfoViewModel
    {
        [JsonProperty(PropertyName = "PatientInfo")]
        public PatientInfo PatientInfo { get; set; }

        [JsonProperty(PropertyName = "EpisodeTree")]
        public List<EpisodeTreeViewModel> EpisodeTree { get; set; }

        //[JsonProperty(PropertyName = "DocumentFilters")]
        //public List<DocumentFilter> DocumentFilters { get; set; }
    }

    public class PatientInfo
    {
        [JsonProperty(PropertyName = "PAPMI_RowId1")]
        public long PAPMI_RowId1 { get; set; }

        [JsonProperty(PropertyName = "PAPMI_No")]
        public string PAPMI_No { get; set; }

        [JsonProperty(PropertyName = "PAPER_ID")]
        public string PAPER_ID { get; set; }

        [JsonProperty(PropertyName = "TTL_Desc")]
        public string TTL_Desc { get; set; }

        [JsonProperty(PropertyName = "PAPER_Name")]
        public string PAPER_Name { get; set; }

        [JsonProperty(PropertyName = "PAPER_Name2")]
        public string PAPER_Name2 { get; set; }

        [JsonProperty(PropertyName = "CTSEX_Desc")]
        public string CTSEX_Desc { get; set; }

        [JsonProperty(PropertyName = "PAPMI_DOB")]
        public DateTime PAPMI_DOB { get; set; }

        [JsonProperty(PropertyName = "PAPER_AgeYr")]
        public int? PAPER_AgeYr { get; set; }

        [JsonProperty(PropertyName = "PAPER_AgeMth")]
        public byte? PAPER_AgeMth { get; set; }

        [JsonProperty(PropertyName = "PAPER_AgeDay")]
        public byte? PAPER_AgeDay { get; set; }

        [JsonProperty(PropertyName = "FullName")]
        public string FullName
        {
            get
            {
                return string.IsNullOrEmpty(TTL_Desc) ? $"{PAPER_Name} {PAPER_Name2}" : $"{TTL_Desc}{PAPER_Name} {PAPER_Name2}";
            }
        }

        [JsonProperty(PropertyName = "Age")]
        public string Age
        {
            get
            {
                return PAPER_AgeYr.HasValue && PAPER_AgeMth.HasValue && PAPER_AgeDay.HasValue ?
                    $"{PAPER_AgeYr}Y {PAPER_AgeMth}M {PAPER_AgeDay}D" : $"{PAPER_AgeYr} {PAPER_AgeMth} {PAPER_AgeDay}";
            }
        }
    }
}
