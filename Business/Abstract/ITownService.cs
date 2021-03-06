using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITownService : IBaseService<Town>
    {
        List<Town> GetByCityId(int CityId);
    }
}
