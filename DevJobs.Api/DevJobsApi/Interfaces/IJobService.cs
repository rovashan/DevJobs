using DevJobsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobsApi.Interfaces
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetJobs(string location, string description);
    }
}
