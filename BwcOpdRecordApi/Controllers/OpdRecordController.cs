using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BwcOpdRecordApi.Data;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.PatientAdmission;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BwcOpdRecordApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpdRecordController : ControllerBase
    {
        private readonly IVitalSignsService _vitalSignsService;
        private readonly IPhysicalExamService _physicalExamService;
        private readonly IDietService _dietService;
        private readonly IExerciseService _exerciseService;
        private readonly ITreatmentService _treatmentService;
        private readonly IEprService _eprService;
        private readonly IPatientInfoService _patientInfoService;

        public OpdRecordController(
            IVitalSignsService vitalSignsService,
            IPhysicalExamService physicalExamService,
            IDietService dietService,
            IExerciseService exerciseService,
            ITreatmentService treatmentService,
            IEprService eprService,
            IPatientInfoService patientInfoService)
        {
            _vitalSignsService = vitalSignsService;
            _physicalExamService = physicalExamService;
            _dietService = dietService;
            _exerciseService = exerciseService;
            _treatmentService = treatmentService;
            _eprService = eprService;
            _patientInfoService = patientInfoService;
        }

        [HttpGet("GetVitalSignsByEpiNo/{epiNo}")]
        public async Task<IActionResult> GetVitalSignsByEpiNoAsync(string epiNo)
        {
            return Ok(await _vitalSignsService.GetVitalSignsOPDByEpiNoAsync(epiNo));
        }

        [HttpGet("GetVitalSignsByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetVitalSignsByEpiRowIdAsync(long epiRowId)
        {
            var results = await _vitalSignsService.GetVitalSignsOPDByEpiRowIdAsync(epiRowId);

            if (results == null) return NotFound();

            return Ok(results);
        }

        [HttpGet("GetExamAntiAgingByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetExamAntiAgingByEpiRowIdAsync(long epiRowId)
        {
            var results = await _physicalExamService.GetExamAntiAgingByEpiRowIdAsync(epiRowId);

            if (results == null) return NotFound();

            return Ok(results);
        }

        [HttpGet("GetPhysicalExamByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetPhysicalExamByEpiRowIdAsync(long epiRowId)
        {
            var results = await _physicalExamService.GetPhysicalExamViewModelByEpiRowIdAsync(epiRowId);

            if (results == null) return NotFound();

            return Ok(results);
        }

        [HttpGet("GetDietByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetDietByEpiRowIdAsync(long epiRowId)
        {
            var results = await _dietService.GetDietByEpiRowIdAsync(epiRowId);

            if (results == null) return NotFound();

            return Ok(results);
        }

        [HttpGet("GetExerciseByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetExerciseByEpiRowIdAsync(long epiRowId)
        {
            var results = await _exerciseService.GetExerciseByEpiRowIdAsync(epiRowId);

            if (results == null) return NotFound();

            return Ok(results);
        }

        [HttpGet("GetTreatmentByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetTreatmentByEpiRowIdAsync(long epiRowId)
        {
            var results = await _treatmentService.GetTreatmentViewModelByEpiRowIdAsync(epiRowId);

            if (results == null) return NotFound();

            return Ok(results);
        }

        [HttpGet("GetDoctorPanelByEpiRowId/{epiRowId}")]
        public async Task<IActionResult> GetDoctorPanelByEpiRowIdAsync(long epiRowId)
        {
            var result = await _eprService.GetDoctorPanelByEpiRowIdAsync(epiRowId);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("GetPatientInfoByPapmiNo/{papmiNo}/DoctorPanel/{status}")]
        public async Task<IActionResult> GetPatientInfoByPapmiNo(string papmiNo, string status)
        {
            var result = new PatientInfoViewModel();
            if (status.ToLower() == "active")
            {
                result = await _patientInfoService.GetPatientInfoByPapmiNoAsync(papmiNo, DoctorPanelEnum.Active);
            }
            else
            {
                result = await _patientInfoService.GetPatientInfoByPapmiNoAsync(papmiNo, DoctorPanelEnum.InActice);
            }

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}