// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Ris2022.Data.Models;
using Ris2022.Resources;

namespace Ris2022.Pages.Account
{
    //[Authorize(Policy = "RequireAdministratorRole")]
    [AllowAnonymous]
    public class AddUserModel : PageModel
    {
        //public IActionResult OnPost() =>
        // Content("OnPost RequireAdministratorRole");
        private readonly SignInManager<RisAppUser> _signInManager;
        private readonly UserManager<RisAppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserStore<RisAppUser> _userStore;
        private readonly IUserEmailStore<RisAppUser> _emailStore;
        private readonly ILogger<AddUserModel> _logger;
        private readonly IEmailSender _emailSender;

        public AddUserModel(
            UserManager<RisAppUser> userManager,
            IUserStore<RisAppUser> userStore,
            SignInManager<RisAppUser> signInManager,
            ILogger<AddUserModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            //[Required]
            //[EmailAddress]
            //[Display(ResourceType = typeof(Resource), Name = "Email")]

            //public string Email { get; set; }
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [Display(ResourceType = typeof(Resource), Name = "UserName")]
            public string UserName { get; set; }

            [Required]
            [Display(ResourceType = typeof(Resource), Name = "Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(ResourceType = typeof(Resource), Name = "SurName")]
            public string LastName { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(ResourceType = typeof(Resource), Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(ResourceType = typeof(Resource), Name = "Confirm")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(ResourceType = typeof(Resource), Name = "Role")]
            public string Role { get; set; } = "User";

            [Required]
            [Display(ResourceType = typeof(Resource), Name = "IsDoctor")]
            public bool IsDoctor { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            //ViewData["Role"] = new SelectList(_roleManager.Roles.ToList(), "Id", "Name");
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            //returnUrl ??= Url.Content("~/");

            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();
                user.Firstname = Input.FirstName;
                user.Lastname = Input.LastName;
                user.Isdoctor = Input.IsDoctor;
                user.Email = Input.UserName + "@yy.com";
                await _userStore.SetUserNameAsync(user, Input.UserName, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.UserName+"@yy.com", CancellationToken.None);
                
                var result1 = await _userManager.CreateAsync(user, Input.Password);
                var result2 = await _userManager.AddToRoleAsync(user, Input.Role);

                if (result1.Succeeded && result2.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToPage("/MainPage");
                }

                foreach (var error in result1.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                foreach (var error in result2.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private RisAppUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<RisAppUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(RisAppUser)}'. " +
                    $"Ensure that '{nameof(RisAppUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<RisAppUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<RisAppUser>)_userStore;
        }
    }
}
