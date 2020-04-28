using DevJobsApi.Interfaces;
using DevJobsApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DevJobsApi.Services
{
    public class JobService : IJobService
    {
        async public Task<IEnumerable<Job>> GetJobs(string location, string description)
        {
            string githubApiUrl = "https://jobs.github.com/positions.json?";

            if (location != "null") {
                githubApiUrl = string.Concat(githubApiUrl, "location=", location);

                if (description != "null")
                {
                    githubApiUrl = string.Concat(githubApiUrl, "&description=", description);
                }
            } else
            {
                if (description != "null")
                {
                    githubApiUrl = string.Concat(githubApiUrl, "description=", description);
                }
            }

            //Console.WriteLine(githubApiUrl);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(githubApiUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync(githubApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Job>>(jsonString);
                }

                return null;
            }
        }
    }
}
