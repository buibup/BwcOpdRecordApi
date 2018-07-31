using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class Document
    {
        [JsonIgnore]
        [JsonProperty(PropertyName = "PAPMI_No")]
        public string PAPMI_No { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "PAADM_RowID")]
        public long PAADM_RowID { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "PAADM_ADMNo")]
        public string PAADM_ADMNo { get; set; }

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

        [JsonProperty(PropertyName = "ContentType")]
        public string ContentType { get; set; }

        [JsonProperty(PropertyName = "DocumentUrl")]
        public string DocumentUrl { get; set; }

        [JsonProperty(PropertyName = "DocType")]
        public string DocType { get; set; }

        [JsonProperty(PropertyName = "IsPdf")]
        public bool IsPdf { get; set; }

        [JsonProperty(PropertyName = "IsOpen")]
        public bool IsOpen { get; set; } = false;
    }
}
