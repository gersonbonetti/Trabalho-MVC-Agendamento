﻿using Microsoft.AspNetCore.Mvc;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;
using Register.WebMVC.Models;

namespace Register.WebMVC.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _service;

        public PatientController(IPatientService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, conditionId, personId")] PatientDTO patient)
        {
            if(ModelState.IsValid)
            {
                if (await _service.Save(patient) > 0) return RedirectToAction(nameof(Index)); 
            }
            return View(patient);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if(id == null) return NotFound();   

            var patient = await _service.GetById(id);
            return View(patient);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, conditionId, conditionId")] PatientDTO patient)
        {
            if (!(id == patient.id)) return NotFound();

            if (ModelState.IsValid)
            {
                if (await _service.Save(patient) > 0) return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int? id)
        {
            var returnDel = new ReturnJsonDelete()
            {
                status = "Success",
                code = "200",
            };

            try
            {
                if (await _service.Delete(id ?? 0) <= 0)
                {
                    returnDel = new ReturnJsonDelete()
                    {
                        status = "Error",
                        code = "400"
                    };
                }
            }
            catch (Exception ex)
            {
                returnDel = new ReturnJsonDelete()
                {
                    status = ex.Message,
                    code = "500",
                };
            }
            return Json(returnDel);
        }

    }
}
