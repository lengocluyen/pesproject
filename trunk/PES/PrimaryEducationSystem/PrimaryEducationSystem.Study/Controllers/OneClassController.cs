using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimaryEducationSystem.Study.Controllers
{
    public class OneClassController : Controller
    {
        //
        // GET: /OneClass/

        public ActionResult Math()
        {
            return View();
        }

        public ActionResult MathLesson()
        {
            return View();
        }
        //
        // GET: /OneClass/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /OneClass/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /OneClass/Create

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

        //
        // GET: /OneClass/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /OneClass/Edit/5

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
    }
}
