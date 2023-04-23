﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models.Entities
{
    public interface IEntity
    {
        public string Name { get; set; }

        public int Balance { get; set; }
    }
}