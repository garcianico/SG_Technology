using SG.Web.Models.ViewModels;
using SG.Web.Services.Interfaces;

namespace SG.Web.Services
{
    public class AccountService : IAccountService
    {

        private readonly HttpClient _apiClient;

        public AccountService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        
        public Task<AccountViewModel> GetAccount(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AccountViewModel>> GetAccounts()
        {
            var response = await _apiClient.GetAsync("api/Account");

            if (response.IsSuccessStatusCode) 
            { 
                var accounts = await response.Content.ReadFromJsonAsync<IEnumerable<AccountViewModel>>();
                return accounts;
            }

            return Enumerable.Empty<AccountViewModel>();
        }


        public async Task<AccountViewModel> CreateAccount(AccountViewModel accountViewModel)
        {
            var response = await _apiClient.PostAsJsonAsync("api/Account", accountViewModel);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AccountViewModel>();
            }

            return null;
        }

    }
}
