using BwcOpdRecordApi.Data.Models.Others;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.VitalSignsOPDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public static class VitalSignsServiceProcessor
    {
        public static List<VitalSignsOPD> GetVitalSignsOPD(this IEnumerable<Observation> models)
        {
            var vitalSignsOPDs = new List<VitalSignsOPD>();

            if (models.ToList().Count == 0) return vitalSignsOPDs;

            var childSubList = models.Select(m => m.OBSENTRY_Childsub).Distinct();

            foreach (var childSub in childSubList)
            {
                var model = new VitalSignsOPD();

                foreach (var item in models)
                {
                    if (childSub == item.OBSENTRY_Childsub)
                    {
                        // add date, time
                        if (!model.OBS_Date.HasValue)
                        {
                            model.OBS_Date = item.OBS_Date;
                            model.OBS_Time = item.OBS_Time;
                        }
                        // Weight
                        if (item.ITM_Code == "WEIGHT")
                        {
                            model.Weight = item.OBS_Value;
                        }
                        // Height
                        else if (item.ITM_Code == "HEIGHT")
                        {
                            model.Height = item.OBS_Value;
                        }
                        // Temperature
                        else if (item.ITM_Code == "VS5")
                        {
                            model.Temperature = item.OBS_Value;
                        }
                        // Systolic
                        else if (item.ITM_Code == "VS1")
                        {
                            model.Systolic = item.OBS_Value;
                        }
                        // Diastolic
                        else if (item.ITM_Code == "VS2")
                        {
                            model.Diastolic = item.OBS_Value;
                        }
                        // Pulse
                        else if (item.ITM_Code == "VS3")
                        {
                            model.Pulse = item.OBS_Value;
                        }
                        // Respirations
                        else if (item.ITM_Code == "VS4")
                        {
                            model.Respirations = item.OBS_Value;
                        }
                        // BMI
                        else if (item.ITM_Code == "BMI")
                        {
                            model.BMI = item.OBS_Value;
                        }
                        // Oxygen Saturation
                        else if (item.ITM_Code == "VS6")
                        {
                            model.OxygenSaturation = item.OBS_Value;
                        }
                        // EWS Total
                        else if (item.ITM_Code == "EWS00")
                        {
                            model.EWSTotal = item.OBS_Value;
                        }
                    }
                }

                vitalSignsOPDs.Add(model);
            }

            return vitalSignsOPDs.OrderByDescending(v => v.OBS_Date).ThenByDescending(v => v.OBS_Time).ToList();
        }

        public static VitalSignsOPDViewModel GetVitalSignsOPDViewModel(this IEnumerable<Observation> models)
        {
            var vitalSignsOPDs = new List<VitalSignsOPD>();
            var hn = "";
            var epiNo = "";

            var childSubList = models.Select(m => m.OBSENTRY_Childsub).Distinct();

            foreach (var childSub in childSubList)
            {
                var model = new VitalSignsOPD();

                foreach (var item in models)
                {
                    hn = string.IsNullOrEmpty(hn) ? item.PAPMI_No : hn;
                    epiNo = string.IsNullOrEmpty(epiNo) ? item.PAADM_ADMNo : epiNo;

                    if (childSub == item.OBSENTRY_Childsub)
                    {
                        // add date, time
                        if (!model.OBS_Date.HasValue)
                        {
                            model.OBS_Date = item.OBS_Date;
                            model.OBS_Time = item.OBS_Time;
                        }
                        // Weight
                        if (item.ITM_Code == "WEIGHT")
                        {
                            model.Weight = item.OBS_Value;
                        }
                        // Height
                        else if (item.ITM_Code == "HEIGHT")
                        {
                            model.Height = item.OBS_Value;
                        }
                        // Temperature
                        else if (item.ITM_Code == "VS5")
                        {
                            model.Temperature = item.OBS_Value;
                        }
                        // Systolic
                        else if (item.ITM_Code == "VS1")
                        {
                            model.Systolic = item.OBS_Value;
                        }
                        // Diastolic
                        else if (item.ITM_Code == "VS2")
                        {
                            model.Diastolic = item.OBS_Value;
                        }
                        // Pulse
                        else if (item.ITM_Code == "VS3")
                        {
                            model.Pulse = item.OBS_Value;
                        }
                        // Respirations
                        else if (item.ITM_Code == "VS4")
                        {
                            model.Respirations = item.OBS_Value;
                        }
                        // BMI
                        else if (item.ITM_Code == "BMI")
                        {
                            model.BMI = item.OBS_Value;
                        }
                        // Oxygen Saturation
                        else if (item.ITM_Code == "VS6")
                        {
                            model.OxygenSaturation = item.OBS_Value;
                        }
                        // EWS Total
                        else if (item.ITM_Code == "EWS00")
                        {
                            model.EWSTotal = item.OBS_Value;
                        }
                    }
                }

                vitalSignsOPDs.Add(model);
            }

            var results = new VitalSignsOPDViewModel()
            {
                PAPMI_No = hn,
                PAADM_ADMNo = epiNo,
                VitalSignsOPDs = vitalSignsOPDs
            };

            return results;
        }
    }
}
