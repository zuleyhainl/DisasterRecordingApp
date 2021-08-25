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

        /*[HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _disasterService.GetAll();
            return Ok(result);
        }*/

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost("adddisaster")]
        public IActionResult Add(Disaster disaster)
        {
            _disasterService.Add(disaster);
            return Ok();
        }
    }
}
