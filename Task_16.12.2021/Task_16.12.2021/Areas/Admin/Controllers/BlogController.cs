using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;
using Task_16._12._2021.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Task_16._12._2021.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {

            return View(_context.Blogs.Include(c=>c.BlogCategory).Include(u=>u.StaticUser).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.BlogCategory = _context.BlogCategories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
            {
                if (model.ImageFile.Length < 3000000)
                {
                    string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("dd MMMM yyyy") + "-" + model.ImageFile.FileName;
                    string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "images", ImageName);

                    using (var Stream = new FileStream(FilePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(Stream);
                    }

                    model.Image = ImageName;
                    model.CreatedDate = DateTime.Now;
                    model.StaticUserId = 1;
                    _context.Blogs.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                else
                {
                    ModelState.AddModelError("", "File should be less than 3 mb");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Wrong file type");
                return View(model);

            }   

        }
    }
}
