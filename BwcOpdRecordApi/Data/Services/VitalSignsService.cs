using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.VitalSignsOPDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class VitalSignsService : IVitalSignsService
    {
        private readonly IObservationRepository _observationRepository;
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public VitalSignsService(
            IObservationRepository observationRepository,
            IQuestionnaireRepository questionnaireRepository
            )
        {
            _observationRepository = observationRepository;
            _questionnaireRepository = questionnaireRepository;
        }



        public async Task<VitalSignsOPDViewModel> GetVitalSignsOPDByEpiNoAsync(string epiNo)
        {
            var vitalSigns = await _observationRepository.GetVitalSignsByEpiNoAsync(epiNo);

            return vitalSigns.GetVitalSignsOPDViewModel();
        }

        public async Task<List<VitalSignsOPD>> GetVitalSignsOPDByEpiRowIdAsync(long epiRowId)
        {
            var vitalSigns = await _observationRepository.GetVitalSignsByEpiRowIdAsync(epiRowId);

            return vitalSigns.GetVitalSignsOPD();
        }

        public async Task<VitalSignsOPDViewModel> GetVitalSignsOPDViewModelByEpiRowIdAsync(long epiRowId)
        {
            var vitalSigns = await _observationRepository.GetVitalSignsByEpiRowIdAsync(epiRowId);

            return vitalSigns.GetVitalSignsOPDViewModel();
        }
    }
}
