using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentBinary
    {
        public byte[] DocData { get; set; }
        public string DocType { get; set; }
    }
}
