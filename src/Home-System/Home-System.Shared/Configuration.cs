namespace Home_System.Shared
{
    public class Configuration
    {
        public static string WorkDir { get; set; }

        public Configuration() 
        {
            WorkDir = @"C:\Users\bobci\repo\home-system\workDir";
        }
    }
}