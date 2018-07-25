using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Repositories
{
    public interface ICodeTablesRepository
    {
        bool IsDoctor(string cTPCP_Code);
    }
}
