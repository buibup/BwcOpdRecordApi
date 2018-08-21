using BwcOpdRecordApi.Data.Interfaces.Repositories.SqlServer;
using BwcOpdRecordApi.Data.Models.ConsentForm;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Repositories.SqlServer
{
    public class ConsentFormRepository : IConsentFormRepository
    {
        private readonly ConnectionStrings _connectionStrings;
        public ConsentFormRepository(ConnectionStrings connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public async Task<IEnumerable<CustomerAgree>> GetCustomerAgreesAsync(int papmiRowId)
        {
            using(var conn = new SqlConnection(_connectionStrings.ConsentDb))
            {
                var p = new DynamicParameters();
                p.Add("@papmi_row_id", papmiRowId);

                var result = (await conn.QueryAsync<CustomerAgree>("GetCustomerAgrees", p, commandType: CommandType.StoredProcedure)).ToList();

                return result;
            }
        }

        public async Task<CustomerPaper> GetCustomerPaperAsync(int customerId, int templateId)
        {
            using(var conn = new SqlConnection(_connectionStrings.ConsentDb))
            {
                var p = new DynamicParameters();
                p.Add("@customer_id", customerId);
                p.Add("@template_id", templateId);

                var result = (await conn.QueryAsync<CustomerPaper>("GetCustomerPaper", p, commandType: CommandType.StoredProcedure)).FirstOrDefault();

                return result;
            }
        }
    }
}
