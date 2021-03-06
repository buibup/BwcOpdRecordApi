﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentType
    {
        [JsonProperty(PropertyName = "DocumentTypeName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Documents")]
        public List<Document> Documents { get; set; }
    }
}
