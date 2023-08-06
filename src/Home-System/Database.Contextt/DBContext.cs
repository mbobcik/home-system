using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Database.Context.Entities;

namespace Database.Context
{
    public class HomeDatabase : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobMaster> JobMasters { get; set; }

    }
}