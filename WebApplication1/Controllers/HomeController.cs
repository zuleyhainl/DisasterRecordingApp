using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

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
        
        [HttpGet]
        public IActionResult Index()
        {
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
            _disasterService.Add(disaster);
            return RedirectToAction("Index");
        }
        public ActionResult BirAction()
        {
            return RedirectToAction("GetDisasterList", "Disasters");
        }

    }
}
