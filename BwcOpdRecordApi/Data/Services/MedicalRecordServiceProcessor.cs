using BwcOpdRecordApi.Data.ViewModels.EPR.ScanDocuments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public static class MedicalRecordServiceProcessor
    {
        public static List<Doctor> GetFilterDoctor(this List<Document> documents)
        {
            var doctors = new List<Doctor>();

            var doctorDist = documents
                .GroupBy(d => d.SADST_Code)
                .Select(d => d.First())
                .ToList();

            foreach (var item in documents)
            {
                var doctor = new Doctor()
                {
                    
                };
            }

            return doctors;
        }

    }
}
