using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEE.Controllers
{
    public class PrivateInstallationController : Controller
    {
        // GET: PrivateInstallationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PrivateInstallationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrivateInstallationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrivateInstallationController/Create
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

        // GET: PrivateInstallationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrivateInstallationController/Edit/5
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

        // GET: PrivateInstallationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrivateInstallationController/Delete/5
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
