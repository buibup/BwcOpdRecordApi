using System;

namespace BwcOpdRecordApi.Data.Models.Questionnaires
{
    public class QNURINFO
    {
        public long ID { get; set; }
        public long QUESPAAdmDR { get; set; }
        public string PAADM_ADMNo { get; set; }
        public long QUESPAPatMasDR { get; set; }
        public string PAPMI_No { get; set; }
        public DateTime QUESDate { get; set; }
        public TimeSpan QUESTime { get; set; }
        public byte QBehavioralNA { get; set; }
        public string QVegetableConsumption { get; set; }
        public string QVegetableFrequency { get; set; }
        public string QVegetableNote { get; set; }
        public string QFruitConsumption { get; set; }
        public string QFruitFrequency { get; set; }
        public string QFruitNote { get; set; }
        public string QTeaType { get; set; }
        public string QTeaTypeOther { get; set; }
        public string QTeaConsumption { get; set; }
        public string QTeaFrequency { get; set; }
        public string QTeaNote { get; set; }
        public string QCoffeeType { get; set; }
        public string QCoffeeTpyeOther { get; set; }
        public string QCoffeeConsumption { get; set; }
        public string QCoffeeFrequency { get; set; }
        public string QCoffeeNote { get; set; }
        public string QAlcoholType { get; set; }
        public string QAlcoholTypeOther { get; set; }
        public string QAlcoholConsumption { get; set; }
        public string QAlcoholFrequency { get; set; }
        public string QAlcoholNote { get; set; }
        public string QDietHistory { get; set; }
        public string QDietOrder { get; set; }
        public string QUESUserDR { get; set; }
        public string SSUSR_Initials { get; set; }
        public string SSUSR_Name { get; set; }
    }
}
