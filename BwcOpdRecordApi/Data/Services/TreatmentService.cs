using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class TreatmentService : ITreatmentService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
        public TreatmentService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<List<PlanAndTreatment>> GetPlanAndTreatmentsByEpiRowIdAsync(long epiRowId)
        {
            var qBWCPANDTs = await _questionnaireRepository.GetTreatmentAsync(epiRowId);
            var planAndTreatments = new List<PlanAndTreatment>();

            foreach (var qBWCPANDT in qBWCPANDTs)
            {
                var plan = new Plan()
                {
                    QDiet = qBWCPANDT.QDiet,
                    QDietText = qBWCPANDT.QDietText,
                    QExercise = qBWCPANDT.QExercise,
                    QExerciseText = qBWCPANDT.QExerciseText,
                    QPlanText = qBWCPANDT.QPlanText,
                    QSleepText = qBWCPANDT.QSleepText
                };

                var medications = await _questionnaireRepository.GetMedicationAsync(qBWCPANDT.ID);

                var treatment = new Treatment()
                {
                    Medications = await medications.GetMedicationsAsync(),
                    QFollowUpMonth = qBWCPANDT.QFollowUpMonth,
                    QFollowUpPhoneM = qBWCPANDT.QFollowUpPhoneM,
                    QFollowUpPhoneW = qBWCPANDT.QFollowUpPhoneW,
                    QFollowUpW = qBWCPANDT.QFollowUpW,
                    QSupplement = qBWCPANDT.QSupplement,
                    QSupplementM = qBWCPANDT.QSupplementM,
                    QSupplementW = qBWCPANDT.QSupplementW
                };

                var planAndTreatment = new PlanAndTreatment()
                {
                    ID = qBWCPANDT.ID,
                    QUESDate = qBWCPANDT.QUESDate,
                    QUESTime = qBWCPANDT.QUESTime,
                    Plan = plan,
                    Treatment = treatment,
                    QUESUserDR = qBWCPANDT.QUESUserDR,
                    SSUSR_Initials = qBWCPANDT.SSUSR_Initials,
                    SSUSR_Name = qBWCPANDT.SSUSR_Name
                };

                planAndTreatments.Add(planAndTreatment);
            }

            return planAndTreatments;
        }

        public async Task<TreatmentViewModel> GetTreatmentViewModelByEpiRowIdAsync(long epiRowId)
        {
            var qBWCPANDTs = await _questionnaireRepository.GetTreatmentAsync(epiRowId);
            var planAndTreatments = new List<PlanAndTreatment>();
            var hn = "";
            var epiNo = "";

            foreach (var qBWCPANDT in qBWCPANDTs)
            {
                hn = string.IsNullOrEmpty(hn) ? qBWCPANDT.PAPMI_No : hn;
                epiNo = string.IsNullOrEmpty(epiNo) ? qBWCPANDT.PAADM_ADMNo : epiNo;

                var plan = new Plan()
                {
                    QDiet = qBWCPANDT.QDiet,
                    QDietText = qBWCPANDT.QDietText,
                    QExercise = qBWCPANDT.QExercise,
                    QExerciseText = qBWCPANDT.QExerciseText,
                    QPlanText = qBWCPANDT.QPlanText,
                    QSleepText = qBWCPANDT.QSleepText
                };

                var medications = await _questionnaireRepository.GetMedicationAsync(qBWCPANDT.ID);

                var treatment = new Treatment()
                {
                    Medications = await medications.GetMedicationsAsync(),
                    QFollowUpMonth = qBWCPANDT.QFollowUpMonth,
                    QFollowUpPhoneM = qBWCPANDT.QFollowUpPhoneM,
                    QFollowUpPhoneW = qBWCPANDT.QFollowUpPhoneW,
                    QFollowUpW = qBWCPANDT.QFollowUpW,
                    QSupplement = qBWCPANDT.QSupplement,
                    QSupplementM = qBWCPANDT.QSupplementM,
                    QSupplementW = qBWCPANDT.QSupplementW
                };

                var planAndTreatment = new PlanAndTreatment()
                {
                    ID = qBWCPANDT.ID,
                    QUESDate = qBWCPANDT.QUESDate,
                    QUESTime = qBWCPANDT.QUESTime,
                    Plan = plan,
                    Treatment = treatment,
                    QUESUserDR = qBWCPANDT.QUESUserDR,
                    SSUSR_Initials = qBWCPANDT.SSUSR_Initials,
                    SSUSR_Name = qBWCPANDT.SSUSR_Name
                };

                planAndTreatments.Add(planAndTreatment);
            }

            var result = new TreatmentViewModel()
            {
                PAPMI_No = hn,
                PAADM_ADMNo = epiNo,
                PlanAndTreatments = planAndTreatments
            };

            return result;
        }
    }
}
