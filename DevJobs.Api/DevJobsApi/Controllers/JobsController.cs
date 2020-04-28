using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevJobsApi.Interfaces;
using DevJobsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevJobsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly ILogger<JobsController> logger;
        private readonly IJobService jobService;

        public JobsController(ILogger<JobsController> Logger, IJobService JobService)
        {
            logger = Logger;
            jobService = JobService;
        }

        [HttpGet]
        async public Task<IEnumerable<Job>> Get(string location, string description)
        {           
            return await jobService.GetJobs(location, description);
        }
    }
}
