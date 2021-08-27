using Entities.Concrete;
using Entities.DTOs;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDisasterDal : IRepository<Disaster>
    {
        List<DisasterDto> GetDisasterDetails();//buraya özgü
    }
}
