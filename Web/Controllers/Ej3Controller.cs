﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej3Controller : Controller
    {
        // GET: Ej3Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ej3Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ej3Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ej3Controller/Create
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

        // GET: Ej3Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ej3Controller/Edit/5
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

        // GET: Ej3Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ej3Controller/Delete/5
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
