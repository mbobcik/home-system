using Microsoft.AspNetCore.Mvc;

namespace Home_System.Controllers
{
    [ApiController]
    [Route("job")]
    public class JobController : Controller
    {
        private readonly ILogger<JobController> _logger;

        public JobController(ILogger<JobController> logger)
        {
            this._logger = logger;
        }

        [HttpPost(Name = "start")]
        public int StartJob() { 
            return 0;
        }


    }
}
