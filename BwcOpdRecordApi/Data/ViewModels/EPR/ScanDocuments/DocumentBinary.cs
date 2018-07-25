using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentBinary
    {
        [JsonProperty(PropertyName = "DocData")]
        public byte[] DocData { get; set; }

        [JsonProperty(PropertyName = "DocType")]
        public string DocType { get; set; }
    }
}
