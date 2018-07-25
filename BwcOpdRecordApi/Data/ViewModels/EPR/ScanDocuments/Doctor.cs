using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class Doctor
    {
        public string Name { get; set; }
        public List<Document> Documents { get; set; }
    }
}
