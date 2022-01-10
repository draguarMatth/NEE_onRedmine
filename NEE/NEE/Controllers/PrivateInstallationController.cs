using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using NEE.Models;
using BLL;

namespace NEE.Controllers
{
    public class PrivateInstallationController : Controller
    {
        // GET: PrivateInstallationController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // Post: PrivateInstallationController
        [HttpPost]
        public ActionResult Index(PrivateInstallationViewModel pivm)
        {
            List<Object> dataList = new List<Object>();
            dataList.Add(pivm.Postleitzahl);
            dataList.Add(pivm.Stadt);
            dataList.Add(pivm.Strasse);
            dataList.Add(pivm.No);
            dataList.Add(pivm.OrientationFieldType);
            dataList.Add(pivm.RoofSlopeType);
            dataList.Add(pivm.Length);
            dataList.Add(pivm.Width);
            dataList.Add(pivm.Area);
            dataList.Add(pivm.PVCellsType);
            dataList.Add(pivm.RenewableEnergy);
            dataList.Add(pivm.IntegrationType);

            PrivateInstallationManager pim = new PrivateInstallationManager();

            bool result;            
            result = pim.postMyInfo(dataList);


            return RedirectToAction("Index","Home");
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
