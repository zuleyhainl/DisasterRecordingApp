using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisastersController : Controller
    {
        IDisasterService _disasterService;
        public DisastersController(IDisasterService disasterService)
        {
            _disasterService = disasterService;
        }
        [HttpGet]
        public IActionResult GetDisasterList()
        {
            var disasterValues = _disasterService.GetDisasterDetails();
            return View(disasterValues);
        }


    }
}
