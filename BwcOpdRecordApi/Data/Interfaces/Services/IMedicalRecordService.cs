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
        Task<FileStreamResult> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path);
        Task<IEnumerable<DocumentViewModel>> GetDocumentsVMByPapmiRowIdAsync(long papmiRowId);
    }
}
