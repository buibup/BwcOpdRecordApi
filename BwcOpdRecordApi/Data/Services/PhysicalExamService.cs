using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.GI;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.Heart;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.NEURO;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.Sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class PhysicalExamService : IPhysicalExamService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
        private readonly IPatientAdmissionRepository _patientAdmissionRepository;

        public PhysicalExamService(
            IQuestionnaireRepository questionnaireRepository,
            IPatientAdmissionRepository patientAdmissionRepository)
        {
            _questionnaireRepository = questionnaireRepository;
            _patientAdmissionRepository = patientAdmissionRepository;
        }

        public async Task<IEnumerable<PhysicalExamAntiAgingViewModel>> GetExamAntiAgingByEpiRowIdAsync(long epiRowId)
        {
            var physicalExam = await _questionnaireRepository.GetPhysicalExamAntiAgingAsync(epiRowId);
            var results = new List<PhysicalExamAntiAgingViewModel>();

            foreach (var item in physicalExam)
            {

                var history = new History()
                {
                    QCC = item.QCC,
                    QCCText = item.QCCText,
                    QCCOtherText = item.QCCOtherText,
                    QUnderlying = item.QUnderlying,
                    QCurrentMed = item.QCurrentMed,
                    QSupplementation = item.QSupplementation,
                    QHistoryInvestigation = item.QHistoryInvestigation,
                    QGI = item.QGI,
                    QGOText = item.QGOText,
                    QSleep = item.QSleep,
                    QSleepHours = item.QSleepHours,
                    QSleepText = item.QSleepText,
                    QSkin = item.QSkin,
                    QSkinText = item.QSkinText,
                    QMemory = item.QMemory,
                    QMemoryText = item.QMemoryText,
                    QImmune = item.QImmune,
                    QImmuneText = item.QImmuneText,
                    QSexual = item.QSexual,
                    QSexualText = item.QSexualText,
                    QExercise = item.QExercise,
                };

               var isHistory = history.GetType().GetProperties()
                        .Where(h => h.GetValue(history) is string)
                        .Select(h => (string)h.GetValue(history))
                        .Any(value => !String.IsNullOrEmpty(value));

                var genetic = new Genetic()
                {
                    QGenetic = item.QGenetic
                };

                var isGenetic = genetic.GetType().GetProperties()
                    .Where(g => g.GetValue(genetic) is string)
                    .Select(g => (string)g.GetValue(genetic))
                    .Any(value => !String.IsNullOrEmpty(value));

                var familyHistory = new FamilyHistory()
                {
                    QFamilyFather = item.QFamilyFather,
                    QFamilyMother = item.QFamilyMother
                };

                var isFamilyHistory = familyHistory.GetType().GetProperties()
                    .Where(f => f.GetValue(familyHistory) is string)
                    .Select(f => (string)f.GetValue(familyHistory))
                    .Any(value => !String.IsNullOrEmpty(value));

                var physicalExamination = new PhysicalExamination()
                {
                    QENTPE = item.QENTPE,
                    QAbdomenPE = item.QAbdomenPE,
                    QAbdomenPEText = item.QAbdomenPEText,
                    QCardiovascularPE = item.QCardiovascularPE,
                    QCardiovascularPEText = item.QCardiovascularPEText,
                    QENTNeckNode = item.QENTNeckNode,
                    QENTPEText = item.QENTPEText,
                    QENTPharynx = item.QENTPharynx,
                    QENTTonsils = item.QENTTonsils,
                    QGeneralPE = item.QGeneralPE,
                    QGeneralPEText = item.QGeneralPEText,
                    QPEText = item.QPEText,
                    QRespiratoryPE = item.QRespiratoryPE,
                    QRespiratoryPEText = item.QRespiratoryPEText
                };

                var isPhysicalExamination = physicalExamination.GetType().GetProperties()
                    .Where(p => p.GetValue(physicalExamination) is string)
                    .Select(p => (string)p.GetValue(physicalExamination))
                    .Any(value => !String.IsNullOrEmpty(value));

                var specialNote = new SpecialNote()
                {
                    QSpecialNote = item.QSpecialNote
                };

                var model = new PhysicalExamAntiAgingViewModel()
                {
                    ID = item.ID,
                    QUESPAAdmDR = item.QUESPAAdmDR,
                    QUESPAPatMasDR = item.QUESPAPatMasDR,
                    QUESDate = item.QUESDate,
                    QUESTime = item.QUESTime,
                    History = history,
                    IsHistory = isHistory,
                    Genetic = genetic,
                    IsGenetic = isGenetic,
                    FamilyHistory = familyHistory,
                    IsFamilyHistory = isFamilyHistory,
                    PhysicalExamination = physicalExamination,
                    IsPhysicalExamination = isFamilyHistory,
                    SpecialNote = specialNote,
                    QDoctor = item.QDoctor,
                    QUESUserDR = item.QUESUserDR
                };


                results.Add(model);
            }

            return results;
        }

        public async Task<PhysicalExam> GetPhysicalExamsByEpiRowIdAsync(long epiRowId)
        {
            var antiAging = await GetExamAntiAgingByEpiRowIdAsync(epiRowId);

            var physicalExams = new PhysicalExam()
            {
                PhysicalExamAntiAgings = antiAging.ToList(),
                PhysicalExamGIs = new List<PhysicalExamGIViewModel>(),
                PhysicalExamHearts = new List<PhysicalExamHeartViewModel>(),
                PhysicalExamNEUROs = new List<PhysicalExamNEUROViewModel>(),
                PhysicalExamSports = new List<PhysicalExamSportViewModel>()
            };

            return physicalExams;
        }

        public async Task<PhysicalExamViewModel> GetPhysicalExamViewModelByEpiRowIdAsync(long epiRowId)
        {
            var hn = "";
            var epiNo = "";

            var antiAging = await GetExamAntiAgingByEpiRowIdAsync(epiRowId);
            var patient = await _patientAdmissionRepository.GetPatientHnByEpiRowIdAsync(epiRowId);

            if (patient != null)
            {
                hn = patient.PAPMI_No;
                epiNo = patient.PAADM_ADMNo;
            }

            var physicalExam = new PhysicalExam()
            {
                PhysicalExamAntiAgings = antiAging.ToList(),
                PhysicalExamGIs = new List<PhysicalExamGIViewModel>(),
                PhysicalExamHearts = new List<PhysicalExamHeartViewModel>(),
                PhysicalExamNEUROs = new List<PhysicalExamNEUROViewModel>(),
                PhysicalExamSports = new List<PhysicalExamSportViewModel>()
            };

            var results = new PhysicalExamViewModel()
            {
                PAPMI_No = hn,
                PAADM_ADMNo = epiNo,
                PhysicalExams = physicalExam
            };

            return results;
        }
    }
}
