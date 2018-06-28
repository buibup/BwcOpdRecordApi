using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel;
using BwcOpdRecordApi.Data.ViewModels.PatientAdmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class PatientInfoService : IPatientInfoService
    {
        private readonly IPatientAdmissionRepository _patientAdmissionRepository;
        private readonly IEprService _eprService;
        public PatientInfoService(
            IPatientAdmissionRepository patientAdmissionRepository,
            IEprService eprService)
        {
            _patientAdmissionRepository = patientAdmissionRepository;
            _eprService = eprService;
        }

        public async Task<PatientInfoViewModel> GetPatientInfoByPapmiNoAsync(string papmiNo, DoctorPanelEnum doctorPanelEnum)
        {
            var patient = await _patientAdmissionRepository.GetPatientMasterByPapmiNoAsync(papmiNo);

            if (patient == null) return null;

            var person = await _patientAdmissionRepository.GetPersonByPapmiRowIdAsync(patient.PAPMI_RowId1);
            var ptAdms = await _patientAdmissionRepository.GetPatientAdmissionsByPapmiRowIdAsync(patient.PAPMI_RowId1);

            var patientInfo = new PatientInfo()
            {
                PAPMI_RowId1 = patient.PAPMI_RowId1,
                PAPMI_No = patient.PAPMI_No,
                PAPER_ID = person.PAPER_ID,
                TTL_Desc = person.TTL_Desc,
                PAPER_Name = person.PAPER_Name,
                PAPER_Name2 = person.PAPER_Name2,
                CTSEX_Desc = person.CTSEX_Desc,
                PAPMI_DOB = person.PAPMI_DOB,
                PAPER_AgeYr = person.PAPER_AgeYr,
                PAPER_AgeMth = person.PAPER_AgeMth,
                PAPER_AgeDay = person.PAPER_AgeDay
            };

            var episodes = new List<EpisodeTreeViewModel>();
            foreach (var item in ptAdms)
            {
                var doctorPanel = new DoctorPanelViewModel();

                if (doctorPanelEnum == DoctorPanelEnum.Active)
                {
                    doctorPanel = await _eprService.GetDoctorPanelByEpiRowIdAsync(item.PAADM_RowID);
                }

                var episodeTree = new EpisodeTreeViewModel()
                {
                    PAADM_RowID = item.PAADM_RowID,
                    PAADM_ADMNo = item.PAADM_ADMNo,
                    PAADM_AdmDate = item.PAADM_AdmDate,
                    PAADM_AdmTime = item.PAADM_AdmTime,
                    CTLOC_Desc = item.CTLOC_Desc,
                    CTPCP_Desc = item.CTPCP_Desc,
                    PAADM_Type = item.PAADM_Type,
                    PAADM_VisitStatus = item.PAADM_VisitStatus,
                    PAADM_DischgDate = item.PAADM_DischgDate,
                    PAADM_DischgTime = item.PAADM_DischgTime,
                    PAADM_Remark = item.PAADM_Remark,
                    DoctorPanel = doctorPanel
                };

                episodes.Add(episodeTree);
            }

            // sort list
            episodes = episodes.OrderByDescending(e => e.PAADM_AdmDate).ThenByDescending(e => e.PAADM_AdmTime).ToList();

            var result = new PatientInfoViewModel()
            {
                PatientInfo = patientInfo,
                EpisodeTree = episodes
            };

            return result;
        }
    }
}
