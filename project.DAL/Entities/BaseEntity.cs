﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL.Entities
{
    public record BaseEntity : IEntity
    {
        public Guid Id { get; init; }
    }
}
