using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Neighborhood : IEntity
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
        public string Name { get; set; }
        
        public ICollection<Disaster> Disasters { get; set; }

    }
}
