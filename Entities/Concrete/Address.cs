﻿using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        //public int NeighborhoodId { get; set; }
        //public virtual Neighborhood Neighborhood { get; set; }
    }
}
