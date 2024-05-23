using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej3LinqController : Controller
    {
        // GET: Ej3LinqController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ej3LinqController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ej3LinqController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ej3LinqController/Create
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

        // GET: Ej3LinqController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ej3LinqController/Edit/5
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

        // GET: Ej3LinqController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ej3LinqController/Delete/5
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
