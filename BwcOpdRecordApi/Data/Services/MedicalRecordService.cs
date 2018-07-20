using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
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
        public MedicalRecordService(IMedicalRecordRepository medicalRecordRepository)
        {
            _medicalRecordRepository = medicalRecordRepository;
        }
        public async Task<FileStreamResult> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path)
        {
            var data = await _medicalRecordRepository.GetDocumentBinaryByPapmiNoAndPathAsync(papmiNo, path);
            string contentType = data.DocType.GetContentTypeByDocType();

            Stream stream = new MemoryStream(data.DocData);
            return new FileStreamResult(stream, contentType);
        }
    }
}
