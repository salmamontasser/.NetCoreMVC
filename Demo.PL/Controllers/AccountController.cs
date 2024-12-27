using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using DemoDAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public AccountController(UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager )
        {
			_userManager = userManager;
			_signInManager = signInManager;
		}
        // Register
        //Base URL/Account/Register
        #region Register
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var User = new ApplicationUser()
                {
                    UserName = model.Email.Split('@')[0],
                    Email = model.Email,
                    FName = model.FName,
                    LName = model.LName,
                    IsAgree = model.IsAgree,

                };
                var Result = await _userManager.CreateAsync(User, model.Password);

                if (Result.Succeeded)
                    return RedirectToAction("Login");
                else
                    foreach (var error in Result.Errors)

                        ModelState.AddModelError(string.Empty, error.Description);


            }
            return View(model);

        }
        #endregion

        // Login
        #region Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModul modul)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(modul.Email);
                if (User is not null)
                {
                    var Flag = await _userManager.CheckPasswordAsync(User, modul.Password);
                    if (Flag)
                    {
                        var Result = await _signInManager.PasswordSignInAsync(User, modul.Password, modul.RemeberMe, false);
                        if (Result.Succeeded)
                            return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Incorrect Password");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Email is nor Exsits");
                }
            }
            return View();
        }
        #endregion
        // SignOut
        #region SignOut
        public new async Task<IActionResult> SignOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        #endregion

        // ForgetPassword
        #region ForgetPassword

        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(ForgetPasswordViewModel model)
        {
            if(ModelState.IsValid)
            {
              var User= await  _userManager.FindByEmailAsync(model.Email);
                if (User is not null)
                {
                    var token =await _userManager.GeneratePasswordResetTokenAsync(User);
                    //https://localhost:44311/Account/ResetPassword?email=salmamontasser@gmail.com?Token=dgjllfhjdiididkfkfk
                    var ResetPasswordLink = Url.Action("ResetPassword", "Auccont",new {emil=User.Email,Token=token},Request.Scheme);
                    // Send Email
                    var email = new Email()
                    {
                        Subject = "Reset Password",
                        To = model.Email,
                        Body = "ResetPasswordLink"
                    };
                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckYourInbox));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Email is not Exsits");

				}
			}
					return View("ForgetPassword", model);

        }
        #endregion
        public IActionResult CheckYourInbox()
        {
            return View();
        }
		// ResetPassword
        public IActionResult ResetPassword(string email,string token)
        {
            TempData["email"]=email;
            TempData["token"]=token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid) 
            {
                string email=(string) TempData["email"];
                string token=(string) TempData["token"];
                var User= await _userManager.FindByEmailAsync(email);
               var Result= await _userManager.ResetPasswordAsync(User,token,model.NewPassword);
                if (Result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    foreach (var error in Result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
	}
}
