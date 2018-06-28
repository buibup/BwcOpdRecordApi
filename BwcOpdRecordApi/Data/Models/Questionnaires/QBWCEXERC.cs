using System;

namespace BwcOpdRecordApi.Data.Models.Questionnaires
{
    public class QBWCEXERC
    {
        public long ID { get; set; }
        public long QUESPAAdmDR { get; set; }
        public string PAADM_ADMNo { get; set; }
        public long QUESPAPatMasDR { get; set; }
        public string PAPMI_No { get; set; }
        public DateTime QUESDate { get; set; }
        public TimeSpan QUESTime { get; set; }
        public string QFrequency { get; set; }
        public string QTypeExercise { get; set; }
        public string QListOfExercise { get; set; }
        public string QListOfExerciseETC { get; set; }
        public string QDuration { get; set; }
        public string QAthleticInjuries { get; set; }
        public string QAthleticInjuriesText { get; set; }
        public long QUESUserDR { get; set; }
        public string SSUSR_Initials { get; set; }
        public string SSUSR_Name { get; set; }
    }
}
