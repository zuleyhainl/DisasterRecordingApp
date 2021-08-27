using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NeighborhoodManager : INeighborhoodService
    {
        INeighborhoodDal _neighborhoodDal;
        public NeighborhoodManager(INeighborhoodDal neighborhoodDal)
        {
            _neighborhoodDal = neighborhoodDal;
        }

        public void Add(Neighborhood entity)
        {
            _neighborhoodDal.Add(entity);
        }

        public void Delete(Neighborhood entity)
        {
            _neighborhoodDal.Delete(entity);
        }

        public List<Neighborhood> GetAll()
        {
            return _neighborhoodDal.GetAll();
        }

        public List<Neighborhood> GetAllByDistrictId(int disId)
        {
            return _neighborhoodDal.GetAll(n => n.DistrictId == disId);
        }

        public Neighborhood GetById(int Id)
        {
            return _neighborhoodDal.Get(n => n.Id == Id);
        }

        public void Update(Neighborhood entity)
        {
            _neighborhoodDal.Update(entity);
        }
    }
}
