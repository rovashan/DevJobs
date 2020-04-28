using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobsApi.Models
{
    public class Job
    {
        public string id { get; set; }
        public string type { get; set; }
        public string company { get; set; }
        public string companyUrl { get; set; }
        public string location { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string createdAt { get; set; }
        public string apply { get; set; }
    }
}
