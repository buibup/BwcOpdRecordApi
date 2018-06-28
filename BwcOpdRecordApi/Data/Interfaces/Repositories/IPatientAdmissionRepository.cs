using BwcOpdRecordApi.Data.Models.PatientAdmission;
using BwcOpdRecordApi.Data.ViewModels.PatientAdmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Repositories
{
    public interface IPatientAdmissionRepository
    {
        Task<IEnumerable<PA_Adm>> GetPatientAdmissionsByPapmiRowIdAsync(long papmiRowId);
        Task<PatientAdmViewModel> GetPatientHnByEpiRowIdAsync(long epiRowId);
        Task<PA_PatMas> GetPatientMasterByPapmiNoAsync(string papmiNo);
        Task<PA_Person> GetPersonByPapmiRowIdAsync(long papmiRowId);
    }
}
