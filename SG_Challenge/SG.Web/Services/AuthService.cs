using SG.Web.Models.ViewModels;
using SG.Web.Services.Interfaces;

namespace SG.Web.Services
{
    public class AuthService : IAuthService
    {

        private readonly HttpClient _apiClient;

        public AuthService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }


        public async Task<string> Login(LoginViewModel loginViewModel)
        {
            var response = await _apiClient.PostAsJsonAsync("api/Account/login", loginViewModel);

            if (response.IsSuccessStatusCode)
            {
                var token = await response.Content.ReadAsStringAsync();
                return token;
            }

            return null;
        }

    }
}
