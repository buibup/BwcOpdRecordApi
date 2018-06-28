using System;

namespace BwcOpdRecordApi.Data.Models.Questionnaires
{
    public class QBWCPANDT
    {
        public long ID { get; set; }
        public long QUESPAAdmDR { get; set; }
        public string PAADM_ADMNo { get; set; }
        public long QUESPAPatMasDR { get; set; }
        public string PAPMI_No { get; set; }
        public DateTime QUESDate { get; set; }
        public TimeSpan QUESTime { get; set; }
        public string QDiet { get; set; }
        public string QDietText { get; set; }
        public string QExercise { get; set; }
        public string QExerciseText { get; set; }
        public string QSleepText { get; set; }
        public string QPlanText { get; set; }
        public byte QSupplementW { get; set; }
        public byte QSupplementM { get; set; }
        public string QSupplement { get; set; }
        public byte QFollowUpPhoneW { get; set; }
        public byte QFollowUpPhoneM { get; set; }
        public byte QFollowUpW { get; set; }
        public byte QFollowUpMonth { get; set; }
        public long QUESUserDR { get; set; }
        public string SSUSR_Initials { get; set; }
        public string SSUSR_Name { get; set; }
    }
}
