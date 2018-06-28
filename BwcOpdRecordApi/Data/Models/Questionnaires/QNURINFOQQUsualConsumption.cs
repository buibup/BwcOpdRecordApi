using System;

namespace BwcOpdRecordApi.Data.Models.Questionnaires
{
    public class QNURINFOQQUsualConsumption
    {
        public long QUESParRefDR { get; set; }
        public string ID { get; set; }
        public TimeSpan QTime { get; set; }
        public string QMeal { get; set; }
        public string QFoodBeverage { get; set; }
        public string childsub { get; set; }
    }
}
