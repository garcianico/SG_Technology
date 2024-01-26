using SG.Web.Models.ViewModels;

namespace SG.Web.Services.Interfaces
{
    public interface IAccountService
    {

        Task<IEnumerable<AccountViewModel>> GetAccounts();
        Task<AccountViewModel> GetAccount(int id);
        Task<AccountViewModel> CreateAccount(AccountViewModel accountViewModel);

    }
}
