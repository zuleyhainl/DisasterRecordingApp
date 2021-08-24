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
    public class DisasterImgManager:IDisasterImgService
    {
        IDisasterImgDal _disasterImgDal;
        public DisasterImgManager(IDisasterImgDal disasterImgDal)
        {
            _disasterImgDal = disasterImgDal;
        }

        public void Add(DisasterImg entity)
        {
            _disasterImgDal.Add(entity);
        }

        public void Delete(DisasterImg entity)
        {
            _disasterImgDal.Delete(entity);
        }

        public List<DisasterImg> GetAll()
        {
            return _disasterImgDal.GetAll();
        }

        public DisasterImg GetById(int Id)
        {
            return _disasterImgDal.Get(i => i.Id == Id);
        }

        public void Update(DisasterImg entity)
        {
            _disasterImgDal.Update(entity);
        }
    }
}
