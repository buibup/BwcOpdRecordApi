using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IMedicalRecordService
    {
        Task<DocumentResult> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path, bool isFileStreamResult);
        Task<IEnumerable<DocumentViewModel>> GetDocumentsVMByPapmiRowIdAsync(long papmiRowId);
        Task<DocumentViewModel> GetDocumentVMByEpiRowIdAsync(long epiRowId);
        Task<DocumentFilter> GetDocumentFilterAsync(long papmiRowId, string searchDoctor);
    }
}
