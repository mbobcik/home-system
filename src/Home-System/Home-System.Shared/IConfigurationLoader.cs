﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_System.Shared
{
    public interface IConfigurationLoader
    {
        Configuration Load();
    }
}
