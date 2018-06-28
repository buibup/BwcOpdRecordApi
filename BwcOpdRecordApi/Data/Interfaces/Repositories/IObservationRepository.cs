using BwcOpdRecordApi.Data.Models.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Repositories
{
    public interface IObservationRepository
    {
        Task<IEnumerable<Observation>> GetVitalSignsByEpiNoAsync(string epiNo);
        Task<IEnumerable<Observation>> GetVitalSignsByEpiRowIdAsync(long epiRowId);
    }
}
