using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class EprService : IEprService
    {
        private readonly IVitalSignsService _vitalSignsService;
        private readonly IPhysicalExamService _physicalExamService;
        private readonly IDietService _dietService;
        private readonly IExerciseService _exerciseService;
        private readonly ITreatmentService _treatmentService;
        private readonly IMedicalRecordService _medicalRecordService;

        public EprService(
            IVitalSignsService vitalSignsService,
            IPhysicalExamService physicalExamService,
            IDietService dietService,
            IExerciseService exerciseService,
            ITreatmentService treatmentService,
            IMedicalRecordService medicalRecordService)
        {
            _vitalSignsService = vitalSignsService;
            _physicalExamService = physicalExamService;
            _dietService = dietService;
            _exerciseService = exerciseService;
            _treatmentService = treatmentService;
            _medicalRecordService = medicalRecordService;
        }

        public async Task<DoctorPanelViewModel> GetDoctorPanelByEpiRowIdAsync(long epiRowId)
        {
            var vitalSigns = await _vitalSignsService.GetVitalSignsOPDByEpiRowIdAsync(epiRowId);
            var physicalExam = await _physicalExamService.GetPhysicalExamsByEpiRowIdAsync(epiRowId);
            var diet = await _dietService.GetDietByEpiRowIdAsync(epiRowId);
            var exercise = await _exerciseService.GetExerciseByEpiRowIdAsync(epiRowId);
            var treatment = await _treatmentService.GetPlanAndTreatmentsByEpiRowIdAsync(epiRowId);

            var result = new DoctorPanelViewModel()
            {
                VitalSignsOPDs = vitalSigns,
                PhysicalExams = physicalExam,
                NutritionInformations = diet,
                Exercises = exercise,
                PlanAndTreatments = treatment
            };

            return result;
        }
    }
}
