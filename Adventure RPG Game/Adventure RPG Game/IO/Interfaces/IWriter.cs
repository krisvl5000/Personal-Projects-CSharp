﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest
{
    public interface IWriter
    {
        void Write(object text);

        void WriteLine(object text);
    }
}
