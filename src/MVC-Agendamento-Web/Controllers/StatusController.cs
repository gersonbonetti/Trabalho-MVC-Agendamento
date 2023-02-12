using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Agendamento_Web.Controllers {
    public class StatusController : Controller {
        // GET: StatusController1
        public ActionResult Index() {
            return View();
        }

        // GET: StatusController1/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: StatusController1/Create
        public ActionResult Create() {
            return View();
        }

        // POST: StatusController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: StatusController1/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: StatusController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: StatusController1/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: StatusController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
