using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int Id { get; set; }
        public int TownId { get; set; }
        public virtual Town Town { get; set; }
        public string Name { get; set; }
        public ICollection<Neighborhood> Neighborhoods { get; set; }
       
    }
}
