using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()//IEntityden türeyen nesneler gelebilir
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filtre vermese de kabul
        T Get(Expression<Func<T, bool>> filter);//filtre zorunlu//getbyID dahil
    }
}
