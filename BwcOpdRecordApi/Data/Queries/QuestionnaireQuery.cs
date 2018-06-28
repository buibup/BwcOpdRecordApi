using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Queries
{
    public class QuestionnaireQuery
    {
        public static string GetPhysicalExamAntiAgingQueryByEpiRowId()
        {
            return @"
            SELECT 
                ID, QUESPAAdmDR, QUESPAPatMasDR, QUESDate, QUESTime, 
                QCC, QCCText, QCCOtherText, QUnderlying, QCurrentMed,
                QSupplementation, QHistoryInvestigation, QGI, QGOText,
                QSleep, QSleepHours, QSleepText, QSkin, QSkinText,
                QMemory, QMemoryText, QImmune, QImmuneText,
                QSexual, QSexualText, QExercise, QGenetic, QFamilyFather,
                QFamilyMother, QGeneralPE, QGeneralPEText, QENTPE,
                QENTPharynx, QENTTonsils, QENTNeckNode, QENTPEText,
                QRespiratoryPE, QRespiratoryPEText, QCardiovascularPE,
                QCardiovascularPEText, QAbdomenPE, QAbdomenPEText,
                QPEText, QSpecialNote, QDoctor, QUESUserDR
            FROM questionnaire.QBWCPEANTI
            WHERE QUESPAAdmDR = ?";
        }

        public static string GetDietBehavioralQueryByEpiRowId()
        {
            return @"
            SELECT 
	            ID, QUESPAAdmDR, QUESPAPatMasDR,
	            QUESPAAdmDR->PAADM_ADMNo, 
	            QUESPAPatMasDR->PAPMI_No,
                QUESDate, QUESTime, QUESUserDR,
                QUESUserDR->SSUSR_Initials,
                QUESUserDR->SSUSR_Name,
                QDietHistory, QDietOrder, QBehavioralNA,
                QVegetableFrequency, QFruitFrequency, QTeaFrequency,
                QCoffeeFrequency, QAlcoholFrequency, QVegetableNote,
                QFruitNote, QTeaNote, QCoffeeNote, QAlcoholNote,
                QVegetableConsumption, QFruitConsumption, QTeaConsumption,
                QCoffeeConsumption, QAlcoholConsumption, QTeaType,
                QCoffeeType, QAlcoholType, QTeaTypeOther,
                QCoffeeTpyeOther, QAlcoholTypeOther
            FROM questionnaire.QNURINFO
            WHERE QUESPAAdmDR = ?";
        }

        public static string GetDietaryPatternQueryByQUESParRefDR()
        {
            return @"
            SELECT 
	            QUESParRefDR, ID, QMeal, 
	            QFoodBeverage, QTime, childsub
            FROM questionnaire.QNURINFOQQUsualConsumption
            WHERE QUESParRefDR = ?";
        }

        public static string GetExerciseQueryByEpiRowId()
        {
            return @"
            SELECT 
	            ID, QUESPAAdmDR, QUESPAAdmDR->PAADM_ADMNo, 
	            QUESPAPatMasDR, QUESPAPatMasDR->PAPMI_No,
	            QUESDate, QUESTime, QFrequency,
	            QTypeExercise, QListOfExercise,
	            QListOfExerciseETC, QDuration,
	            QAthleticInjuries, QAthleticInjuriesText,
	            QUESUserDR, QUESUserDR->SSUSR_Initials, 
	            QUESUserDR->SSUSR_Name
            FROM questionnaire.QBWCEXERC
            WHERE QUESPAAdmDR = ?";
        }

        public static string GetPlanAndTreatmentByEpiRowId()
        {
            return @"
            SELECT 
                ID, QUESPAAdmDR, QUESPAAdmDR->PAADM_ADMNo, 
                QUESPAPatMasDR, QUESPAPatMasDR->PAPMI_No,
                QUESDate, QUESTime, QDiet, QDietText,
                QExercise, QExerciseText, QSleepText, QPlanText,
                QSupplementW, QSupplementM, QSupplement,
                QFollowUpPhoneW, QFollowUpPhoneM,
                QFollowUpW, QFollowUpMonth, 
                QUESUserDR, QUESUserDR->SSUSR_Initials, 
                QUESUserDR->SSUSR_Name
            FROM questionnaire.QBWCPANDT
            WHERE QUESPAAdmDR = ?";
        }

        public static string GetMedicationQueryByQUESParRefDR()
        {
            return @"
            SELECT 
	            q.ID, q.QUESParRefDR, 
	            a.ARCIM_Desc,
	            q.QDose, q.childsub
            FROM questionnaire.QBWCPANDTQQMedication q 
            LEFT JOIN ARC_ItmMast a
            on q.QMedicationOrder = a.ARCIM_RowId
            WHERE QUESParRefDR = ?";
        }
    }
}
