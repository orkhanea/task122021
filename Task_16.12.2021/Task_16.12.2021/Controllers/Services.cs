using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;
using Task_16._12._2021.ViewModels;

namespace Task_16._12._2021.Controllers
{
    public class Services : Controller
    {
        private readonly AppDbContext _context;

        public Services(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Service1()
        {
            VmService model = new();
            model.Setting = _context.Settings.FirstOrDefault();
            model.TwitterFeeds = _context.TwitterFeeds.ToList();
            model.LatestArticles = _context.LatestArticles.ToList();
            model.Socials = _context.SiteSocials.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Service1");
            model.Services = _context.Services.ToList();
            model.OurWorks = _context.OurWorks.ToList();
            model.TagToWorks = _context.TagToWorks.ToList();
            model.WorkTags = _context.WorkTags.ToList();
            model.Testimonials = _context.Testimonials.ToList();
            

            return View(model);
        }
    }
}
