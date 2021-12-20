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
    public class WorkTagController : Controller
    {
        private readonly AppDbContext _context;

        public WorkTagController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.WorkTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WorkTag model)
        {
            if (ModelState.IsValid)
            {
                _context.WorkTags.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int Id)
        {
            return View(_context.WorkTags.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(WorkTag model)
        {
            if (ModelState.IsValid)
            {
                _context.WorkTags.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            WorkTag model = _context.WorkTags.Find(Id);
            _context.WorkTags.Remove(model);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
