using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IMedicalRecordRepository _medicalRecordRepository;
        private readonly ICodeTablesRepository _codeTablesRepository;
        public MedicalRecordService(IMedicalRecordRepository medicalRecordRepository,
            ICodeTablesRepository codeTablesRepository)
        {
            _medicalRecordRepository = medicalRecordRepository;
            _codeTablesRepository = codeTablesRepository;
        }

        public async Task<FileStreamResult> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path)
        {
            var data = await _medicalRecordRepository.GetDocumentBinaryByPapmiNoAndPathAsync(papmiNo, path);
            string contentType = data.DocType.GetContentTypeByDocType();

            Stream stream = new MemoryStream(data.DocData);
            return new FileStreamResult(stream, contentType);
        }

        public async Task<IEnumerable<DocumentViewModel>> GetDocumentsVMByPapmiRowIdAsync(long papmiRowId)
        {
            var result = new List<DocumentViewModel>();

            var documets = await _medicalRecordRepository.GetDocumentsByPapmiRowIdAsync(papmiRowId);

            var doctors = documets.ToList().GetFilterDoctor();

            return result;
        }
    }
}
