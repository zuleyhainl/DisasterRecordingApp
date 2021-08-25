using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        IDisasterTypeService _disasterTypeService;
        public HomeController(IDisasterTypeService disasterTypeService)
        {
            _disasterTypeService = disasterTypeService;
          
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<SelectListItem> valueCategory = (from x in _disasterTypeService.GetAll()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.TypeName,
                                                      Value = x.Id.ToString()


                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            return View();
        }
 

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _disasterTypeService.GetAll();
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult AddDisasterType()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Index(DisasterType disasterType)
        {
            _disasterTypeService.Add(disasterType);
            return RedirectToAction("Index");

        }

        //[HttpGet("gettypenames")]
        //public IActionResult Index()
        //{
        //    var result = _disasterTyepService.GetAll();
        //    return View(result);

        //}



    }
}
