using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Models.ConsentForm
{
    public class CustomerAgree
    {
        public int CustomerId { get; set; }

        public int TemplateId { get; set; }

        public string Name { get; set; }

        public DateTime SignedAt { get; set; }

        public string Paper { get; set; }
    }
}
