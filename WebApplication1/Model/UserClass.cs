﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public interface IUserService
    {
        string Name { get; set; }
        void SetUserStuff(string name);
    }
}
