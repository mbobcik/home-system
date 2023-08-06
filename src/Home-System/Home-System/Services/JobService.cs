using Home_System.Contracts;
using Home_System.Controllers;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Home_System.Services
{
    public class JobService : IJobService
    {
        private readonly ILogger<JobService> _logger;

        public JobService(ILogger<JobService> logger)
        {
            this._logger = logger;
        }

        public async Task<string> StartJob(JobContract contract)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "pwsh.exe",
                Arguments = $"-NoProfile -ExecutionPolicy ByPass {{ {contract.Script} }}",
                UseShellExecute = false,
            };
            var process = Process.Start(startInfo);
            await process.WaitForExitAsync();
            _logger.LogInformation($"Finished '{contract.Script}' in {process.ExitTime - process.StartTime}");
            var result = await process.StandardOutput.ReadToEndAsync();

            return result;

        }
    }
}
