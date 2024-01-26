using SG.Web.Models.ViewModels;

namespace SG.Web.Services.Interfaces
{
    public interface IAuthService
    {

        Task<string> Login(LoginViewModel loginViewModel);

    }
}
