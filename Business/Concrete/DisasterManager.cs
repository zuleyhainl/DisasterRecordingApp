using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DisasterManager:IDisasterService
    {
        IDisasterDal _disasterDal;
        public DisasterManager(IDisasterDal disasterDal)
        {
            _disasterDal = disasterDal;
        }

        public void Add(Disaster entity)
        {
            _disasterDal.Add(entity);
        }

        public void Delete(Disaster entity)
        {
            _disasterDal.Delete(entity);
        }

        public List<Disaster> GetAll()
        {

            return _disasterDal.GetAll();
        }

        public Disaster GetById(int Id)
        {
            return _disasterDal.Get(d => d.Id == Id);
        }

        public List<DisasterDto> GetDisasterDetails()
        {
            return _disasterDal.GetDisasterDetails();
        }

        public void Update(Disaster entity)
        {
            _disasterDal.Update(entity);
        }
    }
}
