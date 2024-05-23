using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej7LinqController : Controller
    {
        // GET: Ej7LinqController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ej7LinqController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ej7LinqController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ej7LinqController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ej7LinqController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ej7LinqController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ej7LinqController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ej7LinqController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
