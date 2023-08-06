using Home_System.Contracts;
using Home_System.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Home_System.Controllers
{
    [ApiController]
    [Route("job")]
    public class JobController : Controller
    {
        private readonly ILogger<JobController> _logger;
        private readonly IJobService jobService;

        public JobController(ILogger<JobController> logger, IJobService jobService)
        {
            this._logger = logger;
            this.jobService = jobService;
        }

        [HttpPost(Name = "start")]
        public string StartJob([FromBody] JobContract job) {
            if (job.Script == null)
            {
                throw new ArgumentNullException("No start script");
            }
            _logger.LogInformation($"Got Post request {Request.Path} with body {job}");
            var result = jobService.StartJob(job);
            return result.Result;
        }


    }
}
