using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Queries;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Repositories
{
    public class CodeTablesRepository : ICodeTablesRepository
    {
        private readonly ConnectionStrings _connectionStrings;
        public CodeTablesRepository(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public async Task<bool> IsDoctorAsync(string cTPCP_Code)
        {
            using(var connection = new OdbcConnection(_connectionStrings.Cache))
            {
                var result = await connection.ExecuteAsync(CodeTablesQuery.IsDoctor(), new { CTPCP_Code = cTPCP_Code });

                return result == 1 ? true : false;
            }
        }
    }
}
