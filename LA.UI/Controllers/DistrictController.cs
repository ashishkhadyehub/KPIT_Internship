﻿using LA.Entities;
using LA.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LA.UI.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IStateRepo _stateRepo;
        private readonly IDistrictRepo _districtRepo;

        public DistrictController(IStateRepo stateRepo, IDistrictRepo districtRepo)
        {
            _stateRepo = stateRepo;
            _districtRepo = districtRepo;
        }

        public IActionResult Index()
        {
            var districts = _districtRepo.GetAll(); 
            return View(districts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var states = _stateRepo.GetAll();
            ViewBag.StateList=new SelectList(states, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(District district)
        {
           _districtRepo.Save(district);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var states = _stateRepo.GetAll();
            ViewBag.StateList = new SelectList(states, "Id", "Name");

            var district = _districtRepo.GetById(id);
            return View(district);
        }

        [HttpPost]
        public IActionResult Edit(District district)
        {
            _districtRepo.Edit(district);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var district = _districtRepo.GetById(id);
            _districtRepo.RemoveData(district);
            return RedirectToAction("Index");

        }
    }
}
