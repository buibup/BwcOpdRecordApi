using BwcOpdRecordApi.Data.Models.Questionnaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Repositories
{
    public interface IQuestionnaireRepository
    {
        Task<IEnumerable<QBWCPEANTI>> GetPhysicalExamAntiAgingAsync(long epiRowId);
        Task<IEnumerable<QNURINFO>> GetNutriInfoBehavioralAsync(long epiRowId);
        Task<IEnumerable<QNURINFOQQUsualConsumption>> GetNutriInfoDietaryPatternAsync(long quesParRefDR);
        Task<IEnumerable<QBWCEXERC>> GetExerciseAsync(long epiRowId);
        Task<IEnumerable<QBWCPANDT>> GetTreatmentAsync(long epiRowId);
        Task<IEnumerable<QBWCPANDTQQMedication>> GetMedicationAsync(long quesParRefDR);
    }
}
