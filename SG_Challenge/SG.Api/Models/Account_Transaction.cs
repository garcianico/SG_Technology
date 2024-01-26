using System.ComponentModel.DataAnnotations;
using SG.Api.Models.Interfaces;

namespace SG.Api.Models
{
    public class Account_Transaction : IAccount_Transaction
    {

        [Key]
        public int transaction_id { get; set; }

        [Required]
        public int account_id { get; set; }

        [Required]
        public int trans_type { get; set; }

        [Required]
        public DateTime trans_date { get; set; }

        [Required]
        public decimal amount { get; set; }


    }
}
