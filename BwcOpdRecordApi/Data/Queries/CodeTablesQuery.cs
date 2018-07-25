using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Queries
{
    public class CodeTablesQuery
    {
        public static string IsDoctor()
        {
            return @"
                SELECT COUNT(*) IsDoctor
                FROM CT_CareProv
                WHERE CTPCP_Code = ? AND 
                CTPCP_CarPrvTp_DR->CTCPT_RowId IN (1, 2, 3) AND 
                SUBSTRING(CTPCP_Code, 0, 5) = '8100'";
        }
    }
}
