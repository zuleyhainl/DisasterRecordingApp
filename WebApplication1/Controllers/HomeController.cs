using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
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
        ICityService _cityService;
        ITownService _townService;
        IDistrictService _districtService;

        public HomeController(IDisasterTypeService disasterTypeService, ICityService cityService, ITownService townService, IDistrictService districtService)
        {
            _disasterTypeService = disasterTypeService;
            _cityService = cityService;
            _townService = townService;
            _districtService = districtService;
        }
        DisasterContext db = new DisasterContext();
        Class class1 = new Class();
        [HttpGet]
        public IActionResult Index()
        {
            class1.Cities = new SelectList(db.Cities,"Id","Name");
            class1.Towns = new SelectList(db.Towns, "Id", "Name");
            class1.Districts = new SelectList(db.Districts, "Id", "Name");
            class1.DisasterTypes = new SelectList(db.DisasterTypes,"Id","TypeName");

            return View(class1);
        }
        //public void GetTownsByCityId(int cityId)
        //{
        //    List<SelectListItem> valueTown = (from x in _townService.GetByCityId(cityId)
        //                                      select new SelectListItem
        //                                      {
        //                                          Text = x.Name,
        //                                          Value = x.Id.ToString()

        //                                      }).ToList();
        //    ViewBag.vlt = valueTown;
        //}

        public JsonResult GetTownsByCityId(int cityId)
        {
            var towns = (from x in _townService.GetByCityId(cityId)
                         select new
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return Json(towns);
        }

        public JsonResult GetDistrictsByTownId(int townId)
        {
            var districts = (from x in _districtService.GetAllByTownId(townId)
                         select new
                         {
                             Text = x.Name,
                             Value = x.Id.ToString()
                         }).ToList();
            return Json(districts);
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
