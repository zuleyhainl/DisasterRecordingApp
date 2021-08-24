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
    public class DisasterTypeManager : IDisasterTypeService
    {
        IDisasterTypeDal _disasterTypeDal;
        public DisasterTypeManager(IDisasterTypeDal disasterTypeDal)
        {
            _disasterTypeDal = disasterTypeDal;
        }

        public void Add(DisasterType entity)
        {
            _disasterTypeDal.Add(entity);
        }

        public void Delete(DisasterType entity)
        {
            _disasterTypeDal.Delete(entity);
        }

        public List<DisasterType> GetAll()
        {
            return _disasterTypeDal.GetAll();
        }

        public DisasterType GetById(int Id)
        {
            return _disasterTypeDal.Get(t => t.Id == Id);
        }

        public void Update(DisasterType entity)
        {
            _disasterTypeDal.Update(entity);
        }
    }
}
