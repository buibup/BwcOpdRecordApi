using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.VitalSignsOPDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IVitalSignsService
    {
        Task<VitalSignsOPDViewModel> GetVitalSignsOPDByEpiNoAsync(string epiNo);
        Task<VitalSignsOPDViewModel> GetVitalSignsOPDViewModelByEpiRowIdAsync(long epiRowId);
        Task<List<VitalSignsOPD>> GetVitalSignsOPDByEpiRowIdAsync(long epiRowId);
    }
}
