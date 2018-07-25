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
            
            var documents = await _medicalRecordRepository.GetDocumentsByPapmiRowIdAsync(papmiRowId);

            var epiDist = documents.DistinctBy(d => d.PAADM_ADMNo).Select(e => e.PAADM_ADMNo);

            foreach(var epi in epiDist)
            {
                var doctors = new List<Doctor>();
                var documentTypes = new List<DocumentType>();

                var documentSubTypesDist = documents.Where(d => d.PAADM_ADMNo == epi).DistinctBy(d => d.SADST_Code).Select(d => new { d.SADST_Code, d.SADST_Desc });

                if(documentSubTypesDist.ToList().Count > 0)
                {
                    // Group by Doctor
                    foreach (var documentSubType in documentSubTypesDist)
                    {
                        if (_codeTablesRepository.IsDoctor(documentSubType.SADST_Code))
                        {
                            var documentsDoctor = documents.Where(d => d.SADST_Code == documentSubType.SADST_Code && d.PAADM_ADMNo == epi).ToList();
                            var doctor = new Doctor()
                            {
                                Name = documentSubType.SADST_Desc,
                                Documents = documentsDoctor
                            };

                            doctors.Add(doctor);
                        }
                    }
                }

                var documentTypeDist = documents.Where(d => d.PAADM_ADMNo == epi).DistinctBy(d => d.DOCTYPE_Desc).Select(d => d.DOCTYPE_Desc);

                if(documentTypeDist.ToList().Count > 0)
                {
                    // Group by DocumentTypes
                    foreach (var documentType in documentTypeDist)
                    {
                        var documentsDocType = documents.Where(d => d.DOCTYPE_Desc == documentType && d.PAADM_ADMNo == epi).ToList();
                        var model = new DocumentType()
                        {
                            Name = documentType,
                            Documents = documentsDocType
                        };

                        documentTypes.Add(model);
                    }
                }

                var documentsEpi = documents.Where(d => d.PAADM_ADMNo == epi).ToList();

                var documentVM = new DocumentViewModel()
                {
                    PAADM_ADMNo = epi,
                    Documents = documentsEpi,
                    Doctors = doctors,
                    DocumentTypes = documentTypes
                };

                result.Add(documentVM);
            }

            return result;
        }
    }
}
