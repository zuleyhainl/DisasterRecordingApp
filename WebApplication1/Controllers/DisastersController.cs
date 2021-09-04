using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
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
        public IActionResult DeleteDisaster(int Id)
        {
            var disaster = _disasterService.GetById(Id);
            _disasterService.Delete(disaster);
            return RedirectToAction("GetDisasterList");
        }


    }
}
