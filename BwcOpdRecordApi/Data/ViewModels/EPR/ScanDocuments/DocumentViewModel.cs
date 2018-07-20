using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentViewModel
    {
        public DateTime? PIC_DateCreated { get; set; }
        public DateTime? PIC_TimeCreated { get; set; }
        public string SADST_Code { get; set; }
        public string SADST_Desc { get; set; }
        public string PIC_Path { get; set; }
        public DocumentBinary DocumentBinary { get; set; }
        public string PIC_Desc { get; set; }
        public string DOCTYPE_Desc { get; set; }
    }
}
