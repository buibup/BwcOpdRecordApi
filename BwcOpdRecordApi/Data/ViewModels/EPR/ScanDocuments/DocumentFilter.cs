using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments
{
    public class DocumentFilter
    {
        [JsonProperty(PropertyName = "TypeFilters")]
        public List<TypeFilter> TypeFilters { get; set; }
    }

    public class TypeFilter
    {
        [JsonProperty(PropertyName = "TypeName")]
        public string TypeName { get; set; }

        [JsonProperty(PropertyName = "Documents")]
        public List<Document> Documents { get; set; }
    }
}
