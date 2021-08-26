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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public void Add(City entity)
        {
            _cityDal.Add(entity);
        }

        public void Delete(City entity)
        {
            _cityDal.Delete(entity);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public City GetById(int Id)
        {
            return _cityDal.Get(c => c.Id == Id);
        }

        public void Update(City entity)
        {
            _cityDal.Update(entity);
        }
    }
}
