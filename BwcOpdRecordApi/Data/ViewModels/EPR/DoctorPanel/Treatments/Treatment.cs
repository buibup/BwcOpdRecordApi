using Newtonsoft.Json;
using System.Collections.Generic;

namespace BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel.Treatments
{
    public class Treatment
    {
        [JsonProperty(PropertyName = "Medications")]
        public List<Medication> Medications { get; set; }

        [JsonProperty(PropertyName = "QSupplementW")]
        public byte QSupplementW { get; set; }

        [JsonProperty(PropertyName = "QSupplementM")]
        public byte QSupplementM { get; set; }

        [JsonProperty(PropertyName = "QSupplement")]
        public string QSupplement { get; set; }

        [JsonProperty(PropertyName = "QFollowUpPhoneW")]
        public byte QFollowUpPhoneW { get; set; }

        [JsonProperty(PropertyName = "QFollowUpPhoneM")]
        public byte QFollowUpPhoneM { get; set; }

        [JsonProperty(PropertyName = "QFollowUpW")]
        public byte QFollowUpW { get; set; }

        [JsonProperty(PropertyName = "QFollowUpMonth")]
        public byte QFollowUpMonth { get; set; }
    }
}
