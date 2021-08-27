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
        INeighborhoodService _neighborhoodService;
        IDisasterService _disasterService;

        public HomeController(IDisasterTypeService disasterTypeService, ICityService cityService, ITownService townService, IDistrictService districtService, INeighborhoodService neighborhoodService, IDisasterService disasterService)
        {
            _disasterTypeService = disasterTypeService;
            _cityService = cityService;
            _townService = townService;
            _districtService = districtService;
            _neighborhoodService = neighborhoodService;
            _disasterService =  disasterService;
        }
        //DisasterContext db = new DisasterContext();
        //ViewClass class1 = new ViewClass();
        [HttpGet]
        public IActionResult Index()
        {
            //class1.Cities = new SelectList(_cityService.GetAll(),"Id","Name");
            //class1.Towns = new SelectList(_townService.GetAll(), "Id", "Name");
            //class1.Districts = new SelectList(_districtService.GetAll(), "Id", "Name");
            //class1.Neighborhoods = new SelectList(_neighborhoodService.GetAll(), "Id", "Name");
            //class1.DisasterTypes = new SelectList(_disasterTypeService.GetAll(),"Id","TypeName");

            List<DisasterType> disasterTypesList = _disasterTypeService.GetAll().ToList();
            ViewBag.disasterTypes = new SelectList(disasterTypesList, "Id", "TypeName");

            List<City> cityList = _cityService.GetAll().ToList();
            ViewBag.cities = new SelectList(cityList, "Id", "Name");

            List<Town> townList = _townService.GetAll().ToList();
            ViewBag.towns = new SelectList(townList, "Id", "Name");

            List<District> districtList = _districtService.GetAll().ToList();
            ViewBag.districts = new SelectList(districtList, "Id", "Name");

            List<Neighborhood> neighborhoodList = _neighborhoodService.GetAll().ToList();
            ViewBag.neighborhoods = new SelectList(neighborhoodList, "Id", "Name");




            return View();
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
        public JsonResult GetNeighborhoodsByDistrictId(int disId)
        {
            var neighborhoods = (from x in _neighborhoodService.GetAllByDistrictId(disId)
                             select new
                             {
                                 Text = x.Name,
                                 Value = x.Id.ToString()
                             }).ToList();
            return Json(neighborhoods);
        }

        [HttpPost]
        public IActionResult Index(Disaster disaster)
        {
            Console.WriteLine(disaster.NeighborhoodId); 
            _disasterService.Add(disaster);
            return RedirectToAction("Index");

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

        //[HttpPost]
        //public IActionResult Index(DisasterType disasterType)
        //{
        //    _disasterTypeService.Add(disasterType);
        //    return RedirectToAction("Index");

        //}

        //[HttpGet("gettypenames")]
        //public IActionResult Index()
        //{
        //    var result = _disasterTyepService.GetAll();
        //    return View(result);

        //}



    }
}
