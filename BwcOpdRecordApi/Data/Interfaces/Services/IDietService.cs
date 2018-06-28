using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IDietService
    {
        Task<DietViewModel> GetDietViewModelByEpiRowIdAsync(long epiRowId);
        Task<List<NutritionInformation>> GetDietByEpiRowIdAsync(long epiRowId);
    }
}
