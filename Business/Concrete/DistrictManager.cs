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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public void Add(District entity)
        {
            _districtDal.Add(entity);
        }

        public void Delete(District entity)
        {
            _districtDal.Delete(entity);
        }

        public List<District> GetAll()
        {
            return _districtDal.GetAll();
        }

        public District GetById(int Id)
        {
            return _districtDal.Get(d => d.Id == Id);
        }

        public List<District> GetAllByTownId(int townId)
        {
            return _districtDal.GetAll(d => d.TownId == townId);
        }

        public void Update(District entity)
        {
            _districtDal.Update(entity);
        }
    }
}
