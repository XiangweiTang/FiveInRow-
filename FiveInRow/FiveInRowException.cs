﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveInRow
{
    class FiveInRowException:Exception
    {
        public FiveInRowException() : base() { }
        public FiveInRowException(string message) : base(message) { }
    }
}
