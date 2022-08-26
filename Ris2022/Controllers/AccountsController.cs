using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ris2022.Data;
using Ris2022.Data.Models;

namespace Ris2022.Controllers
{
    public class AccountsController : ControllerBase
    {
        private readonly RisDBContext _context;


        private readonly UserManager<RisAppUser> _userManager;
        private readonly SignInManager<RisAppUser> _signInManager;

        public AccountsController(UserManager<RisAppUser> userManager,
            SignInManager<RisAppUser> signInManager, RisDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;

        }
        public async Task<IActionResult> Register([FromBody] RisAppUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _userManager.CreateAsync(user);
                return (result.Succeeded) ? BadRequest(ModelState) : Accepted();

            }
            catch (Exception ex)
            {

                return Problem($"somthing went wrong in the {nameof(Register)}");
            }
        }
        public async Task<IActionResult> Login([FromBody] RisAppUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName,user.PasswordHash,false,false);
                return (result.Succeeded) ? BadRequest(ModelState) : Accepted();

            }
            catch (Exception ex)
            {

                return Problem($"somthing went wrong in the {nameof(Register)}");
            }
        }
    }
}
