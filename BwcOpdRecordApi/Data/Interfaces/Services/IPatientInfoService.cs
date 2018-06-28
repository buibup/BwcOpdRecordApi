using BwcOpdRecordApi.Data.ViewModels.PatientAdmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IPatientInfoService
    {
        Task<PatientInfoViewModel> GetPatientInfoByPapmiNoAsync(string papmiNo, DoctorPanelEnum doctorPanel);
    }
}
