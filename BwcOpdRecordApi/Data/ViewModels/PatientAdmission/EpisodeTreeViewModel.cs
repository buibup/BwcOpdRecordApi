using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel;
using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.PatientAdmission
{
    public class EpisodeTreeViewModel
    {
        [JsonProperty(PropertyName = "PAADM_RowID")]
        public long PAADM_RowID { get; set; }

        [JsonProperty(PropertyName = "PAADM_ADMNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "PAADM_AdmDate")]
        public DateTime PAADM_AdmDate { get; set; }

        [JsonProperty(PropertyName = "PAADM_AdmTime")]
        public TimeSpan PAADM_AdmTime { get; set; }

        [JsonProperty(PropertyName = "CTLOC_Desc")]
        public string CTLOC_Desc { get; set; }

        [JsonProperty(PropertyName = "CTPCP_Desc")]
        public string CTPCP_Desc { get; set; }

        [JsonProperty(PropertyName = "PAADM_Type")]
        public string PAADM_Type { get; set; }

        [JsonProperty(PropertyName = "PAADM_VisitStatus")]
        public string PAADM_VisitStatus { get; set; }

        [JsonProperty(PropertyName = "PAADM_DischgDate")]
        public DateTime? PAADM_DischgDate { get; set; }

        [JsonProperty(PropertyName = "PAADM_DischgTime")]
        public TimeSpan? PAADM_DischgTime { get; set; }

        [JsonProperty(PropertyName = "PAADM_Remark")]
        public string PAADM_Remark { get; set; }

        [JsonProperty(PropertyName = "DoctorPanel")]
        public DoctorPanelViewModel DoctorPanel { get; set; }

        [JsonProperty(PropertyName = "Documents")]
        public List<DocumentViewModel> Documents { get; set; }

        [JsonProperty(PropertyName = "VisitType")]
        public string VisitType
        {
            get
            {
                return PAADM_Type.ToUpper() == "O" ? VisitTypeEnum.Outpatient.ToString() : PAADM_Type;
            }
        }
    }
}
