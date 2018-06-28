using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Models.Others;
using BwcOpdRecordApi.Data.Queries;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Repositories
{
    public class ObservationRepository : IObservationRepository
    {
        private readonly ConnectionStrings _connectionStrings;
        public ObservationRepository(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public async Task<IEnumerable<Observation>> GetVitalSignsByEpiNoAsync(string epiNo)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<Observation>(ObservationQuery.GetVitalSignsByEpiNo(), new { PAADM_ADMNo = epiNo });

                return result.ToList();
            }
        }

        public async Task<IEnumerable<Observation>> GetVitalSignsByEpiRowIdAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<Observation>(ObservationQuery.GetVitalSignsByEpiRowId(), new { PAADM_RowID = epiRowId });

                result = result.ToList().Count == 1 ? new List<Observation>() : result;

                return result.ToList();
            }
        }
    }
}
