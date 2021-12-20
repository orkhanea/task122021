using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;
using Task_16._12._2021.ViewModels;

namespace Task_16._12._2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmLayout model = new();
            model.LatestArticles = _context.LatestArticles.ToList();
            model.TwitterFeeds = _context.TwitterFeeds.ToList();
            model.Socials = _context.SiteSocials.ToList();
            model.Setting = _context.Settings.FirstOrDefault();


            return View(model);
        }
    }
}
