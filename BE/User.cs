﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        public string Name { get; set; }
        public Host RelatedHost { get; set; }

    }
}
