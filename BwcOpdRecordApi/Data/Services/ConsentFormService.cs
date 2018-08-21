using BwcOpdRecordApi.Data.Interfaces.Repositories.SqlServer;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.Models.ConsentForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class ConsentFormService : IConsentFormService
    {
        private readonly IConsentFormRepository _consentFormRepository;
        public ConsentFormService(IConsentFormRepository consentFormRepository)
        {
            _consentFormRepository = consentFormRepository;
        }
        public async Task<IEnumerable<CustomerAgree>> GetCustomerAgreesAsync(int papmiRowId)
        {
            return await _consentFormRepository.GetCustomerAgreesAsync(papmiRowId);
        }

        public async Task<CustomerPaper> GetCustomerPaperAsync(int customerId, int templateId)
        {
            return await _consentFormRepository.GetCustomerPaperAsync(customerId, templateId);
        }
    }
}
