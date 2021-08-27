using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ViewClass
    {
        public IEnumerable<SelectListItem> Cities { get; set; }
        public IEnumerable<SelectListItem> Towns { get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
        public IEnumerable<SelectListItem> Neighborhoods { get; set; }
        public IEnumerable<SelectListItem> DisasterTypes { get; set; }

    }
}
