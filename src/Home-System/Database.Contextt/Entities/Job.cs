using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Context.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
        public virtual JobMaster JobMaster { get; set; }
    }
}
