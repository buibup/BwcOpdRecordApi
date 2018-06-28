using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class DietService : IDietService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
        public DietService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<DietViewModel> GetDietViewModelByEpiRowIdAsync(long epiRowId)
        {
            var nutriInfos = await _questionnaireRepository.GetNutriInfoBehavioralAsync(epiRowId);

            var nutritions = new List<NutritionInformation>();
            var result = new DietViewModel();
            var hn = "";
            var epiNo = "";

            foreach (var item in nutriInfos)
            {
                hn = string.IsNullOrEmpty(hn) ? item.PAPMI_No : hn;
                epiNo = string.IsNullOrEmpty(epiNo) ? item.PAADM_ADMNo : epiNo;

                var dietPatterns = await _questionnaireRepository.GetNutriInfoDietaryPatternAsync(item.ID);
                var dietaryPatterns = await dietPatterns.GetDietaryPatterns();

                var behavioral = new Behavioral()
                {
                    QAlcoholConsumption = item.QAlcoholConsumption,
                    QAlcoholFrequency = item.QAlcoholFrequency,
                    QAlcoholNote = item.QAlcoholNote,
                    QAlcoholType = item.QAlcoholType,
                    QAlcoholTypeOther = item.QAlcoholTypeOther,
                    QBehavioralNA = item.QBehavioralNA,
                    QCoffeeConsumption = item.QCoffeeConsumption,
                    QCoffeeFrequency = item.QCoffeeFrequency,
                    QCoffeeNote = item.QCoffeeNote,
                    QCoffeeTpyeOther = item.QCoffeeTpyeOther,
                    QCoffeeType = item.QCoffeeType,
                    QFruitConsumption = item.QFruitConsumption,
                    QFruitFrequency = item.QFruitFrequency,
                    QFruitNote = item.QFruitNote,
                    QTeaConsumption = item.QTeaConsumption,
                    QTeaFrequency = item.QTeaFrequency,
                    QTeaNote = item.QTeaNote,
                    QTeaType = item.QTeaType,
                    QTeaTypeOther = item.QTeaTypeOther,
                    QVegetableConsumption = item.QVegetableConsumption,
                    QVegetableFrequency = item.QVegetableFrequency,
                    QVegetableNote = item.QVegetableNote
                };

                var nutrition = new NutritionInformation()
                {
                    ID = item.ID,
                    QUESDate = item.QUESDate,
                    QUESTime = item.QUESTime,
                    Behavioral = behavioral,
                    DietaryPatterns = dietaryPatterns,
                    QDietHistory = item.QDietHistory,
                    QDietOrder = item.QDietOrder,
                    QUESUserDR = item.QUESUserDR,
                    SSUSR_Initials = item.SSUSR_Initials,
                    SSUSR_Name = item.SSUSR_Name
                };

                nutritions.Add(nutrition);
            }

            result = new DietViewModel()
            {
                PAPMI_No = hn,
                PAADM_ADMNo = epiNo,
                NutritionInformations = nutritions
            };

            return result;
        }

        public async Task<List<NutritionInformation>> GetDietByEpiRowIdAsync(long epiRowId)
        {
            var nutriInfos = await _questionnaireRepository.GetNutriInfoBehavioralAsync(epiRowId);
            var result = new List<NutritionInformation>();

            foreach (var item in nutriInfos)
            {
                var dietPatterns = await _questionnaireRepository.GetNutriInfoDietaryPatternAsync(item.ID);
                var dietaryPatterns = await dietPatterns.GetDietaryPatterns();

                var behavioral = new Behavioral()
                {
                    QAlcoholConsumption = item.QAlcoholConsumption,
                    QAlcoholFrequency = item.QAlcoholFrequency,
                    QAlcoholNote = item.QAlcoholNote,
                    QAlcoholType = item.QAlcoholType,
                    QAlcoholTypeOther = item.QAlcoholTypeOther,
                    QBehavioralNA = item.QBehavioralNA,
                    QCoffeeConsumption = item.QCoffeeConsumption,
                    QCoffeeFrequency = item.QCoffeeFrequency,
                    QCoffeeNote = item.QCoffeeNote,
                    QCoffeeTpyeOther = item.QCoffeeTpyeOther,
                    QCoffeeType = item.QCoffeeType,
                    QFruitConsumption = item.QFruitConsumption,
                    QFruitFrequency = item.QFruitFrequency,
                    QFruitNote = item.QFruitNote,
                    QTeaConsumption = item.QTeaConsumption,
                    QTeaFrequency = item.QTeaFrequency,
                    QTeaNote = item.QTeaNote,
                    QTeaType = item.QTeaType,
                    QTeaTypeOther = item.QTeaTypeOther,
                    QVegetableConsumption = item.QVegetableConsumption,
                    QVegetableFrequency = item.QVegetableFrequency,
                    QVegetableNote = item.QVegetableNote
                };

                var nutrition = new NutritionInformation()
                {
                    ID = item.ID,
                    QUESDate = item.QUESDate,
                    QUESTime = item.QUESTime,
                    Behavioral = behavioral,
                    DietaryPatterns = dietaryPatterns,
                    QDietHistory = item.QDietHistory,
                    QDietOrder = item.QDietOrder,
                    QUESUserDR = item.QUESUserDR,
                    SSUSR_Initials = item.SSUSR_Initials,
                    SSUSR_Name = item.SSUSR_Name
                };

                result.Add(nutrition);
            }

            return result;
        }
    }
}
