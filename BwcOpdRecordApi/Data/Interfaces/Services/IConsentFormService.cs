using BwcOpdRecordApi.Data.Models.ConsentForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IConsentFormService
    {
        Task<IEnumerable<CustomerAgree>> GetCustomerAgreesAsync(int papmiRowId);
        Task<CustomerPaper> GetCustomerPaperAsync(int customerId, int templateId);
    }
}
