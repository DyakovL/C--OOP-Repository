﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Models.Interfaces
{
    public interface ICallable
    {
        string Callable(string phoneNumber);
    }
}