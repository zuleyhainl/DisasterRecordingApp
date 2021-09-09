using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class DisastersController : Controller
    {
        IDisasterTypeService _disasterTypeService;
        ICityService _cityService;
        ITownService _townService;
        IDistrictService _districtService;
        INeighborhoodService _neighborhoodService;
        IDisasterService _disasterService;
        public DisastersController(IDisasterTypeService disasterTypeService, ICityService cityService, ITownService townService, IDistrictService districtService, INeighborhoodService neighborhoodService, IDisasterService disasterService)
        {
            _disasterTypeService = disasterTypeService;
            _cityService = cityService;
            _townService = townService;
            _districtService = districtService;
            _neighborhoodService = neighborhoodService;
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
        [HttpGet]
        public IActionResult UpdateDisaster(int Id)
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

            var disaster_Updated = _disasterService.GetById(Id);
            return View(disaster_Updated);
        }

        [HttpPost]
        public IActionResult UpdateDisaster(Disaster disaster)
        {
            
            _disasterService.Update(disaster);
            return RedirectToAction("GetDisasterList");
        }


    }
}
