using SG.Api.Data;
using SG.Api.Models;
using SG.Api.Services.Interfaces;
using System.Data.Entity;

namespace SG.Api.Services
{
    public class AccountService : IAccountService
    {

        private readonly ApplicationDbContext _context;

        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task<Account> GetAccount(int id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<Account> CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            return account;
        }


    }
}
