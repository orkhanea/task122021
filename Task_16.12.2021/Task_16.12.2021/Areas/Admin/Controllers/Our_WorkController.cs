using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class Our_WorkController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public Our_WorkController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            
            return View(_context.OurWorks.Include(wt=>wt.TagToWorks).ThenInclude(t=>t.WorkTag).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.tags = _context.WorkTags.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(OurWork model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile!=null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "gallery", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;
                            model.CreatedDate = DateTime.Now;
                            _context.OurWorks.Add(model);
                            _context.SaveChanges();



                            if (model.TagToWorksId != null && model.TagToWorksId.Count > 0)
                            {

                                foreach (var item in model.TagToWorksId)
                                {
                                    TagToWork tagToWork = new TagToWork();
                                    tagToWork.WorkTagId = item;
                                    tagToWork.OurWorkId = model.Id;
                                    _context.TagToWorks.Add(tagToWork);
                                    
                                }
                                _context.SaveChanges();

                            }

                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.tags = _context.WorkTags.ToList();
                            ModelState.AddModelError("", "File should be less than 3 mb");
                            return View(model);
                        }
                    }
                    else
                    {
                        ViewBag.tags = _context.WorkTags.ToList();
                        ModelState.AddModelError("", "Wrong file type");
                        return View(model);

                    }
                }
                else
                {
                    ViewBag.tags = _context.WorkTags.ToList();
                    ModelState.AddModelError("", "Duz Emelli Doldur!");
                    return View(model);
                }
                

            }
            else
            {
                ViewBag.tags = _context.WorkTags.ToList();
                ModelState.AddModelError("", "Duz Emelli Doldur!");
                return View(model);
            }
        }

        public IActionResult Update(int Id)
        {

            OurWork model = _context.OurWorks.Include(ttb => ttb.TagToWorks).ThenInclude(wt => wt.WorkTag).FirstOrDefault(o => o.Id == Id);
            model.TagToWorksId = _context.TagToWorks.Where(ttw => ttw.OurWorkId == Id).Select(tb => tb.WorkTagId).ToList();
            ViewBag.tags = _context.WorkTags.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(OurWork model)
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
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "gallery", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            //Create new image
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "gallery", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;
                        }
                        else
                        {
                            ViewBag.tags = _context.WorkTags.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ViewBag.tags = _context.WorkTags.ToList();
                        return View(model);
                    }
                }

                _context.OurWorks.Update(model);
                _context.SaveChanges();

                //Delete TagToWork
                List<TagToWork> tagToWorks = _context.TagToWorks.Where(t => t.OurWorkId == model.Id).ToList();
                foreach (var item in tagToWorks)
                {
                    _context.TagToWorks.Remove(item);
                    _context.SaveChanges();
                }

                //Create new TagToWork
                if (model.TagToWorksId != null && model.TagToWorksId.Count > 0)
                {

                    foreach (var item in model.TagToWorksId)
                    {
                        TagToWork tagToWork = new TagToWork();
                        tagToWork.WorkTagId = item;
                        tagToWork.OurWorkId = model.Id;
                        _context.TagToWorks.Add(tagToWork);
                        _context.SaveChanges();
                    }
                    

                }



                _context.OurWorks.Update(model);
                ViewBag.tags = _context.WorkTags.ToList();
                _context.SaveChanges();
               
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.tags = _context.WorkTags.ToList();
                ModelState.AddModelError("", "Diqqetdi ol Hormetdi ol qagaaaas!");
                return View(model);
            }

        }

        public IActionResult Delete(int Id)
        {
            OurWork model = _context.OurWorks.Include(ttb => ttb.TagToWorks).ThenInclude(wt => wt.WorkTag).FirstOrDefault(o => o.Id == Id);
            model.TagToWorksId = _context.TagToWorks.Where(ttw => ttw.OurWorkId == Id).Select(tb => tb.WorkTagId).ToList();
            _context.OurWorks.Remove(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
