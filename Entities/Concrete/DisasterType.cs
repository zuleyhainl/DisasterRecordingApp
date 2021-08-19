using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DisasterType : IEntity
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Disaster> Disasters { get; set; }
    }
}
