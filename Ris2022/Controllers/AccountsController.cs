using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ris2022.Data;
using Ris2022.Data.Models;
using Ris2022.Data.ViewModel;

namespace Ris2022.Controllers
{
    public class AccountsController : Controller
    {

        private readonly UserManager<RisAppUser> _userManager;
        private readonly SignInManager<RisAppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountsController(UserManager<RisAppUser> userManager,
            SignInManager<RisAppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        [AllowAnonymous]
        public async Task InitializeRoles(RegisterViewModel model)
        {
            bool x = await _roleManager.RoleExistsAsync(model.Role);
            if (!x)
            {
                var user = new RisAppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = model.Role;
                await _roleManager.CreateAsync(role);

                //Add default User to Role Admin
                var result1 = await _userManager.AddToRoleAsync(user, model.Role);
            }
        }
            public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new RisAppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public async Task AddRolesToUser(RegisterViewModel model)
        {
            bool x = await _roleManager.RoleExistsAsync(model.Role);
            if (!x)
            {
                var user = new RisAppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = model.Role;
                await _roleManager.CreateAsync(role);

                //Add default User to Role Admin
                var result1 = await _userManager.AddToRoleAsync(user, model.Role);
            }

            // creating Creating Manager role     
            x = await _roleManager.RoleExistsAsync("Manager");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Manager";
                await _roleManager.CreateAsync(role);
            }

            // creating Creating Employee role     
            x = await _roleManager.RoleExistsAsync("Employee");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Employee";
                await _roleManager.CreateAsync(role);
            }
        }
    }
}
