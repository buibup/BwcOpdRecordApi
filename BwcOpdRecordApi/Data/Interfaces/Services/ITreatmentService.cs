using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface ITreatmentService
    {
        Task<TreatmentViewModel> GetTreatmentViewModelByEpiRowIdAsync(long epiRowId);
        Task<List<PlanAndTreatment>> GetPlanAndTreatmentsByEpiRowIdAsync(long epiRowId);
    }
}
