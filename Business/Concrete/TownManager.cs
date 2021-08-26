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
    public class TownManager : ITownService
    {
        ITownDal _townDal;
        public TownManager(ITownDal townDal)
        {
            _townDal = townDal;
        }

        public void Add(Town entity)
        {
            _townDal.Add(entity);
        }

        public void Delete(Town entity)
        {
            _townDal.Delete(entity);
        }

        public List<Town> GetAll()
        {
            return _townDal.GetAll();
        }

        public List<Town> GetByCityId(int CityId)
        {
            return _townDal.GetAll(c => c.CityId == CityId);
        }

        public Town GetById(int Id)
        {
            return _townDal.Get(t => t.Id == Id);
        }

        public void Update(Town entity)
        {
            _townDal.Update(entity);
        }
    }
}
