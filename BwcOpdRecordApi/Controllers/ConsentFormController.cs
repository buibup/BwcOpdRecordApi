using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BwcOpdRecordApi.Data.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BwcOpdRecordApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsentFormController : ControllerBase
    {
        private readonly IConsentFormService _consentFormService;
        public ConsentFormController(IConsentFormService consentFormService)
        {
            _consentFormService = consentFormService;
        }

        [HttpGet("GetCustomerAgrees/{papmiRowId}")]
        public async Task<IActionResult> GetCustomerAgreesAsync(int papmiRowId)
        {
            var data = await _consentFormService.GetCustomerAgreesAsync(papmiRowId);

            if (data.ToList().Count == 0) return NotFound();

            return Ok(data);
        }

        [HttpGet("GetCustomerPaper/{customerId}/{templateId}")]
        public async Task<IActionResult> GetCustomerPaperAsync(int customerId, int templateId)
        {
            var data = await _consentFormService.GetCustomerPaperAsync(customerId, templateId);

            if (data == null) return NotFound();

            return Ok(data);
        }
    }
}