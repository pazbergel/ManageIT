using ManageIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageIT.Controllers
{
    public class ADMvcController : Controller
    {
        // GET: ADMvc
        public ActionResult Index()
        {
            return View(new ActiveDirectoryModels());
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Newuserlist()
        {
            return View();
        }

        public ActionResult Lockeduserslist()
        {
            return View();
        }

        public ActionResult Usermanagement()
        {
            return View();
        }

        public ActionResult Compmanagement()
        {
            return View();
        }

        public ActionResult Systemmanagement()
        {
            return View();
        }


        // GET: ADMvc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ADMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADMvc/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ADMvc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ADMvc/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ADMvc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ADMvc/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
