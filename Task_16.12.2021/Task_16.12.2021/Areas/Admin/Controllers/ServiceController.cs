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
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ServiceController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length < 3000000)
                    {
                        string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                        string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "resource", ImageName);

                        using (var Stream = new FileStream(FilePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(Stream);
                        }

                        model.Image = ImageName;
                        model.CreatedDate = DateTime.Now;
                        _context.Services.Add(model);
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
            return View(_context.Services.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(Service model)
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
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "resource", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            //Create new image
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "resource", ImageName);

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


                _context.Services.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Diqqetdi ol Hormetdi ol qagaaaas!");
                return View(model);
            }


            
        }

        public IActionResult Delete(int? Id)
        {
            if (Id!=null)
            {
                Service model = _context.Services.Find(Id);

                if (model!=null)
                {
                    _context.Services.Remove(model);
                    _context.SaveChanges();
                    
                }
                
            }

            return RedirectToAction("Index");


        }



    }
}
