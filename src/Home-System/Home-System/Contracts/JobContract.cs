namespace Home_System.Contracts
{
    public class JobContract
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
        public string Script { get; set; }

    }
}
