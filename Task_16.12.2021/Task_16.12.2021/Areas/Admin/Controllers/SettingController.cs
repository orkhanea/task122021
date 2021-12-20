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
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public SettingController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Settings.FirstOrDefault());
        }

        public IActionResult Update()
        {

            return View(_context.Settings.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid)
            {

                if (model.LogoFile != null)
                {
                    if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                    {
                        if (model.LogoFile.Length < 3000000)
                        {

                            // Delete old image
                            if (!string.IsNullOrEmpty(model.Logo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "images", model.Logo);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            //Create new image
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.LogoFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "images", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.LogoFile.CopyTo(Stream);
                            }

                            model.Logo = ImageName;
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


                if (model.FooterLogoFile != null)
                {
                    if (model.FooterLogoFile.ContentType == "image/jpeg" || model.FooterLogoFile.ContentType == "image/png")
                    {
                        if (model.FooterLogoFile.Length < 3000000)
                        {

                            // Delete old image
                            if (!string.IsNullOrEmpty(model.FooterLogo))
                            {
                                string oldImagePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "images", model.FooterLogo);
                                if (System.IO.File.Exists(oldImagePath2))
                                {
                                    System.IO.File.Delete(oldImagePath2);
                                }
                            }


                            //Create new image
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.FooterLogoFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "images", ImageName2);

                            using (var Stream2 = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.FooterLogoFile.CopyTo(Stream2);
                            }

                            model.FooterLogo = ImageName2;
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


                if (model.FooterBgFile != null)
                {
                    if (model.FooterBgFile.ContentType == "image/jpeg" || model.FooterBgFile.ContentType == "image/png")
                    {
                        if (model.FooterBgFile.Length < 3000000)
                        {

                            // Delete old image
                            if (!string.IsNullOrEmpty(model.FooterBg))
                            {
                                string oldImagePath3 = Path.Combine(_webHostEnviroment.WebRootPath, "images", "background", model.FooterBg);
                                if (System.IO.File.Exists(oldImagePath3))
                                {
                                    System.IO.File.Delete(oldImagePath3);
                                }
                            }


                            //Create new image
                            string ImageName3 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.FooterBgFile.FileName;
                            string FilePath3 = Path.Combine(_webHostEnviroment.WebRootPath, "images", "background", ImageName3);

                            using (var Stream3 = new FileStream(FilePath3, FileMode.Create))
                            {
                                model.FooterBgFile.CopyTo(Stream3);
                            }

                            model.FooterBg = ImageName3;
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

                _context.Settings.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
    
