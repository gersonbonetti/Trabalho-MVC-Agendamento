using Microsoft.AspNetCore.Mvc;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;

namespace MVC_Agendamento_Web.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IServiceService _service;

		public ServiceController(IServiceService service)
		{
			_service = service;
		}
		public ActionResult Index()
		{
			return View(_service.FindAll());
		}

		public ActionResult Details(int id)
		{
			return View(_service.FindById(id));
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("scheduleId, patientId, doctorId, statusId, serviceNumber, evaluation, medicalRecord")] ServiceDTO service)
		{
			if (ModelState.IsValid)
			{
				if (await _service.Save(service) > 0)
				{
					return RedirectToAction(nameof(Index));
				}
			}
			return View(service);
			
		}

		public async Task<IActionResult> Edit(int id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var service = await _service.FindById(id);
			return View(service);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int? id, [Bind("scheduleId, patientId, doctorId, statusId, serviceNumber, evaluation, medicalRecord")] ServiceDTO service)
		{
			if (ModelState.IsValid)
			{
				if (await _service.Save(service) > 0)
				{
					return RedirectToAction(nameof(Index));
				}
			}
			return View(service);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Delete(int id)
		{
			var service = await _service.Delete(id);
			return View(service);
		}
	}
}