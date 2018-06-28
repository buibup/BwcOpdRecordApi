using System;

namespace BwcOpdRecordApi.Data.Models.PatientAdmission
{
    public class PA_Adm
    {
        public long PAADM_RowID { get; set; }
        public string PAADM_ADMNo { get; set; }
        public DateTime PAADM_AdmDate { get; set; }
        public TimeSpan PAADM_AdmTime { get; set; }
        public string CTLOC_Code { get; set; }
        public string CTLOC_Desc { get; set; }
        public string CTPCP_Code { get; set; }
        public string CTPCP_Desc { get; set; }
        public string PAADM_Type { get; set; }
        public string PAADM_VisitStatus { get; set; }
        public DateTime? PAADM_DischgDate { get; set; }
        public TimeSpan? PAADM_DischgTime { get; set; }
        public string PAADM_Remark { get; set; }
    }
}
