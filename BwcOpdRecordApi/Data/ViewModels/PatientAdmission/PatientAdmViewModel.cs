using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.PatientAdmission
{
    public class PatientAdmViewModel
    {
        public long PAADM_RowID { get; set; }
        public string PAADM_ADMNo { get; set; }
        public long PAADM_PAPMI_DR { get; set; }
        public string PAPMI_No { get; set; }
    }
}
