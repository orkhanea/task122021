using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_16._12._2021.Data;

namespace Task_16._12._2021.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public LoginController(AppDbContext context, SignInManager<IdentityUser> signInManager)
        {
                
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
