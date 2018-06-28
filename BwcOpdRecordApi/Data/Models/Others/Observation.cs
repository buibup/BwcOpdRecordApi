using System;

namespace BwcOpdRecordApi.Data.Models.Others
{
    public class Observation
    {
        public string PAADM_ADMNo { get; set; }
        public string PAPMI_No { get; set; }
        public double OBSENTRY_Childsub { get; set; }
        public DateTime? OBS_Date { get; set; }
        public TimeSpan? OBS_Time { get; set; }
        public string ITM_Code { get; set; }
        public string ITM_Desc { get; set; }
        public string OBS_Value { get; set; }
        public long? OBS_ParRef { get; set; }
    }
}
