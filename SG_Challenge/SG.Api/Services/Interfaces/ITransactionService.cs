using SG.Api.Data;
using SG.Api.Models;

namespace SG.Api.Services.Interfaces
{
    public interface ITransactionService
    {


        Task<Account_Transaction> GetTransaction(int id);
        Task<Account_Transaction> Deposit(Account_Transaction transaction);
        Task<Account_Transaction> Withdrawal(Account_Transaction transaction);
    }
}
