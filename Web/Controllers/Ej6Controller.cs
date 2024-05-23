using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej6Controller : Controller
    {
        // GET: Ej6Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ej6Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ej6Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ej6Controller/Create
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

        // GET: Ej6Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ej6Controller/Edit/5
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

        // GET: Ej6Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ej6Controller/Delete/5
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
