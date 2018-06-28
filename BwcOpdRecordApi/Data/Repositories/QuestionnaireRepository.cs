using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Models.Questionnaires;
using BwcOpdRecordApi.Data.Queries;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly ConnectionStrings _connectionStrings;
        public QuestionnaireRepository(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public async Task<IEnumerable<QBWCEXERC>> GetExerciseAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<QBWCEXERC>(QuestionnaireQuery.GetExerciseQueryByEpiRowId(), new { QUESPAAdmDR = epiRowId });

                return result;
            }
        }

        public async Task<IEnumerable<QBWCPANDTQQMedication>> GetMedicationAsync(long quesParRefDR)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<QBWCPANDTQQMedication>(QuestionnaireQuery.GetMedicationQueryByQUESParRefDR(), new { QUESParRefDR = quesParRefDR });

                return result;
            }
        }

        public async Task<IEnumerable<QNURINFO>> GetNutriInfoBehavioralAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<QNURINFO>(QuestionnaireQuery.GetDietBehavioralQueryByEpiRowId(), new { QUESPAAdmDR = epiRowId });

                return result.ToList();
            }
        }

        public async Task<IEnumerable<QNURINFOQQUsualConsumption>> GetNutriInfoDietaryPatternAsync(long quesParRefDR)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<QNURINFOQQUsualConsumption>(QuestionnaireQuery.GetDietaryPatternQueryByQUESParRefDR(), new { QUESParRefDR = quesParRefDR });

                return result.ToList();
            }
        }

        public async Task<IEnumerable<QBWCPEANTI>> GetPhysicalExamAntiAgingAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<QBWCPEANTI>(QuestionnaireQuery.GetPhysicalExamAntiAgingQueryByEpiRowId(), new { QUESPAAdmDR = epiRowId });

                return result.ToList();
            }
        }

        public async Task<IEnumerable<QBWCPANDT>> GetTreatmentAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<QBWCPANDT>(QuestionnaireQuery.GetPlanAndTreatmentByEpiRowId(), new { QUESPAAdmDR = epiRowId });

                return result;
            }
        }
    }
}
