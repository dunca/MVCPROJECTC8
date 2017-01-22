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
            new ProjectEvaluation() { Name = "John Doe", City = "Cluj-Napoca", Country = "Romania", Rating = 5, Id = 1 },
            new ProjectEvaluation() { Name = "Maria Enescu", City = "Sibiu", Country = "Romania", Rating = 5, Id = 2 },
            new ProjectEvaluation() { Name = "George Popescu", City = "<script>alert('xss');</script>", Country = "Romania", Rating = 5, Id = 3 },
            new ProjectEvaluation() { Name = "John Doez", City = "Cluj-Napoca", Country = "Romania", Rating = 5, Id = 4 },
            new ProjectEvaluation() { Name = "Maria Enescuz", City = "Sibiu", Country = "Romania", Rating = 5, Id = 5 },
            new ProjectEvaluation() { Name = "George Popescuz", City = "<script>alert('xss');</script>", Country = "Romania", Rating = 5, Id = 6 },
            new ProjectEvaluation() { Name = "John Does", City = "Cluj-Napoca", Country = "Romania", Rating = 5, Id = 7 },
            new ProjectEvaluation() { Name = "Maria Enescu Popescu", City = "Sibiu", Country = "Romania", Rating = 5, Id = 8 },
            new ProjectEvaluation() { Name = "George Popescu Ionescu", City = "<script>alert('xss');</script>", Country = "Romania", Rating = 5, Id = 9 },
            new ProjectEvaluation() { Name = "John Doescu", City = "Cluj-Napoca", Country = "Romania", Rating = 5, Id = 10 },
            new ProjectEvaluation() { Name = "Maria Enescu Lucescu", City = "Sibiu", Country = "Romania", Rating = 5, Id = 11 },
            new ProjectEvaluation() { Name = "George Popescu Ciumescu", City = "<script>alert('xss');</script>", Country = "Romania", Rating = 5, Id = 12 }
        };

        // GET: Evaluation
        public ActionResult Index(string searchTerm = null)
        {
            if (searchTerm != null)
            {
                var lowerSearchTerm = searchTerm.ToLower();
                var model = projectEvaluationList.Where(p => p.Name.ToLower().StartsWith(lowerSearchTerm))
                .Take(10);

                return View(model);
            }

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
            //try
            //{
            //    // TODO: Add update logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}

            var evaluation = projectEvaluationList.Single(e => e.Id == id);

            if (TryUpdateModel(evaluation))
            {
                return RedirectToAction("Index");
            }
            return View(evaluation);
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
