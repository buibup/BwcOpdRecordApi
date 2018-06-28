using BwcOpdRecordApi.Data.Models.Questionnaires;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public static class TreatmentServiceProcessor
    {
        public async static Task<List<Medication>> GetMedicationsAsync(this IEnumerable<QBWCPANDTQQMedication> models)
        {
            var medications = new List<Medication>();
            var childSubList = models.Select(m => m.childsub).Distinct();

            await Task.Run(() =>
            {
                foreach (var item in models)
                {
                    var medication = new Medication()
                    {
                        ARCIM_Desc = item.ARCIM_Desc,
                        childsub = item.childsub,
                        ID = item.ID,
                        QDose = item.QDose,
                        QUESParRefDR = item.QUESParRefDR
                    };
                    medications.Add(medication);
                }
            });

            return medications;
        }
    }
}
