using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;
using Task_16._12._2021.Models;
using Task_16._12._2021.ViewModels;

namespace Task_16._12._2021.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegisterController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public RegisterController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                CustomUser newUser = new()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.UserName,
                    Email = model.Email,
                    CreatedDate = DateTime.Now
                };

               var result = await _userManager.CreateAsync(newUser, model.Password);
                
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View(model);
                }
            }

            return View(model);
        }
    }
}
