using Microsoft.EntityFrameworkCore;
using SG.Api.Models;


namespace SG.Api.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Account_Transaction> Transactions { get; set; }

    }
}
