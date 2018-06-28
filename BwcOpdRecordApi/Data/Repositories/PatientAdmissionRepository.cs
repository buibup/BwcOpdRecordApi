using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Models.PatientAdmission;
using BwcOpdRecordApi.Data.Queries;
using BwcOpdRecordApi.Data.ViewModels.PatientAdmission;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Repositories
{
    public class PatientAdmissionRepository : IPatientAdmissionRepository
    {
        private readonly ConnectionStrings _connectionStrings;
        public PatientAdmissionRepository(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public async Task<PatientAdmViewModel> GetPatientHnByEpiRowIdAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryFirstOrDefaultAsync<PatientAdmViewModel>(PatientAdmissionQuery.GetPatientHnByEpiRowId(), new { a = epiRowId });

                return result;
            }
        }

        public async Task<IEnumerable<PA_Adm>> GetPatientAdmissionsByPapmiRowIdAsync(long papmiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<PA_Adm>(PatientAdmissionQuery.GetEpisodeTreeByPapmiRowId(), new { PAADM_PAPMI_DR = papmiRowId });

                return result;
            }
        }

        public async Task<PA_PatMas> GetPatientMasterByPapmiNoAsync(string papmiNo)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryFirstOrDefaultAsync<PA_PatMas>(PatientAdmissionQuery.GetPatientMasterByPapmiNo(), new { PAPMI_No = papmiNo });

                return result;
            }
        }

        public async Task<PA_Person> GetPersonByPapmiRowIdAsync(long papmiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryFirstOrDefaultAsync<PA_Person>(PatientAdmissionQuery.GetPersonByPapmiRowId(), new { PAPER_PAPMI_DR = papmiRowId });

                return result;
            }
        }
    }
}
