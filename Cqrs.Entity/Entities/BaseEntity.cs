﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs.Entity.Entities
{
    abstract public class BaseEntity
    {
        public int Id { get; set; }
    }
}
