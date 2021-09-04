using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Infrastructure.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDisasterDal : EfRepositoryBase<Disaster, DisasterContext>, IDisasterDal
    {
        public List<DisasterDto> GetDisasterDetails()
        {
            using (DisasterContext context = new DisasterContext())
            {
                //var result2 = from c in context.Disasters
                //              join n in context.Neighborhoods on c.NeighborhoodId equals n.Id

                var result = from d in context.Disasters
                             join tn in context.DisasterTypes on d.TypeId equals tn.Id
                             join cn in context.Cities on d.Neighborhood.District.Town.City.Id equals cn.Id
                             join twn in context.Towns on d.Neighborhood.District.Town.Id equals twn.Id
                             join dn in context.Districts on d.Neighborhood.District.Id equals dn.Id
                             join nn in context.Neighborhoods on d.Neighborhood.Id equals nn.Id
                             select new DisasterDto { DisasterId = d.Id, SerialNumber = d.SerialNumber, GlideNumber = d.GlideNumber, StartDate = d.StartDate, EndDate = d.EndDate, 
                                                      NumberOfDays = d.NumberOfDays, TypeName = tn.TypeName, CityName = cn.Name, TownName = twn.Name, DistrictName = dn.Name,
                                                      NeighborhoodName = nn.Name, PlaceDescription = d.PlaceDescription, Latitude = d.Latitude,
                                                      Longitude = d.Longitude, Cause = d.Cause, CauseDescription = d.CauseDescription, AffectedAreas = d.AffectedAreas, Source = d.Source};
                return result.ToList();

                
                              
            }
        }
    }
}
