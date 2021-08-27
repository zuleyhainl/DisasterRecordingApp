using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DisasterDto
    {
        public string SerialNumber { get; set; }
        public string GlideNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public string TypeName { get; set; }
        public string CityName { get; set; }
        public string TownName { get; set; }
        public string DistrictName { get; set; }
        public string NeighborhoodName { get; set; }
        public string PlaceDescription { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Cause { get; set; }
        public string CauseDescription { get; set; }
        public string AffectedAreas { get; set; }
        public string Source { get; set; }
    }
}
