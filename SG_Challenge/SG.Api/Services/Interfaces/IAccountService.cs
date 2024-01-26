using SG.Api.Models;

namespace SG.Api.Services.Interfaces
{
    public interface IAccountService
    {

        Task<IEnumerable<Account>> GetAccounts();
        Task<Account> GetAccount(int id);
        Task<Account> CreateAccount(Account account);

    }
}
