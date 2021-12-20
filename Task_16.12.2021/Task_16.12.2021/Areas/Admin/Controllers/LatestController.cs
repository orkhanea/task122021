using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;
using Task_16._12._2021.Models;

namespace Task_16._12._2021.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LatestController : Controller
    {
        private readonly AppDbContext _context;

        public LatestController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.LatestArticles.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LatestArticle model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                _context.LatestArticles.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int Id)
        {
            return View(_context.LatestArticles.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(LatestArticle model)
        {
            if (ModelState.IsValid)
            {
                _context.LatestArticles.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int Id)
        {


            LatestArticle model = _context.LatestArticles.Find(Id);
            _context.LatestArticles.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
