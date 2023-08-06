﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Context.Entities
{
    public class JobMaster
    {
        public int Id { get; set; }
        public string Endpoint { get; set; }
        public string Name { get; set; }    
        public virtual List<Job> Jobs { get; set; }
    }
}
