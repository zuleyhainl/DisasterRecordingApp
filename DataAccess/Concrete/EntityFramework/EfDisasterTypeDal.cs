using DataAccess.Abstract;
using Entities.Concrete;
using Infrastructure.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDisasterTypeDal :  EfRepositoryBase<DisasterType, DisasterContext>, IDisasterTypeDal
    {

    }
}
