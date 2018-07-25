using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentViewModel
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "PAADM_ADMNo")]
        public string PAADM_ADMNo { get; set; }

        [JsonProperty(PropertyName = "Doctors")]
        public List<Doctor> Doctors { get; set; }

        [JsonProperty(PropertyName = "DocumentTypes")]
        public List<DocumentType> DocumentTypes { get; set; }

        [JsonProperty(PropertyName = "Documents")]
        public List<Document> Documents { get; set; }
    }
}
