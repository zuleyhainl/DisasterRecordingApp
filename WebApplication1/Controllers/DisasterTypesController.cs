using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class DisasterTypesController : Controller
    {
        IDisasterTypeService _disasterTypeService;
        public DisasterTypesController(IDisasterTypeService disasterTypeService)
        {
            _disasterTypeService = disasterTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _disasterTypeService.GetAll();
            return RedirectToAction("Home/Index",result);
        }


        //[HttpPost("adddisaster")]
        //public IActionResult Add(Disaster disaster)
        //{
        //    _disasterService.Add(disaster);
        //    return Ok();
        //}
    }
}
