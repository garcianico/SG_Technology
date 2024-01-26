using SG.Api.Data;
using SG.Api.Services.Interfaces;
using SG.Api.Models;
using System.Data.Entity;

namespace SG.Api.Services
{
    public class TransactionService : ITransactionService
    {


        private readonly ApplicationDbContext _context;

        public TransactionService(ApplicationDbContext context) 
        {
            _context = context;
        }


        public async Task<Account_Transaction> GetTransaction(int id)
        {
            return await _context.Transactions.FindAsync(id);
        }


        public async Task<Account_Transaction> Deposit(Account_Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return transaction;
        }



        public async Task<Account_Transaction> Withdrawal(Account_Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return transaction;
        }
    }
}
