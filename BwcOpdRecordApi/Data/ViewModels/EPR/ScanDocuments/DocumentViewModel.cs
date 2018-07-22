using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentViewModel
    {
        [JsonProperty(PropertyName = "DateCreated")]
        public DateTime? PIC_DateCreated { get; set; }

        [JsonProperty(PropertyName = "TimeCreated")]
        public TimeSpan? PIC_TimeCreated { get; set; }

        [JsonProperty(PropertyName = "SADST_Code")]
        public string SADST_Code { get; set; }

        [JsonProperty(PropertyName = "SADST_Desc")]
        public string SADST_Desc { get; set; }

        [JsonProperty(PropertyName = "Path")]
        public string PIC_Path { get; set; }

        [JsonProperty(PropertyName = "DocumentBinary")]
        public DocumentBinary DocumentBinary { get; set; }

        [JsonProperty(PropertyName = "Notes")]
        public string PIC_Desc { get; set; }

        [JsonProperty(PropertyName = "DocumentType")]
        public string DOCTYPE_Desc { get; set; }
    }
}
