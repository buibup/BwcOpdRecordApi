using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Repositories
{
    public interface ICodeTablesRepository
    {
        Task<bool> IsDoctorAsync(string cTPCP_Code);
    }
}
