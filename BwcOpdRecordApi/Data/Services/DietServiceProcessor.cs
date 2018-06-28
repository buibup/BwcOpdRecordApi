using BwcOpdRecordApi.Data.Models.Questionnaires;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Diet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public static class DietServiceProcessor
    {
        public async static Task<List<DietaryPattern>> GetDietaryPatterns(this IEnumerable<QNURINFOQQUsualConsumption> models)
        {
            var dietaryPatterns = new List<DietaryPattern>();

            await Task.Run(() => {
                foreach (var dietPattern in models)
                {
                    var dietaryPattern = new DietaryPattern()
                    {
                        QTime = dietPattern.QTime,
                        QMeal = dietPattern.QMeal,
                        QFoodBeverage = dietPattern.QFoodBeverage,
                        Childsub = dietPattern.childsub
                    };

                    dietaryPatterns.Add(dietaryPattern);
                }
            });

            return dietaryPatterns;
        }
    }
}
