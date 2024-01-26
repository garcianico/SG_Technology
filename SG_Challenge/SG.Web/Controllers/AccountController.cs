using Microsoft.AspNetCore.Mvc;
using SG.Web.Models.ViewModels;
using SG.Web.Services.Interfaces;

namespace SG.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAuthService _authService;
        private readonly IAccountService _accountService;


        public AccountController(IAuthService authService, IAccountService accountService)
        {
            _authService = authService;
            _accountService = accountService;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Login()
        {
            return View("Login");
        }


        public IActionResult CreateAccount()
        {
            return View("CreateAccount");
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var token = await _authService.Login(loginViewModel);

                if (token != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credenciales incorrectas");
                }
            }

            return View(loginViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> CreateAccount(AccountViewModel accountViewModel)
        {
            if (ModelState.IsValid)
            {
                var createdAccount = await _accountService.CreateAccount(accountViewModel);

                if (createdAccount != null)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al crear la cuenta");
                }
            }

            return View(accountViewModel);
        }



    }
}
