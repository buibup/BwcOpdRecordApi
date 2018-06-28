using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.PhysicalExams.AntiAging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IPhysicalExamService
    {
        Task<PhysicalExamViewModel> GetPhysicalExamViewModelByEpiRowIdAsync(long epiRowId);
        Task<PhysicalExam> GetPhysicalExamsByEpiRowIdAsync(long epiRowId);
        Task<IEnumerable<PhysicalExamAntiAgingViewModel>> GetExamAntiAgingByEpiRowIdAsync(long epiRowId);
    }
}
