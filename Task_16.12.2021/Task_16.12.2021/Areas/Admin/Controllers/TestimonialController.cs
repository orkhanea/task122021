using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;
using Task_16._12._2021.Models;

namespace Task_16._12._2021.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _iwebHostEnvironment;

        public TestimonialController(AppDbContext context, IWebHostEnvironment iwebHostEnvironment)
        {
            _context = context;
            _iwebHostEnvironment = iwebHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Testimonials.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length < 3000000)
                    {
                        string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                        string FilePath = Path.Combine(_iwebHostEnvironment.WebRootPath, "images", "resource", ImageName);

                        using (var Stream = new FileStream(FilePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(Stream);
                        }

                        model.Image = ImageName;
                        model.CreatedDate = DateTime.Now;
                        _context.Testimonials.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
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
            else
            {
                ModelState.AddModelError("", "Duz Emelli Doldur!");
                return View(model);
            }

            


        }

        public IActionResult Update(int Id)
        {
            return View(_context.Testimonials.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {

                            // Delete old image
                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_iwebHostEnvironment.WebRootPath, "images", "resource", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            //Create new image
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_iwebHostEnvironment.WebRootPath, "images", "resource", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;
                        }
                        else
                        {
                            return View(model);
                        }
                    }
                    else
                    {
                        return View(model);
                    }
                }


                _context.Testimonials.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Diqqetdi ol Hormetdi ol qagaaaas!");
                return View(model);
            }
        }

        public IActionResult Delete(int Id)
        {
            Testimonial model = _context.Testimonials.Find(Id);

            if (!string.IsNullOrEmpty(model.Image))
            {
                string oldImagePath = Path.Combine(_iwebHostEnvironment.WebRootPath, "images", "resource", model.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.Testimonials.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
