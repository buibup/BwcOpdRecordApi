using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;
        public MedicalRecordService(IMedicalRecordRepository medicalRecordRepository,
            ICodeTablesRepository codeTablesRepository,
            IConfiguration configuration
            )
        {
            _medicalRecordRepository = medicalRecordRepository;
            _codeTablesRepository = codeTablesRepository;
            _configuration = configuration;
        }

        public async Task<DocumentResult> GetDocumentBinaryByPapmiNoAndPathAsync(string papmiNo, string path, bool isFileStreamResult)
        {
            var data = await _medicalRecordRepository.GetDocumentBinaryByPapmiNoAndPathAsync(papmiNo, path, isFileStreamResult);
            string contentType = data.DocType.GetContentTypeByDocType();

            if (!isFileStreamResult)
            {
                return new DocumentResult()
                {
                    ContentType = contentType,
                    FileStreamResult = null
                };
            }

            Stream stream = new MemoryStream(data.DocData);
            var fileStreamResult = new FileStreamResult(stream, contentType);

            var result = new DocumentResult()
            {
                ContentType = contentType,
                FileStreamResult = fileStreamResult
            };

            return result;
        }

        public async Task<DocumentViewModel> GetDocumentVMByEpiRowIdAsync(long epiRowId)
        {
            var documents = await _medicalRecordRepository.GetDocumentsByEpiRowIdAsync(epiRowId);
            var hn = documents.DistinctBy(d => d.PAPMI_No).Select(e => e.PAPMI_No).FirstOrDefault();
            var epiNo = documents.DistinctBy(d => d.PAADM_ADMNo).Select(e => e.PAADM_ADMNo).FirstOrDefault();
            var documentsResult = new List<Document>();

            foreach (var item in documents)
            {
                var contentType = await GetDocumentBinaryByPapmiNoAndPathAsync(hn, item.PIC_Path, false);
                var docUrl = $"{_configuration["Settings:BaseUrl"]}api/OpdRecord/GetDocument/{hn}/{item.PIC_Path}";
                var doc = new Document()
                {
                    PAPMI_No = item.PAPMI_No,
                    PAADM_RowID = item.PAADM_RowID,
                    PAADM_ADMNo = item.PAADM_ADMNo,
                    PIC_DateCreated = item.PIC_DateCreated,
                    PIC_TimeCreated = item.PIC_TimeCreated,
                    SADST_Code = item.SADST_Code,
                    SADST_Desc = item.SADST_Desc,
                    DOCTYPE_Desc = item.DOCTYPE_Desc,
                    DocumentBinary = item.DocumentBinary,
                    PIC_Path = item.PIC_Path,
                    PIC_Desc = item.PIC_Desc,
                    ContentType = contentType.ContentType,
                    DocumentUrl = docUrl,
                    DocType = item.DocType,
                    IsPdf = item.DocType.ToLower() == "pdf" ? true : false
                };

                documentsResult.Add(doc);
            }

            var doctors = new List<Doctor>();
            var documentTypes = new List<DocumentType>();

            var documentSubTypesDist = documents.Where(d => d.PAADM_ADMNo == epiNo).DistinctBy(d => d.SADST_Code).Select(d => new { d.SADST_Code, d.SADST_Desc });

            if (documentSubTypesDist.ToList().Count > 0)
            {
                // Group by Doctor
                foreach (var documentSubType in documentSubTypesDist)
                {
                    if (_codeTablesRepository.IsDoctor(documentSubType.SADST_Code))
                    {
                        var documentsDoctor = documentsResult.Where(d => d.SADST_Code == documentSubType.SADST_Code && d.PAADM_ADMNo == epiNo).ToList();
                        var doctor = new Doctor()
                        {
                            Name = documentSubType.SADST_Desc,
                            Documents = documentsDoctor
                        };

                        doctors.Add(doctor);
                    }
                }
            }

            var documentTypeDist = documentsResult.Where(d => d.PAADM_ADMNo == epiNo).DistinctBy(d => d.DOCTYPE_Desc).Select(d => d.DOCTYPE_Desc);

            if (documentTypeDist.ToList().Count > 0)
            {
                // Group by DocumentTypes
                foreach (var documentType in documentTypeDist)
                {
                    var documentsDocType = documentsResult.Where(d => d.DOCTYPE_Desc == documentType && d.PAADM_ADMNo == epiNo).ToList();

                    var model = new DocumentType()
                    {
                        Name = documentType,
                        Documents = documentsDocType
                    };

                    documentTypes.Add(model);
                }
            }

            var documentsEpi = documentsResult.Where(d => d.PAADM_ADMNo == epiNo).ToList();

            var result = new DocumentViewModel()
            {
                PAADM_ADMNo = epiNo,
                Doctors = doctors,
                DocumentTypes = documentTypes,
                Documents = documentsEpi
            };
            return result;
        }

        public async Task<IEnumerable<DocumentViewModel>> GetDocumentsVMByPapmiRowIdAsync(long papmiRowId)
        {
            var result = new List<DocumentViewModel>();

            var documents = await _medicalRecordRepository.GetDocumentsByPapmiRowIdAsync(papmiRowId);

            var epiDist = documents.DistinctBy(d => d.PAADM_ADMNo).Select(e => e.PAADM_ADMNo);

            foreach (var epi in epiDist)
            {
                var doctors = new List<Doctor>();
                var documentTypes = new List<DocumentType>();

                var documentSubTypesDist = documents.Where(d => d.PAADM_ADMNo == epi).DistinctBy(d => d.SADST_Code).Select(d => new { d.SADST_Code, d.SADST_Desc });

                if (documentSubTypesDist.ToList().Count > 0)
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

                if (documentTypeDist.ToList().Count > 0)
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

        public async Task<DocumentFilter> GetDocumentFilterAsync(long papmiRowId)
        {
            var typeFilters = new List<TypeFilter>();

            var documents = await _medicalRecordRepository.GetDocumentsByPapmiRowIdAsync(papmiRowId);
            var documentsDocTypeDistList = documents.Select(d => d.DOCTYPE_Desc).Distinct().OrderBy(d => d).ToList();

            foreach(var item in documentsDocTypeDistList)
            {
                var docs = documents.Where(dc => dc.DOCTYPE_Desc == item).ToList();

                var typeFilter = new TypeFilter
                {
                    TypeName = item,
                    Documents = docs
                };

                typeFilters.Add(typeFilter);
            }

            var documenFilter = new DocumentFilter()
            {
                TypeFilters = typeFilters
            };

            return documenFilter;
        }
    }
}
