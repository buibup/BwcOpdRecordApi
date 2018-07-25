﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentViewModel
    {
        public List<Doctor> Doctors { get; set; }
        public List<DocumentType> DocumentTypes { get; set; }
        public List<Document> Documents { get; set; }
    }
}
