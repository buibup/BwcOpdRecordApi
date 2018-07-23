using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Queries;
using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Repositories
{
    public class MedicalRecordRepository : IMedicalRecordRepository
    {
        private readonly ConnectionStrings _connectionStrings;
        public MedicalRecordRepository(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }
        public async Task<DocumentBinary> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryFirstOrDefaultAsync<DocumentBinary>(MedicalRecordQuery.GetDocumentBinaryByPapmiNoAndPath(), new { PAPMI_No = papmiNo, PIC_Path = path });

                return result;
            }
        }

        public async Task<IEnumerable<DocumentViewModel>> GetDocumentsByEpiRowIdAsync(long epiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<DocumentViewModel>(MedicalRecordQuery.GetDocumentsByEpiRowId(), new { PAADM_RowID = epiRowId });

                return result;
            }
        }

        public async Task<IEnumerable<DocumentViewModel>> GetDocumentsByPapmiRowIdAsync(long papmiRowId)
        {
            using (var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.QueryAsync<DocumentViewModel>(MedicalRecordQuery.GetDocumentsByPapmiRowId(), new { PAPMI_RowId1 = papmiRowId });

                return result;
            }
        }
    }
}
