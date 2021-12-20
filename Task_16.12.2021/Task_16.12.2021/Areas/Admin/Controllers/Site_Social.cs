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
    public class Site_Social : Controller
    {
        private readonly AppDbContext _context;

        public Site_Social(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.SiteSocials.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SiteSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.SiteSocials.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(model);
        }

        public IActionResult Update(int Id)
        {
            return View(_context.SiteSocials.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(SiteSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.SiteSocials.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            SiteSocial siteSocial = _context.SiteSocials.Find(Id);
            _context.SiteSocials.Remove(siteSocial);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
