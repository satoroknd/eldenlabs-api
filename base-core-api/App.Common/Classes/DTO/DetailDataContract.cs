using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Classes.DTO
{
    public class DetailDataContract
    {
        public string ConnectionDeviceID { get; set; }
        public string EventProcessedUtcTime { get; set; }
        public string HefestoID { get; set; }
        public string Timestamp { get; set; }
        public string LongDescription { get; set; }
        public string DetailValue { get; set; }
        public string Plugin { get; set; }
        public string Request { get; set; }
        public string Description { get; set; }
        public int Device { get; set; }
    }
}
