using System;

namespace BwcOpdRecordApi.Data.Models.PatientAdmission
{
    public class PA_Person
    {
        public long PAPER_RowId { get; set; }
        public string PAPER_ID { get; set; }
        public string TTL_Desc { get; set; }
        public string PAPER_Name { get; set; }
        public string PAPER_Name2 { get; set; }
        public string CTSEX_Desc { get; set; }
        public DateTime PAPMI_DOB { get; set; }
        public int PAPER_AgeYr { get; set; }
        public byte PAPER_AgeMth { get; set; }
        public byte PAPER_AgeDay { get; set; }
    }
}
