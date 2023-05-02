using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace global_azure_day2023.Model.Shared.Models
{
    public class Speaker
    {
        public string SessionName { get; set; }

        public string SpeakerName { get; set; }

        public DateTime EventDate { get; set; }

        public string EventTime { get; set; }

        public string SlotName { get; set; }
    }
}
