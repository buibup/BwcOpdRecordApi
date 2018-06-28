using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
        public ExerciseService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<List<Exercise>> GetExerciseByEpiRowIdAsync(long epiRowId)
        {
            var exercises = await _questionnaireRepository.GetExerciseAsync(epiRowId);
            var exerciseList = new List<Exercise>();

            foreach (var item in exercises)
            {
                var exercise = new Exercise()
                {
                    ID = item.ID,
                    QAthleticInjuries = item.QAthleticInjuries,
                    QAthleticInjuriesText = item.QAthleticInjuriesText,
                    QDuration = item.QDuration,
                    QFrequency = item.QFrequency,
                    QListOfExercise = item.QListOfExercise,
                    QListOfExerciseETC = item.QListOfExerciseETC,
                    QTypeExercise = item.QTypeExercise,
                    QUESDate = item.QUESDate,
                    QUESTime = item.QUESTime,
                    QUESUserDR = item.QUESUserDR,
                    SSUSR_Initials = item.SSUSR_Initials,
                    SSUSR_Name = item.SSUSR_Name
                };

                exerciseList.Add(exercise);
            }

            return exerciseList;
        }

        public async Task<ExerciseViewModel> GetExerciseViewModelByEpiRowIdAsync(long epiRowId)
        {
            var exercises = await _questionnaireRepository.GetExerciseAsync(epiRowId);
            var exerciseList = new List<Exercise>();
            var epiNo = "";
            var hn = "";

            foreach (var item in exercises)
            {
                epiNo = string.IsNullOrEmpty(epiNo) ? item.PAADM_ADMNo : epiNo;
                hn = string.IsNullOrEmpty(hn) ? item.PAPMI_No : hn;

                var exercise = new Exercise()
                {
                    ID = item.ID,
                    QAthleticInjuries = item.QAthleticInjuries,
                    QAthleticInjuriesText = item.QAthleticInjuriesText,
                    QDuration = item.QDuration,
                    QFrequency = item.QFrequency,
                    QListOfExercise = item.QListOfExercise,
                    QListOfExerciseETC = item.QListOfExerciseETC,
                    QTypeExercise = item.QTypeExercise,
                    QUESDate = item.QUESDate,
                    QUESTime = item.QUESTime,
                    QUESUserDR = item.QUESUserDR,
                    SSUSR_Initials = item.SSUSR_Initials,
                    SSUSR_Name = item.SSUSR_Name
                };

                exerciseList.Add(exercise);
            }

            var exerciseViewModel = new ExerciseViewModel()
            {
                PAPMI_No = hn,
                PAADM_ADMNo = epiNo,
                Exercises = exerciseList
            };

            return exerciseViewModel;
        }
    }
}
