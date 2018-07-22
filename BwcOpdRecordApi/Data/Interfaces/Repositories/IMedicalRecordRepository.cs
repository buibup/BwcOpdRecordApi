using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Repositories
{
    public interface IMedicalRecordRepository
    {
        Task<IEnumerable<DocumentViewModel>> GetDocumentsByPapmiRowIdAsync(long papmiRowId);
        Task<IEnumerable<DocumentViewModel>> GetDocumentsByEpiRowIdAsync(long epiRowId);
        Task<DocumentBinary> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path);
    }
}
