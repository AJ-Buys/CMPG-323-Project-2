using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Test_Database.Models;

namespace Test_Database.Controllers
{
    public class AdministrationController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;


        public  AdministrationController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRole model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = model.RoleName
                
                };

                IdentityResult res = await roleManager.CreateAsync(role);

                if (res.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                foreach(IdentityError err in res.Errors)
                {
                    ModelState.AddModelError("", err.Description);

                }
            }

            return View(model);
        }
    }
}
