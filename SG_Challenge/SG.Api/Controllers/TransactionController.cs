using Microsoft.AspNetCore.Mvc;
using SG.Api.Models;
using SG.Api.Services.Interfaces;

namespace SG.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Account_Transaction>> GetTransaction(int id)
        {
            var transaction = await _transactionService.GetTransaction(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }



        [HttpPost("deposit")]
        public async Task<ActionResult<Account_Transaction>> Deposit(Account_Transaction transaction)
        {
            var depositTransaction = await _transactionService.Deposit(transaction);
            return CreatedAtAction(nameof(GetTransaction), new { id = depositTransaction.transaction_id }, depositTransaction);
        }



        [HttpPost("withdrawal")]
        public async Task<ActionResult<Account_Transaction>> Withdrawal(Account_Transaction transaction)
        {
            var withdrawnTransaction = await _transactionService.Withdrawal(transaction);
            return CreatedAtAction(nameof(GetTransaction), new { id = withdrawnTransaction.transaction_id }, withdrawnTransaction);
        }



    }
}
