using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Town : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public string Name { get; set; }
        public ICollection<District> Districts { get; set; }
       

    }
}
