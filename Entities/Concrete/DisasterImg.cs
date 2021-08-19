using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DisasterImg : IEntity
    {
        public int Id { get; set; }
        public int DisasterId { get; set; }
        public string ImgPath { get; set; }
        public ICollection<Disaster> Disasters { get; set; }
    }
}
