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
                Arguments = $"-NoProfile -ExecutionPolicy ByPass -Command {contract.Script} ",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
            };
            var process = Process.Start(startInfo);
            process.WaitForExit();
            _logger.LogInformation($"Finished '{contract.Script}' in {process.ExitTime - process.StartTime}");
            var result = await process.StandardOutput.ReadToEndAsync();

            return result;

        }
    }
}
