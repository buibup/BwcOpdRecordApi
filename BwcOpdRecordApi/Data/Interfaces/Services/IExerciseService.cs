using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IExerciseService
    {
        Task<ExerciseViewModel> GetExerciseViewModelByEpiRowIdAsync(long epiRowId);
        Task<List<Exercise>> GetExerciseByEpiRowIdAsync(long epiRowId);
    }
}
