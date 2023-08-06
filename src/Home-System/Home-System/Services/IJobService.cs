using Home_System.Contracts;

namespace Home_System.Services
{
    public interface IJobService
    {
        Task<string> StartJob(JobContract contract);
    }
}