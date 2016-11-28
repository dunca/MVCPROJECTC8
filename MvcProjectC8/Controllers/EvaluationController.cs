using MvcProjectC8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectC8.Controllers
{
    public class EvaluationController : Controller
    {
        static List<ProjectEvaluation> projectEvaluationList = new List<ProjectEvaluation>()
        {
            new ProjectEvaluation() { Name = "John Doe", City = "Cluj-Napoca", Country = "Romania", Rating = 5 },
            new ProjectEvaluation() { Name = "Maria Enescu", City = "Sibiu", Country = "Romania", Rating = 5 },
            new ProjectEvaluation() { Name = "George Popescu", City = "<script>alert('xss');</script>", Country = "Romania", Rating = 5 }
        };

        // GET: Evaluation
        public ActionResult Index()
        {
            return View(projectEvaluationList);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
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

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
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

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
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
