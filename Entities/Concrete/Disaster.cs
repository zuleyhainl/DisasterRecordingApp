﻿using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Disaster : IEntity
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string GlideNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public int TypeId { get; set; }
        public virtual DisasterType Type { get; set; }
        //public int CityId { get; set; }
        //public virtual City City { get; set; }
        //public int TownId { get; set; }
        //public virtual Town Town { get; set; }
        //public int NeighborhoodId { get; set; }
        //public virtual Neighborhood Neighborhood { get; set; }
        //public int VillageId { get; set; }
        //public virtual Village Village { get; set; }
        public string PlaceDescription { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Cause { get; set; }
        public string CauseDescription { get; set; }
        public string AffectedAreas { get; set; }
        public string Source { get; set; }
        public int DisasterImgId { get; set; }
        public virtual DisasterImg DisasterImg { get; set; }
    }
}
