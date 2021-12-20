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
    public class Twitter_Feed : Controller
    {
        private readonly AppDbContext _context;

        public Twitter_Feed(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.TwitterFeeds.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TwitterFeed model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                _context.TwitterFeeds.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int Id)
        {
            return View(_context.TwitterFeeds.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(TwitterFeed model)
        {
            if (ModelState.IsValid)
            {
                _context.TwitterFeeds.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            TwitterFeed model = _context.TwitterFeeds.Find(Id);
            _context.TwitterFeeds.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
