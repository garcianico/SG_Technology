using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SG.Api.Models;
using SG.Api.Services.Interfaces;

namespace SG.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {

        private readonly IAccountService _accountService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IAuthService _authService;




        public AccountController(
                IAccountService accountService,
                UserManager<IdentityUser> userManager,
                SignInManager<IdentityUser> signInManager,
                IAuthService authService)
        {
            _accountService = accountService;
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;          
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(LoginModel loginModel)
        {
            var user = await _userManager.FindByEmailAsync(loginModel.UserName);

            if (user == null)
            {
                return Unauthorized();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginModel.Password, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var token = _authService.GenerateToken(user.Id);
                return Ok(new { Token = token });
            }

            return Unauthorized(result);
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            var accounts = await _accountService.GetAccounts(); 
            return Ok(accounts);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccount(int id)
        {
            var account = await _accountService.GetAccount(id);

            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }




        [HttpPost]
        public async Task<ActionResult<Account>> CreateAccount(Account account)
        {

            var createdAccount = await _accountService.CreateAccount(account);

            return CreatedAtAction(nameof(GetAccounts), new { id = createdAccount.account_id }, createdAccount);
        }


    }
}
