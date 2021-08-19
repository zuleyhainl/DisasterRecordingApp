using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseService<T> where T : IEntity, new()
    {
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
        public List<T> GetAll();
    }
}
