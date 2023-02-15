using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MVC_Agendamento_Domain.Contracts.Services;
using MVC_Agendamento_Domain.DTO;
using MVC_Agendamento_Domain.Entities;

namespace MVC_Agendamento_Web.Controllers
{
	public class ScheduleController : Controller
	{
		private readonly IScheduleService _service;

		public ScheduleController(IScheduleService service)
		{
			_service = service;
		}
		public ActionResult Index()
		{
			return View(_service.FindAll());
		}

		public ActionResult Details(int id)
		{
			return View();
		}

		public ActionResult Create()
		{
           
            return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("id, patientId, doctorId, statusId, date, confirmedQuery")] ScheduleDTO schedule)
		{
			try
			{
                if (ModelState.IsValid)
				{
                    if (await _service.Save(schedule) > 0)
                        return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		public async Task<ActionResult> Edit(int id)
		{
            if (id == null)
            {
                return NotFound();
            }
            var schedule = await _service.FindById(id);
            return View(schedule);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(int id, [Bind("id, patientId, doctorId, statusId, date, confirmedQuery")] ScheduleDTO schedule)
		{
			try
			{

                if (!(id == schedule.id))
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    if (await _service.Save(schedule) > 0)
                        return RedirectToAction(nameof(Index));
                }
                return View(schedule);
            }
			catch
			{
				return View();
			}
		}

		public ActionResult Delete(int id)
		{

            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _service.FindById(id);

            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
		{
			try
			{
                if (id <= 0)
                {
                    return Problem("Entity set 'Schedule'  is null.");
                }
                var schedule = await _service.FindById(id);
                if (schedule != null)
                {
                    await _service.Delete(schedule.id);
                }
                return RedirectToAction(nameof(Index));
            }
			catch
			{
				return View();
			}
		}
	}
}
